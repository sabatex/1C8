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
    [Table("YdentyfykatoryServysovSoprovozhdenyia")]
    [Description1C8(Name = "ИдентификаторыСервисовСопровождения", Comment = "", Synonym = "Идентификаторы сервисов сопровождения")]
    public class ИдентификаторыСервисовСопровождения:CatalogItem
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
    [Description1C8(Name = "URLОписание", Comment = "", Synonym = "URL описание")]
    public string URLОписание {get; set;}
    [Description1C8(Name = "URLУсловияПолучения", Comment = "", Synonym = "URL условия получения")]
    public string URLУсловияПолучения {get; set;}
    [Description1C8(Name = "ИдентификаторКартинки", Comment = "", Synonym = "Идентификатор картинки")]
    [StringLength(255)]
    public string ИдентификаторКартинки {get; set;}
    [Description1C8(Name = "ИдентификаторСервиса", Comment = "", Synonym = "Идентификатор сервиса")]
    [StringLength(255)]
    public string ИдентификаторСервиса {get; set;}
    [Description1C8(Name = "Описание", Comment = "", Synonym = "Описание")]
    [StringLength(150)]
    public string Описание {get; set;}
    #endregion реквізити
    }
}
