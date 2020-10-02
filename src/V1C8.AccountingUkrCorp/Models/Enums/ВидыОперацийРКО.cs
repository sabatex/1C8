using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийРКО", Comment = "(Общ)", Synonym = "Виды операций документа 'РКО'")]
    public class ВидыОперацийРКО:EnumItem
    {
        public static readonly ВидыОперацийРКО ОплатаПоставщику = new ВидыОперацийРКО{Name= "ОплатаПоставщику",Synonim="Оплата поставщику",Comment="(Общ)"};
        public static readonly ВидыОперацийРКО ВозвратДенежныхСредствПокупателю = new ВидыОперацийРКО{Name= "ВозвратДенежныхСредствПокупателю",Synonim="Возврат покупателю",Comment="(Общ)"};
        public static readonly ВидыОперацийРКО ВыдачаДенежныхСредствПодотчетнику = new ВидыОперацийРКО{Name= "ВыдачаДенежныхСредствПодотчетнику",Synonim="Выдача подотчетному лицу",Comment="(Общ)"};
        public static readonly ВидыОперацийРКО ВыплатаЗаработнойПлатыПоВедомостям = new ВидыОперацийРКО{Name= "ВыплатаЗаработнойПлатыПоВедомостям",Synonim="Выплата заработной платы по ведомостям",Comment="(Общ)"};
        public static readonly ВидыОперацийРКО ВыплатаЗарплатыРаздатчиком = new ВидыОперацийРКО{Name= "ВыплатаЗарплатыРаздатчиком",Synonim="Выплата зарплаты раздатчиком",Comment=""};
        public static readonly ВидыОперацийРКО ВыплатаЗаработнойПлатыРаботнику = new ВидыОперацийРКО{Name= "ВыплатаЗаработнойПлатыРаботнику",Synonim="Выплата заработной платы работнику",Comment="(Общ)"};
        public static readonly ВидыОперацийРКО ВыдачаЗаймаСотруднику = new ВидыОперацийРКО{Name= "ВыдачаЗаймаСотруднику",Synonim="Выдача займа сотруднику",Comment=""};
        public static readonly ВидыОперацийРКО ВзносНаличнымиВБанк = new ВидыОперацийРКО{Name= "ВзносНаличнымиВБанк",Synonim="Взнос наличными в банк",Comment="(Общ)"};
        public static readonly ВидыОперацийРКО РасчетыПоКредитамИЗаймамСКонтрагентами = new ВидыОперацийРКО{Name= "РасчетыПоКредитамИЗаймамСКонтрагентами",Synonim="Расчеты по кредитам и займам",Comment=""};
        public static readonly ВидыОперацийРКО ИнкассацияДенежныхСредств = new ВидыОперацийРКО{Name= "ИнкассацияДенежныхСредств",Synonim="Инкассация",Comment=""};
        public static readonly ВидыОперацийРКО РасходДенежныхСредствПрочее = new ВидыОперацийРКО{Name= "РасходДенежныхСредствПрочее",Synonim="Прочий расход",Comment="(Общ)"};
    }
}
