namespace sabatex.V1C8.Metadata
{
    public interface IMetadataObjectNumberQualifiers:ICOMObject1C8
    {
        public int Digits{get=>GetProperty<int>("Digits");}
        public int FractionDigits{get=>GetProperty<int>("FractionDigits");}

    }
}

