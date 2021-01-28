
namespace sabatex.V1C8.Metadata
{
    public interface IMetadataTypeDescription:ICOMObject1C8
    {
        public MetadataObjectCollection<IMetadataTypeDescription>  Types()=> new MetadataObjectCollection<IMetadataTypeDescription>( Method<ICOMObject1C8>("Types"));
        public IMetadataStringQualifiers StringQualifiers{get=>GetProperty<IMetadataStringQualifiers>("StringQualifiers");}
        public IMetadataObjectNumberQualifiers NumberQualifiers{get=>GetProperty<IMetadataObjectNumberQualifiers>("NumberQualifiers");}
    
    }
}

