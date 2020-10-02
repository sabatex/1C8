using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СпособыОценки", Comment = "(Регл)", Synonym = "Способы оценки")]
    public class СпособыОценки:EnumItem
    {
        public static readonly СпособыОценки ПоСредней = new СпособыОценки{Name= "ПоСредней",Synonim="По средней",Comment=""};
        public static readonly СпособыОценки ФИФО = new СпособыОценки{Name= "ФИФО",Synonim="ФИФО",Comment="First input, first output (первым пришел, первым обработан)"};
        public static readonly СпособыОценки ЛИФО = new СпособыОценки{Name= "ЛИФО",Synonim="ЛИФО",Comment="Last input, first output (последним пришел, первым обработан)"};
    }
}
