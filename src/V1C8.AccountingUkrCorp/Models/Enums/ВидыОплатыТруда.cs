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
    [Table("VydyOplatyTruda")]
    [Description1C8(Name = "ВидыОплатыТруда", Comment = "ФОТ неФОТ", Synonym = "Виды оплаты труда")]
    public class ВидыОплатыТруда:EnumItem
    {
        public static readonly ВидыОплатыТруда ФОТ = new ВидыОплатыТруда{Name= "ФОТ",Synonym="ФОТ",Comment="661"};
        public static readonly ВидыОплатыТруда НеФОТ = new ВидыОплатыТруда{Name= "НеФОТ",Synonym="Не ФОТ",Comment="663"};
    }
}
