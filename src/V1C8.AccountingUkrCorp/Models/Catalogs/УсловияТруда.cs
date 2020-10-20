using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Catalogs
{
    [Table("UslovyiaTruda")]
    [Description1C8(Name = "УсловияТруда", Comment = "", Synonym = "Условия труда")]
    public class УсловияТруда:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ПроцентНадбавкиЗаВредность", Comment = "", Synonym = "% надбавки за вредность")]
        // Format 5.2
        public decimal ПроцентНадбавкиЗаВредность {get; set;}
        [Description1C8(Name = "ВыплачиваетсяНадбавкаЗаВредность", Comment = "", Synonym = "Выплачивается надбавка за вредность")]
        public bool ВыплачиваетсяНадбавкаЗаВредность {get; set;}
        [Description1C8(Name = "КоличествоДнейДополнительногоОтпускаВГод", Comment = "", Synonym = "Количество дней дополнительного отпуска за вредность (в год)")]
        // Format 2.0
        public long КоличествоДнейДополнительногоОтпускаВГод {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
