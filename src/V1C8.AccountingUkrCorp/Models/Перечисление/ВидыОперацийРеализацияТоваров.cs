using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийРеализацияТоваров", Comment = "(Общ)", Synonym = "Виды операций документа 'Реализация товаров и услуг'")]
    public enum ВидыОперацийРеализацияТоваров
    {
        [Description1C8(Name = "ПродажаКомиссия", Comment = "", Synonym = "Продажа, комиссия")]
        ПродажаКомиссия,
        [Description1C8(Name = "Оборудование", Comment = "", Synonym = "Оборудование")]
        Оборудование
    }
}
