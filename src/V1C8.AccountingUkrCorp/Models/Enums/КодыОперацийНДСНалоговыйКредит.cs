using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КодыОперацийНДСНалоговыйКредит", Comment = "", Synonym = "Коды операций НДС налоговый кредит")]
    public class КодыОперацийНДСНалоговыйКредит:EnumItem
    {
        public static readonly КодыОперацийНДСНалоговыйКредит ПервичныйДокумент = new КодыОперацийНДСНалоговыйКредит{Name= "ПервичныйДокумент",Synonym="Первичный документ",Comment=""};
        public static readonly КодыОперацийНДСНалоговыйКредит КорректировкиПоИспользованию = new КодыОперацийНДСНалоговыйКредит{Name= "КорректировкиПоИспользованию",Synonym="Корректировки по использованию",Comment=""};
        public static readonly КодыОперацийНДСНалоговыйКредит КорректировкиНеправильноЗарегистрированныхДокументов = new КодыОперацийНДСНалоговыйКредит{Name= "КорректировкиНеправильноЗарегистрированныхДокументов",Synonym="Корректировки неправильно зарегистрированных документов",Comment=""};
    }
}
