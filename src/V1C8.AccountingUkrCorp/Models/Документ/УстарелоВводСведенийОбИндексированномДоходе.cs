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
    [Table("UstareloVvodSvedenyiObYndeksyrovannomDokhode")]
    [Description1C8(Name = "УстарелоВводСведенийОбИндексированномДоходе", Comment = "(Регл) Входящая справка об индексированном доходе", Synonym = "ѳ(устарело) Ввод сведений об индексированном доходе")]
    public class УстарелоВводСведенийОбИндексированномДоходе:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Краткий состав документа")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Работники", Comment = "", Synonym = "Работники")]
        public List<УстарелоВводСведенийОбИндексированномДоходе_Работники> УстарелоВводСведенийОбИндексированномДоходеРаботники {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Работники", Comment = "", Synonym = "Работники")]
    [Table("UstareloVvodSvedenyiObYndeksyrovannomDokhode_Rabotnyky")]
    public class УстарелоВводСведенийОбИндексированномДоходе_Работники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаДействия", Comment = "", Synonym = "Дата действия")]
        public DateTime ДатаДействия {get; set;}
        [Description1C8(Name = "БазаИндексации", Comment = "", Synonym = "База индексации")]
        // Format 15.2
        public decimal БазаИндексации {get; set;}
        [Description1C8(Name = "Индексация", Comment = "", Synonym = "Индексация")]
        // Format 15.2
        public decimal Индексация {get; set;}
        [Description1C8(Name = "УдалитьСотрудник", Comment = "", Synonym = "(не используется) Сотрудник")]
        public Catalogs.Сотрудники УдалитьСотрудник {get; set;}
    }
}
