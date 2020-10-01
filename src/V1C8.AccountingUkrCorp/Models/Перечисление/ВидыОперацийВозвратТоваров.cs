using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийВозвратТоваров", Comment = "(Общ)", Synonym = "Виды операций возврат товаров")]
    public enum ВидыОперацийВозвратТоваров
    {
        [Description1C8(Name = "ИзПереработки", Comment = "(Общ)", Synonym = "Материалы из переработки")]
        ИзПереработки,
        [Description1C8(Name = "ОтЗаказчика", Comment = "(Общ)", Synonym = "Продукция от заказчика")]
        ОтЗаказчика
    }
}
