using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public class EnumerationsMetadata:V1C8COMObject
    {
        public EnumerationsMetadata(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public int Count { get => MethodInt("Count"); }
        public T Get<T>(int i) where T:V1C8COMObject=>Method<T>("Get",i);
    }
}

