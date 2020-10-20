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
    [Table("UstareloVydyLhotPoNDFL")]
    [Description1C8(Name = "УстарелоВидыЛьготПоНДФЛ", Comment = "", Synonym = "ѳ(устарело) Виды льгот по НДФЛ")]
    public class УстарелоВидыЛьготПоНДФЛ:EnumItem
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
    [StringLength(2)]
    public string КодОтчетностиНДФЛ {get; set;}
    [Description1C8(Name = "РазмерНДФЛ", Comment = "( 1; 1,5; 2 )", Synonym = "Размер льготы НДФЛ")]
    // Format 5.2
    public decimal РазмерНДФЛ {get; set;}
    [Description1C8(Name = "СпособПримененияНДФЛ", Comment = "", Synonym = "Способ применения НДФЛ")]
    public DBNull СпособПримененияНДФЛ {get; set;}
    [Description1C8(Name = "УДАЛИТЬПунктЗаконаНДФЛ", Comment = "", Synonym = "(не используется) Пункт Закона об НДФЛ")]
    [StringLength(7)]
    public string УДАЛИТЬПунктЗаконаНДФЛ {get; set;}
    [Description1C8(Name = "ГруппаЛьгот", Comment = "", Synonym = "Группа льгот")]
    public bool ГруппаЛьгот {get; set;}
    [Description1C8(Name = "Льгота1", Comment = "", Synonym = "Льгота 1")]
    public DBNull Льгота1 {get; set;}
    [Description1C8(Name = "Льгота2", Comment = "", Synonym = "Льгота 2")]
    public DBNull Льгота2 {get; set;}
    #endregion реквізити
    }
}
