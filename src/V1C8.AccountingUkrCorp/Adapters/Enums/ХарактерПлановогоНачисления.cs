using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ХарактерПлановогоНачисления:V1C8COMObject
    {
        public ХарактерПлановогоНачисления(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Штатное => GetProperty<EnumItemBase>();
        public EnumItemBase Индивидуальное => GetProperty<EnumItemBase>();
    }
}
