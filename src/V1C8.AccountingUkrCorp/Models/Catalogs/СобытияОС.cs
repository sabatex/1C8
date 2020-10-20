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
    [Table("SobytyiaOS")]
    [Description1C8(Name = "СобытияОС", Comment = "", Synonym = "События ОС")]
    public class СобытияОС:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ВидСобытияОС", Comment = "", Synonym = "Вид события ОС")]
        public Enums.ВидыСобытийОС ВидСобытияОС {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
