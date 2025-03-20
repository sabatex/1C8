namespace Sabatex.V1C8.Metadata;

public interface IMetadataDescription:ICOMObject1C8
{
    string Name {get=>GetProperty<string>("Name");}
    string Synonym {get=>GetProperty<string>("Synonym");}
    string Comment {get=>GetProperty<string>("Comment");}
    
}
