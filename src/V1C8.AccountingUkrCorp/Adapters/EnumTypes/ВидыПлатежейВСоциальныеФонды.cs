using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПлатежейВСоциальныеФонды:V1C8COMObject
    {
        public ВидыПлатежейВСоциальныеФонды(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Взносы => GetProperty<EnumItemBase>("Взносы");
        public EnumItemBase Пени => GetProperty<EnumItemBase>("Пени");
        public EnumItemBase Штрафы => GetProperty<EnumItemBase>("Штрафы");
    }
}
