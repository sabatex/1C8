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
    [Table("RaskhodyBudushchykhPeryodov")]
    [Description1C8(Name = "РасходыБудущихПериодов", Comment = "(Общ)", Synonym = "Расходы будущих периодов")]
    public class РасходыБудущихПериодов:EnumItem
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
    [Description1C8(Name = "ДатаНачалаСписания", Comment = "(Общ)", Synonym = "Начало списания")]
    public DateTime ДатаНачалаСписания {get; set;}
    [Description1C8(Name = "ДатаОкончанияСписания", Comment = "(Общ)", Synonym = "Окончание списания")]
    public DateTime ДатаОкончанияСписания {get; set;}
    [Description1C8(Name = "СчетБУ", Comment = "(Регл)", Synonym = "Счет")]
    public DBNull СчетБУ {get; set;}
    [Description1C8(Name = "СубконтоБУ1", Comment = "(Регл)", Synonym = "Субконто БУ 1")]
    public DBNull СубконтоБУ1 {get; set;}
    [Description1C8(Name = "СубконтоБУ2", Comment = "(Регл)", Synonym = "Субконто БУ 2")]
    public DBNull СубконтоБУ2 {get; set;}
    [Description1C8(Name = "СубконтоБУ3", Comment = "(Регл)", Synonym = "Субконто БУ 3")]
    public DBNull СубконтоБУ3 {get; set;}
    [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Нал. назн. (НДС)")]
    public DBNull НалоговоеНазначение {get; set;}
    [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Нал. назн. затрат (до 01.01.2015)")]
    public DBNull НалоговоеНазначениеДоходовИЗатрат {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "МетодРаспределения", Comment = "", Synonym = "Метод распределения")]
    public DBNull МетодРаспределения {get; set;}
    #endregion реквізити
    }
}
