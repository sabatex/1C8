using sabatex.V1C8.Metadata;

namespace sabatex.V1C8
{
    public static class V1C8Extensions
    {
        public static string Name(this IV1C8Description obj)=> obj.GetProperty<string>("Name");
        public static string Synonym(this IV1C8Description obj)=> obj.GetProperty<string>("Synonym");
        public static string Comment(this IV1C8Description obj)=> obj.GetProperty<string>("Comment"); 
        
    }
    
}