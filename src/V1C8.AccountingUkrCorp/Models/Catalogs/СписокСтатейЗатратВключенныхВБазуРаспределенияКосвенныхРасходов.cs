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
    [Table("SpysokStateiZatratVkliuchennykhVBazuRaspredelenyiaKosvennykhRaskhodov")]
    [Description1C8(Name = "СписокСтатейЗатратВключенныхВБазуРаспределенияКосвенныхРасходов", Comment = "", Synonym = "Список статей затрат, включенных в базу распределения косвенных расходов")]
    public class СписокСтатейЗатратВключенныхВБазуРаспределенияКосвенныхРасходов:CatalogItem
    {
        #region реквізити
        #endregion реквізити
        #region tables
        [Description1C8(Name = "СтатьиЗатрат", Comment = "", Synonym = "Статьи затрат")]
        public List<СписокСтатейЗатратВключенныхВБазуРаспределенияКосвенныхРасходов_СтатьиЗатрат> СписокСтатейЗатратВключенныхВБазуРаспределенияКосвенныхРасходовСтатьиЗатрат {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "СтатьиЗатрат", Comment = "", Synonym = "Статьи затрат")]
    [Table("SpysokStateiZatratVkliuchennykhVBazuRaspredelenyiaKosvennykhRaskhodov_StatyZatrat")]
    public class СписокСтатейЗатратВключенныхВБазуРаспределенияКосвенныхРасходов_СтатьиЗатрат
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СтатьяЗатрат", Comment = "", Synonym = "Статья затрат")]
        public Catalogs.СтатьиЗатрат СтатьяЗатрат {get; set;}
        [Description1C8(Name = "ВидЗатрат", Comment = "", Synonym = "Вид затрат")]
        public Enums.ВидыЗатрат ВидЗатрат {get; set;}
    }
}
