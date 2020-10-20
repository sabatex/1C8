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
    [Table("PerenosOtpuska")]
    [Description1C8(Name = "ПереносОтпуска", Comment = "", Synonym = "Перенос отпуска")]
    public class ПереносОтпуска:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ВидОтпуска", Comment = "", Synonym = "Вид отпуска")]
        public Catalogs.ВидыОтпусков ВидОтпуска {get; set;}
        [Description1C8(Name = "ИсходнаяДатаНачала", Comment = "", Synonym = "Исходная дата начала")]
        public DateTime ИсходнаяДатаНачала {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "КоличествоДней", Comment = "", Synonym = "Количество дней")]
        // Format 3.0
        public long КоличествоДней {get; set;}
        [Description1C8(Name = "ПереносПоИнициативеСотрудника", Comment = "", Synonym = "Перенос по инициативе сотрудника")]
        public bool ПереносПоИнициативеСотрудника {get; set;}
        [Description1C8(Name = "ПричинаПереноса", Comment = "", Synonym = "Причина переноса")]
        public string ПричинаПереноса {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
