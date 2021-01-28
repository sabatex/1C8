
using System;

namespace sabatex.V1C8.Metadata
{
    public interface IMetadataObjectField : IMetadataObject
    {
        public IMetadataTypeDescription Type { get => GetProperty<IMetadataTypeDescription>("Type"); }

        public Indexing Indexing
        {
            get
            {
                string value = GlobalContext.String(GetProperty<IMetadataObject>("Indexing"));
                switch (value)
                {
                    case "»ндексировать":
                    case "Index":
                        return Indexing.Index;
                    case "»ндексировать—ƒоп”пор€дочиванием":
                    case "IndexWithAdditionalOrder":
                        return Indexing.IndexWithAdditionalOrder;
                    case "Ќе»ндексировать":
                    case "DontIndex":
                        return Indexing.DontIndex;
                    default:
                        throw new Exception($"Ќе врозмозможно определить значение {value}");
                }
            }
        }

        public AttributeUse Use
        {
            get
            {
                string value = GlobalContext.String(GetProperty<IMetadataObject>("Use"));
                switch (value)
                {
                    case "ƒл€√руппы":
                    case "ForFolder":
                        return AttributeUse.ForFolder;
                    case "ƒл€√руппы»Ёлемента":
                    case "ForFolderAndItem":
                        return AttributeUse.ForFolderAndItem;
                    case "ƒл€Ёлемента":
                    case "ForItem":
                        return AttributeUse.ForItem;
                    default:
                        throw new Exception($"Ќе врозмозможно определить значение {value}");
                }
             }
        }
        public UseFullTextSearch FullTextSearch
        {
            get
            {
                string value = GlobalContext.String(GetProperty<IMetadataObject>("FullTextSearch"));
                switch (value)
                {
                    case "»спользовать":
                    case "Use":
                        return UseFullTextSearch.Use;
                    case "Ќе»спользовать":
                    case "DontUse":
                        return UseFullTextSearch.DontUse;
                    default:
                        throw new Exception($"Ќе врозмозможно определить значение {value}");
                }
            }
        }


    }
}

