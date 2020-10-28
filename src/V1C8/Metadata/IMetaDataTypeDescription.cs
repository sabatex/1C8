using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataTypeDescription:IV1C8COMObject
    {
         public IMetaDataObjectCollection<IMetaDataTypeDescription>  Types()=>Method<IMetaDataObjectCollection<IMetaDataTypeDescription>>("Types");
        public IMetaDataStringQualifiers StringQualifiers{get=>GetProperty<IMetaDataStringQualifiers>("StringQualifiers");}
        public IMetaDataObjectNumberQualifiers NumberQualifiers{get=>GetProperty<IMetaDataObjectNumberQualifiers>("NumberQualifiers");}
    
    }
}

