using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДействияСНачислениямиИУдержаниями", Comment = "", Synonym = "Действия с начислениями и удержаниями")]
    public class ДействияСНачислениямиИУдержаниями:EnumItem
    {
        public static readonly ДействияСНачислениямиИУдержаниями Утвердить = new ДействияСНачислениямиИУдержаниями{Name= "Утвердить",Synonim="Утвердить",Comment=""};
        public static readonly ДействияСНачислениямиИУдержаниями Отменить = new ДействияСНачислениямиИУдержаниями{Name= "Отменить",Synonim="Отменить",Comment=""};
    }
}
