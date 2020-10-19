using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядкиОкругленияОтчетности:EnumBase
    {
        public ПорядкиОкругленияОтчетности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Окр1 => GetProperty<EnumItem>("Окр1");
        public EnumItem Окр1000 => GetProperty<EnumItem>("Окр1000");
        public EnumItem Окр1000000 => GetProperty<EnumItem>("Окр1000000");
    }
}
