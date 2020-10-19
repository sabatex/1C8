using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПричиныНетрудоспособности:EnumBase
    {
        public ПричиныНетрудоспособности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОбщееЗаболевание => GetProperty<EnumItem>("ОбщееЗаболевание");
        public EnumItem ПоБеременностиИРодам => GetProperty<EnumItem>("ПоБеременностиИРодам");
        public EnumItem ТравмаНаПроизводстве => GetProperty<EnumItem>("ТравмаНаПроизводстве");
        public EnumItem Профзаболевание => GetProperty<EnumItem>("Профзаболевание");
        public EnumItem ПоУходуЗаРебенком => GetProperty<EnumItem>("ПоУходуЗаРебенком");
        public EnumItem ПоУходуЗаВзрослым => GetProperty<EnumItem>("ПоУходуЗаВзрослым");
        public EnumItem Карантин => GetProperty<EnumItem>("Карантин");
        public EnumItem Протезирование => GetProperty<EnumItem>("Протезирование");
        public EnumItem ПособиеПриДолечивании => GetProperty<EnumItem>("ПособиеПриДолечивании");
        public EnumItem ЗаболеваниеЧернобыльцев => GetProperty<EnumItem>("ЗаболеваниеЧернобыльцев");
        public EnumItem НепроизводственныеТравмы => GetProperty<EnumItem>("НепроизводственныеТравмы");
        public EnumItem СанаторноКурортноеЛечение => GetProperty<EnumItem>("СанаторноКурортноеЛечение");
        public EnumItem COVID_19 => GetProperty<EnumItem>("COVID_19");
    }
}
