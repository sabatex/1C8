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
    [Table("OtmenaDoplatyDoSrednehoZarabotka")]
    [Description1C8(Name = "ОтменаДоплатыДоСреднегоЗаработка", Comment = "", Synonym = "Отмена доплаты до среднего заработка")]
    public class ОтменаДоплатыДоСреднегоЗаработка:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаОтмены", Comment = "", Synonym = "Дата отмены")]
        public DateTime ДатаОтмены {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.ПриказНаДоплатуДоСреднегоЗаработка ДокументОснование {get; set;}
        [Description1C8(Name = "ОтменаДоплатыУтверждена", Comment = "", Synonym = "Отмена доплаты утверждена")]
        public bool ОтменаДоплатыУтверждена {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.ОтменаДоплатыДоСреднегоЗаработка ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "НачисленияСотрудника", Comment = "", Synonym = "Начисления сотрудника")]
        public List<ОтменаДоплатыДоСреднегоЗаработка_НачисленияСотрудника> ОтменаДоплатыДоСреднегоЗаработкаНачисленияСотрудника {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "НачисленияСотрудника", Comment = "", Synonym = "Начисления сотрудника")]
    [Table("OtmenaDoplatyDoSrednehoZarabotka_NachyslenyiaSotrudnyka")]
    public class ОтменаДоплатыДоСреднегоЗаработка_НачисленияСотрудника
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.3
        public decimal Размер {get; set;}
    }
}
