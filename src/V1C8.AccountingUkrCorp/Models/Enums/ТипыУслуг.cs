using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыУслуг", Comment = "", Synonym = "Типы услуг")]
    public class ТипыУслуг:EnumItem
    {
        public static readonly ТипыУслуг Безлимитная = new ТипыУслуг{Name= "Безлимитная",Synonim="Безлимитная",Comment=""};
        public static readonly ТипыУслуг Лимитированная = new ТипыУслуг{Name= "Лимитированная",Synonim="Лимитированная",Comment=""};
        public static readonly ТипыУслуг Уникальная = new ТипыУслуг{Name= "Уникальная",Synonim="Уникальная",Comment=""};
    }
}
