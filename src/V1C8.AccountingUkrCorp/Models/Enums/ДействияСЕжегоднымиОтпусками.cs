using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДействияСЕжегоднымиОтпусками", Comment = "", Synonym = "Действия с ежегодными отпусками")]
    public class ДействияСЕжегоднымиОтпусками:EnumItem
    {
        public static readonly ДействияСЕжегоднымиОтпусками Утвердить = new ДействияСЕжегоднымиОтпусками{Name= "Утвердить",Synonim="Утвердить",Comment=""};
        public static readonly ДействияСЕжегоднымиОтпусками Отменить = new ДействияСЕжегоднымиОтпусками{Name= "Отменить",Synonim="Отменить",Comment=""};
    }
}
