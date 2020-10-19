namespace sabatex.V1C8.Metadata
{
    public class StringQualifiersMetaData:V1C8COMObject
    {
        public StringQualifiersMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public int Length{get=>GetStructProperty<int>("Length");}
        public string AllowedLength{get=>GLOBAL.String(GetProperty<V1C8COMObject>("AllowedLength"));}
    }
}

