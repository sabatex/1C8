using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыПлатежейВСоциальныеФонды:V1C8COMObject
    {
        public ВидыПлатежейВСоциальныеФонды(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Взносы => GetProperty<EnumItemBase>();
        public EnumItemBase Пени => GetProperty<EnumItemBase>();
        public EnumItemBase Штрафы => GetProperty<EnumItemBase>();
    }
}
