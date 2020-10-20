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
    [Table("VydyRabotSotrudnykov")]
    [Description1C8(Name = "ВидыРаботСотрудников", Comment = "", Synonym = "Виды работ сотрудников")]
    public class ВидыРаботСотрудников:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "", Synonym = "Единица измерения")]
        [StringLength(10)]
        public string ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Трудоемкость", Comment = "", Synonym = "Трудоемкость")]
        // Format 15.3
        public decimal Трудоемкость {get; set;}
        [Description1C8(Name = "КратностьТрудоемкости", Comment = "", Synonym = "Кратность трудоемкости")]
        // Format 15.3
        public decimal КратностьТрудоемкости {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<ВидыРаботСотрудников_ДополнительныеРеквизиты> ВидыРаботСотрудниковДополнительныеРеквизиты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("VydyRabotSotrudnykov_DopolnytelnyeRekvyzyty")]
    public class ВидыРаботСотрудников_ДополнительныеРеквизиты
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
