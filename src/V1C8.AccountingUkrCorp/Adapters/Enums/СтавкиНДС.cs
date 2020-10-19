using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СтавкиНДС:V1C8COMObject
    {
        public СтавкиНДС(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase НДС20 => GetProperty<EnumItemBase>();
        public EnumItemBase НДС7 => GetProperty<EnumItemBase>();
        public EnumItemBase НДС0 => GetProperty<EnumItemBase>();
        public EnumItemBase БезНДС => GetProperty<EnumItemBase>();
        public EnumItemBase НеНДС => GetProperty<EnumItemBase>();
    }
}
