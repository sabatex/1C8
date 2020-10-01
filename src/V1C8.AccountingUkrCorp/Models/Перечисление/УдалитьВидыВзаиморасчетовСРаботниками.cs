using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьВидыВзаиморасчетовСРаботниками", Comment = "", Synonym = "(не используется) Виды взаиморасчетов с работниками")]
    public enum УдалитьВидыВзаиморасчетовСРаботниками
    {
        [Description1C8(Name = "ЗаработнаяПлата", Comment = "На основании отношений трудового найма", Synonym = "Заработная плата (ФОТ)")]
        ЗаработнаяПлата,
        [Description1C8(Name = "ЗаработнаяПлатаНеФОТ", Comment = "(не ФОТ) На основании отношений трудового найма", Synonym = "Заработная плата (не ФОТ)")]
        ЗаработнаяПлатаНеФОТ,
        [Description1C8(Name = "Дивиденды", Comment = "", Synonym = "Дивиденды")]
        Дивиденды,
        [Description1C8(Name = "ДепонированнаяЗарплата", Comment = "", Synonym = "Депонированная зарплата")]
        ДепонированнаяЗарплата
    }
}
