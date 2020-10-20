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
    [Table("PapkyFailov")]
    [Description1C8(Name = "ПапкиФайлов", Comment = "Структура папок для хранения файлов", Synonym = "Папки")]
    public class ПапкиФайлов:CatalogItem
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
    [Description1C8(Name = "Описание", Comment = "", Synonym = "Описание")]
    public string Описание {get; set;}
    [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
    public Catalogs.Пользователи Ответственный {get; set;}
    [Description1C8(Name = "ДатаСоздания", Comment = "", Synonym = "Дата создания")]
    public DateTime ДатаСоздания {get; set;}
    #endregion реквізити
    }
}
