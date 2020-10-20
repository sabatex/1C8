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
    [Table("VneshnyePolzovately")]
    [Description1C8(Name = "ВнешниеПользователи", Comment = "", Synonym = "Внешние пользователи")]
    public class ВнешниеПользователи
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
    [Description1C8(Name = "Недействителен", Comment = "", Synonym = "Недействителен")]
    public bool Недействителен {get; set;}
    [Description1C8(Name = "ОбъектАвторизации", Comment = "", Synonym = "Объект")]
    [StringLength(10)]
    public string ОбъектАвторизации {get; set;}
    [Description1C8(Name = "УстановитьРолиНепосредственно", Comment = "Используется, если не встроена подсистема 'Управление доступом'", Synonym = "Установить роли непосредственно")]
    public bool УстановитьРолиНепосредственно {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "Подготовлен", Comment = "", Synonym = "Подготовлен")]
    public bool Подготовлен {get; set;}
    [Description1C8(Name = "ИдентификаторПользователяИБ", Comment = "", Synonym = "Идентификатор пользователя ИБ")]
    public Guid ИдентификаторПользователяИБ {get; set;}
    [Description1C8(Name = "ИдентификаторПользователяСервиса", Comment = "", Synonym = "Идентификатор пользователя сервиса")]
    public Guid ИдентификаторПользователяСервиса {get; set;}
    [Description1C8(Name = "СвойстваПользователяИБ", Comment = "", Synonym = "Свойства пользователя ИБ")]
    // Сховище значень
    public byte[] СвойстваПользователяИБ {get; set;}
    [Description1C8(Name = "УдалитьПароль", Comment = "", Synonym = "(не используется) Пароль")]
    [StringLength(30)]
    public string УдалитьПароль {get; set;}
    #endregion реквізити
    }
}
