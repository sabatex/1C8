using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыОчисткиФайлов:V1C8COMObject
    {
        public ВариантыОчисткиФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОчиститьФайлыИВерсии => GetProperty<EnumItemBase>("ОчиститьФайлыИВерсии");
        public EnumItemBase ОчиститьФайлы => GetProperty<EnumItemBase>("ОчиститьФайлы");
        public EnumItemBase ОчиститьВерсии => GetProperty<EnumItemBase>("ОчиститьВерсии");
        public EnumItemBase НеОчищать => GetProperty<EnumItemBase>("НеОчищать");
    }
}
