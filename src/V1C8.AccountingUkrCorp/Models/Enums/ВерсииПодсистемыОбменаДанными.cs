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
    [Table("VersyyPodsystemyObmenaDannymy")]
    [Description1C8(Name = "ВерсииПодсистемыОбменаДанными", Comment = "", Synonym = "Версии подсистемы обмена данными")]
    public class ВерсииПодсистемыОбменаДанными:EnumItem
    {
        public static readonly ВерсииПодсистемыОбменаДанными Версия10 = new ВерсииПодсистемыОбменаДанными{Name= "Версия10",Synonym="Версия 1.0",Comment=""};
        public static readonly ВерсииПодсистемыОбменаДанными Версия20 = new ВерсииПодсистемыОбменаДанными{Name= "Версия20",Synonym="Версия 2.0",Comment=""};
        public static readonly ВерсииПодсистемыОбменаДанными Версия30 = new ВерсииПодсистемыОбменаДанными{Name= "Версия30",Synonym="Версия 3.0",Comment=""};
    }
}
