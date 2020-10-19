using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public class TypeMetaData:MetaDataBase
    {
        public TypeMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public TypesMetaData Types()=>Method<TypesMetaData>("Types");
        
    }
}

