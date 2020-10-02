using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПоступлениеТоваровУслуг", Comment = "(Общ)", Synonym = "Виды операций документа 'Поступление товаров и услуг'")]
    public class ВидыОперацийПоступлениеТоваровУслуг:EnumItem
    {
        public static readonly ВидыОперацийПоступлениеТоваровУслуг ПокупкаКомиссия = new ВидыОперацийПоступлениеТоваровУслуг{Name= "ПокупкаКомиссия",Synonim="Покупка, комиссия",Comment="(Общ)"};
        public static readonly ВидыОперацийПоступлениеТоваровУслуг ВПереработку = new ВидыОперацийПоступлениеТоваровУслуг{Name= "ВПереработку",Synonim="В переработку",Comment="(Общ)"};
        public static readonly ВидыОперацийПоступлениеТоваровУслуг Оборудование = new ВидыОперацийПоступлениеТоваровУслуг{Name= "Оборудование",Synonim="Оборудование",Comment="(Общ)"};
        public static readonly ВидыОперацийПоступлениеТоваровУслуг ОбъектыСтроительства = new ВидыОперацийПоступлениеТоваровУслуг{Name= "ОбъектыСтроительства",Synonim="Объекты строительства",Comment=""};
        public static readonly ВидыОперацийПоступлениеТоваровУслуг БланкиСтрогогоУчета = new ВидыОперацийПоступлениеТоваровУслуг{Name= "БланкиСтрогогоУчета",Synonim="Бланки строгого учета",Comment=""};
    }
}
