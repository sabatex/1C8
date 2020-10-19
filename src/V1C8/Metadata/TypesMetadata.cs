using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public class TypesMetaData:EnumerationsMetadata
    {
        public TypesMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public TypeMetaData Get(int i)=>base.Get<TypeMetaData>(i);
        
    }
}

