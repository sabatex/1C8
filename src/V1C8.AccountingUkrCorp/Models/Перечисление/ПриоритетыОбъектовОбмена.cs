using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПриоритетыОбъектовОбмена", Comment = "", Synonym = "Приоритеты объектов обмена")]
    public enum ПриоритетыОбъектовОбмена
    {
        [Description1C8(Name = "ПриоритетОбъектаОбменаНиже", Comment = "", Synonym = "Приоритет объекта обмена ниже")]
        ПриоритетОбъектаОбменаНиже,
        [Description1C8(Name = "ПриоритетОбъектаОбменаСовпадает", Comment = "", Synonym = "Приоритет объекта обмена совпадает")]
        ПриоритетОбъектаОбменаСовпадает,
        [Description1C8(Name = "ПриоритетОбъектаОбменаВыше", Comment = "", Synonym = "Приоритет объекта обмена выше")]
        ПриоритетОбъектаОбменаВыше
    }
}
