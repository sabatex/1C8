using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыВыгрузкиОбъектовОбмена:V1C8COMObject
    {
        public РежимыВыгрузкиОбъектовОбмена(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВыгружатьВсегда => GetProperty<EnumItemBase>("ВыгружатьВсегда");
        public EnumItemBase ВыгружатьПоУсловию => GetProperty<EnumItemBase>("ВыгружатьПоУсловию");
        public EnumItemBase ВыгружатьПриНеобходимости => GetProperty<EnumItemBase>("ВыгружатьПриНеобходимости");
        public EnumItemBase ВыгружатьВручную => GetProperty<EnumItemBase>("ВыгружатьВручную");
        public EnumItemBase НеВыгружать => GetProperty<EnumItemBase>("НеВыгружать");
    }
}
