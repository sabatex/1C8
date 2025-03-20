﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.ApplicationObjects;
using sabatex.V1C8.Metadata;

namespace sabatex.V1C8
{
    public partial class COMObject1C8:ICOMObject1C8,IArray1C8,IGlobalContext, IStructure,
                                // Metadata
                                // Document
                                IDocumentsManager,IDocumentManager,IDocumentRef, IDocumentSelection,
                                // Enum
                                IEnumsManager,IEnumManager,IEnumRef,
                                // Catalog
                                ICatalogRef,ICatalogObject,ICatalogManager,ICatalogSelection,ICatalogsManager,
                                // Information registers
                                IInformationRegistersManager, IInformationRegisterManager, IInformationRegisterRecord, IIInformationRegisterSelection, IInformationRegisterRecordManager
    {

        //private const string _COMServerName = "V83.COMConnector";
        // mark object then disposed
        private bool _disposed = false;
        // chaild objects
        private List<COMObject1C8> _children = new List<COMObject1C8>();
        // link to owner or null for root
        private COMObject1C8 _owner = null;
        /// <summary>
        /// global context
        /// </summary>
        internal IGlobalContext _globalContext;

        internal object _handle;
        protected object Handle { get => _handle; }
        public dynamic Dynamic {get=>_handle;}
        private COMObject1C8(COMObject1C8 owner, object handle)
        {
            _owner = owner;
            _handle = handle;
            if (owner?._globalContext != null)
                _globalContext = owner._globalContext;
            else
                _globalContext = owner;
        }
        protected object COMMethod(string FuncName, BindingFlags invokeAttr, params object[] Args)
        {
            object[] normalArgs = null;
            if (Args.Length != 0)
            {

                normalArgs = new object[Args.Length]; 
                for (int i = 0; i < Args.Length; i++)
                {
                    var comObject = Args[i] as COMObject1C8;
                    if (comObject != null)
                        normalArgs[i] = comObject._handle;
                    else
                        normalArgs[i] = Args[i];
                }

            }

            try
            {
                var obj = Handle.GetType().InvokeMember(FuncName, invokeAttr, null, _handle, normalArgs);
                if (obj == null) return obj;
                if (Marshal.IsComObject(obj))
                {
                    COMObject1C8 comObj = new COMObject1C8(this, obj);
                    _children.Add(comObj);
                    return comObj;
                }
                else
                    return obj;

            }
            catch (Exception e)
            {
                StringBuilder errorStr = new StringBuilder($"Error {nameof(COMMethod)} with FuncName={FuncName}");
                if (Args.Length != 0)
                {
                    errorStr.Append(" and params:");
                    for (int i = 0; i < Args.Length; i++)
                        errorStr.Append($" Arg{i}={Args[i]}");
                }
                errorStr.Append($" Inner exception - {e.Message}");
                Trace.TraceError(errorStr.ToString());
                // FuncName == null
                throw new Exception(errorStr.ToString());
            }
        }
        protected T COMMethod<T>(string FuncName, BindingFlags invokeAttr, params object[] Args)
        {
            // convert args
            object[] normalArgs = new object[Args.Length];
            for (int i = 0; i < Args.Length; i++)
            {
                var comObject = Args[i] as COMObject1C8;
                if (comObject != null)
                    normalArgs[i] = comObject._handle;
                else
                    normalArgs[i] = Args[i];
            }
            if (normalArgs.Length == 0) normalArgs = null;

            try
            {
                var obj = Handle.GetType().InvokeMember(FuncName, invokeAttr, null, _handle, normalArgs);
                if (obj == null) return (T)obj;
                if (Marshal.IsComObject(obj))
                {
                    try
                    {
                        COMObject1C8 comObj = new COMObject1C8(this, obj);
                        _children.Add(comObj);
                        return (T)(object)comObj;
                    }
                    catch (Exception e)
                    {

                        throw new Exception($"Ошибка приведения COMObject1C8 к {typeof(T).Name}");
                    }
                }
                else
                    return (T)obj;

            }
            catch (Exception e)
            {
                StringBuilder errorStr = new StringBuilder($"Error {nameof(COMMethod)} with FuncName={FuncName}");
                if (Args.Length != 0)
                {
                    errorStr.Append(" and params:");
                    for (int i = 0; i < Args.Length; i++)
                        errorStr.Append($" Arg{i}={Args[i]}");
                }
                errorStr.Append($" Inner exception - {e.Message}");
                Trace.TraceError(errorStr.ToString());
                // FuncName == null
                throw new Exception(errorStr.ToString());
            }
        }
        public T Method<T>(string methodName, params object[] args)=>COMMethod<T>(methodName,BindingFlags.InvokeMethod,args);
        public T GetProperty<T>(string propertyName)=>COMMethod<T>(propertyName, BindingFlags.GetProperty);
        public void SetProperty(string propName, object value) => COMMethod<object>(propName, BindingFlags.PutDispProperty, value );
        public IGlobalContext GlobalContext => _globalContext;

        internal void RemoveChild(COMObject1C8 com)
        {
            _children.Remove(com);
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                // remove all child
                while (_children.Count > 0) _children[0].Dispose();

                // remove this object from owner
                _owner?.RemoveChild(this);

                // Free any unmanaged objects here.
                if (_handle != null)
                {
                    if (Marshal.IsComObject(_handle))
                        Marshal.ReleaseComObject(_handle);
                }
                _handle = null;
                _disposed = true;
            }
        }

