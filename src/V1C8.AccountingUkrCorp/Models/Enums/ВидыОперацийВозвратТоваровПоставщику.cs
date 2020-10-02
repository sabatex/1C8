using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийВозвратТоваровПоставщику", Comment = "(Общ)", Synonym = "Виды операций документа 'Возврат товаров поставщику'")]
    public class ВидыОперацийВозвратТоваровПоставщику:EnumItem
    {
        public static readonly ВидыОперацийВозвратТоваровПоставщику ПокупкаКомиссия = new ВидыОперацийВозвратТоваровПоставщику{Name= "ПокупкаКомиссия",Synonym="Покупка, комиссия",Comment="(Общ)"};
        public static readonly ВидыОперацийВозвратТоваровПоставщику ИзПереработки = new ВидыОперацийВозвратТоваровПоставщику{Name= "ИзПереработки",Synonym="Из переработки",Comment="(Общ)"};
        public static readonly ВидыОперацийВозвратТоваровПоставщику Оборудование = new ВидыОперацийВозвратТоваровПоставщику{Name= "Оборудование",Synonym="Оборудование",Comment="(Общ)"};
    }
}
