using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийСчетНаОплатуПоставщика", Comment = "(Общ)", Synonym = "Виды операций документа 'Счет на оплату поставщика'")]
    public enum ВидыОперацийСчетНаОплатуПоставщика
    {
        [Description1C8(Name = "ПокупкаКомиссия", Comment = "(Общ)", Synonym = "Покупка, комиссия")]
        ПокупкаКомиссия,
        [Description1C8(Name = "Оборудование", Comment = "(Общ)", Synonym = "Оборудование")]
        Оборудование,
        [Description1C8(Name = "ОбъектыСтроительства", Comment = "", Synonym = "Объекты строительства")]
        ОбъектыСтроительства
    }
}
