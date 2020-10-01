using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийВозвратТоваровОтПокупателя", Comment = "(Общ)", Synonym = "Виды операций документа 'Возврат товаров от покупателя'")]
    public enum ВидыОперацийВозвратТоваровОтПокупателя
    {
        [Description1C8(Name = "ПродажаКомиссия", Comment = "", Synonym = "Продажа, комиссия")]
        ПродажаКомиссия,
        [Description1C8(Name = "Оборудование", Comment = "", Synonym = "Оборудование")]
        Оборудование
    }
}
