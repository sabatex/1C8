using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СостоянияСотрудника:V1C8COMObject
    {
        public СостоянияСотрудника(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Работа => GetProperty<EnumItemBase>();
        public EnumItemBase РаботаВОтпускеПоУходуЗаРебенком => GetProperty<EnumItemBase>();
        public EnumItemBase Прогул => GetProperty<EnumItemBase>();
        public EnumItemBase ВынужденныйПрогул => GetProperty<EnumItemBase>();
        public EnumItemBase ПростойПоВинеРаботника => GetProperty<EnumItemBase>();
        public EnumItemBase ПростойПоВинеРаботодателя => GetProperty<EnumItemBase>();
        public EnumItemBase ПростойНеЗависящийОтРаботодателяИРаботника => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускОсновной => GetProperty<EnumItemBase>();
        public EnumItemBase ДополнительныйОтпуск => GetProperty<EnumItemBase>();
        public EnumItemBase ДополнительныйОтпускНеоплачиваемый => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускУчебныйОплачиваемый => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускУчебныйНеоплачиваемый => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускНеоплачиваемыйПоРазрешениюРаботодателя => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускНеоплачиваемыйПоЗаконодательству => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускПоУходуЗаРебенком => GetProperty<EnumItemBase>();
        public EnumItemBase Командировка => GetProperty<EnumItemBase>();
        public EnumItemBase ОтсутствиеССохранениемОплаты => GetProperty<EnumItemBase>();
        public EnumItemBase ВыполнениеГосударственныхОбязанностей => GetProperty<EnumItemBase>();
        public EnumItemBase ДополнительныеВыходныеДниОплачиваемые => GetProperty<EnumItemBase>();
        public EnumItemBase ДополнительныеВыходныеДниНеОплачиваемые => GetProperty<EnumItemBase>();
        public EnumItemBase ОтсутствиеПоНевыясненнымПричинам => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускПоБеременностиИРодам => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускНаСанаторноКурортноеЛечение => GetProperty<EnumItemBase>();
        public EnumItemBase Болезнь => GetProperty<EnumItemBase>();
        public EnumItemBase БолезньБезОплаты => GetProperty<EnumItemBase>();
        public EnumItemBase Факт => GetProperty<EnumItemBase>();
        public EnumItemBase Увольнение => GetProperty<EnumItemBase>();
        public EnumItemBase ОтпускПоУходуЗаРебенком6лет => GetProperty<EnumItemBase>();
    }
}
