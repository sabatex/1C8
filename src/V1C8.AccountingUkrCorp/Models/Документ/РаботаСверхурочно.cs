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
    [Table("RabotaSverkhurochno")]
    [Description1C8(Name = "РаботаСверхурочно", Comment = "", Synonym = "Работа сверхурочно")]
    public class РаботаСверхурочно:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Период регистрации")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Причина", Comment = "", Synonym = "Причина")]
        public string Причина {get; set;}
        [Description1C8(Name = "СогласиеПолучено", Comment = "", Synonym = "Согласие на сверхурочную работу получено")]
        public bool СогласиеПолучено {get; set;}
        [Description1C8(Name = "ДатаНачалаСобытия", Comment = "Дата начала события", Synonym = "Дата начала события")]
        public DateTime ДатаНачалаСобытия {get; set;}
        [Description1C8(Name = "ВремяУчтено", Comment = "", Synonym = "Время учтено")]
        public bool ВремяУчтено {get; set;}
        [Description1C8(Name = "ВремяУчел", Comment = "", Synonym = "Время учел")]
        public Catalogs.Пользователи ВремяУчел {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Приказ оформил")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<РаботаСверхурочно_Сотрудники> РаботаСверхурочноСотрудники {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<РаботаСверхурочно_ФизическиеЛица> РаботаСверхурочноФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("RabotaSverkhurochno_Sotrudnyky")]
    public class РаботаСверхурочно_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Дата", Comment = "", Synonym = "Дата")]
        public DateTime Дата {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "Отработано часов")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "СпособКомпенсацииПереработки", Comment = "", Synonym = "Способ компенсации")]
        public Enums.СпособыКомпенсацииПереработки СпособКомпенсацииПереработки {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("RabotaSverkhurochno_FyzycheskyeLytsa")]
    public class РаботаСверхурочно_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
