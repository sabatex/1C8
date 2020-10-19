using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыРасчетаНачислений:EnumBase
    {
        public СпособыРасчетаНачислений(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПоМесячнойТарифнойСтавкеПоЧасам => GetProperty<EnumItem>("ПоМесячнойТарифнойСтавкеПоЧасам");
        public EnumItem ПроизвольнаяФормула => GetProperty<EnumItem>("ПроизвольнаяФормула");
        public EnumItem ПоМесячнойТарифнойСтавкеПоДням => GetProperty<EnumItem>("ПоМесячнойТарифнойСтавкеПоДням");
        public EnumItem ПоДневнойТарифнойСтавке => GetProperty<EnumItem>("ПоДневнойТарифнойСтавке");
        public EnumItem ПоЧасовойТарифнойСтавке => GetProperty<EnumItem>("ПоЧасовойТарифнойСтавке");
        public EnumItem ФиксированнойСуммой => GetProperty<EnumItem>("ФиксированнойСуммой");
        public EnumItem Процентом => GetProperty<EnumItem>("Процентом");
        public EnumItem ИндексацияЗарплаты => GetProperty<EnumItem>("ИндексацияЗарплаты");
        public EnumItem ДоплатаДоСреднегоЗаработка => GetProperty<EnumItem>("ДоплатаДоСреднегоЗаработка");
        public EnumItem ДоплатаДоСреднегоЗаработкаФСС => GetProperty<EnumItem>("ДоплатаДоСреднегоЗаработкаФСС");
        public EnumItem ОплатаБольничного => GetProperty<EnumItem>("ОплатаБольничного");
        public EnumItem ОплатаОтпускаПоКалендарнымДням => GetProperty<EnumItem>("ОплатаОтпускаПоКалендарнымДням");
        public EnumItem ОплатаОтпускаПоШестидневке => GetProperty<EnumItem>("ОплатаОтпускаПоШестидневке");
        public EnumItem ОплатаПростоя => GetProperty<EnumItem>("ОплатаПростоя");
        public EnumItem ПособиеПоУходуЗаРебенкомДоПолутораЛет => GetProperty<EnumItem>("ПособиеПоУходуЗаРебенкомДоПолутораЛет");
        public EnumItem ДоплатаДоСохраняемогоДенежногоСодержанияЗаДниБолезни => GetProperty<EnumItem>("ДоплатаДоСохраняемогоДенежногоСодержанияЗаДниБолезни");
        public EnumItem ДоплатаДоМЗП => GetProperty<EnumItem>("ДоплатаДоМЗП");
        public EnumItem ИндексацияСоциальныхНачислений => GetProperty<EnumItem>("ИндексацияСоциальныхНачислений");
        public EnumItem НулеваяСумма => GetProperty<EnumItem>("НулеваяСумма");
        public EnumItem Индексация => GetProperty<EnumItem>("Индексация");
    }
}
