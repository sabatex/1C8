using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПередачаТоваров:V1C8COMObject
    {
        public ВидыОперацийПередачаТоваров(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВПереработку => GetProperty<EnumItemBase>("ВПереработку");
        public EnumItemBase ИзПереработки => GetProperty<EnumItemBase>("ИзПереработки");
    }
}
