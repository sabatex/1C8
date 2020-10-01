using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыПредоставленияЗаймаСотруднику", Comment = "", Synonym = "Способы предоставления займа сотруднику")]
    public enum СпособыПредоставленияЗаймаСотруднику
    {
        [Description1C8(Name = "Единовременно", Comment = "", Synonym = "Единовременно")]
        Единовременно,
        [Description1C8(Name = "Траншами", Comment = "", Synonym = "Отдельными траншами")]
        Траншами
    }
}
