namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataAttributes:IV1C8COMObject
    {
        public IMetaDataObjectCollection<IMetaDataObjectField> Attributes{get=>GetProperty<IMetaDataObjectCollection<IMetaDataObjectField>>("Attributes");}
       
    }
    
}