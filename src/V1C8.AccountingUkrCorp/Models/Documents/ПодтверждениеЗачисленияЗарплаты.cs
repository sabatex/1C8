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
    [Table("PodtverzhdenyeZachyslenyiaZarplaty")]
    [Description1C8(Name = "ПодтверждениеЗачисленияЗарплаты", Comment = "", Synonym = "Подтверждение зачисления зарплаты")]
    public class ПодтверждениеЗачисленияЗарплаты:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ПервичныйДокумент", Comment = "", Synonym = "Первичный документ")]
        public Documents.ВедомостьНаВыплатуЗарплатыВБанк ПервичныйДокумент {get; set;}
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
        public List<ПодтверждениеЗачисленияЗарплаты_Сотрудники> ПодтверждениеЗачисленияЗарплатыСотрудники {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("PodtverzhdenyeZachyslenyiaZarplaty_Sotrudnyky")]
    public class ПодтверждениеЗачисленияЗарплаты_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "НомерЛицевогоСчета", Comment = "", Synonym = "Номер лицевого счета")]
        [StringLength(20)]
        public string НомерЛицевогоСчета {get; set;}
        [Description1C8(Name = "РезультатЗачисленияЗарплаты", Comment = "", Synonym = "Результат зачисления зарплаты")]
        public Enums.РезультатыЗачисленияЗарплаты РезультатЗачисленияЗарплаты {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма зачисления")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "КомментарийРезультата", Comment = "", Synonym = "Комментарий результата")]
        public string КомментарийРезультата {get; set;}
    }
}
