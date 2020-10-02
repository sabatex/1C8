using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РасчетыВозврат", Comment = "(Общ)", Synonym = "Расчеты возврат")]
    public class РасчетыВозврат:EnumItem
    {
        public static readonly РасчетыВозврат Расчеты = new РасчетыВозврат{Name= "Расчеты",Synonim="Расчеты",Comment=""};
        public static readonly РасчетыВозврат Возврат = new РасчетыВозврат{Name= "Возврат",Synonim="Возврат",Comment=""};
    }
}
