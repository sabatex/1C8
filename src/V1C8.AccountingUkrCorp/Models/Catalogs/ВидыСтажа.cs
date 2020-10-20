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
    [Description1C8(Name = "КатегорияСтажа", Comment = "", Synonym = "Категория стажа")]
    public Enums.КатегорииСтажа КатегорияСтажа {get; set;}
    #endregion реквізити
    }
}
