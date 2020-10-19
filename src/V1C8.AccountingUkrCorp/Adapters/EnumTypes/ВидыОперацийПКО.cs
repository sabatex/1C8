using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийПКО:EnumBase
    {
        public ВидыОперацийПКО(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОплатаПокупателя => GetProperty<EnumItem>("ОплатаПокупателя");
        public EnumItem ПриходДенежныхСредствРозничнаяВыручка => GetProperty<EnumItem>("ПриходДенежныхСредствРозничнаяВыручка");
        public EnumItem ВозвратДенежныхСредствПодотчетником => GetProperty<EnumItem>("ВозвратДенежныхСредствПодотчетником");
        public EnumItem ВозвратДенежныхСредствПоставщиком => GetProperty<EnumItem>("ВозвратДенежныхСредствПоставщиком");
        public EnumItem ВозвратДенежныхСредствРаботником => GetProperty<EnumItem>("ВозвратДенежныхСредствРаботником");
        public EnumItem ПолучениеНаличныхДенежныхСредствВБанке => GetProperty<EnumItem>("ПолучениеНаличныхДенежныхСредствВБанке");
        public EnumItem РасчетыПоКредитамИЗаймамСКонтрагентами => GetProperty<EnumItem>("РасчетыПоКредитамИЗаймамСКонтрагентами");
        public EnumItem ПриходДенежныхСредствПрочее => GetProperty<EnumItem>("ПриходДенежныхСредствПрочее");
    }
}
