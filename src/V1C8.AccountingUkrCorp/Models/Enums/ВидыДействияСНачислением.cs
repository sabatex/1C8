using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДействияСНачислением", Comment = "(Общ)", Synonym = "Виды действия с начислением")]
    public class ВидыДействияСНачислением:EnumItem
    {
        public static readonly ВидыДействияСНачислением Начать = new ВидыДействияСНачислением{Name= "Начать",Synonim="Начать",Comment="(Общ)"};
        public static readonly ВидыДействияСНачислением Изменить = new ВидыДействияСНачислением{Name= "Изменить",Synonim="Изменить",Comment="(Общ)"};
        public static readonly ВидыДействияСНачислением НеИзменять = new ВидыДействияСНачислением{Name= "НеИзменять",Synonim="Не изменять",Comment="(Общ)"};
        public static readonly ВидыДействияСНачислением Прекратить = new ВидыДействияСНачислением{Name= "Прекратить",Synonim="Прекратить",Comment="(Общ)"};
    }
}
