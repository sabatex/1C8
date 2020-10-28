namespace sabatex.V1C8
{


    public interface IV1C8COMObject
    {
        T GetProperty<T>(string propertyName);
        T Method<T>(string methodName, params object[] args);
        object Method(string methodName, params object[] args);
    }
}
