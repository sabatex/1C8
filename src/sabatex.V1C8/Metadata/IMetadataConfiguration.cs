using sabatex.V1C8.Models.Metadata;
using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public interface IMetadataConfiguration : IMetadataDescription
    {
        string Version => GetProperty<string>("Version");
        IMetadataObject FindByType(ICOMObject1C8 elementType) => Method<IMetadataObject>("FindByType", elementType);
        IMetadataObject FindByFullName(string fullName) => Method<IMetadataObject>("FindByFullName");
        MetadataEnum[] GetMetadataEnum()
        {
            var result = new List<MetadataEnum>();
            foreach (var e in Enums)
            {
                var value = new MetadataEnum();
                value.Comment = e.Comment;
                value.FullName = e.FullName();
                value.Name = e.Name;
                value.Presentation = e.Presentation();
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
                    enumItemValue.Presentation = ei.Presentation();
                    enumItemValue.Synonym = ei.Synonym;
                    enumItems.Add(enumItemValue);
                }
                value.Items = enumItems.ToArray();


                result.Add(value);
            }


            return result.ToArray();
        }

        MetadataObjectCollection<IMetaDataObjectEnum> Enums=>new MetadataObjectCollection<IMetaDataObjectEnum>(GetProperty<ICOMObject1C8>("Enums"));
        MetadataObjectCollection<IMetadataObjectCatalog> Catalogs => new MetadataObjectCollection<IMetadataObjectCatalog>(GetProperty<ICOMObject1C8>("Catalogs"));
        //IMetaDataObjectCollection<IMetaDataObjectDocument> Documents{get=>GetProperty<IMetaDataObjectCollection<IMetaDataObjectDocument>>("Documents");}
        //IMetaDataObjectCollection<IMetaDataObjectChartOfAccount> ChartsOfAccounts{get=>GetProperty<IMetaDataObjectCollection<IMetaDataObjectChartOfAccount>>("ChartsOfAccounts");}

    }


}