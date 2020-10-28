namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataTabularSections:IV1C8COMObject
    {
         public IMetaDataObjectCollection<IMetaDataObjectTabularSection> TabularSections{get=>GetProperty<IMetaDataObjectCollection<IMetaDataObjectTabularSection>>("TabularSections");}
    }
    
}