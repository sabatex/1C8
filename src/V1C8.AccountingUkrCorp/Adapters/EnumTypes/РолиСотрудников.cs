using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РолиСотрудников:EnumBase
    {
        public РолиСотрудников(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Работник => GetProperty<EnumItem>("Работник");
        public EnumItem Договорник => GetProperty<EnumItem>("Договорник");
    }
}
