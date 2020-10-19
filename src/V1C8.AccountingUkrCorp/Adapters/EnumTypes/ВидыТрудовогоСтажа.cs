using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыТрудовогоСтажа:EnumBase
    {
        public ВидыТрудовогоСтажа(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОбщийТрудовойСтаж => GetProperty<EnumItem>("ОбщийТрудовойСтаж");
        public EnumItem ТерриториальныеУсловия => GetProperty<EnumItem>("ТерриториальныеУсловия");
        public EnumItem ОсобыеУсловияТруда => GetProperty<EnumItem>("ОсобыеУсловияТруда");
        public EnumItem ВыслугаЛет => GetProperty<EnumItem>("ВыслугаЛет");
    }
}
