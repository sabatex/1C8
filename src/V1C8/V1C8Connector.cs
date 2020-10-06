using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace sabatex.V1C8
{
     public class V1C8COMConnector:V1C8COMObject, IDisposable
    {
        protected readonly string connectionString;
        public readonly dynamic COMObject;
        //protected bool disposed = false;
        protected V1C8COMConnector()
        {

        }
        public V1C8COMConnector(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException();
            this.connectionString = connectionString;
            Type comConnector = Type.GetTypeFromProgID("V83.COMConnector");
            dynamic instance = Activator.CreateInstance(comConnector);
            handle = instance.Connect(connectionString);

        }

        public V1C8COMConnector(string serverName, string dataBaseName, string userName, string password) :
            this($"Srvr='{serverName}';Ref='{dataBaseName}';Usr='{userName}';pwd='{password}';")
        { }
        public V1C8COMConnector(string dataBasePath, string userName, string password):
            this($"File='{dataBasePath}';Usr='{userName}';pwd='{password}';"){}


        public string String(dynamic value) => COMObject.String(value);
        public Guid GetObjectId(dynamic value) => Guid.Parse(this.String(value.УникальныйИдентификатор()));

        public MetaData MetaData{get=>GetProperty<MetaData>("Metadata");}
        public static string BuildConnectionString(string dataBasePath, string userName, string password)
        {
            return $"File='{dataBasePath}';Usr='{userName}';pwd='{password}';";
        }
        public static string BuildConnectionString(string serverName, string dataBaseName, string userName, string password)
        {
            return $"Srvr='{serverName}';Ref='{dataBaseName}';Usr='{userName}';pwd='{password}';";
        }
    }


}
