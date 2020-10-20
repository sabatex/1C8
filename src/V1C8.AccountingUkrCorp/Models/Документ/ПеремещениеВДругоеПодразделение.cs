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
    [Table("PeremeshchenyeVDruhoePodrazdelenye")]
    [Description1C8(Name = "ПеремещениеВДругоеПодразделение", Comment = "", Synonym = "Перемещение в другое подразделение")]
    public class ПеремещениеВДругоеПодразделение:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ДатаПеремещения", Comment = "", Synonym = "Дата перемещения")]
        public DateTime ДатаПеремещения {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ПодразделениеПрежнее", Comment = "", Synonym = "Подразделение прежнее")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеПрежнее {get; set;}
        [Description1C8(Name = "ОрганизацияНовая", Comment = "", Synonym = "Филиал (обособл. подр.)")]
        public Catalogs.Организации ОрганизацияНовая {get; set;}
        [Description1C8(Name = "ПодразделениеНовое", Comment = "", Synonym = "Подразделение новое")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеНовое {get; set;}
        [Description1C8(Name = "ПричинаПеревода", Comment = "", Synonym = "Причина перевода")]
        public string ПричинаПеревода {get; set;}
        [Description1C8(Name = "ОснованиеПеревода", Comment = "", Synonym = "Основание перевода")]
        [StringLength(254)]
        public string ОснованиеПеревода {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.ПеремещениеВДругоеПодразделение ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "Территория", Comment = "", Synonym = "Территория")]
        public Catalogs.ТерриторииВыполненияРабот Территория {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<ПеремещениеВДругоеПодразделение_Сотрудники> ПеремещениеВДругоеПодразделениеСотрудники {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<ПеремещениеВДругоеПодразделение_ФизическиеЛица> ПеремещениеВДругоеПодразделениеФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("PeremeshchenyeVDruhoePodrazdelenye_Sotrudnyky")]
    public class ПеремещениеВДругоеПодразделение_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
        [Description1C8(Name = "ДолжностьПоШтатномуРасписанию", Comment = "", Synonym = "Должность по штатному расписанию")]
        public Catalogs.ШтатноеРасписание ДолжностьПоШтатномуРасписанию {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Финансирование")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("PeremeshchenyeVDruhoePodrazdelenye_FyzycheskyeLytsa")]
    public class ПеремещениеВДругоеПодразделение_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
