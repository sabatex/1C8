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
    public List<ПрофилиКлючевыхОпераций_КлючевыеОперацииПрофиля> ПрофилиКлючевыхОперацийКлючевыеОперацииПрофиля
    #endregion tables
    }
}
