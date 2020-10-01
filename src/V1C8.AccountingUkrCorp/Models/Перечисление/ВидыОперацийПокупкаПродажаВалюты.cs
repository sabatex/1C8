using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийПокупкаПродажаВалюты", Comment = "(Регл)", Synonym = "Виды операций покупка/продажа валюты")]
    public enum ВидыОперацийПокупкаПродажаВалюты
    {
        [Description1C8(Name = "ПокупкаВалюты", Comment = "", Synonym = "Покупка валюты")]
        ПокупкаВалюты,
        [Description1C8(Name = "ПродажаВалюты", Comment = "", Synonym = "Продажа валюты")]
        ПродажаВалюты
    }
}
