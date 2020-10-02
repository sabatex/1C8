using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийСписаниеТоваров", Comment = "(Общ)", Synonym = "Виды операций документа 'Списание товаров'")]
    public class ВидыОперацийСписаниеТоваров:EnumItem
    {
        public static readonly ВидыОперацийСписаниеТоваров ТоварыПродукция = new ВидыОперацийСписаниеТоваров{Name= "ТоварыПродукция",Synonim="Товары, продукция",Comment=""};
        public static readonly ВидыОперацийСписаниеТоваров Оборудование = new ВидыОперацийСписаниеТоваров{Name= "Оборудование",Synonim="Оборудование",Comment=""};
        public static readonly ВидыОперацийСписаниеТоваров БланкиСтрогогоУчета = new ВидыОперацийСписаниеТоваров{Name= "БланкиСтрогогоУчета",Synonim="Бланки строгого учета",Comment=""};
    }
}
