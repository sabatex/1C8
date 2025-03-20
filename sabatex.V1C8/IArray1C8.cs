using System;
using System.Collections.Generic;
using System.Text;

namespace sabatex.V1C8
{
    /// <summary>
    /// Произвольный
    /// Для объекта доступен обход коллекции посредством оператора Для каждого … Из … Цикл.При обходе выбираются значения элементов массива.
    /// Возможно обращение к значению элемента посредством оператора [...]. В качестве аргумента передается индекс значения (нумерация с 0).
    /// </summary>
    public interface IArray1C8:IFixedArray
    {
        /// <summary>
        /// Вставляет значение в массив по указанному индексу.
        /// </summary>
        /// <param name="index">Индекс вставляемого значения.</param>
        /// <param name="value">Вставляемое значение.</param>
        /// <returns></returns>
        public void Insert(int index, object value) => Method<object>("Insert", index, value);
        /// <summary>
        /// Вставляет Неопределено в массив по указанному индексу.
        /// </summary>
        /// <param name="index">Индекс вставляемого значения.</param>
        /// <returns></returns>
        public void Insert(int index) => Method<object>("Insert", index);
        /// <summary>
        /// Добавляет элемент в конец массива.
        /// </summary>
        /// <param name="value">Добавляемое значение</param>
        public void Add(object value) => Method<object>("Add", value);
        /// <summary>
        /// Добавляет Неопределено. в конец массива.
        /// </summary>
        public void Add() => Method<object>("Add");
        /// <summary>
        /// Удаляет все значения из массива
        /// </summary>
        public void Clear() => Method<object>("Clear");
        /// <summary>
        /// Удаляет значение из массива по указанному индексу.
        /// </summary>
        /// <param name="index">Индекс удаляемого элемента.</param>
        public void Delete(int index) => Method<object>("Delete", index);
        /// <summary>
        /// Устанавливает значение по индексу. Работает аналогично оператору [].
        /// </summary>
        /// <param name="index">Индекс элемента.</param>
        /// <param name="value">Устанавливаемое значение.</param>
        public void Set(int index, object value) => Method<object>("Set", index, value);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public void Set(int index)=> Method<object>("Set", index,null);
        /// <summary>
        /// Возможно обращение к значению элемента посредством оператора [...]. В качестве аргумента передается индекс значения (нумерация с 0).
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public new object this[int index] { get => Get(index); set => Set(index, value); }

    }

    /// <summary>
    /// Произвольный
    /// Для объекта доступен обход коллекции посредством оператора Для каждого … Из … Цикл.При обходе выбираются значения элементов массива.
    /// Возможно обращение к значению элемента посредством оператора [...]. В качестве аргумента передается индекс значения (нумерация с 0).
    /// </summary>
    public interface IArray1C8<T> : IFixedArray<T>
    {
        /// <summary>
        /// Вставляет значение в массив по указанному индексу.
        /// </summary>
        /// <param name="index">Индекс вставляемого значения.</param>
        /// <param name="value">Вставляемое значение.</param>
        /// <returns></returns>
        public void Insert(int index, T value) => Method<object>("Insert", index, value);
        /// <summary>
        /// Вставляет Неопределено в массив по указанному индексу.
        /// </summary>
        /// <param name="index">Индекс вставляемого значения.</param>
        /// <returns></returns>
        public void Insert(int index) => Method<object>("Insert", index);
        /// <summary>
        /// Добавляет элемент в конец массива.
        /// </summary>
        /// <param name="value">Добавляемое значение</param>
        public void Add(T value) => Method("Add", value);
        /// <summary>
        /// Добавляет Неопределено. в конец массива.
        /// </summary>
        public void Add() => Method("Add");
        /// <summary>
        /// Удаляет все значения из массива
        /// </summary>
        public void Clear() => Method("Clear");
        /// <summary>
        /// Удаляет значение из массива по указанному индексу.
        /// </summary>
        /// <param name="index">Индекс удаляемого элемента.</param>
        public void Delete(int index) => Method("Delete", index);
        /// <summary>
        /// Устанавливает значение по индексу. Работает аналогично оператору [].
        /// </summary>
        /// <param name="index">Индекс элемента.</param>
        /// <param name="value">Устанавливаемое значение.</param>
        public void Set(int index, T value) => Method("Set", index, value);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        public void Set(int index) => Method("Set", index, null);
        /// <summary>
        /// Возможно обращение к значению элемента посредством оператора [...]. В качестве аргумента передается индекс значения (нумерация с 0).
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public new T this[int index] { get => Get(index); set => Set(index, value); }

    }


}
