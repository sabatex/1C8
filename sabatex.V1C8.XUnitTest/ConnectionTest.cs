using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace sabatex.V1C8.XUnitTest
{
    public class ConnectionTest
    {
        [Fact]
        public void Connect()
        {
            var Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                .AddJsonFile("appsettings.json")
                                                .Build();
            var GlobalContext = COMObject1C8.CreateConnection(Configuration["ConnectionString1C8"]);

        }
    }
}
