using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПричиныНетрудоспособности:V1C8COMObject
    {
        public ПричиныНетрудоспособности(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОбщееЗаболевание => GetProperty<EnumItemBase>();
        public EnumItemBase ПоБеременностиИРодам => GetProperty<EnumItemBase>();
        public EnumItemBase ТравмаНаПроизводстве => GetProperty<EnumItemBase>();
        public EnumItemBase Профзаболевание => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУходуЗаРебенком => GetProperty<EnumItemBase>();
        public EnumItemBase ПоУходуЗаВзрослым => GetProperty<EnumItemBase>();
        public EnumItemBase Карантин => GetProperty<EnumItemBase>();
        public EnumItemBase Протезирование => GetProperty<EnumItemBase>();
        public EnumItemBase ПособиеПриДолечивании => GetProperty<EnumItemBase>();
        public EnumItemBase ЗаболеваниеЧернобыльцев => GetProperty<EnumItemBase>();
        public EnumItemBase НепроизводственныеТравмы => GetProperty<EnumItemBase>();
        public EnumItemBase СанаторноКурортноеЛечение => GetProperty<EnumItemBase>();
        public EnumItemBase COVID_19 => GetProperty<EnumItemBase>();
    }
}
