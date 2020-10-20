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
    [Table("NaboryDopolnytelnykhRekvyzytovYSvedenyi")]
    [Description1C8(Name = "НаборыДополнительныхРеквизитовИСведений", Comment = "", Synonym = "Наборы дополнительных реквизитов и сведений")]
    public class НаборыДополнительныхРеквизитовИСведений:EnumItem
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
    [Description1C8(Name = "КоличествоРеквизитов", Comment = "", Synonym = "Количество реквизитов")]
    [StringLength(5)]
    public string КоличествоРеквизитов {get; set;}
    [Description1C8(Name = "КоличествоСведений", Comment = "", Synonym = "Количество сведений")]
    [StringLength(5)]
    public string КоличествоСведений {get; set;}
    [Description1C8(Name = "Используется", Comment = "", Synonym = "Используется")]
    public bool Используется {get; set;}
    #endregion реквізити
    }
}
