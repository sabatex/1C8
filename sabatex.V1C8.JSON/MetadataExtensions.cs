using sabatex.V1C8.Metadata;
using sabatex.V1C8.Models.Metadata;
using System;
using System.Collections.Generic;

namespace sabatex.V1C8.JSON
{
    public static class MetadataExtensions
    {
        static Dictionary<int, Dictionary<string, MetadataEnum>> enumCashe = new Dictionary<int, Dictionary<string, MetadataEnum>>();
        public static MetadataEnum GetEnumMetadata(this IMetadataConfiguration metadata,string enumName)
        {
            int hash = metadata.GlobalContext.GetHashCode();
            Dictionary<string, MetadataEnum>  enums;
            // chec group
            if (!enumCashe.TryGetValue(hash,out  enums ))
            {
                enums = new Dictionary<string, MetadataEnum>();
                enumCashe.Add(hash, enums);
            }
            // check value
            MetadataEnum result;
            if (!enums.TryGetValue(enumName, out result)) return result;
            var e = metadata.Enums[enumName];
            result = new MetadataEnum();
            result.Comment = e.Comment;
            result.FullName = e.FullName();
            result.Name = e.Name;
            result.Synonym = e.Synonym;

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
                    result.Items = enumItems.ToArray();
                enums.Add(enumName, result);
            return result;
        }
    }
}
