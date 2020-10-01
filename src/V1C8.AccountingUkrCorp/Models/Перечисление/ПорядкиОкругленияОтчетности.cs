using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядкиОкругленияОтчетности", Comment = "(Общ)", Synonym = "Порядки округления отчетности")]
    public enum ПорядкиОкругленияОтчетности
    {
        [Description1C8(Name = "Окр1", Comment = "(Общ)", Synonym = "1")]
        Окр1,
        [Description1C8(Name = "Окр1000", Comment = "(Общ)", Synonym = "1 000")]
        Окр1000,
        [Description1C8(Name = "Окр1000000", Comment = "(Общ)", Synonym = "1 000 000")]
        Окр1000000
    }
}
