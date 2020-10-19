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
    [Table("VydyOperatsyiDoverennost")]
    [Description1C8(Name = "ВидыОперацийДоверенность", Comment = "", Synonym = "Виды операций доверенность")]
    public class ВидыОперацийДоверенность:EnumItem
    {
        public static readonly ВидыОперацийДоверенность Доверенность = new ВидыОперацийДоверенность{Name= "Доверенность",Synonym="Доверенность",Comment=""};
        public static readonly ВидыОперацийДоверенность ДоверенностьСтрогогоУчета = new ВидыОперацийДоверенность{Name= "ДоверенностьСтрогогоУчета",Synonym="Доверенность строгого учета",Comment=""};
    }
}
