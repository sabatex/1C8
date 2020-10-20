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
    [Table("VydyStazha")]
    [Description1C8(Name = "ВидыСтажа", Comment = "", Synonym = "Виды стажа")]
    public class ВидыСтажа:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "КатегорияСтажа", Comment = "", Synonym = "Категория стажа")]
        public Enums.КатегорииСтажа КатегорияСтажа {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
