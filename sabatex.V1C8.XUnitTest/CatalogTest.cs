using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace sabatex.V1C8.XUnitTest
{
    [Collection("Connection 1C8")]
    public class CatalogTest
    {
        private readonly ConnectionFixture _connection;

        public CatalogTest(ConnectionFixture connection)
        {
            _connection = connection;
        }

        [Fact]
        public void GetCatalogItems()
        {
            var test = _connection.GlobalContext.Catalogs["ФизическиеЛица"].Select();
            while (test.Next())
            {
                if (test.DeletionMark) continue;
                if (test.IsFolder) continue;
                var owner = test.Owner;
                var parent = test.Parent;
                var code = test.Code;
                var description = test.Description;
                var refCatalog = test.Ref;
                var item = _connection.GlobalContext.Catalogs["ФизическиеЛица"].FindByCode(code);
                Assert.NotNull(item);

            }
        }


    }
}
