using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Documents
{
    [Table("RaspredelenyeOsnovnohoZarabotka")]
    [Description1C8(Name = "РаспределениеОсновногоЗаработка", Comment = "", Synonym = "Распределение основного заработка")]
    public class РаспределениеОсновногоЗаработка:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Месяц")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "РаспределениеОсновногоЗаработка", Comment = "", Synonym = "Распределение основного заработка")]
        public List<РаспределениеОсновногоЗаработка_РаспределениеОсновногоЗаработка> РаспределениеОсновногоЗаработкаРаспределениеОсновногоЗаработка {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РаспределениеОсновногоЗаработка", Comment = "", Synonym = "Распределение основного заработка")]
    [Table("RaspredelenyeOsnovnohoZarabotka_RaspredelenyeOsnovnohoZarabotka")]
    public class РаспределениеОсновногоЗаработка_РаспределениеОсновногоЗаработка
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "ДоляРаспределения", Comment = "", Synonym = "Доля распределения")]
        // Format 14.3
        public decimal ДоляРаспределения {get; set;}
    }
}
