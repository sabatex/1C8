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
    [Table("VaryantVyrazhenyiaVnutrennykhUsluh")]
    [Description1C8(Name = "ВариантВыраженияВнутреннихУслуг", Comment = "", Synonym = "Вариант выражения внутренних услуг")]
    public class ВариантВыраженияВнутреннихУслуг:EnumItem
    {
        public static readonly ВариантВыраженияВнутреннихУслуг ВПлановыхЦенах = new ВариантВыраженияВнутреннихУслуг{Name= "ВПлановыхЦенах",Synonym="В плановых ценах",Comment=""};
        public static readonly ВариантВыраженияВнутреннихУслуг ВКоличественныхПоказателях = new ВариантВыраженияВнутреннихУслуг{Name= "ВКоличественныхПоказателях",Synonym="В количественных показателях",Comment=""};
    }
}
