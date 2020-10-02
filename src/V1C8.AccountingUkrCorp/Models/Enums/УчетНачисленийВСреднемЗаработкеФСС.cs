using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УчетНачисленийВСреднемЗаработкеФСС", Comment = "", Synonym = "Учет начислений в среднем заработке ФСС")]
    public class УчетНачисленийВСреднемЗаработкеФСС:EnumItem
    {
        public static readonly УчетНачисленийВСреднемЗаработкеФСС Включать = new УчетНачисленийВСреднемЗаработкеФСС{Name= "Включать",Synonim="Включать",Comment=""};
        public static readonly УчетНачисленийВСреднемЗаработкеФСС НеВключать = new УчетНачисленийВСреднемЗаработкеФСС{Name= "НеВключать",Synonim="Не включать",Comment=""};
    }
}
