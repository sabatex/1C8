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
    [Table("UstareloKomandyrovkyOrhanyzatsyi")]
    [Description1C8(Name = "УстарелоКомандировкиОрганизаций", Comment = "(Регл)", Synonym = "ѳ(устарело) Командировки")]
    public class УстарелоКомандировкиОрганизаций:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "СтранаНазначения", Comment = "", Synonym = "Страна назначения")]
        public string СтранаНазначения {get; set;}
        [Description1C8(Name = "ОрганизацияНазначения", Comment = "", Synonym = "Организация назначения")]
        public string ОрганизацияНазначения {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "ОснованиеКомандировки", Comment = "", Synonym = "Основание командировки")]
        public string ОснованиеКомандировки {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Краткий состав документа")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
        public List<УстарелоКомандировкиОрганизаций_РаботникиОрганизации> УстарелоКомандировкиОрганизацийРаботникиОрганизации {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
    [Table("UstareloKomandyrovkyOrhanyzatsyi_RabotnykyOrhanyzatsyy")]
    public class УстарелоКомандировкиОрганизаций_РаботникиОрганизации
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "УдалитьПриказ", Comment = "", Synonym = "(не используется) Приказ")]
        public Документ.УдалитьПриемНаРаботуВОрганизацию УдалитьПриказ {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Цель", Comment = "", Synonym = "Цель")]
        public string Цель {get; set;}
        [Description1C8(Name = "ИсточникФинансирования", Comment = "", Synonym = "Источник финансирования")]
        public string ИсточникФинансирования {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
}
