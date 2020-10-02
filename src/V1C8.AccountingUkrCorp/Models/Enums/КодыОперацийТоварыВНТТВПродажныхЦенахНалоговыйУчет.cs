using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет", Comment = "", Synonym = "Коды операций регистра 'Товары в НТТ в продажных ценах (налоговый учет)'")]
    public class КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет:EnumItem
    {
        public static readonly КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет Поступление = new КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет{Name= "Поступление",Synonim="Поступление",Comment=""};
        public static readonly КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет Возврат = new КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет{Name= "Возврат",Synonim="Возврат",Comment=""};
        public static readonly КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет Реализация = new КодыОперацийТоварыВНТТВПродажныхЦенахНалоговыйУчет{Name= "Реализация",Synonim="Реализация",Comment=""};
    }
}
