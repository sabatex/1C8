using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПередачаТоваров:EnumBase
    {
        public ВидыОперацийПередачаТоваров(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВПереработку => GetProperty<EnumItem>("ВПереработку");
        public EnumItem ИзПереработки => GetProperty<EnumItem>("ИзПереработки");
    }
}
