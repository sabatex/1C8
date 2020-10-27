using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public class ConfigurationMetadataObject:V1C8COMObject,IV1C8Description
    {
        public ConfigurationMetadataObject(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public string Version { get => GetProperty<string>("Version") ; }
        public ObjectMetaData FindByType(V1C8COMObject elementType)=>Method<ObjectMetaData>("FindByType",elementType);

        public MetadataObjectCollection<EnumMetaData>  Enums{get=>GetProperty<MetadataObjectCollection<EnumMetaData>>("Enums");}
        public MetadataObjectCollection<CatalogMetaData> Catalogs{get=>GetProperty<MetadataObjectCollection<CatalogMetaData>>("Catalogs");}
        public MetadataObjectCollection<DocumentMetaData> Documents{get=>GetProperty<MetadataObjectCollection<DocumentMetaData>>("Documents");}
        public MetadataObjectCollection<ChartOfAccountMetaData> ChartsOfAccounts{get=>GetProperty<MetadataObjectCollection<ChartOfAccountMetaData>>("ChartsOfAccounts");}


     }

    
}