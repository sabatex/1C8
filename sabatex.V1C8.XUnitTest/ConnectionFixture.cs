using Microsoft.Extensions.Configuration;
using Sabatex.V1C8;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sabatex.V1C8.XUnitTest
{
    public class ConnectionFixture:IDisposable
    {
        public  IGlobalContext GlobalContext { get; private set; }
        public IConfigurationRoot Configuration { get; private set; }

        public ConnectionFixture()
        {
            Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                .AddJsonFile("appsettings.json")
                                                .Build();

            GlobalContext = COMObject1C8.CreateConnection(Configuration["ConnectionString1C8"]);
        }
        public void Dispose()
        {
            GlobalContext.Dispose();
        }
    }
    [CollectionDefinition("Connection 1C8")]
    public class Connection1C8FixtureCollection: ICollectionFixture<ConnectionFixture>
    { }
}
