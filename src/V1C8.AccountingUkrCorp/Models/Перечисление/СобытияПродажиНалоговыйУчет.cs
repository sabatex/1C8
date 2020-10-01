using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СобытияПродажиНалоговыйУчет", Comment = "(Регл)", Synonym = "События продажи налоговый учет")]
    public enum СобытияПродажиНалоговыйУчет
    {
        [Description1C8(Name = "ОплатаПокупателем", Comment = "", Synonym = "Оплата покупателем")]
        ОплатаПокупателем,
        [Description1C8(Name = "ВозвратОплатыПокупателю", Comment = "", Synonym = "Возврат оплаты покупателю")]
        ВозвратОплатыПокупателю,
        [Description1C8(Name = "РеализацияПокупателю", Comment = "", Synonym = "Реализация покупателю")]
        РеализацияПокупателю,
        [Description1C8(Name = "ВозвратОтПокупателя", Comment = "", Synonym = "Возврат от покупателя")]
        ВозвратОтПокупателя
    }
}
