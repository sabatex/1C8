interface IV1CCOMObject
{
    T GetProperty<T>(string propertyName);
    T Method<T>(string methodName, params object[] args);
}