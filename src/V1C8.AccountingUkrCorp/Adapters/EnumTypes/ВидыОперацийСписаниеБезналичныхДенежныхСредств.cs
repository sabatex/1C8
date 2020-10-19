using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийСписаниеБезналичныхДенежныхСредств:V1C8COMObject
    {
        public ВидыОперацийСписаниеБезналичныхДенежныхСредств(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплатаПоставщику => GetProperty<EnumItemBase>("ОплатаПоставщику");
        public EnumItemBase ВозвратДенежныхСредствПокупателю => GetProperty<EnumItemBase>("ВозвратДенежныхСредствПокупателю");
        public EnumItemBase ПеречислениеНалога => GetProperty<EnumItemBase>("ПеречислениеНалога");
        public EnumItemBase РасчетыПоКредитамИЗаймам => GetProperty<EnumItemBase>("РасчетыПоКредитамИЗаймам");
        public EnumItemBase ПрочиеРасчетыСКонтрагентами => GetProperty<EnumItemBase>("ПрочиеРасчетыСКонтрагентами");
        public EnumItemBase ПереводНаДругойСчет => GetProperty<EnumItemBase>("ПереводНаДругойСчет");
        public EnumItemBase ПеречислениеДенежныхСредствПодотчетнику => GetProperty<EnumItemBase>("ПеречислениеДенежныхСредствПодотчетнику");
        public EnumItemBase ПокупкаПродажаВалюты => GetProperty<EnumItemBase>("ПокупкаПродажаВалюты");
        public EnumItemBase ПеречислениеЗП => GetProperty<EnumItemBase>("ПеречислениеЗП");
        public EnumItemBase ПрочееСписаниеБезналичныхДенежныхСредств => GetProperty<EnumItemBase>("ПрочееСписаниеБезналичныхДенежныхСредств");
    }
}
