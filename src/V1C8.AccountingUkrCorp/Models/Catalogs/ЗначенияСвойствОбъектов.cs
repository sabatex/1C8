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
    [Table("ZnachenyiaSvoistvObektov")]
    [Description1C8(Name = "ЗначенияСвойствОбъектов", Comment = "", Synonym = "Дополнительные значения")]
    public class ЗначенияСвойствОбъектов:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Вес", Comment = "", Synonym = "Весовой коэффициент")]
    // Format 10.2
    public decimal Вес {get; set;}
    [Description1C8(Name = "ПолноеНаименование", Comment = "", Synonym = "Полное наименование")]
    public string ПолноеНаименование {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
