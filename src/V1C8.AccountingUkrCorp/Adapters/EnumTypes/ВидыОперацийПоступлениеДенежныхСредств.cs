using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПоступлениеДенежныхСредств:EnumBase
    {
        public ВидыОперацийПоступлениеДенежныхСредств(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОплатаПокупателя => GetProperty<EnumItem>("ОплатаПокупателя");
        public EnumItem ВозвратДенежныхСредствПоставщиком => GetProperty<EnumItem>("ВозвратДенежныхСредствПоставщиком");
        public EnumItem РасчетыПоКредитамИЗаймам => GetProperty<EnumItem>("РасчетыПоКредитамИЗаймам");
        public EnumItem ПрочиеРасчетыСКонтрагентами => GetProperty<EnumItem>("ПрочиеРасчетыСКонтрагентами");
        public EnumItem ИнкассацияДенежныхСредств => GetProperty<EnumItem>("ИнкассацияДенежныхСредств");
        public EnumItem ПокупкаПродажаВалюты => GetProperty<EnumItem>("ПокупкаПродажаВалюты");
        public EnumItem ПрочееПоступлениеБезналичныхДенежныхСредств => GetProperty<EnumItem>("ПрочееПоступлениеБезналичныхДенежныхСредств");
        public EnumItem ПоступленияОтПродажПоПлатежнымКартамИБанковскимКредитам => GetProperty<EnumItem>("ПоступленияОтПродажПоПлатежнымКартамИБанковскимКредитам");
        public EnumItem ПоступлениеСредствОтФСС => GetProperty<EnumItem>("ПоступлениеСредствОтФСС");
        public EnumItem ВозвратДенежныхСредствПодотчетником => GetProperty<EnumItem>("ВозвратДенежныхСредствПодотчетником");
    }
}
