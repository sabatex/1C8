using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядокФормированияИндивидуальныхСведенийУчетаВремени", Comment = "", Synonym = "Порядок формирования индивидуальных сведений учета времени")]
    public enum ПорядокФормированияИндивидуальныхСведенийУчетаВремени
    {
        [Description1C8(Name = "НеФормировать", Comment = "", Synonym = "Не формировать")]
        НеФормировать,
        [Description1C8(Name = "ФормироватьПоЗарегистрированнымВидамВремени", Comment = "", Synonym = "Формировать по зарегистрированным видам времени")]
        ФормироватьПоЗарегистрированнымВидамВремени,
        [Description1C8(Name = "ФормироватьПолностью", Comment = "", Synonym = "Формировать полностью")]
        ФормироватьПолностью
    }
}
