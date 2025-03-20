using System;
using System.Collections.Generic;
using System.Text;


namespace Sabatex.V1C8.Metadata;

public interface IMetadataObject: IMetadataDescription
{
    /// <summary>
    /// Получает полное имя объекта метаданного. Имя отвечает требованиям, предъявляемым к именам (должно начинаться с буквы, содержать только буквы, цифры или символ "_", может содержать одну точку (не начальный и не конечный символ)).
    /// </summary>
    /// <returns></returns>
    string FullName()=>Method<string>("FullName");
    /// <summary>
    /// Получает строковое представление объекта метаданных. Как правило, в качестве строкового представления выступает синоним, а при его отсутствии - имя объекта метаданных, как оно задано в Конфигураторе.
    /// </summary>
    /// <returns></returns>
    public string Presentation() => Method<string>("Presentation");
    /// <summary>
    ///Получает объект описания расширения конфигурации, с помощью которого объект метаданных был добавлен.
    ///Доступность:
    ///Сервер, толстый клиент, внешнее соединение, мобильное приложение(сервер), мобильный автономный сервер.
    ///Использование в версии:
    ///Доступен, начиная с версии 8.3.8.
    /// </summary>
    /// <returns> РасширениеКонфигурации ,null - объект относится к основной конфигурации.</returns>
    public IMetadataObject ConfigurationExtension() => Method<IMetadataObject>("ConfigurationExtension");
    /// <summary>
    /// Получает объект описания метаданного, которому подчинен данный объект.
    /// </summary>
    /// <returns></returns>
    public IMetadataObject Parent()=> Method<IMetadataObject>("Parent");
}
