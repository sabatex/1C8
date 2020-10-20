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
    [Table("RodstvennykyFyzycheskykhLyts")]
    [Description1C8(Name = "РодственникиФизическихЛиц", Comment = "", Synonym = "Родственники сотрудников")]
    public class РодственникиФизическихЛиц:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "СтепеньРодства", Comment = "", Synonym = "Степень родства")]
        public Catalogs.СтепениРодстваФизическихЛиц СтепеньРодства {get; set;}
        [Description1C8(Name = "ДатаРождения", Comment = "", Synonym = "Дата рождения")]
        public DateTime ДатаРождения {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
