using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОплатыТруда", Comment = "ФОТ неФОТ", Synonym = "Виды оплаты труда")]
    public enum ВидыОплатыТруда
    {
        [Description1C8(Name = "ФОТ", Comment = "661", Synonym = "ФОТ")]
        ФОТ,
        [Description1C8(Name = "НеФОТ", Comment = "663", Synonym = "Не ФОТ")]
        НеФОТ
    }
}
