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
    [Table("RaschetyVozvrat")]
    [Description1C8(Name = "РасчетыВозврат", Comment = "(Общ)", Synonym = "Расчеты возврат")]
    public class РасчетыВозврат:EnumItem
    {
        public static readonly РасчетыВозврат Расчеты = new РасчетыВозврат{Name= "Расчеты",Synonym="Расчеты",Comment=""};
        public static readonly РасчетыВозврат Возврат = new РасчетыВозврат{Name= "Возврат",Synonym="Возврат",Comment=""};
    }
}
