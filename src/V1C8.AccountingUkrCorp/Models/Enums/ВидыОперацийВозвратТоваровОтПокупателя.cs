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
    [Table("VydyOperatsyiVozvratTovarovOtPokupatelia")]
    [Description1C8(Name = "ВидыОперацийВозвратТоваровОтПокупателя", Comment = "(Общ)", Synonym = "Виды операций документа 'Возврат товаров от покупателя'")]
    public class ВидыОперацийВозвратТоваровОтПокупателя:EnumItem
    {
        public static readonly ВидыОперацийВозвратТоваровОтПокупателя ПродажаКомиссия = new ВидыОперацийВозвратТоваровОтПокупателя{Name= "ПродажаКомиссия",Synonym="Продажа, комиссия",Comment=""};
        public static readonly ВидыОперацийВозвратТоваровОтПокупателя Оборудование = new ВидыОперацийВозвратТоваровОтПокупателя{Name= "Оборудование",Synonym="Оборудование",Comment=""};
    }
}
