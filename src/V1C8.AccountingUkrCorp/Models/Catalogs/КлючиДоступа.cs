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
    [Table("KliuchyDostupa")]
    [Description1C8(Name = "КлючиДоступа", Comment = "", Synonym = "Ключи доступа")]
    public class КлючиДоступа:CatalogItem
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
    [Description1C8(Name = "Список", Comment = "", Synonym = "Список")]
    public Catalogs.ИдентификаторыОбъектовМетаданных Список {get; set;}
    [Description1C8(Name = "ДляВнешнихПользователей", Comment = "", Synonym = "Для внешних пользователей")]
    public bool ДляВнешнихПользователей {get; set;}
    [Description1C8(Name = "Хеш", Comment = "", Synonym = "Хеш")]
    // Format 10.0
    public long Хеш {get; set;}
    [Description1C8(Name = "СоставПолей", Comment = "", Synonym = "Состав полей")]
    // Format 17.0
    public long СоставПолей {get; set;}
    [Description1C8(Name = "Значение1", Comment = "", Synonym = "Значение 1")]
    public Catalogs.ПапкиФайлов Значение1 {get; set;}
    [Description1C8(Name = "Значение2", Comment = "", Synonym = "Значение 2")]
    public Catalogs.ПапкиФайлов Значение2 {get; set;}
    [Description1C8(Name = "Значение3", Comment = "", Synonym = "Значение 3")]
    public Catalogs.ПапкиФайлов Значение3 {get; set;}
    [Description1C8(Name = "Значение4", Comment = "", Synonym = "Значение 4")]
    public Catalogs.ПапкиФайлов Значение4 {get; set;}
    [Description1C8(Name = "Значение5", Comment = "", Synonym = "Значение 5")]
    public Catalogs.ПапкиФайлов Значение5 {get; set;}
    #endregion реквізити
    }
}
