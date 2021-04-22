using System;

namespace sabatex.V1C8
{


    public interface ICOMObject1C8:IDisposable
    {
        T GetProperty<T>(string propertyName);
        void SetProperty(string propertyName, object value);

        T Method<T>(string methodName, params object[] args);
        void Method(string methodName, params object[] args) => Method<object>(methodName, args);

        IGlobalContext GlobalContext { get; }
     }
}
