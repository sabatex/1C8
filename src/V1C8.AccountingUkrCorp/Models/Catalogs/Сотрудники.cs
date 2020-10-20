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
    [Table("Sotrudnyky")]
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    public class Сотрудники:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
    public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    [Description1C8(Name = "Актуальность", Comment = "", Synonym = "Актуальность")]
    public bool Актуальность {get; set;}
    [Description1C8(Name = "ГоловнаяОрганизация", Comment = "", Synonym = "Головная организация")]
    public Catalogs.Организации ГоловнаяОрганизация {get; set;}
    [Description1C8(Name = "УдалитьВидЗанятости", Comment = "", Synonym = "(не используется) Вид занятости")]
    public Enums.УстарелоВидыЗанятости УдалитьВидЗанятости {get; set;}
    [Description1C8(Name = "ВАрхиве", Comment = "", Synonym = "В архиве")]
    public bool ВАрхиве {get; set;}
    [Description1C8(Name = "ОсновноеНазначение", Comment = "", Synonym = "Основное назначение")]
    public Catalogs.Сотрудники ОсновноеНазначение {get; set;}
    [Description1C8(Name = "ПоНаправлениюОргановЗанятости", Comment = "", Synonym = "По направлению органов занятости")]
    public bool ПоНаправлениюОргановЗанятости {get; set;}
    [Description1C8(Name = "УточнениеНаименования", Comment = "", Synonym = "Уточнение наименования")]
    [StringLength(40)]
    public string УточнениеНаименования {get; set;}
    [Description1C8(Name = "ГоловнойСотрудник", Comment = "", Synonym = "Основной сотрудник")]
    public Catalogs.Сотрудники ГоловнойСотрудник {get; set;}
    #endregion реквізити
    #region tables
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    public List<Сотрудники_ДополнительныеРеквизиты> СотрудникиДополнительныеРеквизиты
    [Description1C8(Name = "НаборыЗначенийДоступа", Comment = "", Synonym = "Наборы значений доступа")]
    public List<Сотрудники_НаборыЗначенийДоступа> СотрудникиНаборыЗначенийДоступа
    #endregion tables
    }
}
