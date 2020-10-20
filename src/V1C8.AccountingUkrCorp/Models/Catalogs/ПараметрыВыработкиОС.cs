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
    [Table("ParametryVyrabotkyOS")]
    [Description1C8(Name = "ПараметрыВыработкиОС", Comment = "", Synonym = "Параметры выработки ОС")]
    public class ПараметрыВыработкиОС:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
