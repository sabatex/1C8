using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ДополнительныеЗначенияДоступа:V1C8COMObject
    {
        public ДополнительныеЗначенияДоступа(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДоступРазрешен => GetProperty<EnumItemBase>("ДоступРазрешен");
        public EnumItemBase ДоступЗапрещен => GetProperty<EnumItemBase>("ДоступЗапрещен");
        public EnumItemBase Истина => GetProperty<EnumItemBase>("Истина");
        public EnumItemBase Ложь => GetProperty<EnumItemBase>("Ложь");
        public EnumItemBase ПустаяСсылкаЛюбогоТипа => GetProperty<EnumItemBase>("ПустаяСсылкаЛюбогоТипа");
        public EnumItemBase Неопределено => GetProperty<EnumItemBase>("Неопределено");
        public EnumItemBase Null => GetProperty<EnumItemBase>("Null");
        public EnumItemBase ТипРазрешенный => GetProperty<EnumItemBase>("ТипРазрешенный");
        public EnumItemBase ТипЗапрещенный => GetProperty<EnumItemBase>("ТипЗапрещенный");
    }
}
