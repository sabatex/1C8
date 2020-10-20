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
    [Table("UstareloOsnovanyiaUvolnenyia")]
    [Description1C8(Name = "УстарелоОснованияУвольнения", Comment = "(Регл)", Synonym = "ѳ(устарело) Основания увольнения")]
    public class УстарелоОснованияУвольнения:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ТекстОснования", Comment = "", Synonym = "Текст основания")]
        [StringLength(250)]
        public string ТекстОснования {get; set;}
        [Description1C8(Name = "СтатьяЗакона", Comment = "Статья закона", Synonym = "Статья закона")]
        [StringLength(100)]
        public string СтатьяЗакона {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
