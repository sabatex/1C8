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
    [Table("KharakterPlanovohoNachyslenyia")]
    [Description1C8(Name = "ХарактерПлановогоНачисления", Comment = "", Synonym = "Характер планового начисления")]
    public class ХарактерПлановогоНачисления:EnumItem
    {
        public static readonly ХарактерПлановогоНачисления Штатное = new ХарактерПлановогоНачисления{Name= "Штатное",Synonym="Штатное",Comment=""};
        public static readonly ХарактерПлановогоНачисления Индивидуальное = new ХарактерПлановогоНачисления{Name= "Индивидуальное",Synonym="Индивидуальное",Comment=""};
    }
}
