using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыТрудовогоСтажа:V1C8COMObject
    {
        public ВидыТрудовогоСтажа(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбщийТрудовойСтаж => GetProperty<EnumItemBase>();
        public EnumItemBase ТерриториальныеУсловия => GetProperty<EnumItemBase>();
        public EnumItemBase ОсобыеУсловияТруда => GetProperty<EnumItemBase>();
        public EnumItemBase ВыслугаЛет => GetProperty<EnumItemBase>();
    }
}
