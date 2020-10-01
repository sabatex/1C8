using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыСправокОДоходах", Comment = "", Synonym = "Виды справок о доходах")]
    public enum ВидыСправокОДоходах
    {
        [Description1C8(Name = "Произвольная", Comment = "", Synonym = "Справка в свободной форме")]
        Произвольная,
        [Description1C8(Name = "Соцстрах2015", Comment = "", Synonym = "Для выплат по соц. страхованию")]
        Соцстрах2015,
        [Description1C8(Name = "Субсидия2015", Comment = "", Synonym = "Для оформления субсидии")]
        Субсидия2015,
        [Description1C8(Name = "Пенсия2015", Comment = "", Synonym = "Для расчета пенсии")]
        Пенсия2015,
        [Description1C8(Name = "ДоходыИНалоги", Comment = "", Synonym = "Доходы и налоги")]
        ДоходыИНалоги,
        [Description1C8(Name = "Соцстрах", Comment = "", Synonym = "(устарело) Для назначения помощи по нетрудоспособности")]
        Соцстрах,
        [Description1C8(Name = "Безработица", Comment = "", Synonym = "(устарело) Для расчета выплат по безработице")]
        Безработица,
        [Description1C8(Name = "Пенсия", Comment = "", Synonym = "(устарело) Для расчета пенсии")]
        Пенсия,
        [Description1C8(Name = "Субсидия", Comment = "", Synonym = "(устарело) Для оформления субсидии")]
        Субсидия
    }
}
