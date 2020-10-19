using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииСтажа:V1C8COMObject
    {
        public КатегорииСтажа(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВыслугаЛет => GetProperty<EnumItemBase>("ВыслугаЛет");
        public EnumItemBase Медицинский => GetProperty<EnumItemBase>("Медицинский");
        public EnumItemBase Непрерывный => GetProperty<EnumItemBase>("Непрерывный");
        public EnumItemBase Общий => GetProperty<EnumItemBase>("Общий");
        public EnumItemBase ОбщийНаучноПедагогический => GetProperty<EnumItemBase>("ОбщийНаучноПедагогический");
        public EnumItemBase Педагогический => GetProperty<EnumItemBase>("Педагогический");
        public EnumItemBase Прочее => GetProperty<EnumItemBase>("Прочее");
        public EnumItemBase РасширенныйСтраховой => GetProperty<EnumItemBase>("РасширенныйСтраховой");
        public EnumItemBase Северный => GetProperty<EnumItemBase>("Северный");
        public EnumItemBase Страховой => GetProperty<EnumItemBase>("Страховой");
        public EnumItemBase ВыслугаЛетНаГосударственнойСлужбе => GetProperty<EnumItemBase>("ВыслугаЛетНаГосударственнойСлужбе");
        public EnumItemBase ВыслугаЛетНаВоеннойСлужбе => GetProperty<EnumItemBase>("ВыслугаЛетНаВоеннойСлужбе");
    }
}
