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
    [Table("Voenkomaty")]
    [Description1C8(Name = "Военкоматы", Comment = "", Synonym = "Военкоматы")]
    public class Военкоматы:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Адрес", Comment = "", Synonym = "Адрес")]
        [StringLength(256)]
        public string Адрес {get; set;}
        [Description1C8(Name = "АдресВнутреннееПредставление", Comment = "", Synonym = "Адрес внутреннее представление")]
        public string АдресВнутреннееПредставление {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
