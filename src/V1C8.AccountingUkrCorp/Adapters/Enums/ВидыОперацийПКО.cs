using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийПКО:V1C8COMObject
    {
        public ВидыОперацийПКО(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплатаПокупателя => GetProperty<EnumItemBase>();
        public EnumItemBase ПриходДенежныхСредствРозничнаяВыручка => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвратДенежныхСредствПодотчетником => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвратДенежныхСредствПоставщиком => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвратДенежныхСредствРаботником => GetProperty<EnumItemBase>();
        public EnumItemBase ПолучениеНаличныхДенежныхСредствВБанке => GetProperty<EnumItemBase>();
        public EnumItemBase РасчетыПоКредитамИЗаймамСКонтрагентами => GetProperty<EnumItemBase>();
        public EnumItemBase ПриходДенежныхСредствПрочее => GetProperty<EnumItemBase>();
    }
}
