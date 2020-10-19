using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РазделыУчетаДляВводаОстатков:V1C8COMObject
    {
        public РазделыУчетаДляВводаОстатков(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОсновныеСредства => GetProperty<EnumItemBase>();
        public EnumItemBase МалоценныеАктивыВЭксплуатации => GetProperty<EnumItemBase>();
        public EnumItemBase НематериальныеАктивы => GetProperty<EnumItemBase>();
        public EnumItemBase КапитальныеИнвестиции => GetProperty<EnumItemBase>();
        public EnumItemBase ЗапасыСебестоимость => GetProperty<EnumItemBase>();
        public EnumItemBase ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах => GetProperty<EnumItemBase>();
        public EnumItemBase ЗапасыПереданные => GetProperty<EnumItemBase>();
        public EnumItemBase НезавершенноеПроизводство => GetProperty<EnumItemBase>();
        public EnumItemBase ТоварыПоПродажнойЦене => GetProperty<EnumItemBase>();
        public EnumItemBase ДенежныеСредства => GetProperty<EnumItemBase>();
        public EnumItemBase ВзаиморасчетыСКонтрагентами => GetProperty<EnumItemBase>();
        public EnumItemBase ВзаиморасчетыСПодотчетнымиЛицами => GetProperty<EnumItemBase>();
        public EnumItemBase РасходыБудущихПериодов => GetProperty<EnumItemBase>();
        public EnumItemBase ЗарплатаИОтчисления => GetProperty<EnumItemBase>();
        public EnumItemBase ТоварыНаКомиссии => GetProperty<EnumItemBase>();
        public EnumItemBase ПрочиеСчетаБухгалтерскогоУчета => GetProperty<EnumItemBase>();
        public EnumItemBase ОтсроченныеНалоговыеАктивыИОбязательства => GetProperty<EnumItemBase>();
        public EnumItemBase ДанныеНалоговогоУчета => GetProperty<EnumItemBase>();
        public EnumItemBase ГруппыОСНалоговыйУчет => GetProperty<EnumItemBase>();
    }
}