        public static COMObject1C8 CreateConnection(string connectionString,string COMIDName = "V83.COMConnector")
        {
            
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException();

            Type comConnector = Type.GetTypeFromProgID(COMIDName);

            if (comConnector == null)
            {
                string error = $"Помилка зєднання з COM Class Object {COMIDName} !";
                Trace.TraceError(error);
                throw new Exception(error);
            }
            
            object instance = Activator.CreateInstance(comConnector);
            if (instance == null)
            {
                string error = $"Instance of class {COMIDName} was not created";
                Trace.TraceError(error);
                comConnector = null;
                throw new Exception(error);
            }
            try
            {
                var handle = instance.GetType().InvokeMember("Connect", BindingFlags.InvokeMethod,null, instance,new object[] { connectionString });
                if (handle == null)
                {
                    comConnector = null;
                    instance = null;
                    string error = $"Помилка зєднання з базою {connectionString} !!!";
                    Trace.TraceError(error);
                    throw new Exception(error);
                }
  
                return new COMObject1C8(null,handle);
            }
            catch (Exception e)
            {
                comConnector = null;
                instance = null;
                string error = $"Помилка зєднання з базою {connectionString} !!! Error - {e.Message}";
                Trace.TraceError(error);
                throw new Exception(error);

            }
        }

        public static COMObject1C8 CreateConnection(string serverName, string dataBaseName, string userName, string password, string COMIDName = "V83.COMConnector") =>
                CreateConnection($"Srvr='{serverName}';Ref='{dataBaseName}';Usr='{userName}';pwd='{password}';",COMIDName);

        public static COMObject1C8 CreateConnection(string dataBasePath, string userName, string password, string COMIDName = "V83.COMConnector") =>
                CreateConnection($"File='{dataBasePath}';Usr='{userName}';pwd='{password}';",COMIDName);


        public override bool Equals(object obj)
        {
            COMObject1C8 b = obj as COMObject1C8;
            if (b == null) return false;
            return _handle == b._handle;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        IEnumerator<IMetadataObjectTabularSection> IEnumerable<IMetadataObjectTabularSection>.GetEnumerator()
        {
            return new V1C8Enumerator<IMetadataObjectTabularSection>(this); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


        #region Hidden System.Object members
        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns> A string that represents the current object. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string? ToString()
            => base.ToString();
        #endregion


    }

}

