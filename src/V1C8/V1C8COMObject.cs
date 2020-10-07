using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8
{
    public class V1C8COMObject:IDisposable
    {
        List<V1C8COMObject> Children = new List<V1C8COMObject>();
        V1C8COMObject owner = null;
        bool disposed = false;
        protected object handle;
        protected object Handle { get => handle; }
        public dynamic Dynamic {get=>handle;}
        protected V1C8COMObject()
        {

        }
        public V1C8COMObject(V1C8COMObject owner, object handle)
        {
            this.owner = owner;
            this.handle = handle;
        }
        protected object OLE1C77Function(string FuncName, BindingFlags invokeAttr, object Handle, params object[] Args)
        {
            // convert args
            object[] normalArgs = new object[Args.Length];
            for (int i = 0; i < Args.Length; i++)
            {
                var comObject = Args[i] as V1C8COMObject;
                if (comObject != null)
                    normalArgs[i] = comObject.handle;
                else
                    normalArgs[i] = Args[i];
            }
            if (normalArgs.Length == 0) normalArgs = null;

            try
            {
                var obj = Handle.GetType().InvokeMember(FuncName, invokeAttr, null, Handle, normalArgs);
                if (obj == null) return null;
                if (Marshal.IsComObject(obj))
                {
                    var comObj = new V1C8COMObject(this, obj);
                    Children.Add(comObj);
                    return comObj;
                }
                else
                    return obj;

            }
            catch (ArgumentNullException e)
            {
                // FuncName == null
                throw (e);
            }

            catch (ArgumentException e)
            {

                /* args is multidimensional.
                -or- 
                invokeAttr is not a valid BindingFlags attribute.
                -or- 
                invokeAttr contains CreateInstance combined with InvokeMethod, GetField, SetField, GetProperty, or SetProperty.
                -or- 
                invokeAttr contains both GetField and SetField.
                -or- 
                invokeAttr contains both GetProperty and SetProperty.
                -or- 
                invokeAttr contains InvokeMethod combined with SetField or SetProperty.
                -or- 
                invokeAttr contains SetField and args has more than one element.
                -or- 
                This method is called on a COM object and one of the following binding flags was not passed in: BindingFlags.InvokeMethod, BindingFlags.GetProperty, BindingFlags.SetProperty, BindingFlags.PutDispProperty, or BindingFlags.PutRefDispProperty.
                -or- 
                One of the named parameter arrays contains a string that is a null reference*/
                throw (e);
            }

            catch (MethodAccessException e)
            {//The specified member is a class initializer.
                throw (e);
            }

            catch (MissingFieldException e)
            {//The field or property cannot be found.
                throw (e);
            }

            catch (MissingMethodException e)
            {/*The method cannot be found.

             -or- 

             The current Type object represents a type that contains open type parameters, that is, ContainsGenericParameters returns true.*/

                throw (e);

            }

            catch (TargetException e)

            {//The specified member cannot be invoked on target. 

                throw (e);

            }

            catch (AmbiguousMatchException e)

            {//More than one method matches the binding criteria. 

                throw (e);

            }

            catch (NotSupportedException e)

            {//The .NET Compact Framework does not currently support this property.

                throw (e);



            }

            catch (Exception e)

            {

                throw (e);

            }

        }
 
       protected T OLE1C77Function<T>(string FuncName, BindingFlags invokeAttr, object Handle, params object[] Args)
        where T : V1C8COMObject
        {
            // convert args
            object[] normalArgs = new object[Args.Length];
            for (int i = 0; i < Args.Length; i++)
            {
                var comObject = Args[i] as V1C8COMObject;
                if (comObject != null)
                    normalArgs[i] = comObject.handle;
                else
                    normalArgs[i] = Args[i];
            }
            if (normalArgs.Length == 0) normalArgs = null;

            try
            {
                var obj = Handle.GetType().InvokeMember(FuncName, invokeAttr, null, Handle, normalArgs);
                if (obj == null) return null;
                if (Marshal.IsComObject(obj))
                {
                   T comObj = (T)Activator.CreateInstance(typeof(T),this,obj);  
                    Children.Add(comObj);
                    return comObj;
                }
                else
                    return null;

            }
            catch (ArgumentNullException e)
            {
                // FuncName == null
                throw (e);
            }

            catch (ArgumentException e)
            {

                /* args is multidimensional.
                -or- 
                invokeAttr is not a valid BindingFlags attribute.
                -or- 
                invokeAttr contains CreateInstance combined with InvokeMethod, GetField, SetField, GetProperty, or SetProperty.
                -or- 
                invokeAttr contains both GetField and SetField.
                -or- 
                invokeAttr contains both GetProperty and SetProperty.
                -or- 
                invokeAttr contains InvokeMethod combined with SetField or SetProperty.
                -or- 
                invokeAttr contains SetField and args has more than one element.
                -or- 
                This method is called on a COM object and one of the following binding flags was not passed in: BindingFlags.InvokeMethod, BindingFlags.GetProperty, BindingFlags.SetProperty, BindingFlags.PutDispProperty, or BindingFlags.PutRefDispProperty.
                -or- 
                One of the named parameter arrays contains a string that is a null reference*/
                throw (e);
            }

            catch (MethodAccessException e)
            {//The specified member is a class initializer.
                throw (e);
            }

            catch (MissingFieldException e)
            {//The field or property cannot be found.
                throw (e);
            }

            catch (MissingMethodException e)
            {/*The method cannot be found.

             -or- 

             The current Type object represents a type that contains open type parameters, that is, ContainsGenericParameters returns true.*/

                throw (e);

            }

            catch (TargetException e)

            {//The specified member cannot be invoked on target. 

                throw (e);

            }

            catch (AmbiguousMatchException e)

            {//More than one method matches the binding criteria. 

                throw (e);

            }

            catch (NotSupportedException e)

            {//The .NET Compact Framework does not currently support this property.

                throw (e);



            }

            catch (Exception e)

            {

                throw (e);

            }

        }
 


        public object Method(string methodName, params object[] args)
        {
            return OLE1C77Function(methodName, BindingFlags.InvokeMethod, handle, args);
        }
        public T Method<T>(string methodName, params object[] args) where T:V1C8COMObject
        {
            return OLE1C77Function<T>(methodName,BindingFlags.InvokeMethod,handle,args);
        }

        public object GetProperty(string PropertyName) => OLE1C77Function(PropertyName, BindingFlags.GetProperty, Handle);
        public T GetProperty<T>(string PropertyName) where T:V1C8COMObject
        {
            return OLE1C77Function<T>(PropertyName, BindingFlags.GetProperty, Handle);
        }

        public V1C8COMObject GetPropertyObject(string PropertyName)
        {
            try
            {
                return (V1C8COMObject)GetProperty(PropertyName);
            }
            catch
            {
                Trace.TraceError($"Error get property {PropertyName} as COMObject");
                return null;
            }
        }
        public string GetPropertyString(string PropertyName)
        {
            try
            {
                return ((string)GetProperty(PropertyName)).Trim();
            }
            catch
            {
                Trace.TraceError("Error get property {0} as string", PropertyName);
                return string.Empty;
            }
        }
        public double GetPropertyDouble(string PropertyName)
        {
            try
            {
                return (double)GetProperty(PropertyName);
            }
            catch
            {
                Trace.TraceError("Error get property {0} as double", PropertyName);
                return 0;
            }
        }
        public uint? GetPropertyUint(string PropertyName)
        {
            string result = GetPropertyString(PropertyName);
            return result == "" ? new uint?() : new uint?(uint.Parse(result));
        }
        public DateTime GetPropertyDateTime(string PropertyName)
        {
            try
            {
                return (DateTime)GetProperty(PropertyName);
            }
            catch
            {
                Trace.TraceError("Error get property {0} as DateTime", PropertyName);
                return DateTime.MinValue;
            }

        }

        public void SetProperty(string propName, object value) => OLE1C77Function(propName, BindingFlags.PutDispProperty, Handle, new object[] { value });


        public int MethodInt(string MethodName)
        {
            try
            {
                return (int)Method(MethodName);
            }
            catch
            {
                Trace.TraceError("Error get method {0} as int", MethodName);
                return 0;
            }

        }
        public int MethodInt(string MethodName, params object[] args)
        {
            try
            {
                string result = MethodString(MethodName, args);
                if (result == "")
                    result = "0";
                return int.Parse(result.ToString());
            }
            catch
            {
                Trace.TraceError("Error get method {0} as int", MethodName);
                return 0;
            }

        }
        public double MethodDouble(string MethodName, params object[] args)
        {
            try
            {
                return (double)Method(MethodName, args);
            }
            catch
            {
                Trace.TraceError($"Error get method {MethodName} as Decimal");
                return 0;
            }


        }
        public string MethodString(string MethodName, params object[] args)
        {
            try
            {
                return ((string)Method(MethodName, args)).Trim();
            }
            catch
            {
                Trace.TraceError($"Error get method {MethodName} as string");
                return string.Empty;
            }


        }

         public V1C8COMConnector GLOBAL
        {
            get
            {
                var result = this;
                while (result.owner != null)
                {
                    result = result.owner;
                }
                return result as V1C8COMConnector;
            }
        }

        public void RemoveChild(V1C8COMObject com)
        {
            Children.Remove(com);
        }

        public void Dispose()
        {
            if (!disposed)
            {
                // remove all child
                while (Children.Count > 0) Children[0].Dispose();

                // remove this object from owner
                owner?.RemoveChild(this);

                // Free any unmanaged objects here.
                if (handle != null)
                {
                    if (Marshal.IsComObject(handle))
                        Marshal.ReleaseComObject(handle);
                }
                handle = null;
                disposed = true;
            }
        }
    }


}

