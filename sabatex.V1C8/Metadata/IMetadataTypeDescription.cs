
namespace sabatex.V1C8.Metadata
{
    /// <summary>
    /// Представляет собой объект для управления допустимыми типами значений. В основном предназначен для присвоения в качестве значений соответствующим свойствам других объектов. Набор допустимых типов и квалификаторы примитивных типов задаются при создании объекта.
    /// </summary>
    public interface IMetadataTypeDescription:ICOMObject1C8
    {
        /// <summary>
        /// Если значение передано, то выполняется проверка на соответствие значения описанию типа. Если значение соответствует, то метод возвращает переданное значение. Если значение не соответствует, то оно приводится к типу, доступному в описании типа.
        /// Если значение не передано, то выдается значение по умолчанию для данного описания типа.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public object AdjustValue(object value) => Method<object>("AdjustValue", value);
        /// <summary>
        /// Определяет, входит ли указанный тип в используемые данным объектом типы.
        /// </summary>
        /// <param name="type">ип, вхождение которого проверяется.</param>
        /// <returns>Истина - указанный тип входит в используемые типы; Ложь - в противном случае</returns>
        public bool ContainsType(ICOMObject1C8 type) => Method<bool>("ContainsType", type);
        /// <summary>
        /// Получает типы, используемые в объекте.
        /// </summary>
        /// <returns>Типы используемые в объекте.</returns>
        public IArray1C8 Types() => Method<IArray1C8>("Types");
        public IMetadataStringQualifiers StringQualifiers{get=>GetProperty<IMetadataStringQualifiers>("StringQualifiers");}
        public IMetadataObjectNumberQualifiers NumberQualifiers{get=>GetProperty<IMetadataObjectNumberQualifiers>("NumberQualifiers");}
    
    }
}

