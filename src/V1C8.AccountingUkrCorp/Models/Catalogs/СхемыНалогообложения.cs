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
    #region Стандартні реквізити
    public Guid Id {get; set;}
    public bool IsFolder {get; set;}
    public bool DeletionMark {get; set;}
    public bool Predefined {get; set;}
    public string Code {get; set;}
    public string Description {get; set;}
    public Guid? Parent {get; set;}
    public Guid? Owner {get; set;}
    #endregion Стандартні реквізити
    #region реквізити
    [Description1C8(Name = "НалогНаПрибыль", Comment = "", Synonym = "Налог на прибыль")]
    public bool НалогНаПрибыль {get; set;}
    [Description1C8(Name = "НДС", Comment = "", Synonym = "НДС")]
    public bool НДС {get; set;}
    [Description1C8(Name = "ЕдиныйНалог", Comment = "", Synonym = "Единый налог")]
    public bool ЕдиныйНалог {get; set;}
    #endregion реквізити
    }
}
