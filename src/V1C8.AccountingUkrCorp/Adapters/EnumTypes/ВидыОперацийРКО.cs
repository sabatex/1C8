using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийРКО:V1C8COMObject
    {
        public ВидыОперацийРКО(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплатаПоставщику => GetProperty<EnumItemBase>("ОплатаПоставщику");
        public EnumItemBase ВозвратДенежныхСредствПокупателю => GetProperty<EnumItemBase>("ВозвратДенежныхСредствПокупателю");
        public EnumItemBase ВыдачаДенежныхСредствПодотчетнику => GetProperty<EnumItemBase>("ВыдачаДенежныхСредствПодотчетнику");
        public EnumItemBase ВыплатаЗаработнойПлатыПоВедомостям => GetProperty<EnumItemBase>("ВыплатаЗаработнойПлатыПоВедомостям");
        public EnumItemBase ВыплатаЗарплатыРаздатчиком => GetProperty<EnumItemBase>("ВыплатаЗарплатыРаздатчиком");
        public EnumItemBase ВыплатаЗаработнойПлатыРаботнику => GetProperty<EnumItemBase>("ВыплатаЗаработнойПлатыРаботнику");
        public EnumItemBase ВыдачаЗаймаСотруднику => GetProperty<EnumItemBase>("ВыдачаЗаймаСотруднику");
        public EnumItemBase ВзносНаличнымиВБанк => GetProperty<EnumItemBase>("ВзносНаличнымиВБанк");
        public EnumItemBase РасчетыПоКредитамИЗаймамСКонтрагентами => GetProperty<EnumItemBase>("РасчетыПоКредитамИЗаймамСКонтрагентами");
        public EnumItemBase ИнкассацияДенежныхСредств => GetProperty<EnumItemBase>("ИнкассацияДенежныхСредств");
        public EnumItemBase РасходДенежныхСредствПрочее => GetProperty<EnumItemBase>("РасходДенежныхСредствПрочее");
    }
}
