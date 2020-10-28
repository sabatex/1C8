namespace sabatex.V1C8.Metadata
{
    public interface IMetaDataObjectNumberQualifiers:IV1C8COMObject
    {
        public int Digits{get=>GetProperty<int>("Digits");}
        public int FractionDigits{get=>GetProperty<int>("FractionDigits");}

    }
}

