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
    [Table("VydyOperatsyiPostuplenyeTovarovUsluh")]
    [Description1C8(Name = "ВидыОперацийПоступлениеТоваровУслуг", Comment = "(Общ)", Synonym = "Виды операций документа 'Поступление товаров и услуг'")]
    public class ВидыОперацийПоступлениеТоваровУслуг:EnumItem
    {
        public static readonly ВидыОперацийПоступлениеТоваровУслуг ПокупкаКомиссия = new ВидыОперацийПоступлениеТоваровУслуг{Name= "ПокупкаКомиссия",Synonym="Покупка, комиссия",Comment="(Общ)"};
        public static readonly ВидыОперацийПоступлениеТоваровУслуг ВПереработку = new ВидыОперацийПоступлениеТоваровУслуг{Name= "ВПереработку",Synonym="В переработку",Comment="(Общ)"};
        public static readonly ВидыОперацийПоступлениеТоваровУслуг Оборудование = new ВидыОперацийПоступлениеТоваровУслуг{Name= "Оборудование",Synonym="Оборудование",Comment="(Общ)"};
        public static readonly ВидыОперацийПоступлениеТоваровУслуг ОбъектыСтроительства = new ВидыОперацийПоступлениеТоваровУслуг{Name= "ОбъектыСтроительства",Synonym="Объекты строительства",Comment=""};
        public static readonly ВидыОперацийПоступлениеТоваровУслуг БланкиСтрогогоУчета = new ВидыОперацийПоступлениеТоваровУслуг{Name= "БланкиСтрогогоУчета",Synonym="Бланки строгого учета",Comment=""};
    }
}
