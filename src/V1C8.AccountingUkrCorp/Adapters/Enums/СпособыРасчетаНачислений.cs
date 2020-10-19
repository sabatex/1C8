using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыРасчетаНачислений:V1C8COMObject
    {
        public СпособыРасчетаНачислений(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоМесячнойТарифнойСтавкеПоЧасам => GetProperty<EnumItemBase>();
        public EnumItemBase ПроизвольнаяФормула => GetProperty<EnumItemBase>();
        public EnumItemBase ПоМесячнойТарифнойСтавкеПоДням => GetProperty<EnumItemBase>();
        public EnumItemBase ПоДневнойТарифнойСтавке => GetProperty<EnumItemBase>();
        public EnumItemBase ПоЧасовойТарифнойСтавке => GetProperty<EnumItemBase>();
        public EnumItemBase ФиксированнойСуммой => GetProperty<EnumItemBase>();
        public EnumItemBase Процентом => GetProperty<EnumItemBase>();
        public EnumItemBase ИндексацияЗарплаты => GetProperty<EnumItemBase>();
        public EnumItemBase ДоплатаДоСреднегоЗаработка => GetProperty<EnumItemBase>();
        public EnumItemBase ДоплатаДоСреднегоЗаработкаФСС => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаБольничного => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаОтпускаПоКалендарнымДням => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаОтпускаПоШестидневке => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаПростоя => GetProperty<EnumItemBase>();
        public EnumItemBase ПособиеПоУходуЗаРебенкомДоПолутораЛет => GetProperty<EnumItemBase>();
        public EnumItemBase ДоплатаДоСохраняемогоДенежногоСодержанияЗаДниБолезни => GetProperty<EnumItemBase>();
        public EnumItemBase ДоплатаДоМЗП => GetProperty<EnumItemBase>();
        public EnumItemBase ИндексацияСоциальныхНачислений => GetProperty<EnumItemBase>();
        public EnumItemBase НулеваяСумма => GetProperty<EnumItemBase>();
        public EnumItemBase Индексация => GetProperty<EnumItemBase>();
    }
}
