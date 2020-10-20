namespace sabatex.V1C8.Metadata
{
    public class NumberQualifiersMetaData:V1C8COMObject
    {
        public NumberQualifiersMetaData(V1C8COMObject owner, object handle):base(owner,handle)
        {
            
        }
        public int Digits{get=>GetStructProperty<int>("Digits");}
        public int FractionDigits{get=>GetStructProperty<int>("FractionDigits");}

    }
}

