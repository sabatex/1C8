using System;

namespace sabatex.V1C8
{


    public interface ICOMObject1C8:IDisposable
    {
        /// <summary>
        /// �������� �������� ������
        /// </summary>
        /// <typeparam name="T">��� ����������</typeparam>
        /// <param name="propertyName">�������� ��������</param>
        /// <returns></returns>
        T GetProperty<T>(string propertyName);
        /// <summary>
        /// ���������� ��������
        /// </summary>
        /// <param name="propertyName">�������� ��������</param>
        /// <param name="value">�������� ������� ����� ����������</param>
        void SetProperty(string propertyName, object value);
        /// <summary>
        /// ��������� ����� � ����������� ���� �
        /// </summary>
        /// <typeparam name="T">��� ����������</typeparam>
        /// <param name="methodName">��� ������</param>
        /// <param name="args">��������� ������, �������������� ��������� �� ��������� ��������� ������ ���� null</param>
        /// <returns></returns>
        T Method<T>(string methodName, params object[] args);
        /// <summary>
        /// ����� ��� ���������� (void)
        /// </summary>
        /// <param name="methodName">��� ������</param>
        /// <param name="args">��������� ������, �������������� ��������� �� ��������� ��������� ������ ���� null</param>
        void Method(string methodName, params object[] args) => Method<object>(methodName, args);
        /// <summary>
        /// ���������� ��������
        /// </summary>
        IGlobalContext GlobalContext { get; }
     }
}
