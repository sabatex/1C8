using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантВыраженияВнутреннихУслуг", Comment = "", Synonym = "Вариант выражения внутренних услуг")]
    public enum ВариантВыраженияВнутреннихУслуг
    {
        [Description1C8(Name = "ВПлановыхЦенах", Comment = "", Synonym = "В плановых ценах")]
        ВПлановыхЦенах,
        [Description1C8(Name = "ВКоличественныхПоказателях", Comment = "", Synonym = "В количественных показателях")]
        ВКоличественныхПоказателях
    }
}
