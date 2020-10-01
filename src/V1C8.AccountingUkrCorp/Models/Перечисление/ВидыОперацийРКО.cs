using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийРКО", Comment = "(Общ)", Synonym = "Виды операций документа 'РКО'")]
    public enum ВидыОперацийРКО
    {
        [Description1C8(Name = "ОплатаПоставщику", Comment = "(Общ)", Synonym = "Оплата поставщику")]
        ОплатаПоставщику,
        [Description1C8(Name = "ВозвратДенежныхСредствПокупателю", Comment = "(Общ)", Synonym = "Возврат покупателю")]
        ВозвратДенежныхСредствПокупателю,
        [Description1C8(Name = "ВыдачаДенежныхСредствПодотчетнику", Comment = "(Общ)", Synonym = "Выдача подотчетному лицу")]
        ВыдачаДенежныхСредствПодотчетнику,
        [Description1C8(Name = "ВыплатаЗаработнойПлатыПоВедомостям", Comment = "(Общ)", Synonym = "Выплата заработной платы по ведомостям")]
        ВыплатаЗаработнойПлатыПоВедомостям,
        [Description1C8(Name = "ВыплатаЗарплатыРаздатчиком", Comment = "", Synonym = "Выплата зарплаты раздатчиком")]
        ВыплатаЗарплатыРаздатчиком,
        [Description1C8(Name = "ВыплатаЗаработнойПлатыРаботнику", Comment = "(Общ)", Synonym = "Выплата заработной платы работнику")]
        ВыплатаЗаработнойПлатыРаботнику,
        [Description1C8(Name = "ВыдачаЗаймаСотруднику", Comment = "", Synonym = "Выдача займа сотруднику")]
        ВыдачаЗаймаСотруднику,
        [Description1C8(Name = "ВзносНаличнымиВБанк", Comment = "(Общ)", Synonym = "Взнос наличными в банк")]
        ВзносНаличнымиВБанк,
        [Description1C8(Name = "РасчетыПоКредитамИЗаймамСКонтрагентами", Comment = "", Synonym = "Расчеты по кредитам и займам")]
        РасчетыПоКредитамИЗаймамСКонтрагентами,
        [Description1C8(Name = "ИнкассацияДенежныхСредств", Comment = "", Synonym = "Инкассация")]
        ИнкассацияДенежныхСредств,
        [Description1C8(Name = "РасходДенежныхСредствПрочее", Comment = "(Общ)", Synonym = "Прочий расход")]
        РасходДенежныхСредствПрочее
    }
}
