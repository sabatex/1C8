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
    [Table("NemateryalnyeAktyvy")]
    [Description1C8(Name = "НематериальныеАктивы", Comment = "", Synonym = "Нематериальные активы")]
    public class НематериальныеАктивы:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "НаименованиеПолное", Comment = "", Synonym = "Полное наименование")]
        [StringLength(1000)]
        public string НаименованиеПолное {get; set;}
        [Description1C8(Name = "ПрочиеСведения", Comment = "", Synonym = "Прочие сведения")]
        public string ПрочиеСведения {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<НематериальныеАктивы_ДополнительныеРеквизиты> НематериальныеАктивыДополнительныеРеквизиты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("NemateryalnyeAktyvy_DopolnytelnyeRekvyzyty")]
    public class НематериальныеАктивы_ДополнительныеРеквизиты
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
