using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядкиОкругленияОтчетности:V1C8COMObject
    {
        public ПорядкиОкругленияОтчетности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Окр1 => GetProperty<EnumItemBase>("Окр1");
        public EnumItemBase Окр1000 => GetProperty<EnumItemBase>("Окр1000");
        public EnumItemBase Окр1000000 => GetProperty<EnumItemBase>("Окр1000000");
    }
}
