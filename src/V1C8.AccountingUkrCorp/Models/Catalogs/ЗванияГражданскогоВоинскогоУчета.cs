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
    [Table("ZvanyiaHrazhdanskohoVoynskohoUcheta")]
    [Description1C8(Name = "ЗванияГражданскогоВоинскогоУчета", Comment = "", Synonym = "Воинские звания")]
    public class ЗванияГражданскогоВоинскогоУчета:EnumItem
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
    [Description1C8(Name = "ОбщевойсковоеЗвание", Comment = "", Synonym = "Общевойсковое звание")]
    public DBNull ОбщевойсковоеЗвание {get; set;}
    [Description1C8(Name = "РеквизитДопУпорядочивания", Comment = "", Synonym = "Порядок")]
    public DBNull РеквизитДопУпорядочивания {get; set;}
    [Description1C8(Name = "Состав", Comment = "", Synonym = "Состав")]
    public DBNull Состав {get; set;}
    #endregion реквізити
    }
}
