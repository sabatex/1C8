using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазделыУчетаДляВводаОстатков:V1C8COMObject
    {
        public РазделыУчетаДляВводаОстатков(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОсновныеСредства => GetProperty<EnumItemBase>("ОсновныеСредства");
        public EnumItemBase МалоценныеАктивыВЭксплуатации => GetProperty<EnumItemBase>("МалоценныеАктивыВЭксплуатации");
        public EnumItemBase НематериальныеАктивы => GetProperty<EnumItemBase>("НематериальныеАктивы");
        public EnumItemBase КапитальныеИнвестиции => GetProperty<EnumItemBase>("КапитальныеИнвестиции");
        public EnumItemBase ЗапасыСебестоимость => GetProperty<EnumItemBase>("ЗапасыСебестоимость");
        public EnumItemBase ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах => GetProperty<EnumItemBase>("ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах");
        public EnumItemBase ЗапасыПереданные => GetProperty<EnumItemBase>("ЗапасыПереданные");
        public EnumItemBase НезавершенноеПроизводство => GetProperty<EnumItemBase>("НезавершенноеПроизводство");
        public EnumItemBase ТоварыПоПродажнойЦене => GetProperty<EnumItemBase>("ТоварыПоПродажнойЦене");
        public EnumItemBase ДенежныеСредства => GetProperty<EnumItemBase>("ДенежныеСредства");
        public EnumItemBase ВзаиморасчетыСКонтрагентами => GetProperty<EnumItemBase>("ВзаиморасчетыСКонтрагентами");
        public EnumItemBase ВзаиморасчетыСПодотчетнымиЛицами => GetProperty<EnumItemBase>("ВзаиморасчетыСПодотчетнымиЛицами");
        public EnumItemBase РасходыБудущихПериодов => GetProperty<EnumItemBase>("РасходыБудущихПериодов");
        public EnumItemBase ЗарплатаИОтчисления => GetProperty<EnumItemBase>("ЗарплатаИОтчисления");
        public EnumItemBase ТоварыНаКомиссии => GetProperty<EnumItemBase>("ТоварыНаКомиссии");
        public EnumItemBase ПрочиеСчетаБухгалтерскогоУчета => GetProperty<EnumItemBase>("ПрочиеСчетаБухгалтерскогоУчета");
        public EnumItemBase ОтсроченныеНалоговыеАктивыИОбязательства => GetProperty<EnumItemBase>("ОтсроченныеНалоговыеАктивыИОбязательства");
        public EnumItemBase ДанныеНалоговогоУчета => GetProperty<EnumItemBase>("ДанныеНалоговогоУчета");
        public EnumItemBase ГруппыОСНалоговыйУчет => GetProperty<EnumItemBase>("ГруппыОСНалоговыйУчет");
    }
}
