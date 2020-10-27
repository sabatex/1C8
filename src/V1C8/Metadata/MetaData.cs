using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public class MetaData:V1C8COMObject
    {
        public MetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public string Name { get=>GetProperty<string>("Name");}
        public string Version { get => GetProperty<string>("Version") ; }
        public ObjectMetaData FindByType(V1C8COMObject elementType)=>Method<ObjectMetaData>("FindByType",elementType);

        public EnumerationsMetadata<EnumMetaData>  Enums{get=>GetProperty<EnumerationsMetadata<EnumMetaData>>("Enums");}
        public EnumerationsMetadata<CatalogMetaData> Catalogs{get=>GetProperty<EnumerationsMetadata<CatalogMetaData>>("Catalogs");}
        public EnumerationsMetadata<DocumentMetaData> Documents{get=>GetProperty<EnumerationsMetadata<DocumentMetaData>>("Documents");}

        public EnumerationsMetadata<ChartOfAccountMetaData> ChartsOfAccounts{get=>GetProperty<EnumerationsMetadata<ChartOfAccountMetaData>>("ChartsOfAccounts");}


     }

    
}