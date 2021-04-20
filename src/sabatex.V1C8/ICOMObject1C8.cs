using System;

namespace sabatex.V1C8
{


    public interface ICOMObject1C8:IDisposable
    {
        T GetProperty<T>(string propertyName);
        void SetProperty(string propertyName, object value);

        T Method<T>(string methodName, params object[] args);
        IGlobalContext GlobalContext { get; }
        T ConvertTo1CObject<T>(object obj) where T : ICOMObject1C8;
 
     }
}
