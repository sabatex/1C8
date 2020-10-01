using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийВозвратТоваровПоставщику", Comment = "(Общ)", Synonym = "Виды операций документа 'Возврат товаров поставщику'")]
    public enum ВидыОперацийВозвратТоваровПоставщику
    {
        [Description1C8(Name = "ПокупкаКомиссия", Comment = "(Общ)", Synonym = "Покупка, комиссия")]
        ПокупкаКомиссия,
        [Description1C8(Name = "ИзПереработки", Comment = "(Общ)", Synonym = "Из переработки")]
        ИзПереработки,
        [Description1C8(Name = "Оборудование", Comment = "(Общ)", Synonym = "Оборудование")]
        Оборудование
    }
}
