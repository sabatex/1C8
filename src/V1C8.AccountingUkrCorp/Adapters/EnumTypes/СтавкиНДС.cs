using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтавкиНДС:EnumBase
    {
        public СтавкиНДС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem НДС20 => GetProperty<EnumItem>("НДС20");
        public EnumItem НДС7 => GetProperty<EnumItem>("НДС7");
        public EnumItem НДС0 => GetProperty<EnumItem>("НДС0");
        public EnumItem БезНДС => GetProperty<EnumItem>("БезНДС");
        public EnumItem НеНДС => GetProperty<EnumItem>("НеНДС");
    }
}
