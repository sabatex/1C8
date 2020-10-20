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
    [Table("ProfylyHruppDostupa")]
    [Description1C8(Name = "ПрофилиГруппДоступа", Comment = "", Synonym = "Профили групп доступа")]
    public class ПрофилиГруппДоступа:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ИдентификаторПоставляемыхДанных", Comment = "", Synonym = "Идентификатор поставляемых данных")]
        public Guid ИдентификаторПоставляемыхДанных {get; set;}
        [Description1C8(Name = "ПоставляемыйПрофильИзменен", Comment = "", Synonym = "Поставляемый профиль изменен")]
        public bool ПоставляемыйПрофильИзменен {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Роли", Comment = "", Synonym = "Роли")]
        public List<ПрофилиГруппДоступа_Роли> ПрофилиГруппДоступаРоли {get;set;}
        [Description1C8(Name = "ВидыДоступа", Comment = "", Synonym = "Виды доступа")]
        public List<ПрофилиГруппДоступа_ВидыДоступа> ПрофилиГруппДоступаВидыДоступа {get;set;}
        [Description1C8(Name = "ЗначенияДоступа", Comment = "", Synonym = "Значения доступа")]
        public List<ПрофилиГруппДоступа_ЗначенияДоступа> ПрофилиГруппДоступаЗначенияДоступа {get;set;}
        [Description1C8(Name = "Назначение", Comment = "", Synonym = "Назначение")]
        public List<ПрофилиГруппДоступа_Назначение> ПрофилиГруппДоступаНазначение {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Роли", Comment = "", Synonym = "Роли")]
    [Table("ProfylyHruppDostupa_Roly")]
    public class ПрофилиГруппДоступа_Роли
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Роль", Comment = "", Synonym = "Роль")]
        public Catalogs.ИдентификаторыОбъектовРасширений Роль {get; set;}
        [Description1C8(Name = "УдалитьРоль", Comment = "", Synonym = "(не используется) Роль")]
        [StringLength(150)]
        public string УдалитьРоль {get; set;}
    }
    [Description1C8(Name = "ВидыДоступа", Comment = "", Synonym = "Виды доступа")]
    [Table("ProfylyHruppDostupa_VydyDostupa")]
    public class ПрофилиГруппДоступа_ВидыДоступа
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидДоступа", Comment = "Представлен пустой ссылкой основного типа значений", Synonym = "Вид доступа")]
        public Catalogs.ПапкиФайлов ВидДоступа {get; set;}
        [Description1C8(Name = "Предустановленный", Comment = "", Synonym = "Предустановленный")]
        public bool Предустановленный {get; set;}
        [Description1C8(Name = "ВсеРазрешены", Comment = "", Synonym = "Все разрешены")]
        public bool ВсеРазрешены {get; set;}
    }
    [Description1C8(Name = "ЗначенияДоступа", Comment = "", Synonym = "Значения доступа")]
    [Table("ProfylyHruppDostupa_ZnachenyiaDostupa")]
    public class ПрофилиГруппДоступа_ЗначенияДоступа
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидДоступа", Comment = "Представлен пустой ссылкой основного типа значений", Synonym = "Вид доступа")]
        public Catalogs.ПапкиФайлов ВидДоступа {get; set;}
        [Description1C8(Name = "ЗначениеДоступа", Comment = "", Synonym = "Значение доступа")]
        public Catalogs.ПапкиФайлов ЗначениеДоступа {get; set;}
    }
    [Description1C8(Name = "Назначение", Comment = "", Synonym = "Назначение")]
    [Table("ProfylyHruppDostupa_Naznachenye")]
    public class ПрофилиГруппДоступа_Назначение
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ТипПользователей", Comment = "", Synonym = "Тип пользователей")]
        public Catalogs.Пользователи ТипПользователей {get; set;}
    }
}
