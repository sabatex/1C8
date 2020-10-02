using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыРегистров", Comment = "", Synonym = "Типы регистров")]
    public class ТипыРегистров:EnumItem
    {
        public static readonly ТипыРегистров РегистрНакопления = new ТипыРегистров{Name= "РегистрНакопления",Synonim="Регистр накопления",Comment=""};
        public static readonly ТипыРегистров РегистрСведений = new ТипыРегистров{Name= "РегистрСведений",Synonim="Регистр сведений",Comment=""};
    }
}
