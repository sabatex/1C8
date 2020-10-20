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
    [Table("TaryfyPlatezhnykhAhentov")]
    [Description1C8(Name = "ТарифыПлатежныхАгентов", Comment = "", Synonym = "Тарифы платежных агентов")]
    public class ТарифыПлатежныхАгентов:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "ИспользуетсяШкала", Comment = "", Synonym = "Использовать шкалу")]
    public bool ИспользуетсяШкала {get; set;}
    [Description1C8(Name = "СпособВводаСуммы", Comment = "Способ ввода суммы по тарифу. 0 — процент взимается с полной суммы перевода, 1 — процент взимается с суммы перевода, превышающей предыдущий порог", Synonym = "Способ ввода суммы")]
    // Format 1.0
    public long СпособВводаСуммы {get; set;}
    #endregion реквізити
    #region tables
    [Description1C8(Name = "Шкала", Comment = "", Synonym = "Шкала")]
    public List<ТарифыПлатежныхАгентов_Шкала> ТарифыПлатежныхАгентовШкала
    #endregion tables
    }
}
