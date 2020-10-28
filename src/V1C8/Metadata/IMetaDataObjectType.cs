using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataObjectType:IV1C8Description
    {
         public IMetaDataObjectCollection<IMetaDataObjectType>  Types()=>Method<IMetaDataObjectCollection<IMetaDataObjectType>>("Types");
        public IMetaDataStringQualifiers StringQualifiers{get=>GetProperty<IMetaDataStringQualifiers>("StringQualifiers");}
        public IMetaDataObjectNumberQualifiers NumberQualifiers{get=>GetProperty<IMetaDataObjectNumberQualifiers>("NumberQualifiers");}
    
    }
}

