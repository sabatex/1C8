using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УдалитьВидыВзаиморасчетовСРаботниками", Comment = "", Synonym = "(не используется) Виды взаиморасчетов с работниками")]
    public class УдалитьВидыВзаиморасчетовСРаботниками:EnumItem
    {
        public static readonly УдалитьВидыВзаиморасчетовСРаботниками ЗаработнаяПлата = new УдалитьВидыВзаиморасчетовСРаботниками{Name= "ЗаработнаяПлата",Synonim="Заработная плата (ФОТ)",Comment="На основании отношений трудового найма"};
        public static readonly УдалитьВидыВзаиморасчетовСРаботниками ЗаработнаяПлатаНеФОТ = new УдалитьВидыВзаиморасчетовСРаботниками{Name= "ЗаработнаяПлатаНеФОТ",Synonim="Заработная плата (не ФОТ)",Comment="(не ФОТ) На основании отношений трудового найма"};
        public static readonly УдалитьВидыВзаиморасчетовСРаботниками Дивиденды = new УдалитьВидыВзаиморасчетовСРаботниками{Name= "Дивиденды",Synonim="Дивиденды",Comment=""};
        public static readonly УдалитьВидыВзаиморасчетовСРаботниками ДепонированнаяЗарплата = new УдалитьВидыВзаиморасчетовСРаботниками{Name= "ДепонированнаяЗарплата",Synonim="Депонированная зарплата",Comment=""};
    }
}
