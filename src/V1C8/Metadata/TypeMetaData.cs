using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public class TypeMetaData:MetaDataBase
    {
        public TypeMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public EnumerationsMetadata<TypeMetaData>  Types()=>Method<EnumerationsMetadata<TypeMetaData>>("Types");
        public StringQualifiersMetaData StringQualifiers{get=>GetProperty<StringQualifiersMetaData>("StringQualifiers");}
        public NumberQualifiersMetaData NumberQualifiers{get=>GetProperty<NumberQualifiersMetaData>("NumberQualifiers");}
    
    }
}
