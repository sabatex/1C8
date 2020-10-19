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
    [Table("TypyOplat")]
    [Description1C8(Name = "ТипыОплат", Comment = "", Synonym = "Типы оплат")]
    public class ТипыОплат:EnumItem
    {
        public static readonly ТипыОплат Наличные = new ТипыОплат{Name= "Наличные",Synonym="Наличные",Comment=""};
        public static readonly ТипыОплат ПлатежнаяКарта = new ТипыОплат{Name= "ПлатежнаяКарта",Synonym="Платежная карта",Comment=""};
        public static readonly ТипыОплат БанковскийКредит = new ТипыОплат{Name= "БанковскийКредит",Synonym="Банковский кредит",Comment=""};
    }
}
