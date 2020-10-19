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
    [Table("MetodyRaspredelenyiaRBP")]
    [Description1C8(Name = "МетодыРаспределенияРБП", Comment = "", Synonym = "Методы распределения расходов будущих периодов")]
    public class МетодыРаспределенияРБП:EnumItem
    {
        public static readonly МетодыРаспределенияРБП ПоДням = new МетодыРаспределенияРБП{Name= "ПоДням",Synonym="По количеству дней в месяце",Comment=""};
        public static readonly МетодыРаспределенияРБП ПоМесяцам = new МетодыРаспределенияРБП{Name= "ПоМесяцам",Synonym="Равными частями каждый месяц",Comment=""};
    }
}
