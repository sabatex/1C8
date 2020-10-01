using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РазделыУчета", Comment = "", Synonym = "Разделы учета")]
    public enum РазделыУчета
    {
        [Description1C8(Name = "ОценкаМПЗ", Comment = "", Synonym = "Оценка МПЗ при выбытии")]
        ОценкаМПЗ,
        [Description1C8(Name = "РасчетыСКонтрагентами", Comment = "", Synonym = "Расчеты с контрагентами")]
        РасчетыСКонтрагентами
    }
}
