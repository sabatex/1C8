using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыКодовДляНалоговойНакладной", Comment = "", Synonym = "Виды кодов для налоговой накладной")]
    public class ВидыКодовДляНалоговойНакладной:EnumItem
    {
        public static readonly ВидыКодовДляНалоговойНакладной КодТовара = new ВидыКодовДляНалоговойНакладной{Name= "КодТовара",Synonim="Товар",Comment=""};
        public static readonly ВидыКодовДляНалоговойНакладной КодТовараИмпортированного = new ВидыКодовДляНалоговойНакладной{Name= "КодТовараИмпортированного",Synonim="Импортированный товар",Comment=""};
        public static readonly ВидыКодовДляНалоговойНакладной КодУслуги = new ВидыКодовДляНалоговойНакладной{Name= "КодУслуги",Synonim="Услуга",Comment=""};
    }
}
