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
    [Table("PostavshchykyUsluhServysa")]
    [Description1C8(Name = "ПоставщикиУслугСервиса", Comment = "", Synonym = "Поставщики услуг сервиса")]
    public class ПоставщикиУслугСервиса:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Идентификатор", Comment = "", Synonym = "Идентификатор")]
        [StringLength(50)]
        public string Идентификатор {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
