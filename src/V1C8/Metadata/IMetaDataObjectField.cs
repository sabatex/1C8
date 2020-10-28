using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataObjectField:IV1C8COMObject
    {
         public IMetaDataObjectType Type {get=>GetProperty<IMetaDataObjectType>("Type");}
 
      
    }
}

