using sabatex.V1C8.Models.Metadata;
using sabatex.V1C8.Metadata;
using System;
using System.Collections.Generic;

namespace sabatex.V1C8.Extensions
{
    public static class MetadataExtensions
    {
        public static MetadataEnum[] GetMetadataEnums(this IMetadataConfiguration metadata)
        {
            var result = new List<MetadataEnum>();
            foreach (var e in metadata.Enums)
            {
                var value = new MetadataEnum();
                value.Comment = e.Comment;
                value.FullName = e.FullName();
                value.Name = e.Name;
                value.Synonym = e.Synonym;

                var enumItems = new List<MetadataEnumItem>();

                var i = 0;
                foreach (var ei in e.EnumValues)
                {
                    var enumItemValue = new MetadataEnumItem();
                    enumItemValue.Id = i++;
                    enumItemValue.Comment = ei.Comment;
                    enumItemValue.FullName = ei.FullName();
                    enumItemValue.Name = ei.Name;
                    enumItemValue.Synonym = ei.Synonym;
                    enumItems.Add(enumItemValue);
                }
                value.Items = enumItems.ToArray();


                result.Add(value);
            }
            return result.ToArray();
        }
    }
}
