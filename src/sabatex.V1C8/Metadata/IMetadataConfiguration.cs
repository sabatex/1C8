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

        MetadataObjectCollection<IMetaDataObjectEnum> Enums=>new MetadataObjectCollection<IMetaDataObjectEnum>(GetProperty<ICOMObject1C8>("Enums"));
        MetadataObjectCollection<IMetadataObjectCatalog> Catalogs => new MetadataObjectCollection<IMetadataObjectCatalog>(GetProperty<ICOMObject1C8>("Catalogs"));
        //IMetaDataObjectCollection<IMetaDataObjectDocument> Documents{get=>GetProperty<IMetaDataObjectCollection<IMetaDataObjectDocument>>("Documents");}
        //IMetaDataObjectCollection<IMetaDataObjectChartOfAccount> ChartsOfAccounts{get=>GetProperty<IMetaDataObjectCollection<IMetaDataObjectChartOfAccount>>("ChartsOfAccounts");}

    }


}