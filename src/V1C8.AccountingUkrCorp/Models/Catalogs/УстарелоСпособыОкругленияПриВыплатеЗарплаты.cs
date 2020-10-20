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
    [Table("UstareloSposobyOkruhlenyiaPryVyplateZarplaty")]
    [Description1C8(Name = "УстарелоСпособыОкругленияПриВыплатеЗарплаты", Comment = "", Synonym = "ѳ(устарело) Способы округления при выплате")]
    public class УстарелоСпособыОкругленияПриВыплатеЗарплаты:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Точность", Comment = "", Synonym = "Точность")]
        // Format 7.2
        public decimal Точность {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
