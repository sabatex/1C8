using sabatex.V1C8.Models;

namespace sabatex.V1C8.Metadata
{
    public class EnumValues:V1C8COMObject
    {
        public EnumValues(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public int Count { get => MethodInt("Count"); }
        public EnumItem Get(int i){
               var v = Method<V1C8COMObject>("Get",i);
               return new EnumItem
               {
                    Name = v.GetPropertyString("Name"),
                    Synonym = v.GetPropertyString("Synonym"),
                    Comment = v.GetPropertyString("Comment")
               };
        }
        
    }
}

