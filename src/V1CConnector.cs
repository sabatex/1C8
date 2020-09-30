using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8
{
    public class V1CConnector
    {

        private V1CConnector()
        {

        }

        public static string BuildConnectionString(String dataBasePath, string userName, string password)
        {
            return $"File='{dataBasePath}';Usr='{userName}';pwd='{password}';";
        }
        public static string BuildConnectionString(string serverName, string dataBaseName, string userName, string password)
        {
            return $"Srvr='{serverName}';Ref='{dataBaseName}';Usr='{userName}';pwd='{password}';";
        }


        public static V1CConnector GetConnection(string connectionString)
        {
            Type comConnector = Type.GetTypeFromProgID("V83.COMConnector");
            dynamic instance = Activator.CreateInstance(comConnector);
            dynamic comObject = instance.Connect(connectionString);

            return new V1CConnector() { context = comObject };
        }

        dynamic context;
        public dynamic Context => context;

        public string GetAsString(dynamic value) => context.String(value);
        public Guid GetObjectId(dynamic value)
        {
            if (value == null)
                throw new Exception("Параметр value не може бути null");
            return new Guid(GetAsString(value.УникальныйИдентификатор()));
        }
        public dynamic Catalogs => Context.Catalogs;
        public dynamic Справочники => Catalogs;
    }

}
