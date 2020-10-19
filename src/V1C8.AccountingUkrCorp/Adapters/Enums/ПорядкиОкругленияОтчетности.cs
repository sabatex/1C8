using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПорядкиОкругленияОтчетности:V1C8COMObject
    {
        public ПорядкиОкругленияОтчетности(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Окр1 => GetProperty<EnumItemBase>();
        public EnumItemBase Окр1000 => GetProperty<EnumItemBase>();
        public EnumItemBase Окр1000000 => GetProperty<EnumItemBase>();
    }
}
