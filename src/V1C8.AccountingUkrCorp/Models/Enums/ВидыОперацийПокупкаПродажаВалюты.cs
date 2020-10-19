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
    [Table("VydyOperatsyiPokupkaProdazhaValiuty")]
    [Description1C8(Name = "ВидыОперацийПокупкаПродажаВалюты", Comment = "(Регл)", Synonym = "Виды операций покупка/продажа валюты")]
    public class ВидыОперацийПокупкаПродажаВалюты:EnumItem
    {
        public static readonly ВидыОперацийПокупкаПродажаВалюты ПокупкаВалюты = new ВидыОперацийПокупкаПродажаВалюты{Name= "ПокупкаВалюты",Synonym="Покупка валюты",Comment=""};
        public static readonly ВидыОперацийПокупкаПродажаВалюты ПродажаВалюты = new ВидыОперацийПокупкаПродажаВалюты{Name= "ПродажаВалюты",Synonym="Продажа валюты",Comment=""};
    }
}
