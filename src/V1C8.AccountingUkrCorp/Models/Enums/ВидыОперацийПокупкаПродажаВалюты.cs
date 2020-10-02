using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПокупкаПродажаВалюты", Comment = "(Регл)", Synonym = "Виды операций покупка/продажа валюты")]
    public class ВидыОперацийПокупкаПродажаВалюты:EnumItem
    {
        public static readonly ВидыОперацийПокупкаПродажаВалюты ПокупкаВалюты = new ВидыОперацийПокупкаПродажаВалюты{Name= "ПокупкаВалюты",Synonim="Покупка валюты",Comment=""};
        public static readonly ВидыОперацийПокупкаПродажаВалюты ПродажаВалюты = new ВидыОперацийПокупкаПродажаВалюты{Name= "ПродажаВалюты",Synonim="Продажа валюты",Comment=""};
    }
}
