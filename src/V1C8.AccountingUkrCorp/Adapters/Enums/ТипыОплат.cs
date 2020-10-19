using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыОплат:V1C8COMObject
    {
        public ТипыОплат(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Наличные => GetProperty<EnumItemBase>();
        public EnumItemBase ПлатежнаяКарта => GetProperty<EnumItemBase>();
        public EnumItemBase БанковскийКредит => GetProperty<EnumItemBase>();
    }
}
