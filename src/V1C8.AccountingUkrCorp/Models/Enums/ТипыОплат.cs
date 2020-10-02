using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ТипыОплат", Comment = "", Synonym = "Типы оплат")]
    public class ТипыОплат:EnumItem
    {
        public static readonly ТипыОплат Наличные = new ТипыОплат{Name= "Наличные",Synonim="Наличные",Comment=""};
        public static readonly ТипыОплат ПлатежнаяКарта = new ТипыОплат{Name= "ПлатежнаяКарта",Synonim="Платежная карта",Comment=""};
        public static readonly ТипыОплат БанковскийКредит = new ТипыОплат{Name= "БанковскийКредит",Synonim="Банковский кредит",Comment=""};
    }
}
