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
        public List<ГруппыДоступа_Пользователи> ГруппыДоступаПользователи {get;set;}
        [Description1C8(Name = "ВидыДоступа", Comment = "", Synonym = "Виды доступа")]
        public List<ГруппыДоступа_ВидыДоступа> ГруппыДоступаВидыДоступа {get;set;}
        [Description1C8(Name = "ЗначенияДоступа", Comment = "", Synonym = "Значения доступа")]
        public List<ГруппыДоступа_ЗначенияДоступа> ГруппыДоступаЗначенияДоступа {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Пользователи", Comment = "", Synonym = "Пользователи")]
    [Table("HruppyDostupa_Polzovately")]
    public class ГруппыДоступа_Пользователи
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "Пользователь", Comment = "", Synonym = "Пользователь")]
        public Catalogs.ВнешниеПользователи Пользователь {get; set;}
    }
    [Description1C8(Name = "ВидыДоступа", Comment = "", Synonym = "Виды доступа")]
    [Table("HruppyDostupa_VydyDostupa")]
    public class ГруппыДоступа_ВидыДоступа
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "ВидДоступа", Comment = "Представлен пустой ссылкой основного типа значений", Synonym = "Вид доступа")]
        public Catalogs.ПапкиФайлов ВидДоступа {get; set;}
        [Description1C8(Name = "ВсеРазрешены", Comment = "", Synonym = "Все разрешены")]
        public bool ВсеРазрешены {get; set;}
    }
    [Description1C8(Name = "ЗначенияДоступа", Comment = "", Synonym = "Значения доступа")]
    [Table("HruppyDostupa_ZnachenyiaDostupa")]
    public class ГруппыДоступа_ЗначенияДоступа
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "ВидДоступа", Comment = "Представлен пустой ссылкой основного типа значений", Synonym = "Вид доступа")]
        public Catalogs.ПапкиФайлов ВидДоступа {get; set;}
        [Description1C8(Name = "ЗначениеДоступа", Comment = "", Synonym = "Значение доступа")]
        public Catalogs.ПапкиФайлов ЗначениеДоступа {get; set;}
    }
}
