using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыУлучшения:EnumBase
    {
        public ВидыУлучшения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Модернизация => GetProperty<EnumItem>("Модернизация");
        public EnumItem Ремонт => GetProperty<EnumItem>("Ремонт");
    }
}
