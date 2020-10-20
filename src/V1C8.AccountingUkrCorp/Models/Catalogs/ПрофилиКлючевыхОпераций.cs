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
    [Table("ProfylyKliuchevykhOperatsyi")]
    [Description1C8(Name = "ПрофилиКлючевыхОпераций", Comment = "", Synonym = "Профили ключевых операций")]
    public class ПрофилиКлючевыхОпераций:CatalogItem
    {
        #region реквізити
        #endregion реквізити
        #region tables
        [Description1C8(Name = "КлючевыеОперацииПрофиля", Comment = "", Synonym = "Ключевые операции профиля")]
        public List<ПрофилиКлючевыхОпераций_КлючевыеОперацииПрофиля> ПрофилиКлючевыхОперацийКлючевыеОперацииПрофиля {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "КлючевыеОперацииПрофиля", Comment = "", Synonym = "Ключевые операции профиля")]
    [Table("ProfylyKliuchevykhOperatsyi_KliuchevyeOperatsyyProfylia")]
    public class ПрофилиКлючевыхОпераций_КлючевыеОперацииПрофиля
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "КлючеваяОперация", Comment = "", Synonym = "Ключевая операция")]
        public Catalogs.КлючевыеОперации КлючеваяОперация {get; set;}
        [Description1C8(Name = "ЦелевоеВремя", Comment = "", Synonym = "Целевое время")]
        // Format 5.1
        public decimal ЦелевоеВремя {get; set;}
        [Description1C8(Name = "Приоритет", Comment = "", Synonym = "Приоритет")]
        // Format 5.0
        public long Приоритет {get; set;}
    }
}
