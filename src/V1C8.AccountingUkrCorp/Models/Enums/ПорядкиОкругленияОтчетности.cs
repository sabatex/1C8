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
    [Table("PoriadkyOkruhlenyiaOtchetnosty")]
    [Description1C8(Name = "ПорядкиОкругленияОтчетности", Comment = "(Общ)", Synonym = "Порядки округления отчетности")]
    public class ПорядкиОкругленияОтчетности:EnumItem
    {
        public static readonly ПорядкиОкругленияОтчетности Окр1 = new ПорядкиОкругленияОтчетности{Name= "Окр1",Synonym="1",Comment="(Общ)"};
        public static readonly ПорядкиОкругленияОтчетности Окр1000 = new ПорядкиОкругленияОтчетности{Name= "Окр1000",Synonym="1 000",Comment="(Общ)"};
        public static readonly ПорядкиОкругленияОтчетности Окр1000000 = new ПорядкиОкругленияОтчетности{Name= "Окр1000000",Synonym="1 000 000",Comment="(Общ)"};
    }
}
