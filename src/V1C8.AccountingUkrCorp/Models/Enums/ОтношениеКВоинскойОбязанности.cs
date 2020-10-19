using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("OtnoshenyeKVoynskoiObiazannosty")]
    [Description1C8(Name = "ОтношениеКВоинскойОбязанности", Comment = "", Synonym = "Отношение к воинской обязанности")]
    public class ОтношениеКВоинскойОбязанности:EnumItem
    {
        public static readonly ОтношениеКВоинскойОбязанности Военнообязанный = new ОтношениеКВоинскойОбязанности{Name= "Военнообязанный",Synonym="Военнообязанный",Comment=""};
        public static readonly ОтношениеКВоинскойОбязанности НеВоеннообязанный = new ОтношениеКВоинскойОбязанности{Name= "НеВоеннообязанный",Synonym="Не военнообязанный",Comment=""};
        public static readonly ОтношениеКВоинскойОбязанности Призывник = new ОтношениеКВоинскойОбязанности{Name= "Призывник",Synonym="Призывник",Comment=""};
    }
}
