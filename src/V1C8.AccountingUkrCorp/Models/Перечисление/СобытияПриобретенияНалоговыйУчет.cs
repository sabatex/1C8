using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СобытияПриобретенияНалоговыйУчет", Comment = "(Регл)", Synonym = "События приобретения налоговый учет")]
    public enum СобытияПриобретенияНалоговыйУчет
    {
        [Description1C8(Name = "ОплатаПоставщику", Comment = "", Synonym = "Оплата поставщику")]
        ОплатаПоставщику,
        [Description1C8(Name = "ВозвратОплатыПоставщиком", Comment = "", Synonym = "Возврат оплаты поставщиком")]
        ВозвратОплатыПоставщиком,
        [Description1C8(Name = "ПоступлениеОтПоставщика", Comment = "", Synonym = "Поступление от поставщика")]
        ПоступлениеОтПоставщика,
        [Description1C8(Name = "ВозвратПоставщику", Comment = "", Synonym = "Возврат поставщику")]
        ВозвратПоставщику
    }
}
