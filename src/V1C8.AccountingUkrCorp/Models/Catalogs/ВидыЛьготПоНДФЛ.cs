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
    [Table("VydyLhotPoNDFL")]
    [Description1C8(Name = "ВидыЛьготПоНДФЛ", Comment = "", Synonym = "Виды льгот по НДФЛ")]
    public class ВидыЛьготПоНДФЛ:CatalogItem
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
    [Description1C8(Name = "КодОтчетностиНДФЛ", Comment = "", Synonym = "Код отчетности НДФЛ")]
    [StringLength(3)]
    public string КодОтчетностиНДФЛ {get; set;}
    [Description1C8(Name = "РазмерНДФЛ", Comment = "", Synonym = "Размер льготы НДФЛ")]
    // Format 5.2
    public decimal РазмерНДФЛ {get; set;}
    [Description1C8(Name = "СпособПримененияНДФЛ", Comment = "", Synonym = "Способ применения льготы по НДФЛ")]
    public Enums.СпособыПримененияЛьготРаботников СпособПримененияНДФЛ {get; set;}
    [Description1C8(Name = "ГруппаЛьгот", Comment = "", Synonym = "Группа льгот")]
    public bool ГруппаЛьгот {get; set;}
    [Description1C8(Name = "Льгота1", Comment = "", Synonym = "Льгота1")]
    public Catalogs.ВидыЛьготПоНДФЛ Льгота1 {get; set;}
    [Description1C8(Name = "Льгота2", Comment = "", Synonym = "Льгота2")]
    public Catalogs.ВидыЛьготПоНДФЛ Льгота2 {get; set;}
    #endregion реквізити
    }
}
