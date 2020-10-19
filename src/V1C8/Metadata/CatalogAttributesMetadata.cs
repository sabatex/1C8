using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public class CatalogAttributesMetadata:V1C8COMObject
    {
        public CatalogAttributesMetadata(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public int Count { get => MethodInt("Count"); }
        public FieldMetadata Get(int i)=>Method<FieldMetadata>("Get");

    }
}

