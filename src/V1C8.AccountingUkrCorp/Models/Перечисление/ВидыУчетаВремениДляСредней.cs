using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыУчетаВремениДляСредней", Comment = "", Synonym = "Виды учета времени для средней")]
    public enum ВидыУчетаВремениДляСредней
    {
        [Description1C8(Name = "ПоРабочимДням", Comment = "", Synonym = "По рабочим дням")]
        ПоРабочимДням,
        [Description1C8(Name = "ПоРабочимЧасам", Comment = "", Synonym = "По рабочим часам")]
        ПоРабочимЧасам
    }
}
