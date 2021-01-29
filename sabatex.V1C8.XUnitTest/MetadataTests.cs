using sabatex.V1C8.Metadata;
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
        private readonly IMetadataConfiguration _metadata;
        public MetadataTests(ConnectionFixture connection)
        {
            _connection = connection;
            _metadata = _connection.GlobalContext.MetaData;
        }
        [Fact]
        public object GetEnumsMetadata()
        {
            var result = new List<object>();

            foreach (var e in _metadata.Enums)
            {
                var testEnumItems = new List<object>();
                foreach (var ei in e.EnumValues)
                {
                    var enumItemValue = new
                    {
                        Name = ei.Name,
                        Synonym = ei.Synonym,
                        Comment = ei.Comment,
                        Parent = e.Parent()?.Presentation(),
                        Presentation = e.Presentation(),
                        ConfigurationExtension = e.ConfigurationExtension()?.Presentation(),
                    };
                    testEnumItems.Add(enumItemValue);

                }


                var en = new
                {
                    Name = e.Name,
                    Synonym = e.Synonym,
                    Comment = e.Comment,
                    Parent = e.Parent()?.Presentation(),
                    Presentation = e.Presentation(),
                    ConfigurationExtension = e.ConfigurationExtension()?.Presentation(),
                    items = testEnumItems
                };
                result.Add(en);
            }
            return result;
        }
        [Fact]
        public object GetCatalogsMetadata()
        {
            var result = new List<object>();
            foreach (var e in _metadata.Catalogs)
            {

                var predefinedNames = e.GetPredefinedNames();
                var sb = new List<string>();
                for (int i = 0; i < predefinedNames.Count(); i++) sb.Add((string)predefinedNames.Get(i));


                var attributes = new List<object>();
                foreach (var attr in e.Attributes)
                {
                    attributes.Add( new
                    {
                        Name = attr.Name,
                        Synonym = attr.Synonym,
                        Comment = attr.Comment,
                        Parent = attr.Parent()?.Presentation(),
                        Presentation = attr.Presentation(),
                        ConfigurationExtension = attr.ConfigurationExtension()?.Presentation(),
                        Indexing = attr.Indexing,
                        Use = attr.Use,
                        FullName = attr.FullName(),
                        FullTextSearch = attr.FullTextSearch,
                        Format = attr.Format
                    });
                }



                var en = new
                {
                    Name = e.Name,
                    Synonym = e.Synonym,
                    Comment = e.Comment,
                    Parent = e.Parent()?.Presentation(),
                    Presentation = e.Presentation(),
                    ConfigurationExtension = e.ConfigurationExtension()?.Presentation(),
                    PredefinedNames = sb,
                    Attributes = attributes
                };
                result.Add(en);
            }
            return result;
        }


        [Fact]
        public void GetMetadata()
        {
            var result = new 
            { 
                Name = _metadata.Name,
                Synonym = _metadata.Synonym,
                Comment = _metadata.Comment,
                Enums = GetEnumsMetadata(),
                Catalogs = GetCatalogsMetadata()

            };
        }
    

    
    }
}
