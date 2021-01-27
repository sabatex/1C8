using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace sabatex.V1C8.XUnitTest
{
    [Collection("Connection 1C8")]
    public class MetadataTests
    {
        private readonly ConnectionFixture _connection;
        public MetadataTests(ConnectionFixture connection)
        {
            _connection = connection;    
        }
        [Fact]
        public void GetMetadata()
        {
            var metadata = _connection.GlobalContext.MetaData;
            var result = new 
            { 
                Name = metadata.Name,
                Synonym = metadata.Synonym,
                Comment = metadata.Comment

            };
        }
    }
}
