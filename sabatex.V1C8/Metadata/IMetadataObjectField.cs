
using System;

namespace sabatex.V1C8.Metadata
{
    public interface IMetadataObjectField : IMetadataObject
    {
        public IMetadataTypeDescription Type { get => GetProperty<IMetadataTypeDescription>("Type"); }
        /// <summary>
        /// ��� �������������� ��������, ����������� ��� ������ � ������� ������� ����������.
        /// </summary>
        public Indexing Indexing
        {
            get
            {
                string value = GlobalContext.String(GetProperty<IMetadataObject>("Indexing"));
                switch (value)
                {
                    case "�������������":
                    case "Index":
                        return Indexing.Index;
                    case "��������������������������������":
                    case "IndexWithAdditionalOrder":
                        return Indexing.IndexWithAdditionalOrder;
                    case "���������������":
                    case "DontIndex":
                        return Indexing.DontIndex;
                    default:
                        throw new Exception($"�� ������������ ���������� �������� {value}");
                }
            }
        }
        /// <summary>
        /// ��� ���������� ������������, ������ ����� ������������� ��� �������� ��������� ������ ������������� ������ ������������ ������� ������������ (��������, �����������, ���������, ������������������).
        /// </summary>
        public AttributeUse Use
        {
            get
            {
                string value = GlobalContext.String(GetProperty<IMetadataObject>("Use"));
                switch (value)
                {
                    case "���������":
                    case "ForFolder":
                        return AttributeUse.ForFolder;
                    case "������������������":
                    case "ForFolderAndItem":
                        return AttributeUse.ForFolderAndItem;
                    case "�����������":
                    case "ForItem":
                        return AttributeUse.ForItem;
                    default:
                        throw new Exception($"�� ������������ ���������� �������� {value}");
                }
             }
        }
        /// <summary>
        /// ����������, ������������ ��� ��� ������ ����� ������� ���������� � �������������� ������.
        /// </summary>
        public UseFullTextSearch FullTextSearch
        {
            get
            {
                string value = GlobalContext.String(GetProperty<IMetadataObject>("FullTextSearch"));
                switch (value)
                {
                    case "������������":
                    case "Use":
                        return UseFullTextSearch.Use;
                    case "��������������":
                    case "DontUse":
                        return UseFullTextSearch.DontUse;
                    default:
                        throw new Exception($"�� ������������ ���������� �������� {value}");
                }
            }
        }
        /// <summary>
        /// �������� �������� ��������� ������, ������������ ��� ������ ���������.
        /// </summary>
        public string Format => GetProperty<string>("Format");
    }
}

