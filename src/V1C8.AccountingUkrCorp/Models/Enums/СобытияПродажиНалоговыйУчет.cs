using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СобытияПродажиНалоговыйУчет", Comment = "(Регл)", Synonym = "События продажи налоговый учет")]
    public class СобытияПродажиНалоговыйУчет:EnumItem
    {
        public static readonly СобытияПродажиНалоговыйУчет ОплатаПокупателем = new СобытияПродажиНалоговыйУчет{Name= "ОплатаПокупателем",Synonym="Оплата покупателем",Comment=""};
        public static readonly СобытияПродажиНалоговыйУчет ВозвратОплатыПокупателю = new СобытияПродажиНалоговыйУчет{Name= "ВозвратОплатыПокупателю",Synonym="Возврат оплаты покупателю",Comment=""};
        public static readonly СобытияПродажиНалоговыйУчет РеализацияПокупателю = new СобытияПродажиНалоговыйУчет{Name= "РеализацияПокупателю",Synonym="Реализация покупателю",Comment=""};
        public static readonly СобытияПродажиНалоговыйУчет ВозвратОтПокупателя = new СобытияПродажиНалоговыйУчет{Name= "ВозвратОтПокупателя",Synonym="Возврат от покупателя",Comment=""};
    }
}
