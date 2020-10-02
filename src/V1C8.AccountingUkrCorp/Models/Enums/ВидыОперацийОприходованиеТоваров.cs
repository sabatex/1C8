using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийОприходованиеТоваров", Comment = "(Общ)", Synonym = "Виды операций документа 'Оприходование товаров'")]
    public class ВидыОперацийОприходованиеТоваров:EnumItem
    {
        public static readonly ВидыОперацийОприходованиеТоваров ТоварыПродукция = new ВидыОперацийОприходованиеТоваров{Name= "ТоварыПродукция",Synonim="Товары, продукция",Comment=""};
        public static readonly ВидыОперацийОприходованиеТоваров Оборудование = new ВидыОперацийОприходованиеТоваров{Name= "Оборудование",Synonim="Оборудование",Comment=""};
        public static readonly ВидыОперацийОприходованиеТоваров БланкиСтрогогоУчета = new ВидыОперацийОприходованиеТоваров{Name= "БланкиСтрогогоУчета",Synonim="Бланки строгого учета",Comment=""};
    }
}
