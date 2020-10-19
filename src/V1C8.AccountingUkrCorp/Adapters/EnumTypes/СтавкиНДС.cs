using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СтавкиНДС:V1C8COMObject
    {
        public СтавкиНДС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НДС20 => GetProperty<EnumItemBase>("НДС20");
        public EnumItemBase НДС7 => GetProperty<EnumItemBase>("НДС7");
        public EnumItemBase НДС0 => GetProperty<EnumItemBase>("НДС0");
        public EnumItemBase БезНДС => GetProperty<EnumItemBase>("БезНДС");
        public EnumItemBase НеНДС => GetProperty<EnumItemBase>("НеНДС");
    }
}
