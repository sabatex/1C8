using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыНалоговыхГруппНА", Comment = "", Synonym = "Виды налоговых групп НА")]
    public class ВидыНалоговыхГруппНА:EnumItem
    {
        public static readonly ВидыНалоговыхГруппНА ДоНКУ = new ВидыНалоговыхГруппНА{Name= "ДоНКУ",Synonym="до 01.04.2011 (устаревшие)",Comment=""};
        public static readonly ВидыНалоговыхГруппНА ОС = new ВидыНалоговыхГруппНА{Name= "ОС",Synonym="ОС",Comment=""};
        public static readonly ВидыНалоговыхГруппНА НМА = new ВидыНалоговыхГруппНА{Name= "НМА",Synonym="НМА",Comment=""};
    }
}
