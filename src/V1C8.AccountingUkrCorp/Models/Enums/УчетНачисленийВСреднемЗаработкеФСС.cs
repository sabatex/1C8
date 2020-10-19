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
    [Table("UchetNachyslenyiVSrednemZarabotkeFSS")]
    [Description1C8(Name = "УчетНачисленийВСреднемЗаработкеФСС", Comment = "", Synonym = "Учет начислений в среднем заработке ФСС")]
    public class УчетНачисленийВСреднемЗаработкеФСС:EnumItem
    {
        public static readonly УчетНачисленийВСреднемЗаработкеФСС Включать = new УчетНачисленийВСреднемЗаработкеФСС{Name= "Включать",Synonym="Включать",Comment=""};
        public static readonly УчетНачисленийВСреднемЗаработкеФСС НеВключать = new УчетНачисленийВСреднемЗаработкеФСС{Name= "НеВключать",Synonym="Не включать",Comment=""};
    }
}
