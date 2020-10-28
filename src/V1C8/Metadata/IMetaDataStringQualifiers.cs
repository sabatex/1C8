namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataStringQualifiers:IV1C8COMObject
    {
        public int Length{get=>GetProperty<int>("Length");}
        public string AllowedLength{get=>GLOBAL.String(GetProperty<V1C8COMObject>("AllowedLength"));}
    }
}

