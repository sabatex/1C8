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
    [Table("PodtverzhdenyeOtkrytyiaLytsevykhSchetovSotrudnykov")]
    [Description1C8(Name = "ПодтверждениеОткрытияЛицевыхСчетовСотрудников", Comment = "", Synonym = "Подтверждение открытия счетов")]
    public class ПодтверждениеОткрытияЛицевыхСчетовСотрудников:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "МесяцОткрытия", Comment = "", Synonym = "Месяц открытия")]
        public DateTime МесяцОткрытия {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ПервичныйДокумент", Comment = "", Synonym = "Первичный документ")]
        public Documents.ЗаявкаНаОткрытиеЛицевыхСчетовСотрудников ПервичныйДокумент {get; set;}
        [Description1C8(Name = "ЗарплатныйПроект", Comment = "", Synonym = "Зарплатный проект")]
        public Catalogs.ЗарплатныеПроекты ЗарплатныйПроект {get; set;}
        [Description1C8(Name = "ХешФайла", Comment = "", Synonym = "Хеш файла")]
        [StringLength(40)]
        public string ХешФайла {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<ПодтверждениеОткрытияЛицевыхСчетовСотрудников_Сотрудники> ПодтверждениеОткрытияЛицевыхСчетовСотрудниковСотрудники {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("PodtverzhdenyeOtkrytyiaLytsevykhSchetovSotrudnykov_Sotrudnyky")]
    public class ПодтверждениеОткрытияЛицевыхСчетовСотрудников_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "НомерЛицевогоСчета", Comment = "", Synonym = "Номер лицевого счета")]
        [StringLength(20)]
        public string НомерЛицевогоСчета {get; set;}
        [Description1C8(Name = "РезультатОткрытияСчета", Comment = "", Synonym = "Результат открытия счета")]
        public Enums.РезультатыОткрытияЛицевыхСчетовСотрудников РезультатОткрытияСчета {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма первоначального пополнения")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "КомментарийРезультата", Comment = "", Synonym = "Комментарий результата")]
        public string КомментарийРезультата {get; set;}
    }
}
