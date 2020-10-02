using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПриоритетыОбъектовОбмена", Comment = "", Synonym = "Приоритеты объектов обмена")]
    public class ПриоритетыОбъектовОбмена:EnumItem
    {
        public static readonly ПриоритетыОбъектовОбмена ПриоритетОбъектаОбменаНиже = new ПриоритетыОбъектовОбмена{Name= "ПриоритетОбъектаОбменаНиже",Synonim="Приоритет объекта обмена ниже",Comment=""};
        public static readonly ПриоритетыОбъектовОбмена ПриоритетОбъектаОбменаСовпадает = new ПриоритетыОбъектовОбмена{Name= "ПриоритетОбъектаОбменаСовпадает",Synonim="Приоритет объекта обмена совпадает",Comment=""};
        public static readonly ПриоритетыОбъектовОбмена ПриоритетОбъектаОбменаВыше = new ПриоритетыОбъектовОбмена{Name= "ПриоритетОбъектаОбменаВыше",Synonim="Приоритет объекта обмена выше",Comment=""};
    }
}
