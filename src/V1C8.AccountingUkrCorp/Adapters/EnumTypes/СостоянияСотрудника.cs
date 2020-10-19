using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияСотрудника:V1C8COMObject
    {
        public СостоянияСотрудника(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Работа => GetProperty<EnumItemBase>("Работа");
        public EnumItemBase РаботаВОтпускеПоУходуЗаРебенком => GetProperty<EnumItemBase>("РаботаВОтпускеПоУходуЗаРебенком");
        public EnumItemBase Прогул => GetProperty<EnumItemBase>("Прогул");
        public EnumItemBase ВынужденныйПрогул => GetProperty<EnumItemBase>("ВынужденныйПрогул");
        public EnumItemBase ПростойПоВинеРаботника => GetProperty<EnumItemBase>("ПростойПоВинеРаботника");
        public EnumItemBase ПростойПоВинеРаботодателя => GetProperty<EnumItemBase>("ПростойПоВинеРаботодателя");
        public EnumItemBase ПростойНеЗависящийОтРаботодателяИРаботника => GetProperty<EnumItemBase>("ПростойНеЗависящийОтРаботодателяИРаботника");
        public EnumItemBase ОтпускОсновной => GetProperty<EnumItemBase>("ОтпускОсновной");
        public EnumItemBase ДополнительныйОтпуск => GetProperty<EnumItemBase>("ДополнительныйОтпуск");
        public EnumItemBase ДополнительныйОтпускНеоплачиваемый => GetProperty<EnumItemBase>("ДополнительныйОтпускНеоплачиваемый");
        public EnumItemBase ОтпускУчебныйОплачиваемый => GetProperty<EnumItemBase>("ОтпускУчебныйОплачиваемый");
        public EnumItemBase ОтпускУчебныйНеоплачиваемый => GetProperty<EnumItemBase>("ОтпускУчебныйНеоплачиваемый");
        public EnumItemBase ОтпускНеоплачиваемыйПоРазрешениюРаботодателя => GetProperty<EnumItemBase>("ОтпускНеоплачиваемыйПоРазрешениюРаботодателя");
        public EnumItemBase ОтпускНеоплачиваемыйПоЗаконодательству => GetProperty<EnumItemBase>("ОтпускНеоплачиваемыйПоЗаконодательству");
        public EnumItemBase ОтпускПоУходуЗаРебенком => GetProperty<EnumItemBase>("ОтпускПоУходуЗаРебенком");
        public EnumItemBase Командировка => GetProperty<EnumItemBase>("Командировка");
        public EnumItemBase ОтсутствиеССохранениемОплаты => GetProperty<EnumItemBase>("ОтсутствиеССохранениемОплаты");
        public EnumItemBase ВыполнениеГосударственныхОбязанностей => GetProperty<EnumItemBase>("ВыполнениеГосударственныхОбязанностей");
        public EnumItemBase ДополнительныеВыходныеДниОплачиваемые => GetProperty<EnumItemBase>("ДополнительныеВыходныеДниОплачиваемые");
        public EnumItemBase ДополнительныеВыходныеДниНеОплачиваемые => GetProperty<EnumItemBase>("ДополнительныеВыходныеДниНеОплачиваемые");
        public EnumItemBase ОтсутствиеПоНевыясненнымПричинам => GetProperty<EnumItemBase>("ОтсутствиеПоНевыясненнымПричинам");
        public EnumItemBase ОтпускПоБеременностиИРодам => GetProperty<EnumItemBase>("ОтпускПоБеременностиИРодам");
        public EnumItemBase ОтпускНаСанаторноКурортноеЛечение => GetProperty<EnumItemBase>("ОтпускНаСанаторноКурортноеЛечение");
        public EnumItemBase Болезнь => GetProperty<EnumItemBase>("Болезнь");
        public EnumItemBase БолезньБезОплаты => GetProperty<EnumItemBase>("БолезньБезОплаты");
        public EnumItemBase Факт => GetProperty<EnumItemBase>("Факт");
        public EnumItemBase Увольнение => GetProperty<EnumItemBase>("Увольнение");
        public EnumItemBase ОтпускПоУходуЗаРебенком6лет => GetProperty<EnumItemBase>("ОтпускПоУходуЗаРебенком6лет");
    }
}
