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
    [Table("NomenklaturnyeHruppy")]
    [Description1C8(Name = "НоменклатурныеГруппы", Comment = "", Synonym = "Номенклатурные группы")]
    public class НоменклатурныеГруппы:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "НалоговоеНазначениеВПроизводстве", Comment = "", Synonym = "Нал. назн. (НДС) в производстве")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеВПроизводстве {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<НоменклатурныеГруппы_ДополнительныеРеквизиты> НоменклатурныеГруппыДополнительныеРеквизиты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("NomenklaturnyeHruppy_DopolnytelnyeRekvyzyty")]
    public class НоменклатурныеГруппы_ДополнительныеРеквизиты
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
