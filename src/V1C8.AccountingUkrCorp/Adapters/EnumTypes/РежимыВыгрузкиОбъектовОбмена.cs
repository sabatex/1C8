using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыВыгрузкиОбъектовОбмена:EnumBase
    {
        public РежимыВыгрузкиОбъектовОбмена(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВыгружатьВсегда => GetProperty<EnumItem>("ВыгружатьВсегда");
        public EnumItem ВыгружатьПоУсловию => GetProperty<EnumItem>("ВыгружатьПоУсловию");
        public EnumItem ВыгружатьПриНеобходимости => GetProperty<EnumItem>("ВыгружатьПриНеобходимости");
        public EnumItem ВыгружатьВручную => GetProperty<EnumItem>("ВыгружатьВручную");
        public EnumItem НеВыгружать => GetProperty<EnumItem>("НеВыгружать");
    }
}
