using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийСписаниеБезналичныхДенежныхСредств:V1C8COMObject
    {
        public ВидыОперацийСписаниеБезналичныхДенежныхСредств(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплатаПоставщику => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвратДенежныхСредствПокупателю => GetProperty<EnumItemBase>();
        public EnumItemBase ПеречислениеНалога => GetProperty<EnumItemBase>();
        public EnumItemBase РасчетыПоКредитамИЗаймам => GetProperty<EnumItemBase>();
        public EnumItemBase ПрочиеРасчетыСКонтрагентами => GetProperty<EnumItemBase>();
        public EnumItemBase ПереводНаДругойСчет => GetProperty<EnumItemBase>();
        public EnumItemBase ПеречислениеДенежныхСредствПодотчетнику => GetProperty<EnumItemBase>();
        public EnumItemBase ПокупкаПродажаВалюты => GetProperty<EnumItemBase>();
        public EnumItemBase ПеречислениеЗП => GetProperty<EnumItemBase>();
        public EnumItemBase ПрочееСписаниеБезналичныхДенежныхСредств => GetProperty<EnumItemBase>();
    }
}
