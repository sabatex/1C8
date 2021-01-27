using System;

namespace sabatex.V1C8
{


    public interface ICOMObject1C8:IDisposable
    {
        T GetProperty<T>(string propertyName);
        void SetProperty(string propertyName, object value);

        T Method<T>(string methodName, params object[] args);
        IGlobalContext GlobalContext { get; }
    }
}
