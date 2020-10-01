using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыКонтрагентовВМонитореРуководителя", Comment = "", Synonym = "Виды контрагентов в мониторе руководителя")]
    public enum ВидыКонтрагентовВМонитореРуководителя
    {
        [Description1C8(Name = "Покупатели", Comment = "", Synonym = "Покупатели")]
        Покупатели,
        [Description1C8(Name = "Поставщики", Comment = "", Synonym = "Поставщики")]
        Поставщики
    }
}
