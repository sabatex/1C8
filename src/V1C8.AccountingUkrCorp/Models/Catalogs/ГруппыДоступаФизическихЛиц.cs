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
    [Table("HruppyDostupaFyzycheskykhLyts")]
    [Description1C8(Name = "ГруппыДоступаФизическихЛиц", Comment = "", Synonym = "Группы доступа физических лиц")]
    public class ГруппыДоступаФизическихЛиц:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ГруппаДоступа", Comment = "", Synonym = "Группа доступа")]
        public Catalogs.ГруппыДоступаФизическихЛиц ГруппаДоступа {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
