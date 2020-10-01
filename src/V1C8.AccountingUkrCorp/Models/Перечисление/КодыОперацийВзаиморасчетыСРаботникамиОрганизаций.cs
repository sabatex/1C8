using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КодыОперацийВзаиморасчетыСРаботникамиОрганизаций", Comment = "", Synonym = "Коды операций: Взаиморасчеты с работниками организации")]
    public enum КодыОперацийВзаиморасчетыСРаботникамиОрганизаций
    {
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        Начисления,
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        Взносы,
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        НДФЛ,
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        Удержания,
        [Description1C8(Name = "Выплата", Comment = "", Synonym = "Выплата")]
        Выплата,
        [Description1C8(Name = "ПереносКопеекНаСледующийМесяц", Comment = "", Synonym = "Перенос копеек на следующий месяц")]
        ПереносКопеекНаСледующийМесяц,
        [Description1C8(Name = "УдалитьВыплатаАванса", Comment = "", Synonym = "(Не используется) Выплата аванса")]
        УдалитьВыплатаАванса,
        [Description1C8(Name = "УдалитьВыплатаМежрасчетная", Comment = "", Synonym = "(Не используется) Выплата межрасчетная")]
        УдалитьВыплатаМежрасчетная,
        [Description1C8(Name = "УдалитьВыплатаОчередная", Comment = "", Synonym = "(Не используется) Выплата очередная")]
        УдалитьВыплатаОчередная,
        [Description1C8(Name = "УдалитьВыплатаДивидендов", Comment = "", Synonym = "(Не используется) Выплата дивидендов")]
        УдалитьВыплатаДивидендов,
        [Description1C8(Name = "УдалитьВыплатаДепонента", Comment = "", Synonym = "(Не используется) Выплата депонента")]
        УдалитьВыплатаДепонента,
        [Description1C8(Name = "УдалитьПогашениеНачисленийПоФактуВыплаты", Comment = "", Synonym = "(Не используется) Погашение начислений по факту выплаты")]
        УдалитьПогашениеНачисленийПоФактуВыплаты,
        [Description1C8(Name = "УдалитьВключениеКопеекПредыдущегоМесяца", Comment = "", Synonym = "(Не используется) Включение копеек предыдущего месяца")]
        УдалитьВключениеКопеекПредыдущегоМесяца
    }
}
