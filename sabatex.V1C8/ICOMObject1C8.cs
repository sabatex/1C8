using System;

namespace Sabatex.V1C8
{


    public interface ICOMObject1C8:IDisposable
    {
        /// <summary>
        /// Получить свойство обекта
        /// </summary>
        /// <typeparam name="T">Тип результата</typeparam>
        /// <param name="propertyName">Название свойства</param>
        /// <returns></returns>
        T GetProperty<T>(string propertyName);
        /// <summary>
        /// Установить свойство
        /// </summary>
        /// <param name="propertyName">Название свойства</param>
        /// <param name="value">Значение которое будет установлен</param>
        void SetProperty(string propertyName, object value);
        /// <summary>
        /// Выполнить метод с результатом типа Т
        /// </summary>
        /// <typeparam name="T">Тип результата</typeparam>
        /// <param name="methodName">Имя метода</param>
        /// <param name="args">параметры метода, необязательные параметры до указаного параметра должны быть null</param>
        /// <returns></returns>
        T Method<T>(string methodName, params object[] args);
        /// <summary>
        /// Метод без результата (void)
        /// </summary>
        /// <param name="methodName">Имя метода</param>
        /// <param name="args">параметры метода, необязательные параметры до указаного параметра должны быть null</param>
        void Method(string methodName, params object[] args) => Method<object>(methodName, args);
        /// <summary>
        /// Глобальный контекст
        /// </summary>
        IGlobalContext GlobalContext { get; }
     }
}
