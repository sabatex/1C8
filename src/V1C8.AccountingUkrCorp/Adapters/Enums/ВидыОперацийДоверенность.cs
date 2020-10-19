using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийДоверенность:V1C8COMObject
    {
        public ВидыОперацийДоверенность(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Доверенность => GetProperty<EnumItemBase>();
        public EnumItemBase ДоверенностьСтрогогоУчета => GetProperty<EnumItemBase>();
    }
}
