using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "БонусныеПрограммыБанков", Comment = "", Synonym = "Бонусные программы банков")]
    public enum БонусныеПрограммыБанков
    {
        [Description1C8(Name = "AE", Comment = "", Synonym = "Аэрофлот бонус")]
        AE,
        [Description1C8(Name = "GM", Comment = "", Synonym = "Золотая маска")]
        GM,
        [Description1C8(Name = "PG", Comment = "", Synonym = "Подари жизнь")]
        PG
    }
}
