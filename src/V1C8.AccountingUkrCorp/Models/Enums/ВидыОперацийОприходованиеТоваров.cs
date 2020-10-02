using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийОприходованиеТоваров", Comment = "(Общ)", Synonym = "Виды операций документа 'Оприходование товаров'")]
    public class ВидыОперацийОприходованиеТоваров:EnumItem
    {
        public static readonly ВидыОперацийОприходованиеТоваров ТоварыПродукция = new ВидыОперацийОприходованиеТоваров{Name= "ТоварыПродукция",Synonym="Товары, продукция",Comment=""};
        public static readonly ВидыОперацийОприходованиеТоваров Оборудование = new ВидыОперацийОприходованиеТоваров{Name= "Оборудование",Synonym="Оборудование",Comment=""};
        public static readonly ВидыОперацийОприходованиеТоваров БланкиСтрогогоУчета = new ВидыОперацийОприходованиеТоваров{Name= "БланкиСтрогогоУчета",Synonym="Бланки строгого учета",Comment=""};
    }
}
