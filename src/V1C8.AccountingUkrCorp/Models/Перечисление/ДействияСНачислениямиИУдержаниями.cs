using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДействияСНачислениямиИУдержаниями", Comment = "", Synonym = "Действия с начислениями и удержаниями")]
    public enum ДействияСНачислениямиИУдержаниями
    {
        [Description1C8(Name = "Утвердить", Comment = "", Synonym = "Утвердить")]
        Утвердить,
        [Description1C8(Name = "Отменить", Comment = "", Synonym = "Отменить")]
        Отменить
    }
}
