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
    [Table("NomeraHTD")]
    [Description1C8(Name = "НомераГТД", Comment = "", Synonym = "Номера ГТД")]
    public class НомераГТД:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Дата", Comment = "", Synonym = "Дата")]
        public DateTime Дата {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
