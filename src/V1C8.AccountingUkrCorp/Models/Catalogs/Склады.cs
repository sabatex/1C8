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
    [Table("Sklady")]
    [Description1C8(Name = "Склады", Comment = "", Synonym = "Склады (места хранения)")]
    public class Склады:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ТипЦенРозничнойТорговли", Comment = "(Общ)", Synonym = "Тип цен розничной торговли")]
        public Catalogs.ТипыЦенНоменклатуры ТипЦенРозничнойТорговли {get; set;}
        [Description1C8(Name = "ТипСклада", Comment = "", Synonym = "Тип склада")]
        public Enums.ТипыСкладов ТипСклада {get; set;}
        [Description1C8(Name = "ТерриторияПоКОАТУУ", Comment = "Название и код территории по КОАТУУ, на которой расположен склад (торговая точка)", Synonym = "Территория по КОАТУУ")]
        public Catalogs.КлассификаторКОАТУУ ТерриторияПоКОАТУУ {get; set;}
        [Description1C8(Name = "Местонахождение", Comment = "", Synonym = "Местонахождение")]
        public string Местонахождение {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<Склады_ДополнительныеРеквизиты> СкладыДополнительныеРеквизиты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("Sklady_DopolnytelnyeRekvyzyty")]
    public class Склады_ДополнительныеРеквизиты
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
