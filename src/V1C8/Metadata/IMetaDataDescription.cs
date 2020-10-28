namespace sabatex.V1C8.Metadata
{
    public interface IV1C8Description:IV1C8COMObject
    {
        string Name {get=>GetProperty<string>("Name");}
        string Synonym {get=>GetProperty<string>("Synonym");}
        string Comment {get=>GetProperty<string>("Comment");}
        
    }
    
}