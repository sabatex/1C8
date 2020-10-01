using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ОтношениеКВоинскойОбязанности", Comment = "", Synonym = "Отношение к воинской обязанности")]
    public enum ОтношениеКВоинскойОбязанности
    {
        [Description1C8(Name = "Военнообязанный", Comment = "", Synonym = "Военнообязанный")]
        Военнообязанный,
        [Description1C8(Name = "НеВоеннообязанный", Comment = "", Synonym = "Не военнообязанный")]
        НеВоеннообязанный,
        [Description1C8(Name = "Призывник", Comment = "", Synonym = "Призывник")]
        Призывник
    }
}
