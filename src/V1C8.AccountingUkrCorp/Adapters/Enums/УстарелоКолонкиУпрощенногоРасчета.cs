using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class УстарелоКолонкиУпрощенногоРасчета:V1C8COMObject
    {
        public УстарелоКолонкиУпрощенногоРасчета(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Оклад => GetProperty<EnumItemBase>();
        public EnumItemBase Отпускные => GetProperty<EnumItemBase>();
        public EnumItemBase БольничныеПредприятие => GetProperty<EnumItemBase>();
        public EnumItemBase БольничныеФСС => GetProperty<EnumItemBase>();
        public EnumItemBase Индексация => GetProperty<EnumItemBase>();
        public EnumItemBase Доплата1 => GetProperty<EnumItemBase>();
        public EnumItemBase Доплата2 => GetProperty<EnumItemBase>();
        public EnumItemBase Доплата3 => GetProperty<EnumItemBase>();
        public EnumItemBase Доплата4 => GetProperty<EnumItemBase>();
        public EnumItemBase Доплата5 => GetProperty<EnumItemBase>();
        public EnumItemBase Доплата6 => GetProperty<EnumItemBase>();
    }
}
