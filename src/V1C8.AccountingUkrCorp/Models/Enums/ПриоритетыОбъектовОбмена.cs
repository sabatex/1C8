using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("PryorytetyObektovObmena")]
    [Description1C8(Name = "ПриоритетыОбъектовОбмена", Comment = "", Synonym = "Приоритеты объектов обмена")]
    public class ПриоритетыОбъектовОбмена:EnumItem
    {
        public static readonly ПриоритетыОбъектовОбмена ПриоритетОбъектаОбменаНиже = new ПриоритетыОбъектовОбмена{Name= "ПриоритетОбъектаОбменаНиже",Synonym="Приоритет объекта обмена ниже",Comment=""};
        public static readonly ПриоритетыОбъектовОбмена ПриоритетОбъектаОбменаСовпадает = new ПриоритетыОбъектовОбмена{Name= "ПриоритетОбъектаОбменаСовпадает",Synonym="Приоритет объекта обмена совпадает",Comment=""};
        public static readonly ПриоритетыОбъектовОбмена ПриоритетОбъектаОбменаВыше = new ПриоритетыОбъектовОбмена{Name= "ПриоритетОбъектаОбменаВыше",Synonym="Приоритет объекта обмена выше",Comment=""};
    }
}
