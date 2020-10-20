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
    [Table("KliuchevyeOperatsyy")]
    [Description1C8(Name = "КлючевыеОперации", Comment = "", Synonym = "Ключевые операции")]
    public class КлючевыеОперации:EnumItem
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
    [Description1C8(Name = "Имя", Comment = "", Synonym = "Имя")]
    [StringLength(1000)]
    public string Имя {get; set;}
    [Description1C8(Name = "МинимальноДопустимыйУровень", Comment = "", Synonym = "Минимально допустимый уровень")]
    public DBNull МинимальноДопустимыйУровень {get; set;}
    [Description1C8(Name = "Приоритет", Comment = "", Synonym = "Приоритет")]
    // Format 15.0
    public long Приоритет {get; set;}
    [Description1C8(Name = "ЦелевоеВремя", Comment = "", Synonym = "Целевое время")]
    // Format 15.2
    public decimal ЦелевоеВремя {get; set;}
    [Description1C8(Name = "ИмяХеш", Comment = "", Synonym = "Имя хеш")]
    [StringLength(40)]
    public string ИмяХеш {get; set;}
    [Description1C8(Name = "ВыполненаСОшибкой", Comment = "", Synonym = "Выполнена с ошибкой")]
    public bool ВыполненаСОшибкой {get; set;}
    [Description1C8(Name = "Длительная", Comment = "", Synonym = "Длительная")]
    public bool Длительная {get; set;}
    #endregion реквізити
    }
}
