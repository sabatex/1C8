using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПередачаТоваров", Comment = "(Общ)", Synonym = "Виды операций передача товаров")]
    public class ВидыОперацийПередачаТоваров:EnumItem
    {
        public static readonly ВидыОперацийПередачаТоваров ВПереработку = new ВидыОперацийПередачаТоваров{Name= "ВПереработку",Synonym="Передача сырья в переработку",Comment="(Общ)"};
        public static readonly ВидыОперацийПередачаТоваров ИзПереработки = new ВидыОперацийПередачаТоваров{Name= "ИзПереработки",Synonym="Передача продукции заказчику",Comment="(Общ)"};
    }
}
