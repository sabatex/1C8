using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ХарактерЗависимостиКоличестваДнейОтпуска", Comment = "", Synonym = "Характер зависимости количества дней отпуска")]
    public enum ХарактерЗависимостиКоличестваДнейОтпуска
    {
        [Description1C8(Name = "НеЗависит", Comment = "", Synonym = "Не зависит")]
        НеЗависит,
        [Description1C8(Name = "ЗависитОтРабочегоМеста", Comment = "", Synonym = "Зависит от рабочего места")]
        ЗависитОтРабочегоМеста,
        [Description1C8(Name = "ЗависитОтСтажа", Comment = "", Synonym = "Зависит от стажа")]
        ЗависитОтСтажа
    }
}
