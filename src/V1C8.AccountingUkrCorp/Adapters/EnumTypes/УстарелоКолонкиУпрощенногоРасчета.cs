using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УстарелоКолонкиУпрощенногоРасчета:EnumBase
    {
        public УстарелоКолонкиУпрощенногоРасчета(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Оклад => GetProperty<EnumItem>("Оклад");
        public EnumItem Отпускные => GetProperty<EnumItem>("Отпускные");
        public EnumItem БольничныеПредприятие => GetProperty<EnumItem>("БольничныеПредприятие");
        public EnumItem БольничныеФСС => GetProperty<EnumItem>("БольничныеФСС");
        public EnumItem Индексация => GetProperty<EnumItem>("Индексация");
        public EnumItem Доплата1 => GetProperty<EnumItem>("Доплата1");
        public EnumItem Доплата2 => GetProperty<EnumItem>("Доплата2");
        public EnumItem Доплата3 => GetProperty<EnumItem>("Доплата3");
        public EnumItem Доплата4 => GetProperty<EnumItem>("Доплата4");
        public EnumItem Доплата5 => GetProperty<EnumItem>("Доплата5");
        public EnumItem Доплата6 => GetProperty<EnumItem>("Доплата6");
    }
}
