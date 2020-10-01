using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПризовПодарков", Comment = "", Synonym = "Виды призов и подарков")]
    public enum ВидыПризовПодарков
    {
        [Description1C8(Name = "Подарок", Comment = "", Synonym = "Подарок")]
        Подарок,
        [Description1C8(Name = "Приз", Comment = "", Synonym = "Приз, выигрыш в конкурсе")]
        Приз
    }
}
