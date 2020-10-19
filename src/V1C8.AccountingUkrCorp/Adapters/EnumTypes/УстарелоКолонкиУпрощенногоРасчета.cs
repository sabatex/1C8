using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УстарелоКолонкиУпрощенногоРасчета:V1C8COMObject
    {
        public УстарелоКолонкиУпрощенногоРасчета(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Оклад => GetProperty<EnumItemBase>("Оклад");
        public EnumItemBase Отпускные => GetProperty<EnumItemBase>("Отпускные");
        public EnumItemBase БольничныеПредприятие => GetProperty<EnumItemBase>("БольничныеПредприятие");
        public EnumItemBase БольничныеФСС => GetProperty<EnumItemBase>("БольничныеФСС");
        public EnumItemBase Индексация => GetProperty<EnumItemBase>("Индексация");
        public EnumItemBase Доплата1 => GetProperty<EnumItemBase>("Доплата1");
        public EnumItemBase Доплата2 => GetProperty<EnumItemBase>("Доплата2");
        public EnumItemBase Доплата3 => GetProperty<EnumItemBase>("Доплата3");
        public EnumItemBase Доплата4 => GetProperty<EnumItemBase>("Доплата4");
        public EnumItemBase Доплата5 => GetProperty<EnumItemBase>("Доплата5");
        public EnumItemBase Доплата6 => GetProperty<EnumItemBase>("Доплата6");
    }
}
