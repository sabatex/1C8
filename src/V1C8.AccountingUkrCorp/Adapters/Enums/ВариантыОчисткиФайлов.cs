using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВариантыОчисткиФайлов:V1C8COMObject
    {
        public ВариантыОчисткиФайлов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОчиститьФайлыИВерсии => GetProperty<EnumItemBase>();
        public EnumItemBase ОчиститьФайлы => GetProperty<EnumItemBase>();
        public EnumItemBase ОчиститьВерсии => GetProperty<EnumItemBase>();
        public EnumItemBase НеОчищать => GetProperty<EnumItemBase>();
    }
}
