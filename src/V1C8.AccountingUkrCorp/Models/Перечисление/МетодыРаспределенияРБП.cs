using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "МетодыРаспределенияРБП", Comment = "", Synonym = "Методы распределения расходов будущих периодов")]
    public enum МетодыРаспределенияРБП
    {
        [Description1C8(Name = "ПоДням", Comment = "", Synonym = "По количеству дней в месяце")]
        ПоДням,
        [Description1C8(Name = "ПоМесяцам", Comment = "", Synonym = "Равными частями каждый месяц")]
        ПоМесяцам
    }
}
