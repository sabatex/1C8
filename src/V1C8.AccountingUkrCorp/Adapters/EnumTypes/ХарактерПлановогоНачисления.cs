using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ХарактерПлановогоНачисления:EnumBase
    {
        public ХарактерПлановогоНачисления(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Штатное => GetProperty<EnumItem>("Штатное");
        public EnumItem Индивидуальное => GetProperty<EnumItem>("Индивидуальное");
    }
}
