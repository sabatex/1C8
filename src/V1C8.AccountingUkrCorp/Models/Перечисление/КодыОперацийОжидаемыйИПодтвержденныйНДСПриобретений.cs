using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений", Comment = "", Synonym = "Коды операций регистра Ожидаемый и подтвержденный НДС приобретений")]
    public enum КодыОперацийОжидаемыйИПодтвержденныйНДСПриобретений
    {
        [Description1C8(Name = "ОжидаемыйНДС", Comment = "", Synonym = "Ожидаемый НДС")]
        ОжидаемыйНДС,
        [Description1C8(Name = "ПодтвержденныйНДС", Comment = "", Synonym = "Подтвержденный НДС")]
        ПодтвержденныйНДС,
        [Description1C8(Name = "КорректировкаПервичныйДокумент", Comment = "", Synonym = "Корректировка первичный документ")]
        КорректировкаПервичныйДокумент,
        [Description1C8(Name = "КорректировкаНалоговыйДокумент", Comment = "", Synonym = "Корректировка налоговый документ")]
        КорректировкаНалоговыйДокумент,
        [Description1C8(Name = "КорректировкаРегламентная", Comment = "", Synonym = "Корректировка регламентная")]
        КорректировкаРегламентная,
        [Description1C8(Name = "КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат", Comment = "", Synonym = "Корректировка ожидаемого НДС по видам деятельности оплат")]
        КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат,
        [Description1C8(Name = "РегистрацияАвансов", Comment = "", Synonym = "Регистрация авансов")]
        РегистрацияАвансов,
        [Description1C8(Name = "ОтменаРегистрацииАвансов", Comment = "", Synonym = "Отмена регистрации авансов")]
        ОтменаРегистрацииАвансов,
        [Description1C8(Name = "КорректировкаНеправильноОформленныхНалоговыхДокументов", Comment = "", Synonym = "Корректировка неправильно оформленных налоговых документов")]
        КорректировкаНеправильноОформленныхНалоговыхДокументов
    }
}
