using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.RU.Metadata
{
    public interface IМетаданныеКонфигурации:IОписаниеМетаданных
    {
        public string Версия => GetProperty<string>("Version");
        public IОбьектМетаданных НайтиПоПолномуИмени(string fullName) => Method<IОбьектМетаданных>("FindByFullName");
        public IОбьектМетаданных НайтиПоТипу(ICOMObject1C8 objectType) => Method<IОбьектМетаданных>("FindByType", objectType);
    }
}
