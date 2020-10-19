using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийСписаниеДенежныхСредств:EnumBase
    {
        public ВидыОперацийСписаниеДенежныхСредств(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОплатаПоставщику => GetProperty<EnumItem>("ОплатаПоставщику");
        public EnumItem ВозвратДенежныхСредствПокупателю => GetProperty<EnumItem>("ВозвратДенежныхСредствПокупателю");
        public EnumItem ПеречислениеНалога => GetProperty<EnumItem>("ПеречислениеНалога");
        public EnumItem РасчетыПоКредитамИЗаймамСКонтрагентами => GetProperty<EnumItem>("РасчетыПоКредитамИЗаймамСКонтрагентами");
        public EnumItem ПрочиеРасчетыСКонтрагентами => GetProperty<EnumItem>("ПрочиеРасчетыСКонтрагентами");
        public EnumItem ПереводНаДругойСчет => GetProperty<EnumItem>("ПереводНаДругойСчет");
        public EnumItem ПеречислениеЗП => GetProperty<EnumItem>("ПеречислениеЗП");
        public EnumItem ВыплатаЗарплатыНаЛицевыеСчета => GetProperty<EnumItem>("ВыплатаЗарплатыНаЛицевыеСчета");
        public EnumItem ПокупкаПродажаВалюты => GetProperty<EnumItem>("ПокупкаПродажаВалюты");
        public EnumItem ПеречислениеДенежныхСредствПодотчетнику => GetProperty<EnumItem>("ПеречислениеДенежныхСредствПодотчетнику");
        public EnumItem ПрочееСписаниеБезналичныхДенежныхСредств => GetProperty<EnumItem>("ПрочееСписаниеБезналичныхДенежныхСредств");
    }
}
