using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыОплат:V1C8COMObject
    {
        public ТипыОплат(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Наличные => GetProperty<EnumItemBase>("Наличные");
        public EnumItemBase ПлатежнаяКарта => GetProperty<EnumItemBase>("ПлатежнаяКарта");
        public EnumItemBase БанковскийКредит => GetProperty<EnumItemBase>("БанковскийКредит");
    }
}
