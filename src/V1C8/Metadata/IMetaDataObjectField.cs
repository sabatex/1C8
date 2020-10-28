using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataObjectField:IMetaDataDescription
    {
         public IMetaDataTypeDescription Type {get=>GetProperty<IMetaDataTypeDescription>("Type");}
 
      
    }
}

