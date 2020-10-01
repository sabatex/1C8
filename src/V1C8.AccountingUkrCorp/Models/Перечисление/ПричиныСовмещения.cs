using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПричиныСовмещения", Comment = "", Synonym = "Причины совмещения")]
    public enum ПричиныСовмещения
    {
        [Description1C8(Name = "СовмещениеПрофессийДолжностей", Comment = "", Synonym = "Совмещение профессий (должностей)")]
        СовмещениеПрофессийДолжностей,
        [Description1C8(Name = "УвеличениеОбъемаРабот", Comment = "", Synonym = "Увеличение объема работ")]
        УвеличениеОбъемаРабот,
        [Description1C8(Name = "ИсполнениеОбязанностей", Comment = "", Synonym = "Исполнение обязанностей")]
        ИсполнениеОбязанностей
    }
}
