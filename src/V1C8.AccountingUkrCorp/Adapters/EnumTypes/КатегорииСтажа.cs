using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КатегорииСтажа:EnumBase
    {
        public КатегорииСтажа(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВыслугаЛет => GetProperty<EnumItem>("ВыслугаЛет");
        public EnumItem Медицинский => GetProperty<EnumItem>("Медицинский");
        public EnumItem Непрерывный => GetProperty<EnumItem>("Непрерывный");
        public EnumItem Общий => GetProperty<EnumItem>("Общий");
        public EnumItem ОбщийНаучноПедагогический => GetProperty<EnumItem>("ОбщийНаучноПедагогический");
        public EnumItem Педагогический => GetProperty<EnumItem>("Педагогический");
        public EnumItem Прочее => GetProperty<EnumItem>("Прочее");
        public EnumItem РасширенныйСтраховой => GetProperty<EnumItem>("РасширенныйСтраховой");
        public EnumItem Северный => GetProperty<EnumItem>("Северный");
        public EnumItem Страховой => GetProperty<EnumItem>("Страховой");
        public EnumItem ВыслугаЛетНаГосударственнойСлужбе => GetProperty<EnumItem>("ВыслугаЛетНаГосударственнойСлужбе");
        public EnumItem ВыслугаЛетНаВоеннойСлужбе => GetProperty<EnumItem>("ВыслугаЛетНаВоеннойСлужбе");
    }
}
