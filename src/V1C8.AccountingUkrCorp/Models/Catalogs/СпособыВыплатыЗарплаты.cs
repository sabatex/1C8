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
    [Table("SposobyVyplatyZarplaty")]
    [Description1C8(Name = "СпособыВыплатыЗарплаты", Comment = "", Synonym = "Способы выплаты зарплаты")]
    public class СпособыВыплатыЗарплаты
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
    [Description1C8(Name = "Поставляемый", Comment = "", Synonym = "Поставляемый")]
    public bool Поставляемый {get; set;}
    [Description1C8(Name = "ХарактерВыплаты", Comment = "", Synonym = "Характер выплаты")]
    public Enums.ХарактерВыплатыЗарплаты ХарактерВыплаты {get; set;}
    [Description1C8(Name = "ВидДокументаОснования", Comment = "", Synonym = "Вид документа основания")]
    public Enums.ВидыДокументовМежрасчетныхНачислений ВидДокументаОснования {get; set;}
    [Description1C8(Name = "Округление", Comment = "", Synonym = "Округление")]
    public Catalogs.СпособыОкругленияПриРасчетеЗарплаты Округление {get; set;}
    [Description1C8(Name = "ПроцентВыплаты", Comment = "", Synonym = "Процент выплаты")]
    // Format 3.0
    public long ПроцентВыплаты {get; set;}
    [Description1C8(Name = "УдалитьИдентификаторОбъекта", Comment = "", Synonym = "(не использовать) Идентификатор объекта")]
    [StringLength(256)]
    public string УдалитьИдентификаторОбъекта {get; set;}
    [Description1C8(Name = "УдалитьСпособПолученияЗарплатыКВыплате", Comment = "", Synonym = "(не использовать) Способ получения зарплаты к выплате")]
    [StringLength(10)]
    public string УдалитьСпособПолученияЗарплатыКВыплате {get; set;}
    [Description1C8(Name = "ГруппаУчетаНачислений", Comment = "", Synonym = "Группа учета начислений")]
    public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчетаНачислений {get; set;}
    [Description1C8(Name = "КодДоходаНДФЛ", Comment = "", Synonym = "Код дохода НДФЛ")]
    public Catalogs.ВидыДоходовНДФЛ КодДоходаНДФЛ {get; set;}
    [Description1C8(Name = "КодДоходаВС", Comment = "", Synonym = "Код дохода ВС")]
    public Catalogs.ВидыДоходовНДФЛ КодДоходаВС {get; set;}
    #endregion реквізити
    }
}
