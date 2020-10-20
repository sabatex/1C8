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
    [Table("ObektyStroytelstva")]
    [Description1C8(Name = "ОбъектыСтроительства", Comment = "", Synonym = "Объекты строительства")]
    public class ОбъектыСтроительства:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
    public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
