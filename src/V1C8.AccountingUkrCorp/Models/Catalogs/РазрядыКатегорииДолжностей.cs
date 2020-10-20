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
    public class РазрядыКатегорииДолжностей
    {
    #region Стандартні реквізити
    public Guid Id {get; set;}
    public bool IsFolder {get; set;}
    public bool DeletionMark {get; set;}
    public bool Predefined {get; set;}
    public string Code {get; set;}
    public string Description {get; set;}
    public Guid? Parent {get; set;}
    public Guid? Owner {get; set;}
    #endregion Стандартні реквізити
    #region реквізити
    [Description1C8(Name = "РеквизитДопУпорядочивания", Comment = "", Synonym = "Порядок")]
    // Format 5.0
    public long РеквизитДопУпорядочивания {get; set;}
    [Description1C8(Name = "НаименованиеПолное", Comment = "", Synonym = "Наименование полное")]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "ТарифнаяСетка", Comment = "", Synonym = "Тарифная сетка")]
    public Catalogs.ТарифныеСетки ТарифнаяСетка {get; set;}
    #endregion реквізити
    }
}
