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
    [Table("UstareloDolzhnosty")]
    [Description1C8(Name = "УстарелоДолжности", Comment = "", Synonym = "ѳ(устарело) Должности")]
    public class УстарелоДолжности:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "РеквизитДопУпорядочивания", Comment = "", Synonym = "Порядок")]
        // Format 5.0
        public long РеквизитДопУпорядочивания {get; set;}
        [Description1C8(Name = "КодКП", Comment = "Код (классификатор профессий)", Synonym = "Код по классификатору профессий")]
        [StringLength(10)]
        public string КодКП {get; set;}
        [Description1C8(Name = "ЯвляетсяШахтерскойДолжностью", Comment = "", Synonym = "Является шахтерской должностью")]
        public bool ЯвляетсяШахтерскойДолжностью {get; set;}
        [Description1C8(Name = "НаименованиеПоКП", Comment = "Наименование по классификатору профессий", Synonym = "Наименование по КП")]
        [StringLength(300)]
        public string НаименованиеПоКП {get; set;}
        [Description1C8(Name = "КодЗКППТР", Comment = "", Synonym = "Код ЗКППТР")]
        [StringLength(6)]
        public string КодЗКППТР {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<УстарелоДолжности_ДополнительныеРеквизиты> УстарелоДолжностиДополнительныеРеквизиты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("UstareloDolzhnosty_DopolnytelnyeRekvyzyty")]
    public class УстарелоДолжности_ДополнительныеРеквизиты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Свойство", Comment = "", Synonym = "Свойство")]
        public ПланВидовХарактеристик.ДополнительныеРеквизитыИСведения Свойство {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public Catalogs.Склады Значение {get; set;}
        [Description1C8(Name = "ТекстоваяСтрока", Comment = "", Synonym = "Текстовая строка")]
        public string ТекстоваяСтрока {get; set;}
    }
}
