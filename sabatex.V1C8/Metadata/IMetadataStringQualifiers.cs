namespace sabatex.V1C8.Metadata
{
    public interface IMetadataStringQualifiers:ICOMObject1C8
    {
        public int Length{get=>GetProperty<int>("Length");}
        public string AllowedLength{get=>GlobalContext.String(GetProperty<COMObject1C8>("AllowedLength"));}
    }
}

