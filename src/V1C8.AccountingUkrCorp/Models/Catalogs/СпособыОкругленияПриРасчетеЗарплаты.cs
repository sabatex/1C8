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
    [Table("SposobyOkruhlenyiaPryRascheteZarplaty")]
    [Description1C8(Name = "СпособыОкругленияПриРасчетеЗарплаты", Comment = "", Synonym = "Способы округления зарплаты")]
    public class СпособыОкругленияПриРасчетеЗарплаты:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Точность", Comment = "", Synonym = "Точность")]
    // Format 7.2
    public decimal Точность {get; set;}
    [Description1C8(Name = "ПравилоОкругления", Comment = "", Synonym = "Правило округления")]
    public Enums.ПравилаОкругленияПриРасчетеЗарплаты ПравилоОкругления {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
