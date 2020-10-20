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
    [Table("StranyMyra")]
    [Description1C8(Name = "СтраныМира", Comment = "", Synonym = "Страны мира")]
    public class СтраныМира:EnumItem
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
    [Description1C8(Name = "НаименованиеПолное", Comment = "", Synonym = "Наименование полное")]
    [StringLength(100)]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "КодАльфа2", Comment = "", Synonym = "Код альфа-2")]
    [StringLength(2)]
    public string КодАльфа2 {get; set;}
    [Description1C8(Name = "КодАльфа3", Comment = "", Synonym = "Код альфа-3")]
    [StringLength(3)]
    public string КодАльфа3 {get; set;}
    #endregion реквізити
    }
}
