using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ХарактерПлановогоНачисления:V1C8COMObject
    {
        public ХарактерПлановогоНачисления(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Штатное => GetProperty<EnumItemBase>("Штатное");
        public EnumItemBase Индивидуальное => GetProperty<EnumItemBase>("Индивидуальное");
    }
}
