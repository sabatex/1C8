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
    [Table("KlassyfykatorEdynytsYzmerenyia")]
    [Description1C8(Name = "КлассификаторЕдиницИзмерения", Comment = "(Общ)", Synonym = "Классификатор единиц измерения")]
    public class КлассификаторЕдиницИзмерения:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "НаименованиеПолное", Comment = "(Общ)", Synonym = "Полное наименование")]
        [StringLength(100)]
        public string НаименованиеПолное {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
