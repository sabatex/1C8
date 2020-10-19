using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ДополнительныеЗначенияДоступа:V1C8COMObject
    {
        public ДополнительныеЗначенияДоступа(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДоступРазрешен => GetProperty<EnumItemBase>();
        public EnumItemBase ДоступЗапрещен => GetProperty<EnumItemBase>();
        public EnumItemBase Истина => GetProperty<EnumItemBase>();
        public EnumItemBase Ложь => GetProperty<EnumItemBase>();
        public EnumItemBase ПустаяСсылкаЛюбогоТипа => GetProperty<EnumItemBase>();
        public EnumItemBase Неопределено => GetProperty<EnumItemBase>();
        public EnumItemBase Null => GetProperty<EnumItemBase>();
        public EnumItemBase ТипРазрешенный => GetProperty<EnumItemBase>();
        public EnumItemBase ТипЗапрещенный => GetProperty<EnumItemBase>();
    }
}
