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
    [Table("VydyDokumentovFyzycheskykhLyts")]
    [Description1C8(Name = "ВидыДокументовФизическихЛиц", Comment = "", Synonym = "Виды документов физических лиц")]
    public class ВидыДокументовФизическихЛиц:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "РеквизитДопУпорядочивания", Comment = "", Synonym = "Порядок")]
    // Format 5.0
    public long РеквизитДопУпорядочивания {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
