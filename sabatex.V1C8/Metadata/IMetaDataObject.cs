using System;
using System.Collections.Generic;
using System.Text;


namespace sabatex.V1C8.Metadata
{
    public interface IMetadataObject: IMetadataDescription
    {
        /// <summary>
        /// �������� ������ ��� ������� �����������. ��� �������� �����������, ������������� � ������ (������ ���������� � �����, ��������� ������ �����, ����� ��� ������ "_", ����� ��������� ���� ����� (�� ��������� � �� �������� ������)).
        /// </summary>
        /// <returns></returns>
        string FullName()=>Method<string>("FullName");
        /// <summary>
        /// �������� ��������� ������������� ������� ����������. ��� �������, � �������� ���������� ������������� ��������� �������, � ��� ��� ���������� - ��� ������� ����������, ��� ��� ������ � �������������.
        /// </summary>
        /// <returns></returns>
        public string Presentation() => Method<string>("Presentation");
        /// <summary>
        ///�������� ������ �������� ���������� ������������, � ������� �������� ������ ���������� ��� ��������.
        ///�����������:
        ///������, ������� ������, ������� ����������, ��������� ����������(������), ��������� ���������� ������.
        ///������������� � ������:
        ///��������, ������� � ������ 8.3.8.
        /// </summary>
        /// <returns> ���������������������� ,null - ������ ��������� � �������� ������������.</returns>
        public IMetadataObject ConfigurationExtension() => Method<IMetadataObject>("ConfigurationExtension");
        /// <summary>
        /// �������� ������ �������� �����������, �������� �������� ������ ������.
        /// </summary>
        /// <returns></returns>
        public IMetadataObject Parent()=> Method<IMetadataObject>("Parent");
    }
   
}