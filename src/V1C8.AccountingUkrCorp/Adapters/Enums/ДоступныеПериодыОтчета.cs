using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ДоступныеПериодыОтчета:V1C8COMObject
    {
        public ДоступныеПериодыОтчета(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase День => GetProperty<EnumItemBase>();
        public EnumItemBase Неделя => GetProperty<EnumItemBase>();
        public EnumItemBase Декада => GetProperty<EnumItemBase>();
        public EnumItemBase Месяц => GetProperty<EnumItemBase>();
        public EnumItemBase Квартал => GetProperty<EnumItemBase>();
        public EnumItemBase Полугодие => GetProperty<EnumItemBase>();
        public EnumItemBase Год => GetProperty<EnumItemBase>();
        public EnumItemBase ПроизвольныйПериод => GetProperty<EnumItemBase>();
    }
}
