using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8.RU.Metadata
{
    public interface IОписаниеМетаданных : ICOMObject1C8
    {
        string Имя => GetProperty<string>("Name"); 
        string Синоним  => GetProperty<string>("Synonym");
        string Комментарий => GetProperty<string>("Comment");

    }
}
