using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыОперацийДоверенность", Comment = "", Synonym = "Виды операций доверенность")]
    public enum ВидыОперацийДоверенность
    {
        [Description1C8(Name = "Доверенность", Comment = "", Synonym = "Доверенность")]
        Доверенность,
        [Description1C8(Name = "ДоверенностьСтрогогоУчета", Comment = "", Synonym = "Доверенность строгого учета")]
        ДоверенностьСтрогогоУчета
    }
}
