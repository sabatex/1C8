using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыПлатежейВСоциальныеФонды:EnumBase
    {
        public ВидыПлатежейВСоциальныеФонды(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Взносы => GetProperty<EnumItem>("Взносы");
        public EnumItem Пени => GetProperty<EnumItem>("Пени");
        public EnumItem Штрафы => GetProperty<EnumItem>("Штрафы");
    }
}
