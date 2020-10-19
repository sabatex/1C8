using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыТрудовогоСтажа:V1C8COMObject
    {
        public ВидыТрудовогоСтажа(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбщийТрудовойСтаж => GetProperty<EnumItemBase>("ОбщийТрудовойСтаж");
        public EnumItemBase ТерриториальныеУсловия => GetProperty<EnumItemBase>("ТерриториальныеУсловия");
        public EnumItemBase ОсобыеУсловияТруда => GetProperty<EnumItemBase>("ОсобыеУсловияТруда");
        public EnumItemBase ВыслугаЛет => GetProperty<EnumItemBase>("ВыслугаЛет");
    }
}
