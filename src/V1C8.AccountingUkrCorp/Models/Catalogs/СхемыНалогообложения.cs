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
    [Table("SkhemyNalohooblozhenyia")]
    [Description1C8(Name = "СхемыНалогообложения", Comment = "", Synonym = "Схемы налогообложения")]
    public class СхемыНалогообложения:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "НалогНаПрибыль", Comment = "", Synonym = "Налог на прибыль")]
    public bool НалогНаПрибыль {get; set;}
    [Description1C8(Name = "НДС", Comment = "", Synonym = "НДС")]
    public bool НДС {get; set;}
    [Description1C8(Name = "ЕдиныйНалог", Comment = "", Synonym = "Единый налог")]
    public bool ЕдиныйНалог {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
