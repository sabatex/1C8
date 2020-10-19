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
    [Table("VydyOperatsyiVozvratTovarov")]
    [Description1C8(Name = "ВидыОперацийВозвратТоваров", Comment = "(Общ)", Synonym = "Виды операций возврат товаров")]
    public class ВидыОперацийВозвратТоваров:EnumItem
    {
        public static readonly ВидыОперацийВозвратТоваров ИзПереработки = new ВидыОперацийВозвратТоваров{Name= "ИзПереработки",Synonym="Материалы из переработки",Comment="(Общ)"};
        public static readonly ВидыОперацийВозвратТоваров ОтЗаказчика = new ВидыОперацийВозвратТоваров{Name= "ОтЗаказчика",Synonym="Продукция от заказчика",Comment="(Общ)"};
    }
}
