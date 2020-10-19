using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПКО:V1C8COMObject
    {
        public ВидыОперацийПКО(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплатаПокупателя => GetProperty<EnumItemBase>("ОплатаПокупателя");
        public EnumItemBase ПриходДенежныхСредствРозничнаяВыручка => GetProperty<EnumItemBase>("ПриходДенежныхСредствРозничнаяВыручка");
        public EnumItemBase ВозвратДенежныхСредствПодотчетником => GetProperty<EnumItemBase>("ВозвратДенежныхСредствПодотчетником");
        public EnumItemBase ВозвратДенежныхСредствПоставщиком => GetProperty<EnumItemBase>("ВозвратДенежныхСредствПоставщиком");
        public EnumItemBase ВозвратДенежныхСредствРаботником => GetProperty<EnumItemBase>("ВозвратДенежныхСредствРаботником");
        public EnumItemBase ПолучениеНаличныхДенежныхСредствВБанке => GetProperty<EnumItemBase>("ПолучениеНаличныхДенежныхСредствВБанке");
        public EnumItemBase РасчетыПоКредитамИЗаймамСКонтрагентами => GetProperty<EnumItemBase>("РасчетыПоКредитамИЗаймамСКонтрагентами");
        public EnumItemBase ПриходДенежныхСредствПрочее => GetProperty<EnumItemBase>("ПриходДенежныхСредствПрочее");
    }
}
