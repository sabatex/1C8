using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПределовДоходовНДФЛ:EnumBase
    {
        public ВидыПределовДоходовНДФЛ(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Годовой => GetProperty<EnumItem>("Годовой");
        public EnumItem Разовый => GetProperty<EnumItem>("Разовый");
    }
}
