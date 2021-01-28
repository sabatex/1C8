using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8
{
    /// <summary>
    /// Неизменяемый массив. Заполняется системой при инициализации объектов данного типа или с помощью конструктора.
    /// </summary>
    public interface IFixedArray:ICOMObject1C8
    {
        /// <summary>
        /// Возвращает наибольший индекс элемента массива. Соответствует Количество()-1.
        /// </summary>
        /// <returns></returns>
        int UBound() => Method<int>("UBound");
        /// <summary>
        /// Получает количество элементов массива.
        /// </summary>
        /// <returns></returns>
        int Count() => Method<int>("Count");
        /// <summary>
        /// Выполняет поиск элемента в массиве.
        /// </summary>
        /// <param name="value">Произвольный. </param>
        /// <returns>Если элемент найден, возвращается его порядковый номер. Если элемент не найден, возвращается Неопределено.</returns>
        int? Find(object value) => Method<int?>("Find", value);
        /// <summary>
        /// Получает значение по индексу. Тип возвращаемого значения определяется типом хранящихся в коллекции значений.
        /// </summary>
        /// <param name="index">Индекс элемента.</param>
        /// <returns>Тип: Произвольный. </returns>
        object Get(int index) => Method<object>("Get", index);
    }

}
