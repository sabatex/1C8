using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sabatex.V1C8.XUnitTest
{
    [Collection("Connection 1C8")]
    public class ArrayTests
    {
        private readonly ConnectionFixture _connection;
        public ArrayTests(ConnectionFixture connection)
        {
            _connection = connection;
        }
        [Fact]
        public void ArrayTest()
        {
            var array = _connection.GlobalContext.NewObject<IArray1C8>("Массив");
            Assert.Equal(0,array.Count());
            Assert.Equal(-1, array.UBound());
            array.Add(10);
            Assert.Equal(10, array[0]);
            Assert.Equal(1, array.Count());
            Assert.Equal(0, array.UBound());
            Assert.Equal(0, array.Find(10));
            array[0] = 20;
            Assert.Equal(20, array[0]);
            array.Insert(0);
            array.Insert(0, 25);
            var undef = array[1];
            Assert.Equal(3, array.Count());
            array.Set(0);
            array.Set(0, "xxx");
            array.Delete(1);
            Assert.Equal(2, array.Count());
            array.Add();
            array.Clear();
            Assert.Equal(0, array.Count());
        }


    }
}
