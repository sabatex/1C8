using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ПорядкиОкругления", Comment = "(Общ)", Synonym = "Порядки округления")]
    public enum ПорядкиОкругления
    {
        [Description1C8(Name = "Окр0_01", Comment = "(Общ)", Synonym = "0.01")]
        Окр0_01,
        [Description1C8(Name = "Окр0_05", Comment = "(Общ)", Synonym = "0.05")]
        Окр0_05,
        [Description1C8(Name = "Окр0_1", Comment = "(Общ)", Synonym = "0.1")]
        Окр0_1,
        [Description1C8(Name = "Окр0_5", Comment = "(Общ)", Synonym = "0.5")]
        Окр0_5,
        [Description1C8(Name = "Окр1", Comment = "(Общ)", Synonym = "1")]
        Окр1,
        [Description1C8(Name = "Окр5", Comment = "(Общ)", Synonym = "5")]
        Окр5,
        [Description1C8(Name = "Окр10", Comment = "(Общ)", Synonym = "10")]
        Окр10,
        [Description1C8(Name = "Окр50", Comment = "(Общ)", Synonym = "50")]
        Окр50,
        [Description1C8(Name = "Окр100", Comment = "(Общ)", Synonym = "100")]
        Окр100
    }
}
