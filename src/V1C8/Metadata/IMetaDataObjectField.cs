using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataObjectField:IV1C8COMObject
    {
         public IMetaDataTypeDescription Type {get=>GetProperty<IMetaDataTypeDescription>("Type");}
 
      
    }
}

