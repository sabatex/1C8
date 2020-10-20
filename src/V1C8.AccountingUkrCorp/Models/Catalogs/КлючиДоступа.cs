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
    #region tables
    [Description1C8(Name = "Шапка", Comment = "", Synonym = "Шапка")]
    public List<КлючиДоступа_Шапка> КлючиДоступаШапка
    [Description1C8(Name = "ТабличнаяЧасть1", Comment = "", Synonym = "Табличная часть 1")]
    public List<КлючиДоступа_ТабличнаяЧасть1> КлючиДоступаТабличнаяЧасть1
    [Description1C8(Name = "ТабличнаяЧасть2", Comment = "", Synonym = "Табличная часть 2")]
    public List<КлючиДоступа_ТабличнаяЧасть2> КлючиДоступаТабличнаяЧасть2
    [Description1C8(Name = "ТабличнаяЧасть3", Comment = "", Synonym = "Табличная часть 3")]
    public List<КлючиДоступа_ТабличнаяЧасть3> КлючиДоступаТабличнаяЧасть3
    [Description1C8(Name = "ТабличнаяЧасть4", Comment = "", Synonym = "Табличная часть 4")]
    public List<КлючиДоступа_ТабличнаяЧасть4> КлючиДоступаТабличнаяЧасть4
    #endregion tables
    }
}
