using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("VydyOperatsyiRKO")]
    [Description1C8(Name = "ВидыОперацийРКО", Comment = "(Общ)", Synonym = "Виды операций документа 'РКО'")]
    public class ВидыОперацийРКО:EnumItem
    {
        public static readonly ВидыОперацийРКО ОплатаПоставщику = new ВидыОперацийРКО{Name= "ОплатаПоставщику",Synonym="Оплата поставщику",Comment="(Общ)"};
        public static readonly ВидыОперацийРКО ВозвратДенежныхСредствПокупателю = new ВидыОперацийРКО{Name= "ВозвратДенежныхСредствПокупателю",Synonym="Возврат покупателю",Comment="(Общ)"};
        public static readonly ВидыОперацийРКО ВыдачаДенежныхСредствПодотчетнику = new ВидыОперацийРКО{Name= "ВыдачаДенежныхСредствПодотчетнику",Synonym="Выдача подотчетному лицу",Comment="(Общ)"};
        public static readonly ВидыОперацийРКО ВыплатаЗаработнойПлатыПоВедомостям = new ВидыОперацийРКО{Name= "ВыплатаЗаработнойПлатыПоВедомостям",Synonym="Выплата заработной платы по ведомостям",Comment="(Общ)"};
        public static readonly ВидыОперацийРКО ВыплатаЗарплатыРаздатчиком = new ВидыОперацийРКО{Name= "ВыплатаЗарплатыРаздатчиком",Synonym="Выплата зарплаты раздатчиком",Comment=""};
        public static readonly ВидыОперацийРКО ВыплатаЗаработнойПлатыРаботнику = new ВидыОперацийРКО{Name= "ВыплатаЗаработнойПлатыРаботнику",Synonym="Выплата заработной платы работнику",Comment="(Общ)"};
        public static readonly ВидыОперацийРКО ВыдачаЗаймаСотруднику = new ВидыОперацийРКО{Name= "ВыдачаЗаймаСотруднику",Synonym="Выдача займа сотруднику",Comment=""};
        public static readonly ВидыОперацийРКО ВзносНаличнымиВБанк = new ВидыОперацийРКО{Name= "ВзносНаличнымиВБанк",Synonym="Взнос наличными в банк",Comment="(Общ)"};
        public static readonly ВидыОперацийРКО РасчетыПоКредитамИЗаймамСКонтрагентами = new ВидыОперацийРКО{Name= "РасчетыПоКредитамИЗаймамСКонтрагентами",Synonym="Расчеты по кредитам и займам",Comment=""};
        public static readonly ВидыОперацийРКО ИнкассацияДенежныхСредств = new ВидыОперацийРКО{Name= "ИнкассацияДенежныхСредств",Synonym="Инкассация",Comment=""};
        public static readonly ВидыОперацийРКО РасходДенежныхСредствПрочее = new ВидыОперацийРКО{Name= "РасходДенежныхСредствПрочее",Synonym="Прочий расход",Comment="(Общ)"};
    }
}
