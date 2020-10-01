using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПоступлениеТоваровУслуг", Comment = "(Общ)", Synonym = "Виды операций документа 'Поступление товаров и услуг'")]
    public enum ВидыОперацийПоступлениеТоваровУслуг
    {
        [Description1C8(Name = "ПокупкаКомиссия", Comment = "(Общ)", Synonym = "Покупка, комиссия")]
        ПокупкаКомиссия,
        [Description1C8(Name = "ВПереработку", Comment = "(Общ)", Synonym = "В переработку")]
        ВПереработку,
        [Description1C8(Name = "Оборудование", Comment = "(Общ)", Synonym = "Оборудование")]
        Оборудование,
        [Description1C8(Name = "ОбъектыСтроительства", Comment = "", Synonym = "Объекты строительства")]
        ОбъектыСтроительства,
        [Description1C8(Name = "БланкиСтрогогоУчета", Comment = "", Synonym = "Бланки строгого учета")]
        БланкиСтрогогоУчета
    }
}
