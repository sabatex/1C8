using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВариантВыраженияВнутреннихУслуг", Comment = "", Synonym = "Вариант выражения внутренних услуг")]
    public class ВариантВыраженияВнутреннихУслуг:EnumItem
    {
        public static readonly ВариантВыраженияВнутреннихУслуг ВПлановыхЦенах = new ВариантВыраженияВнутреннихУслуг{Name= "ВПлановыхЦенах",Synonim="В плановых ценах",Comment=""};
        public static readonly ВариантВыраженияВнутреннихУслуг ВКоличественныхПоказателях = new ВариантВыраженияВнутреннихУслуг{Name= "ВКоличественныхПоказателях",Synonim="В количественных показателях",Comment=""};
    }
}
