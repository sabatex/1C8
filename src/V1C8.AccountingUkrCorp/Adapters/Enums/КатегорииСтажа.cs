using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КатегорииСтажа:V1C8COMObject
    {
        public КатегорииСтажа(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВыслугаЛет => GetProperty<EnumItemBase>();
        public EnumItemBase Медицинский => GetProperty<EnumItemBase>();
        public EnumItemBase Непрерывный => GetProperty<EnumItemBase>();
        public EnumItemBase Общий => GetProperty<EnumItemBase>();
        public EnumItemBase ОбщийНаучноПедагогический => GetProperty<EnumItemBase>();
        public EnumItemBase Педагогический => GetProperty<EnumItemBase>();
        public EnumItemBase Прочее => GetProperty<EnumItemBase>();
        public EnumItemBase РасширенныйСтраховой => GetProperty<EnumItemBase>();
        public EnumItemBase Северный => GetProperty<EnumItemBase>();
        public EnumItemBase Страховой => GetProperty<EnumItemBase>();
        public EnumItemBase ВыслугаЛетНаГосударственнойСлужбе => GetProperty<EnumItemBase>();
        public EnumItemBase ВыслугаЛетНаВоеннойСлужбе => GetProperty<EnumItemBase>();
    }
}
