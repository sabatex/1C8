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
    [Table("ParametrySynkhronyzatsyyV77")]
    [Description1C8(Name = "ПараметрыСинхронизацииV77", Comment = "", Synonym = "Параметры синхронизации с v7.7")]
    public class ПараметрыСинхронизацииV77:EnumItem
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
    [Description1C8(Name = "ИмяФайлаДанных", Comment = "", Synonym = "Имя файла данных")]
    public string ИмяФайлаДанных {get; set;}
    [Description1C8(Name = "НомерПоследнейЗагрузки", Comment = "", Synonym = "Номер последней загрузки")]
    public DBNull НомерПоследнейЗагрузки {get; set;}
    [Description1C8(Name = "ОтветственныйПользователь", Comment = "", Synonym = "Ответственный пользователь")]
    [StringLength(100)]
    public string ОтветственныйПользователь {get; set;}
    [Description1C8(Name = "АдресТаблицыСоответствий", Comment = "", Synonym = "Адрес таблицы соответствий")]
    [StringLength(250)]
    public string АдресТаблицыСоответствий {get; set;}
    #endregion реквізити
    }
}
