using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыОплат:EnumBase
    {
        public ТипыОплат(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Наличные => GetProperty<EnumItem>("Наличные");
        public EnumItem ПлатежнаяКарта => GetProperty<EnumItem>("ПлатежнаяКарта");
        public EnumItem БанковскийКредит => GetProperty<EnumItem>("БанковскийКредит");
    }
}
