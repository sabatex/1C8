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
    [Table("KatehoryyZastrakhovannykhLytsESV")]
    [Description1C8(Name = "КатегорииЗастрахованныхЛицЕСВ", Comment = "", Synonym = "Категории застрахованных лиц (ЕСВ)")]
    public class КатегорииЗастрахованныхЛицЕСВ:EnumItem
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
    [Description1C8(Name = "ВидЕСВ", Comment = "", Synonym = "Вид ЕСВ")]
    public DBNull ВидЕСВ {get; set;}
    #endregion реквізити
    }
}
