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
    [Table("NaboryHruppDostupa")]
    [Description1C8(Name = "НаборыГруппДоступа", Comment = "", Synonym = "Наборы групп доступа")]
    public class НаборыГруппДоступа:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ДляВнешнихПользователей", Comment = "", Synonym = "Для внешних пользователей")]
        public bool ДляВнешнихПользователей {get; set;}
        [Description1C8(Name = "ТипЭлементовНабора", Comment = "", Synonym = "Тип элементов набора")]
        public Catalogs.ГруппыДоступа ТипЭлементовНабора {get; set;}
        [Description1C8(Name = "НеИспользуетсяС", Comment = "", Synonym = "Не используется с")]
        public DateTime НеИспользуетсяС {get; set;}
        [Description1C8(Name = "Пользователь", Comment = "", Synonym = "Пользователь")]
        public Catalogs.ВнешниеПользователи Пользователь {get; set;}
        [Description1C8(Name = "РазрешенныйНаборГруппДоступа", Comment = "", Synonym = "Разрешенный набор групп доступа")]
        public Catalogs.НаборыГруппДоступа РазрешенныйНаборГруппДоступа {get; set;}
        [Description1C8(Name = "РазрешенныйНаборГруппПользователей", Comment = "", Synonym = "Разрешенный набор групп пользователей")]
        public Catalogs.НаборыГруппДоступа РазрешенныйНаборГруппПользователей {get; set;}
        [Description1C8(Name = "НовыйНаборГруппДоступа", Comment = "", Synonym = "Новый набор групп доступа")]
        public Catalogs.НаборыГруппДоступа НовыйНаборГруппДоступа {get; set;}
        [Description1C8(Name = "НовыйНаборГруппПользователей", Comment = "", Synonym = "Новый набор групп пользователей")]
        public Catalogs.НаборыГруппДоступа НовыйНаборГруппПользователей {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Группы", Comment = "", Synonym = "Группы")]
        public List<НаборыГруппДоступа_Группы> НаборыГруппДоступаГруппы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Группы", Comment = "", Synonym = "Группы")]
    [Table("NaboryHruppDostupa_Hruppy")]
    public class НаборыГруппДоступа_Группы
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "Группа", Comment = "", Synonym = "Группа")]
        public Catalogs.ГруппыДоступа Группа {get; set;}
    }
}
