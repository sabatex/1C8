using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийПередачаТоваров:V1C8COMObject
    {
        public ВидыОперацийПередачаТоваров(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВПереработку => GetProperty<EnumItemBase>();
        public EnumItemBase ИзПереработки => GetProperty<EnumItemBase>();
    }
}
