using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ДополнительныеЗначенияДоступа:EnumBase
    {
        public ДополнительныеЗначенияДоступа(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ДоступРазрешен => GetProperty<EnumItem>("ДоступРазрешен");
        public EnumItem ДоступЗапрещен => GetProperty<EnumItem>("ДоступЗапрещен");
        public EnumItem Истина => GetProperty<EnumItem>("Истина");
        public EnumItem Ложь => GetProperty<EnumItem>("Ложь");
        public EnumItem ПустаяСсылкаЛюбогоТипа => GetProperty<EnumItem>("ПустаяСсылкаЛюбогоТипа");
        public EnumItem Неопределено => GetProperty<EnumItem>("Неопределено");
        public EnumItem Null => GetProperty<EnumItem>("Null");
        public EnumItem ТипРазрешенный => GetProperty<EnumItem>("ТипРазрешенный");
        public EnumItem ТипЗапрещенный => GetProperty<EnumItem>("ТипЗапрещенный");
    }
}
