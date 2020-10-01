using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПередачаТоваров", Comment = "(Общ)", Synonym = "Виды операций передача товаров")]
    public enum ВидыОперацийПередачаТоваров
    {
        [Description1C8(Name = "ВПереработку", Comment = "(Общ)", Synonym = "Передача сырья в переработку")]
        ВПереработку,
        [Description1C8(Name = "ИзПереработки", Comment = "(Общ)", Synonym = "Передача продукции заказчику")]
        ИзПереработки
    }
}
