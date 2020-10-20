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
    [Table("Nalohy")]
    [Description1C8(Name = "Налоги", Comment = "", Synonym = "Налоги")]
    public class Налоги:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Актуальность", Comment = "", Synonym = "Актуальность")]
        public bool Актуальность {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
