using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДополнительныеЗначенияДоступа", Comment = "", Synonym = "Дополнительные значения доступа")]
    public enum ДополнительныеЗначенияДоступа
    {
        [Description1C8(Name = "ДоступРазрешен", Comment = "", Synonym = "Доступ разрешен")]
        ДоступРазрешен,
        [Description1C8(Name = "ДоступЗапрещен", Comment = "", Synonym = "Доступ запрещен")]
        ДоступЗапрещен,
        [Description1C8(Name = "Истина", Comment = "", Synonym = "Истина")]
        Истина,
        [Description1C8(Name = "Ложь", Comment = "", Synonym = "Ложь")]
        Ложь,
        [Description1C8(Name = "ПустаяСсылкаЛюбогоТипа", Comment = "", Synonym = "Пустая ссылка любого типа")]
        ПустаяСсылкаЛюбогоТипа,
        [Description1C8(Name = "Неопределено", Comment = "", Synonym = "Неопределено")]
        Неопределено,
        [Description1C8(Name = "Null", Comment = "", Synonym = "Null")]
        Null,
        [Description1C8(Name = "ТипРазрешенный", Comment = "", Synonym = "Тип разрешенный")]
        ТипРазрешенный,
        [Description1C8(Name = "ТипЗапрещенный", Comment = "", Synonym = "Тип запрещенный")]
        ТипЗапрещенный
    }
}
