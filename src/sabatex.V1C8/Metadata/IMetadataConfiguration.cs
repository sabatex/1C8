using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public interface IMetadataConfiguration:IMetadataDescription
    {
        string Version  => GetProperty<string>("Version") ; 
        IMetaDataObject FindByType(ICOMObject1C8 elementType)=>Method<IMetaDataObject>("FindByType",elementType);
        IMetaDataObject FindByFullName(string fullName) => Method<IMetaDataObject>("FindByFullName");
        //IMetaDataObjectCollection<IMetaDataObjectEnum>  Enums{get=>GetProperty<IMetaDataObjectCollection<IMetaDataObjectEnum>>("Enums");}
        //IMetaDataObjectCollection<IMetaDataObjectCatalog> Catalogs{get=>GetProperty<IMetaDataObjectCollection<IMetaDataObjectCatalog>>("Catalogs");}
        //IMetaDataObjectCollection<IMetaDataObjectDocument> Documents{get=>GetProperty<IMetaDataObjectCollection<IMetaDataObjectDocument>>("Documents");}
        //IMetaDataObjectCollection<IMetaDataObjectChartOfAccount> ChartsOfAccounts{get=>GetProperty<IMetaDataObjectCollection<IMetaDataObjectChartOfAccount>>("ChartsOfAccounts");}

    }

    
}