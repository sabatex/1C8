using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийДоверенность:V1C8COMObject
    {
        public ВидыОперацийДоверенность(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Доверенность => GetProperty<EnumItemBase>("Доверенность");
        public EnumItemBase ДоверенностьСтрогогоУчета => GetProperty<EnumItemBase>("ДоверенностьСтрогогоУчета");
    }
}
