
namespace sabatex.V1C8.Metadata
{
    /// <summary>
    /// ������������ ����� ������ ��� ���������� ����������� ������ ��������. � �������� ������������ ��� ���������� � �������� �������� ��������������� ��������� ������ ��������. ����� ���������� ����� � ������������� ����������� ����� �������� ��� �������� �������.
    /// </summary>
    public interface IMetadataTypeDescription:ICOMObject1C8
    {
        /// <summary>
        /// ���� �������� ��������, �� ����������� �������� �� ������������ �������� �������� ����. ���� �������� �������������, �� ����� ���������� ���������� ��������. ���� �������� �� �������������, �� ��� ���������� � ����, ���������� � �������� ����.
        /// ���� �������� �� ��������, �� �������� �������� �� ��������� ��� ������� �������� ����.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public object AdjustValue(object value) => Method<object>("AdjustValue", value);
        /// <summary>
        /// ����������, ������ �� ��������� ��� � ������������ ������ �������� ����.
        /// </summary>
        /// <param name="type">��, ��������� �������� �����������.</param>
        /// <returns>������ - ��������� ��� ������ � ������������ ����; ���� - � ��������� ������</returns>
        public bool ContainsType(ICOMObject1C8 type) => Method<bool>("ContainsType", type);
        /// <summary>
        /// �������� ����, ������������ � �������.
        /// </summary>
        /// <returns>���� ������������ � �������.</returns>
        public IArray1C8 Types() => Method<IArray1C8>("Types");
        public IMetadataStringQualifiers StringQualifiers{get=>GetProperty<IMetadataStringQualifiers>("StringQualifiers");}
        public IMetadataObjectNumberQualifiers NumberQualifiers{get=>GetProperty<IMetadataObjectNumberQualifiers>("NumberQualifiers");}
    
    }
}

