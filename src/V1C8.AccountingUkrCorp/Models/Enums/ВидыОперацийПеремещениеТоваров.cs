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
    [Table("VydyOperatsyiPeremeshchenyeTovarov")]
    [Description1C8(Name = "ВидыОперацийПеремещениеТоваров", Comment = "(Общ)", Synonym = "Виды операций документа 'Перемещение товаров'")]
    public class ВидыОперацийПеремещениеТоваров:EnumItem
    {
        public static readonly ВидыОперацийПеремещениеТоваров ТоварыПродукция = new ВидыОперацийПеремещениеТоваров{Name= "ТоварыПродукция",Synonym="Товары, продукция",Comment=""};
        public static readonly ВидыОперацийПеремещениеТоваров Оборудование = new ВидыОперацийПеремещениеТоваров{Name= "Оборудование",Synonym="Оборудование",Comment=""};
        public static readonly ВидыОперацийПеремещениеТоваров БланкиСтрогогоУчета = new ВидыОперацийПеремещениеТоваров{Name= "БланкиСтрогогоУчета",Synonym="Бланки строгого учета",Comment=""};
    }
}
