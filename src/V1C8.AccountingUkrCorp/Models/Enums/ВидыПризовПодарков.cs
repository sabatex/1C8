using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыПризовПодарков", Comment = "", Synonym = "Виды призов и подарков")]
    public class ВидыПризовПодарков:EnumItem
    {
        public static readonly ВидыПризовПодарков Подарок = new ВидыПризовПодарков{Name= "Подарок",Synonim="Подарок",Comment=""};
        public static readonly ВидыПризовПодарков Приз = new ВидыПризовПодарков{Name= "Приз",Synonim="Приз, выигрыш в конкурсе",Comment=""};
    }
}
