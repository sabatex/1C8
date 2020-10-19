using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийРКО:V1C8COMObject
    {
        public ВидыОперацийРКО(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплатаПоставщику => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвратДенежныхСредствПокупателю => GetProperty<EnumItemBase>();
        public EnumItemBase ВыдачаДенежныхСредствПодотчетнику => GetProperty<EnumItemBase>();
        public EnumItemBase ВыплатаЗаработнойПлатыПоВедомостям => GetProperty<EnumItemBase>();
        public EnumItemBase ВыплатаЗарплатыРаздатчиком => GetProperty<EnumItemBase>();
        public EnumItemBase ВыплатаЗаработнойПлатыРаботнику => GetProperty<EnumItemBase>();
        public EnumItemBase ВыдачаЗаймаСотруднику => GetProperty<EnumItemBase>();
        public EnumItemBase ВзносНаличнымиВБанк => GetProperty<EnumItemBase>();
        public EnumItemBase РасчетыПоКредитамИЗаймамСКонтрагентами => GetProperty<EnumItemBase>();
        public EnumItemBase ИнкассацияДенежныхСредств => GetProperty<EnumItemBase>();
        public EnumItemBase РасходДенежныхСредствПрочее => GetProperty<EnumItemBase>();
    }
}
