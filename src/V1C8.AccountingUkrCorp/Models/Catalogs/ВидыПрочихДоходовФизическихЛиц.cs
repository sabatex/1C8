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
    [Table("VydyProchykhDokhodovFyzycheskykhLyts")]
    [Description1C8(Name = "ВидыПрочихДоходовФизическихЛиц", Comment = "", Synonym = "Виды прочих доходов физлиц")]
    public class ВидыПрочихДоходовФизическихЛиц
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
    [Description1C8(Name = "КодДоходаНДФЛ", Comment = "", Synonym = "Код дохода НДФЛ")]
    public Catalogs.ВидыДоходовНДФЛ КодДоходаНДФЛ {get; set;}
    [Description1C8(Name = "УдержатьНДФЛИзЗарплаты", Comment = "", Synonym = "Удерживать НДФЛ из зарплаты")]
    public bool УдержатьНДФЛИзЗарплаты {get; set;}
    [Description1C8(Name = "ДоходВНатуральнойФорме", Comment = "", Synonym = "Доход в натуральной форме")]
    public bool ДоходВНатуральнойФорме {get; set;}
    [Description1C8(Name = "ГруппаУчета", Comment = "", Synonym = "Группа учета")]
    public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчета {get; set;}
    [Description1C8(Name = "ОтражатьТолькоНДФЛ", Comment = "", Synonym = "Отражать только НДФЛ для 1ДФ")]
    public bool ОтражатьТолькоНДФЛ {get; set;}
    #endregion реквізити
    }
}
