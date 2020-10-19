using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СостоянияСотрудника:EnumBase
    {
        public СостоянияСотрудника(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Работа => GetProperty<EnumItem>("Работа");
        public EnumItem РаботаВОтпускеПоУходуЗаРебенком => GetProperty<EnumItem>("РаботаВОтпускеПоУходуЗаРебенком");
        public EnumItem Прогул => GetProperty<EnumItem>("Прогул");
        public EnumItem ВынужденныйПрогул => GetProperty<EnumItem>("ВынужденныйПрогул");
        public EnumItem ПростойПоВинеРаботника => GetProperty<EnumItem>("ПростойПоВинеРаботника");
        public EnumItem ПростойПоВинеРаботодателя => GetProperty<EnumItem>("ПростойПоВинеРаботодателя");
        public EnumItem ПростойНеЗависящийОтРаботодателяИРаботника => GetProperty<EnumItem>("ПростойНеЗависящийОтРаботодателяИРаботника");
        public EnumItem ОтпускОсновной => GetProperty<EnumItem>("ОтпускОсновной");
        public EnumItem ДополнительныйОтпуск => GetProperty<EnumItem>("ДополнительныйОтпуск");
        public EnumItem ДополнительныйОтпускНеоплачиваемый => GetProperty<EnumItem>("ДополнительныйОтпускНеоплачиваемый");
        public EnumItem ОтпускУчебныйОплачиваемый => GetProperty<EnumItem>("ОтпускУчебныйОплачиваемый");
        public EnumItem ОтпускУчебныйНеоплачиваемый => GetProperty<EnumItem>("ОтпускУчебныйНеоплачиваемый");
        public EnumItem ОтпускНеоплачиваемыйПоРазрешениюРаботодателя => GetProperty<EnumItem>("ОтпускНеоплачиваемыйПоРазрешениюРаботодателя");
        public EnumItem ОтпускНеоплачиваемыйПоЗаконодательству => GetProperty<EnumItem>("ОтпускНеоплачиваемыйПоЗаконодательству");
        public EnumItem ОтпускПоУходуЗаРебенком => GetProperty<EnumItem>("ОтпускПоУходуЗаРебенком");
        public EnumItem Командировка => GetProperty<EnumItem>("Командировка");
        public EnumItem ОтсутствиеССохранениемОплаты => GetProperty<EnumItem>("ОтсутствиеССохранениемОплаты");
        public EnumItem ВыполнениеГосударственныхОбязанностей => GetProperty<EnumItem>("ВыполнениеГосударственныхОбязанностей");
        public EnumItem ДополнительныеВыходныеДниОплачиваемые => GetProperty<EnumItem>("ДополнительныеВыходныеДниОплачиваемые");
        public EnumItem ДополнительныеВыходныеДниНеОплачиваемые => GetProperty<EnumItem>("ДополнительныеВыходныеДниНеОплачиваемые");
        public EnumItem ОтсутствиеПоНевыясненнымПричинам => GetProperty<EnumItem>("ОтсутствиеПоНевыясненнымПричинам");
        public EnumItem ОтпускПоБеременностиИРодам => GetProperty<EnumItem>("ОтпускПоБеременностиИРодам");
        public EnumItem ОтпускНаСанаторноКурортноеЛечение => GetProperty<EnumItem>("ОтпускНаСанаторноКурортноеЛечение");
        public EnumItem Болезнь => GetProperty<EnumItem>("Болезнь");
        public EnumItem БолезньБезОплаты => GetProperty<EnumItem>("БолезньБезОплаты");
        public EnumItem Факт => GetProperty<EnumItem>("Факт");
        public EnumItem Увольнение => GetProperty<EnumItem>("Увольнение");
        public EnumItem ОтпускПоУходуЗаРебенком6лет => GetProperty<EnumItem>("ОтпускПоУходуЗаРебенком6лет");
    }
}
