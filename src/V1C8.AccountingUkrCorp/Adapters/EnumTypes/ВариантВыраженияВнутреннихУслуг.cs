using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантВыраженияВнутреннихУслуг:V1C8COMObject
    {
        public ВариантВыраженияВнутреннихУслуг(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВПлановыхЦенах => GetProperty<EnumItemBase>("ВПлановыхЦенах");
        public EnumItemBase ВКоличественныхПоказателях => GetProperty<EnumItemBase>("ВКоличественныхПоказателях");
    }
}
