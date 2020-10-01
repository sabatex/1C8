using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КодыОперацийНДСНалоговыйКредит", Comment = "", Synonym = "Коды операций НДС налоговый кредит")]
    public enum КодыОперацийНДСНалоговыйКредит
    {
        [Description1C8(Name = "ПервичныйДокумент", Comment = "", Synonym = "Первичный документ")]
        ПервичныйДокумент,
        [Description1C8(Name = "КорректировкиПоИспользованию", Comment = "", Synonym = "Корректировки по использованию")]
        КорректировкиПоИспользованию,
        [Description1C8(Name = "КорректировкиНеправильноЗарегистрированныхДокументов", Comment = "", Synonym = "Корректировки неправильно зарегистрированных документов")]
        КорректировкиНеправильноЗарегистрированныхДокументов
    }
}
