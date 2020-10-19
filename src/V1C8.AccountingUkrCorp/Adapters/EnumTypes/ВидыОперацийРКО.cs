using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийРКО:EnumBase
    {
        public ВидыОперацийРКО(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОплатаПоставщику => GetProperty<EnumItem>("ОплатаПоставщику");
        public EnumItem ВозвратДенежныхСредствПокупателю => GetProperty<EnumItem>("ВозвратДенежныхСредствПокупателю");
        public EnumItem ВыдачаДенежныхСредствПодотчетнику => GetProperty<EnumItem>("ВыдачаДенежныхСредствПодотчетнику");
        public EnumItem ВыплатаЗаработнойПлатыПоВедомостям => GetProperty<EnumItem>("ВыплатаЗаработнойПлатыПоВедомостям");
        public EnumItem ВыплатаЗарплатыРаздатчиком => GetProperty<EnumItem>("ВыплатаЗарплатыРаздатчиком");
        public EnumItem ВыплатаЗаработнойПлатыРаботнику => GetProperty<EnumItem>("ВыплатаЗаработнойПлатыРаботнику");
        public EnumItem ВыдачаЗаймаСотруднику => GetProperty<EnumItem>("ВыдачаЗаймаСотруднику");
        public EnumItem ВзносНаличнымиВБанк => GetProperty<EnumItem>("ВзносНаличнымиВБанк");
        public EnumItem РасчетыПоКредитамИЗаймамСКонтрагентами => GetProperty<EnumItem>("РасчетыПоКредитамИЗаймамСКонтрагентами");
        public EnumItem ИнкассацияДенежныхСредств => GetProperty<EnumItem>("ИнкассацияДенежныхСредств");
        public EnumItem РасходДенежныхСредствПрочее => GetProperty<EnumItem>("РасходДенежныхСредствПрочее");
    }
}
