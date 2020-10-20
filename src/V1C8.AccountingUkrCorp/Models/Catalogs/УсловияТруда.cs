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
    [Table("UslovyiaTruda")]
    [Description1C8(Name = "УсловияТруда", Comment = "", Synonym = "Условия труда")]
    public class УсловияТруда:EnumItem
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
    [Description1C8(Name = "ПроцентНадбавкиЗаВредность", Comment = "", Synonym = "% надбавки за вредность")]
    public DBNull ПроцентНадбавкиЗаВредность {get; set;}
    [Description1C8(Name = "ВыплачиваетсяНадбавкаЗаВредность", Comment = "", Synonym = "Выплачивается надбавка за вредность")]
    public bool ВыплачиваетсяНадбавкаЗаВредность {get; set;}
    [Description1C8(Name = "КоличествоДнейДополнительногоОтпускаВГод", Comment = "", Synonym = "Количество дней дополнительного отпуска за вредность (в год)")]
    public DBNull КоличествоДнейДополнительногоОтпускаВГод {get; set;}
    #endregion реквізити
    }
}
