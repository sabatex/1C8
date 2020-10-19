using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийПоступлениеДенежныхСредств:V1C8COMObject
    {
        public ВидыОперацийПоступлениеДенежныхСредств(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплатаПокупателя => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвратДенежныхСредствПоставщиком => GetProperty<EnumItemBase>();
        public EnumItemBase РасчетыПоКредитамИЗаймам => GetProperty<EnumItemBase>();
        public EnumItemBase ПрочиеРасчетыСКонтрагентами => GetProperty<EnumItemBase>();
        public EnumItemBase ИнкассацияДенежныхСредств => GetProperty<EnumItemBase>();
        public EnumItemBase ПокупкаПродажаВалюты => GetProperty<EnumItemBase>();
        public EnumItemBase ПрочееПоступлениеБезналичныхДенежныхСредств => GetProperty<EnumItemBase>();
        public EnumItemBase ПоступленияОтПродажПоПлатежнымКартамИБанковскимКредитам => GetProperty<EnumItemBase>();
        public EnumItemBase ПоступлениеСредствОтФСС => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвратДенежныхСредствПодотчетником => GetProperty<EnumItemBase>();
    }
}
