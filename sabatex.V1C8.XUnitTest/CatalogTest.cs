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
            var testL = _connection.GlobalContext.Catalogs["ФизическиеЛица"].Select();
            while (testL.Next())
            {
                var test = testL.Ref;
                if (test.DeletionMark) continue;
                if (test.IsFolder) continue;
                var owner = test.Owner;
                var parent = test.Parent;
                var code = test.Code;
                var description = test.Description;
                var item = _connection.GlobalContext.Catalogs["ФизическиеЛица"].FindByCode(code);
                var uuid = test.UUID;
                var metadata = test.Metadata();
                var fullDescr = test.FullDescr();
                var fullCode = test.FullCode();
                var obj = test.GetObject();
                var isEmpty = test.IsEmpty();
                var copy = test.Copy();
                var level = test.Level();
                Assert.NotNull(item);

            }
        }


    }
}
