namespace sabatex.V1C8.Metadata
{
    public interface IMetadataAttributes:ICOMObject1C8
    {
        public MetadataObjectCollection<IMetadataObjectField> Attributes => new MetadataObjectCollection<IMetadataObjectField>(GetProperty<ICOMObject1C8>("Attributes"));
    }


}