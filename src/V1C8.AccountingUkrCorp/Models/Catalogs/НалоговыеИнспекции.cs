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
    [Table("NalohovyeYnspektsyy")]
    [Description1C8(Name = "НалоговыеИнспекции", Comment = "Налоговые инспекции", Synonym = "Налоговые инспекции")]
    public class НалоговыеИнспекции
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
    [Description1C8(Name = "ТипДПИ", Comment = "", Synonym = "Тип ДПИ")]
    [StringLength(1)]
    public string ТипДПИ {get; set;}
    [Description1C8(Name = "КодАдмРайона", Comment = "", Synonym = "Код адм. района")]
    [StringLength(2)]
    public string КодАдмРайона {get; set;}
    [Description1C8(Name = "НаименованиеАдмРайона", Comment = "", Synonym = "Наименование адм. района")]
    [StringLength(60)]
    public string НаименованиеАдмРайона {get; set;}
    [Description1C8(Name = "Адрес", Comment = "", Synonym = "Адрес")]
    [StringLength(32)]
    public string Адрес {get; set;}
    [Description1C8(Name = "ЕДРПОУ", Comment = "", Synonym = "ЕДРПОУ")]
    [StringLength(10)]
    public string ЕДРПОУ {get; set;}
    [Description1C8(Name = "КодДляПоиска", Comment = "", Synonym = "Код для поиска")]
    [StringLength(6)]
    public string КодДляПоиска {get; set;}
    [Description1C8(Name = "НаименованиеПолное", Comment = "(Общ) Полное наименование, например, для печати", Synonym = "Полное наименование")]
    [StringLength(1000)]
    public string НаименованиеПолное {get; set;}
    #endregion реквізити
    }
}
