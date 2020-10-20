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
    [Table("HruppyDostupa")]
    [Description1C8(Name = "ГруппыДоступа", Comment = "", Synonym = "Группы доступа")]
    public class ГруппыДоступа:EnumItem
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
    [Description1C8(Name = "Профиль", Comment = "", Synonym = "Профиль")]
    public DBNull Профиль {get; set;}
    [Description1C8(Name = "Пользователь", Comment = "Только для персональных групп доступа", Synonym = "Пользователь")]
    public DBNull Пользователь {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
    public DBNull Ответственный {get; set;}
    [Description1C8(Name = "ОсновнаяГруппаДоступаПоставляемогоПрофиля", Comment = "", Synonym = "Основная группа доступа поставляемого профиля")]
    public bool ОсновнаяГруппаДоступаПоставляемогоПрофиля {get; set;}
    #endregion реквізити
    }
}
