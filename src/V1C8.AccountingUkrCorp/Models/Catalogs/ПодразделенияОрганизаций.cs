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
    [Table("PodrazdelenyiaOrhanyzatsyi")]
    [Description1C8(Name = "ПодразделенияОрганизаций", Comment = "", Synonym = "Подразделения")]
    public class ПодразделенияОрганизаций:EnumItem
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
    [Description1C8(Name = "Сформировано", Comment = "", Synonym = "Сформировано")]
    public bool Сформировано {get; set;}
    [Description1C8(Name = "ДатаСоздания", Comment = "", Synonym = "Дата создания")]
    public DateTime ДатаСоздания {get; set;}
    [Description1C8(Name = "Расформировано", Comment = "", Synonym = "Расформировано")]
    public bool Расформировано {get; set;}
    [Description1C8(Name = "ДатаРасформирования", Comment = "", Synonym = "Дата расформирования")]
    public DateTime ДатаРасформирования {get; set;}
    [Description1C8(Name = "РеквизитДопУпорядочиванияИерархического", Comment = "", Synonym = "Порядок (иерархический)")]
    [StringLength(100)]
    public string РеквизитДопУпорядочиванияИерархического {get; set;}
    [Description1C8(Name = "ГрафикРаботыСотрудников", Comment = "", Synonym = "График работы")]
    public DBNull ГрафикРаботыСотрудников {get; set;}
    #endregion реквізити
    }
}
