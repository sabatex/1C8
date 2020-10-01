using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ГруппыНачисленияУдержанияВыплаты", Comment = "", Synonym = "Группы начисления удержания выплаты")]
    public enum ГруппыНачисленияУдержанияВыплаты
    {
        [Description1C8(Name = "НачальноеСальдоПериода", Comment = "", Synonym = "Входящее сальдо периода")]
        НачальноеСальдоПериода,
        [Description1C8(Name = "НачальноеСальдо", Comment = "", Synonym = "Входящее сальдо месяца")]
        НачальноеСальдо,
        [Description1C8(Name = "Начислено", Comment = "", Synonym = "Начислено")]
        Начислено,
        [Description1C8(Name = "Удержано", Comment = "", Synonym = "Удержано")]
        Удержано,
        [Description1C8(Name = "Выплачено", Comment = "", Synonym = "Выплачено")]
        Выплачено,
        [Description1C8(Name = "КонечноеСальдо", Comment = "", Synonym = "Сальдо по итогам расчетов за месяц")]
        КонечноеСальдо,
        [Description1C8(Name = "КонечноеСальдоПериода", Comment = "", Synonym = "Сальдо по итогам расчетов за период")]
        КонечноеСальдоПериода,
        [Description1C8(Name = "Справочно", Comment = "", Synonym = "Справочно")]
        Справочно,
        [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
        Льготы
    }
}
