using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("VydyOperatsyiSpysanyeTovarov")]
    [Description1C8(Name = "ВидыОперацийСписаниеТоваров", Comment = "(Общ)", Synonym = "Виды операций документа 'Списание товаров'")]
    public class ВидыОперацийСписаниеТоваров:EnumItem
    {
        public static readonly ВидыОперацийСписаниеТоваров ТоварыПродукция = new ВидыОперацийСписаниеТоваров{Name= "ТоварыПродукция",Synonym="Товары, продукция",Comment=""};
        public static readonly ВидыОперацийСписаниеТоваров Оборудование = new ВидыОперацийСписаниеТоваров{Name= "Оборудование",Synonym="Оборудование",Comment=""};
        public static readonly ВидыОперацийСписаниеТоваров БланкиСтрогогоУчета = new ВидыОперацийСписаниеТоваров{Name= "БланкиСтрогогоУчета",Synonym="Бланки строгого учета",Comment=""};
    }
}
