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
    [Table("RazriadyKatehoryyDolzhnostei")]
    [Description1C8(Name = "РазрядыКатегорииДолжностей", Comment = "", Synonym = "Квалификационные разряды (категории)")]
    public class РазрядыКатегорииДолжностей:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "РеквизитДопУпорядочивания", Comment = "", Synonym = "Порядок")]
    // Format 5.0
    public long РеквизитДопУпорядочивания {get; set;}
    [Description1C8(Name = "НаименованиеПолное", Comment = "", Synonym = "Наименование полное")]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "ТарифнаяСетка", Comment = "", Synonym = "Тарифная сетка")]
    public Catalogs.ТарифныеСетки ТарифнаяСетка {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
