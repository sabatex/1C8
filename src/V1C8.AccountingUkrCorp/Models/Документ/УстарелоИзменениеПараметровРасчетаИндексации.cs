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
    [Table("UstareloYzmenenyeParametrovRaschetaYndeksatsyy")]
    [Description1C8(Name = "УстарелоИзменениеПараметровРасчетаИндексации", Comment = "", Synonym = "ѳ(устарело) Изменение параметров расчета индексации")]
    public class УстарелоИзменениеПараметровРасчетаИндексации:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.УстарелоКадровыйПеревод ДокументОснование {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.УстарелоДолжности Должность {get; set;}
        [Description1C8(Name = "ФиксированнаяИндексация", Comment = "", Synonym = "Фиксированная индексация")]
        // Format 15.2
        public decimal ФиксированнаяИндексация {get; set;}
        [Description1C8(Name = "ДатаИзменения", Comment = "", Synonym = "Дата изменения")]
        public DateTime ДатаИзменения {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "НачисленияДо", Comment = "", Synonym = "Начисления до")]
        public List<УстарелоИзменениеПараметровРасчетаИндексации_НачисленияДо> УстарелоИзменениеПараметровРасчетаИндексацииНачисленияДо {get;set;}
        [Description1C8(Name = "НачисленияПосле", Comment = "", Synonym = "Начисления после")]
        public List<УстарелоИзменениеПараметровРасчетаИндексации_НачисленияПосле> УстарелоИзменениеПараметровРасчетаИндексацииНачисленияПосле {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "НачисленияДо", Comment = "", Synonym = "Начисления до")]
    [Table("UstareloYzmenenyeParametrovRaschetaYndeksatsyy_NachyslenyiaDo")]
    public class УстарелоИзменениеПараметровРасчетаИндексации_НачисленияДо
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.УстарелоНачисления Начисление {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 15.2
        public decimal Результат {get; set;}
    }
    [Description1C8(Name = "НачисленияПосле", Comment = "", Synonym = "Начисления после")]
    [Table("UstareloYzmenenyeParametrovRaschetaYndeksatsyy_NachyslenyiaPosle")]
    public class УстарелоИзменениеПараметровРасчетаИндексации_НачисленияПосле
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.УстарелоНачисления Начисление {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 15.2
        public decimal Результат {get; set;}
    }
}
