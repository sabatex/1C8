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
    public List<СписокСтатейЗатратВключенныхВБазуРаспределенияКосвенныхРасходов_СтатьиЗатрат> СписокСтатейЗатратВключенныхВБазуРаспределенияКосвенныхРасходовСтатьиЗатрат
    #endregion tables
    }
}
