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
    [Table("PoriadkyOkruhlenyia")]
    [Description1C8(Name = "ПорядкиОкругления", Comment = "(Общ)", Synonym = "Порядки округления")]
    public class ПорядкиОкругления:EnumItem
    {
        public static readonly ПорядкиОкругления Окр0_01 = new ПорядкиОкругления{Name= "Окр0_01",Synonym="0.01",Comment="(Общ)"};
        public static readonly ПорядкиОкругления Окр0_05 = new ПорядкиОкругления{Name= "Окр0_05",Synonym="0.05",Comment="(Общ)"};
        public static readonly ПорядкиОкругления Окр0_1 = new ПорядкиОкругления{Name= "Окр0_1",Synonym="0.1",Comment="(Общ)"};
        public static readonly ПорядкиОкругления Окр0_5 = new ПорядкиОкругления{Name= "Окр0_5",Synonym="0.5",Comment="(Общ)"};
        public static readonly ПорядкиОкругления Окр1 = new ПорядкиОкругления{Name= "Окр1",Synonym="1",Comment="(Общ)"};
        public static readonly ПорядкиОкругления Окр5 = new ПорядкиОкругления{Name= "Окр5",Synonym="5",Comment="(Общ)"};
        public static readonly ПорядкиОкругления Окр10 = new ПорядкиОкругления{Name= "Окр10",Synonym="10",Comment="(Общ)"};
        public static readonly ПорядкиОкругления Окр50 = new ПорядкиОкругления{Name= "Окр50",Synonym="50",Comment="(Общ)"};
        public static readonly ПорядкиОкругления Окр100 = new ПорядкиОкругления{Name= "Окр100",Synonym="100",Comment="(Общ)"};
    }
}
