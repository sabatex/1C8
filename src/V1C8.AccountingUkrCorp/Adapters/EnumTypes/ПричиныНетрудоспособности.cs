using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПричиныНетрудоспособности:V1C8COMObject
    {
        public ПричиныНетрудоспособности(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбщееЗаболевание => GetProperty<EnumItemBase>("ОбщееЗаболевание");
        public EnumItemBase ПоБеременностиИРодам => GetProperty<EnumItemBase>("ПоБеременностиИРодам");
        public EnumItemBase ТравмаНаПроизводстве => GetProperty<EnumItemBase>("ТравмаНаПроизводстве");
        public EnumItemBase Профзаболевание => GetProperty<EnumItemBase>("Профзаболевание");
        public EnumItemBase ПоУходуЗаРебенком => GetProperty<EnumItemBase>("ПоУходуЗаРебенком");
        public EnumItemBase ПоУходуЗаВзрослым => GetProperty<EnumItemBase>("ПоУходуЗаВзрослым");
        public EnumItemBase Карантин => GetProperty<EnumItemBase>("Карантин");
        public EnumItemBase Протезирование => GetProperty<EnumItemBase>("Протезирование");
        public EnumItemBase ПособиеПриДолечивании => GetProperty<EnumItemBase>("ПособиеПриДолечивании");
        public EnumItemBase ЗаболеваниеЧернобыльцев => GetProperty<EnumItemBase>("ЗаболеваниеЧернобыльцев");
        public EnumItemBase НепроизводственныеТравмы => GetProperty<EnumItemBase>("НепроизводственныеТравмы");
        public EnumItemBase СанаторноКурортноеЛечение => GetProperty<EnumItemBase>("СанаторноКурортноеЛечение");
        public EnumItemBase COVID_19 => GetProperty<EnumItemBase>("COVID_19");
    }
}
