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
    public class РасходыБудущихПериодов:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "ДатаНачалаСписания", Comment = "(Общ)", Synonym = "Начало списания")]
    public DateTime ДатаНачалаСписания {get; set;}
    [Description1C8(Name = "ДатаОкончанияСписания", Comment = "(Общ)", Synonym = "Окончание списания")]
    public DateTime ДатаОкончанияСписания {get; set;}
    [Description1C8(Name = "СчетБУ", Comment = "(Регл)", Synonym = "Счет")]
    public ПланСчетов.Хозрасчетный СчетБУ {get; set;}
    [Description1C8(Name = "СубконтоБУ1", Comment = "(Регл)", Synonym = "Субконто БУ 1")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоБУ1 {get; set;}
    [Description1C8(Name = "СубконтоБУ2", Comment = "(Регл)", Synonym = "Субконто БУ 2")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоБУ2 {get; set;}
    [Description1C8(Name = "СубконтоБУ3", Comment = "(Регл)", Synonym = "Субконто БУ 3")]
    public Catalogs.ВидыНалоговойДеятельности СубконтоБУ3 {get; set;}
    [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Нал. назн. (НДС)")]
    public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Нал. назн. затрат (до 01.01.2015)")]
    public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "МетодРаспределения", Comment = "", Synonym = "Метод распределения")]
    public Enums.МетодыРаспределенияРБП МетодРаспределения {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
