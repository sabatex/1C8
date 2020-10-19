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
    [Table("VydyOperatsyiRealyzatsyiaTovarov")]
    [Description1C8(Name = "ВидыОперацийРеализацияТоваров", Comment = "(Общ)", Synonym = "Виды операций документа 'Реализация товаров и услуг'")]
    public class ВидыОперацийРеализацияТоваров:EnumItem
    {
        public static readonly ВидыОперацийРеализацияТоваров ПродажаКомиссия = new ВидыОперацийРеализацияТоваров{Name= "ПродажаКомиссия",Synonym="Продажа, комиссия",Comment=""};
        public static readonly ВидыОперацийРеализацияТоваров Оборудование = new ВидыОперацийРеализацияТоваров{Name= "Оборудование",Synonym="Оборудование",Comment=""};
    }
}
