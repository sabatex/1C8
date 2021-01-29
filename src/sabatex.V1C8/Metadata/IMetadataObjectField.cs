
using System;

namespace sabatex.V1C8.Metadata
{
    public interface IMetadataObjectField : IMetadataObject
    {
        public IMetadataTypeDescription Type { get => GetProperty<IMetadataTypeDescription>("Type"); }
        /// <summary>
        /// ¬ид дополнительных индексов, создаваемых дл€ работы с данными объекта метаданных.
        /// </summary>
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
        /// <summary>
        /// ƒл€ реквизитов справочников, планов видов характеристик это свойство указывает способ использовани€ данных подчиненного объекта конфигурации (например, ƒл€Ёлемента, ƒл€√руппы, ƒл€√руппы»Ёлемента).
        /// </summary>
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
        /// <summary>
        /// ќпредел€ет, использовать или нет данные этого объекта метаданных в полнотекстовом поиске.
        /// </summary>
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
        /// <summary>
        /// —войство содержит форматную строку, используемую при выводе реквизита.
        /// </summary>
        public string Format => GetProperty<string>("Format");
    }
}

