using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПоступлениеДенежныхСредств:V1C8COMObject
    {
        public ВидыОперацийПоступлениеДенежныхСредств(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплатаПокупателя => GetProperty<EnumItemBase>("ОплатаПокупателя");
        public EnumItemBase ВозвратДенежныхСредствПоставщиком => GetProperty<EnumItemBase>("ВозвратДенежныхСредствПоставщиком");
        public EnumItemBase РасчетыПоКредитамИЗаймам => GetProperty<EnumItemBase>("РасчетыПоКредитамИЗаймам");
        public EnumItemBase ПрочиеРасчетыСКонтрагентами => GetProperty<EnumItemBase>("ПрочиеРасчетыСКонтрагентами");
        public EnumItemBase ИнкассацияДенежныхСредств => GetProperty<EnumItemBase>("ИнкассацияДенежныхСредств");
        public EnumItemBase ПокупкаПродажаВалюты => GetProperty<EnumItemBase>("ПокупкаПродажаВалюты");
        public EnumItemBase ПрочееПоступлениеБезналичныхДенежныхСредств => GetProperty<EnumItemBase>("ПрочееПоступлениеБезналичныхДенежныхСредств");
        public EnumItemBase ПоступленияОтПродажПоПлатежнымКартамИБанковскимКредитам => GetProperty<EnumItemBase>("ПоступленияОтПродажПоПлатежнымКартамИБанковскимКредитам");
        public EnumItemBase ПоступлениеСредствОтФСС => GetProperty<EnumItemBase>("ПоступлениеСредствОтФСС");
        public EnumItemBase ВозвратДенежныхСредствПодотчетником => GetProperty<EnumItemBase>("ВозвратДенежныхСредствПодотчетником");
    }
}
