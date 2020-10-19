using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РазделыУчетаДляВводаОстатков:EnumBase
    {
        public РазделыУчетаДляВводаОстатков(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОсновныеСредства => GetProperty<EnumItem>("ОсновныеСредства");
        public EnumItem МалоценныеАктивыВЭксплуатации => GetProperty<EnumItem>("МалоценныеАктивыВЭксплуатации");
        public EnumItem НематериальныеАктивы => GetProperty<EnumItem>("НематериальныеАктивы");
        public EnumItem КапитальныеИнвестиции => GetProperty<EnumItem>("КапитальныеИнвестиции");
        public EnumItem ЗапасыСебестоимость => GetProperty<EnumItem>("ЗапасыСебестоимость");
        public EnumItem ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах => GetProperty<EnumItem>("ТранспортноЗаготовительныеРасходыНаОтдельныхСубсчетах");
        public EnumItem ЗапасыПереданные => GetProperty<EnumItem>("ЗапасыПереданные");
        public EnumItem НезавершенноеПроизводство => GetProperty<EnumItem>("НезавершенноеПроизводство");
        public EnumItem ТоварыПоПродажнойЦене => GetProperty<EnumItem>("ТоварыПоПродажнойЦене");
        public EnumItem ДенежныеСредства => GetProperty<EnumItem>("ДенежныеСредства");
        public EnumItem ВзаиморасчетыСКонтрагентами => GetProperty<EnumItem>("ВзаиморасчетыСКонтрагентами");
        public EnumItem ВзаиморасчетыСПодотчетнымиЛицами => GetProperty<EnumItem>("ВзаиморасчетыСПодотчетнымиЛицами");
        public EnumItem РасходыБудущихПериодов => GetProperty<EnumItem>("РасходыБудущихПериодов");
        public EnumItem ЗарплатаИОтчисления => GetProperty<EnumItem>("ЗарплатаИОтчисления");
        public EnumItem ТоварыНаКомиссии => GetProperty<EnumItem>("ТоварыНаКомиссии");
        public EnumItem ПрочиеСчетаБухгалтерскогоУчета => GetProperty<EnumItem>("ПрочиеСчетаБухгалтерскогоУчета");
        public EnumItem ОтсроченныеНалоговыеАктивыИОбязательства => GetProperty<EnumItem>("ОтсроченныеНалоговыеАктивыИОбязательства");
        public EnumItem ДанныеНалоговогоУчета => GetProperty<EnumItem>("ДанныеНалоговогоУчета");
        public EnumItem ГруппыОСНалоговыйУчет => GetProperty<EnumItem>("ГруппыОСНалоговыйУчет");
    }
}
