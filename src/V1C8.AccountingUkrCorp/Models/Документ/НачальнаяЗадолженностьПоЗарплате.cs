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
    [Table("NachalnaiaZadolzhennostPoZarplate")]
    [Description1C8(Name = "НачальнаяЗадолженностьПоЗарплате", Comment = "", Synonym = "Начальная задолженность по зарплате")]
    public class НачальнаяЗадолженностьПоЗарплате:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Месяц", Comment = "", Synonym = "Месяц")]
        public DateTime Месяц {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ЗадолженностьПоЗарплате", Comment = "", Synonym = "Задолженность по зарплате")]
        public List<НачальнаяЗадолженностьПоЗарплате_ЗадолженностьПоЗарплате> НачальнаяЗадолженностьПоЗарплатеЗадолженностьПоЗарплате {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<НачальнаяЗадолженностьПоЗарплате_ФизическиеЛица> НачальнаяЗадолженностьПоЗарплатеФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ЗадолженностьПоЗарплате", Comment = "", Synonym = "Задолженность по зарплате")]
    [Table("NachalnaiaZadolzhennostPoZarplate_ZadolzhennostPoZarplate")]
    public class НачальнаяЗадолженностьПоЗарплате_ЗадолженностьПоЗарплате
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "СтатьяРасходов", Comment = "", Synonym = "Статья расходов")]
        public Catalogs.СтатьиРасходовЗарплата СтатьяРасходов {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 13.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ГруппаУчетаНачислений", Comment = "", Synonym = "Группа учета начислений")]
        public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчетаНачислений {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("NachalnaiaZadolzhennostPoZarplate_FyzycheskyeLytsa")]
    public class НачальнаяЗадолженностьПоЗарплате_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
