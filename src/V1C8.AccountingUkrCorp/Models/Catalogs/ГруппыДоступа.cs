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
    public class ГруппыДоступа:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Профиль", Comment = "", Synonym = "Профиль")]
    public Catalogs.ПрофилиГруппДоступа Профиль {get; set;}
    [Description1C8(Name = "Пользователь", Comment = "Только для персональных групп доступа", Synonym = "Пользователь")]
    public Catalogs.ВнешниеПользователи Пользователь {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
    public Catalogs.Пользователи Ответственный {get; set;}
    [Description1C8(Name = "ОсновнаяГруппаДоступаПоставляемогоПрофиля", Comment = "", Synonym = "Основная группа доступа поставляемого профиля")]
    public bool ОсновнаяГруппаДоступаПоставляемогоПрофиля {get; set;}
    #endregion реквізити
    #region tables
    [Description1C8(Name = "Пользователи", Comment = "", Synonym = "Пользователи")]
    public List<ГруппыДоступа_Пользователи> ГруппыДоступаПользователи
    [Description1C8(Name = "ВидыДоступа", Comment = "", Synonym = "Виды доступа")]
    public List<ГруппыДоступа_ВидыДоступа> ГруппыДоступаВидыДоступа
    [Description1C8(Name = "ЗначенияДоступа", Comment = "", Synonym = "Значения доступа")]
    public List<ГруппыДоступа_ЗначенияДоступа> ГруппыДоступаЗначенияДоступа
    #endregion tables
    }
}
