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
    [Table("UstareloYzmenenyeParametrovRaschetaYndeksatsyyPoDolzhnostiam")]
    [Description1C8(Name = "УстарелоИзменениеПараметровРасчетаИндексацииПоДолжностям", Comment = "", Synonym = "ѳ(устарело) Изменение параметров расчета индексации (по должностям)")]
    public class УстарелоИзменениеПараметровРасчетаИндексацииПоДолжностям:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "УдалитьДокументОснование", Comment = "", Synonym = "Удалить документ основание")]
        public Документ.УдалитьКадровоеПеремещениеОрганизаций УдалитьДокументОснование {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ШтатныеЕдиницы", Comment = "", Synonym = "Штатные единицы")]
        public List<УстарелоИзменениеПараметровРасчетаИндексацииПоДолжностям_ШтатныеЕдиницы> УстарелоИзменениеПараметровРасчетаИндексацииПоДолжностямШтатныеЕдиницы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ШтатныеЕдиницы", Comment = "", Synonym = "Штатные единицы")]
    [Table("UstareloYzmenenyeParametrovRaschetaYndeksatsyyPoDolzhnostiam_ShtatnyeEdynytsy")]
    public class УстарелоИзменениеПараметровРасчетаИндексацииПоДолжностям_ШтатныеЕдиницы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДатаИзменения", Comment = "", Synonym = "Дата изменения")]
        public DateTime ДатаИзменения {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.УстарелоДолжности Должность {get; set;}
    }
}
