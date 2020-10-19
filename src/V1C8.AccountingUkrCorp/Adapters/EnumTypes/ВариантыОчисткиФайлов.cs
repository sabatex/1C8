using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыОчисткиФайлов:EnumBase
    {
        public ВариантыОчисткиФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОчиститьФайлыИВерсии => GetProperty<EnumItem>("ОчиститьФайлыИВерсии");
        public EnumItem ОчиститьФайлы => GetProperty<EnumItem>("ОчиститьФайлы");
        public EnumItem ОчиститьВерсии => GetProperty<EnumItem>("ОчиститьВерсии");
        public EnumItem НеОчищать => GetProperty<EnumItem>("НеОчищать");
    }
}
