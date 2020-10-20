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
    [Table("VydyRabotSotrudnykov")]
    [Description1C8(Name = "ВидыРаботСотрудников", Comment = "", Synonym = "Виды работ сотрудников")]
    public class ВидыРаботСотрудников:EnumItem
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
    [Description1C8(Name = "ЕдиницаИзмерения", Comment = "", Synonym = "Единица измерения")]
    [StringLength(10)]
    public string ЕдиницаИзмерения {get; set;}
    [Description1C8(Name = "Трудоемкость", Comment = "", Synonym = "Трудоемкость")]
    public DBNull Трудоемкость {get; set;}
    [Description1C8(Name = "КратностьТрудоемкости", Comment = "", Synonym = "Кратность трудоемкости")]
    public DBNull КратностьТрудоемкости {get; set;}
    #endregion реквізити
    }
}
