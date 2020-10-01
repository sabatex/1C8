using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыРасчетаНачислений", Comment = "", Synonym = "Способы расчета начислений")]
    public enum СпособыРасчетаНачислений
    {
        [Description1C8(Name = "ПоМесячнойТарифнойСтавкеПоЧасам", Comment = "(Общ)", Synonym = "По месячной тарифной ставке по часам")]
        ПоМесячнойТарифнойСтавкеПоЧасам,
        [Description1C8(Name = "ПроизвольнаяФормула", Comment = "", Synonym = "Произвольная формула")]
        ПроизвольнаяФормула,
        [Description1C8(Name = "ПоМесячнойТарифнойСтавкеПоДням", Comment = "(Общ)", Synonym = "По месячной тарифной ставке")]
        ПоМесячнойТарифнойСтавкеПоДням,
        [Description1C8(Name = "ПоДневнойТарифнойСтавке", Comment = "(Общ)", Synonym = "По дневной тарифной ставке")]
        ПоДневнойТарифнойСтавке,
        [Description1C8(Name = "ПоЧасовойТарифнойСтавке", Comment = "(Общ)", Synonym = "По часовой тарифной ставке")]
        ПоЧасовойТарифнойСтавке,
        [Description1C8(Name = "ФиксированнойСуммой", Comment = "(Общ)", Synonym = "Фиксированной суммой")]
        ФиксированнойСуммой,
        [Description1C8(Name = "Процентом", Comment = "(Общ)", Synonym = "Процентом")]
        Процентом,
        [Description1C8(Name = "ИндексацияЗарплаты", Comment = "", Synonym = "Индексация зарплаты")]
        ИндексацияЗарплаты,
        [Description1C8(Name = "ДоплатаДоСреднегоЗаработка", Comment = "", Synonym = "Доплата до среднего заработка")]
        ДоплатаДоСреднегоЗаработка,
        [Description1C8(Name = "ДоплатаДоСреднегоЗаработкаФСС", Comment = "", Synonym = "Доплата до среднего заработка ФСС")]
        ДоплатаДоСреднегоЗаработкаФСС,
        [Description1C8(Name = "ОплатаБольничного", Comment = "", Synonym = "Оплата больничного")]
        ОплатаБольничного,
        [Description1C8(Name = "ОплатаОтпускаПоКалендарнымДням", Comment = "", Synonym = "Оплата отпуска по календарным дням")]
        ОплатаОтпускаПоКалендарнымДням,
        [Description1C8(Name = "ОплатаОтпускаПоШестидневке", Comment = "", Synonym = "По среднему заработку для отпуска при расчете из рабочих дней")]
        ОплатаОтпускаПоШестидневке,
        [Description1C8(Name = "ОплатаПростоя", Comment = "", Synonym = "Оплата простоя")]
        ОплатаПростоя,
        [Description1C8(Name = "ПособиеПоУходуЗаРебенкомДоПолутораЛет", Comment = "", Synonym = "Пособие по уходу за ребенком до 1.5 лет")]
        ПособиеПоУходуЗаРебенкомДоПолутораЛет,
        [Description1C8(Name = "ДоплатаДоСохраняемогоДенежногоСодержанияЗаДниБолезни", Comment = "", Synonym = "Доплата до сохраняемого денежного содержания за дни болезни")]
        ДоплатаДоСохраняемогоДенежногоСодержанияЗаДниБолезни,
        [Description1C8(Name = "ДоплатаДоМЗП", Comment = "", Synonym = "Доплата до МЗП")]
        ДоплатаДоМЗП,
        [Description1C8(Name = "ИндексацияСоциальныхНачислений", Comment = "", Synonym = "Индексация социальных начислений")]
        ИндексацияСоциальныхНачислений,
        [Description1C8(Name = "НулеваяСумма", Comment = "", Synonym = "Нулевая сумма")]
        НулеваяСумма,
        [Description1C8(Name = "Индексация", Comment = "", Synonym = "Индексация")]
        Индексация
    }
}
