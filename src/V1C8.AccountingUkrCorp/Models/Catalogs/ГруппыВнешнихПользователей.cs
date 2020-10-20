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
    [Table("HruppyVneshnykhPolzovatelei")]
    [Description1C8(Name = "ГруппыВнешнихПользователей", Comment = "", Synonym = "Группы внешних пользователей")]
    public class ГруппыВнешнихПользователей:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "УдалитьТипОбъектовАвторизации", Comment = "В качестве типа используется пустая ссылка", Synonym = "(не используется) Тип объектов авторизации")]
        [StringLength(10)]
        public string УдалитьТипОбъектовАвторизации {get; set;}
        [Description1C8(Name = "ВсеОбъектыАвторизации", Comment = "", Synonym = "Все")]
        public bool ВсеОбъектыАвторизации {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Состав", Comment = "", Synonym = "Участники группы")]
        public List<ГруппыВнешнихПользователей_Состав> ГруппыВнешнихПользователейСостав {get;set;}
        [Description1C8(Name = "Роли", Comment = "", Synonym = "Роли")]
        public List<ГруппыВнешнихПользователей_Роли> ГруппыВнешнихПользователейРоли {get;set;}
        [Description1C8(Name = "Назначение", Comment = "", Synonym = "Назначение")]
        public List<ГруппыВнешнихПользователей_Назначение> ГруппыВнешнихПользователейНазначение {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Состав", Comment = "", Synonym = "Участники группы")]
    [Table("HruppyVneshnykhPolzovatelei_Sostav")]
    public class ГруппыВнешнихПользователей_Состав
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "ВнешнийПользователь", Comment = "", Synonym = "Внешний пользователь")]
        public Catalogs.ВнешниеПользователи ВнешнийПользователь {get; set;}
    }
    [Description1C8(Name = "Роли", Comment = "", Synonym = "Роли")]
    [Table("HruppyVneshnykhPolzovatelei_Roly")]
    public class ГруппыВнешнихПользователей_Роли
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "Роль", Comment = "", Synonym = "Роль")]
        public Catalogs.ИдентификаторыОбъектовМетаданных Роль {get; set;}
        [Description1C8(Name = "УдалитьРоль", Comment = "", Synonym = "(не используется) Роль")]
        [StringLength(150)]
        public string УдалитьРоль {get; set;}
    }
    [Description1C8(Name = "Назначение", Comment = "", Synonym = "Назначение")]
    [Table("HruppyVneshnykhPolzovatelei_Naznachenye")]
    public class ГруппыВнешнихПользователей_Назначение
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "ТипПользователей", Comment = "", Synonym = "Тип пользователей")]
        [StringLength(10)]
        public string ТипПользователей {get; set;}
    }
}
