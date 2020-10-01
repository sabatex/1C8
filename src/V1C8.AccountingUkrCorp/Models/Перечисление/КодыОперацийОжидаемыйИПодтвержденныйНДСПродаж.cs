using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж", Comment = "", Synonym = "Коды операций регистра Ожидаемый и подтвержденный НДС продаж")]
    public enum КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж
    {
        [Description1C8(Name = "ОжидаемыйНДС", Comment = "", Synonym = "Ожидаемый НДС")]
        ОжидаемыйНДС,
        [Description1C8(Name = "ПодтвержденныйНДС", Comment = "", Synonym = "Подтвержденный НДС")]
        ПодтвержденныйНДС,
        [Description1C8(Name = "КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат", Comment = "", Synonym = "Корректировка ожидаемого НДС по видам деятельности оплат")]
        КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат,
        [Description1C8(Name = "РегистрацияАвансов", Comment = "", Synonym = "Регистрация авансов")]
        РегистрацияАвансов,
        [Description1C8(Name = "ОтменаРегистрацииАвансов", Comment = "", Synonym = "Отмена регистрации авансов")]
        ОтменаРегистрацииАвансов,
        [Description1C8(Name = "КорректировкаНеправильноОформленныхНалоговыхДокументов", Comment = "", Synonym = "Корректировка неправильно оформленных налоговых документов")]
        КорректировкаНеправильноОформленныхНалоговыхДокументов,
        [Description1C8(Name = "ПереводОФвСоставНепроизводственных", Comment = "", Synonym = "Перевод основных фондов в состав непроизводственных")]
        ПереводОФвСоставНепроизводственных
    }
}
