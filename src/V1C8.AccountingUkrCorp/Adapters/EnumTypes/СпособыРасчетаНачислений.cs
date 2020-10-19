using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаНачислений:V1C8COMObject
    {
        public СпособыРасчетаНачислений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоМесячнойТарифнойСтавкеПоЧасам => GetProperty<EnumItemBase>("ПоМесячнойТарифнойСтавкеПоЧасам");
        public EnumItemBase ПроизвольнаяФормула => GetProperty<EnumItemBase>("ПроизвольнаяФормула");
        public EnumItemBase ПоМесячнойТарифнойСтавкеПоДням => GetProperty<EnumItemBase>("ПоМесячнойТарифнойСтавкеПоДням");
        public EnumItemBase ПоДневнойТарифнойСтавке => GetProperty<EnumItemBase>("ПоДневнойТарифнойСтавке");
        public EnumItemBase ПоЧасовойТарифнойСтавке => GetProperty<EnumItemBase>("ПоЧасовойТарифнойСтавке");
        public EnumItemBase ФиксированнойСуммой => GetProperty<EnumItemBase>("ФиксированнойСуммой");
        public EnumItemBase Процентом => GetProperty<EnumItemBase>("Процентом");
        public EnumItemBase ИндексацияЗарплаты => GetProperty<EnumItemBase>("ИндексацияЗарплаты");
        public EnumItemBase ДоплатаДоСреднегоЗаработка => GetProperty<EnumItemBase>("ДоплатаДоСреднегоЗаработка");
        public EnumItemBase ДоплатаДоСреднегоЗаработкаФСС => GetProperty<EnumItemBase>("ДоплатаДоСреднегоЗаработкаФСС");
        public EnumItemBase ОплатаБольничного => GetProperty<EnumItemBase>("ОплатаБольничного");
        public EnumItemBase ОплатаОтпускаПоКалендарнымДням => GetProperty<EnumItemBase>("ОплатаОтпускаПоКалендарнымДням");
        public EnumItemBase ОплатаОтпускаПоШестидневке => GetProperty<EnumItemBase>("ОплатаОтпускаПоШестидневке");
        public EnumItemBase ОплатаПростоя => GetProperty<EnumItemBase>("ОплатаПростоя");
        public EnumItemBase ПособиеПоУходуЗаРебенкомДоПолутораЛет => GetProperty<EnumItemBase>("ПособиеПоУходуЗаРебенкомДоПолутораЛет");
        public EnumItemBase ДоплатаДоСохраняемогоДенежногоСодержанияЗаДниБолезни => GetProperty<EnumItemBase>("ДоплатаДоСохраняемогоДенежногоСодержанияЗаДниБолезни");
        public EnumItemBase ДоплатаДоМЗП => GetProperty<EnumItemBase>("ДоплатаДоМЗП");
        public EnumItemBase ИндексацияСоциальныхНачислений => GetProperty<EnumItemBase>("ИндексацияСоциальныхНачислений");
        public EnumItemBase НулеваяСумма => GetProperty<EnumItemBase>("НулеваяСумма");
        public EnumItemBase Индексация => GetProperty<EnumItemBase>("Индексация");
    }
}
