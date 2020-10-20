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
    [Table("ProdlenyeKontraktaDohovora")]
    [Description1C8(Name = "ПродлениеКонтрактаДоговора", Comment = "", Synonym = "Продление контракта, договора")]
    public class ПродлениеКонтрактаДоговора:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаПродления", Comment = "", Synonym = "Дата продления")]
        public DateTime ДатаПродления {get; set;}
        [Description1C8(Name = "ТрудовойДоговорНомер", Comment = "", Synonym = "Номер")]
        [StringLength(13)]
        public string ТрудовойДоговорНомер {get; set;}
        [Description1C8(Name = "ТрудовойДоговорДата", Comment = "", Synonym = "Дата")]
        public DateTime ТрудовойДоговорДата {get; set;}
        [Description1C8(Name = "СрочныйДоговор", Comment = "", Synonym = "Срочный договор")]
        public bool СрочныйДоговор {get; set;}
        [Description1C8(Name = "ДатаЗавершенияТрудовогоДоговора", Comment = "", Synonym = "Дата завершения трудового договора")]
        public DateTime ДатаЗавершенияТрудовогоДоговора {get; set;}
        [Description1C8(Name = "ОснованиеСрочногоДоговора", Comment = "", Synonym = "Основание срочного договора")]
        public Catalogs.ОснованияЗаключенияСрочныхТрудовыхДоговоров ОснованиеСрочногоДоговора {get; set;}
        [Description1C8(Name = "СрокЗаключенияДоговора", Comment = "", Synonym = "Срок заключения договора")]
        [StringLength(300)]
        public string СрокЗаключенияДоговора {get; set;}
        [Description1C8(Name = "ОснованиеПредставителяНанимателя", Comment = "", Synonym = "Основание представителя нанимателя")]
        public string ОснованиеПредставителяНанимателя {get; set;}
        [Description1C8(Name = "ВидАктаГосоргана", Comment = "", Synonym = "Вид акта государственного органа")]
        [StringLength(100)]
        public string ВидАктаГосоргана {get; set;}
        [Description1C8(Name = "ОборудованиеРабочегоМеста", Comment = "", Synonym = "Оборудование рабочего места")]
        public string ОборудованиеРабочегоМеста {get; set;}
        [Description1C8(Name = "ИныеУсловияДоговора", Comment = "", Synonym = "Иные условия договора")]
        public string ИныеУсловияДоговора {get; set;}
        [Description1C8(Name = "ПредставительНанимателя", Comment = "", Synonym = "Представитель нанимателя")]
        public Catalogs.ФизическиеЛица ПредставительНанимателя {get; set;}
        [Description1C8(Name = "ДолжностьПредставителяНанимателя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьПредставителяНанимателя {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Documents.ПродлениеКонтрактаДоговора ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
