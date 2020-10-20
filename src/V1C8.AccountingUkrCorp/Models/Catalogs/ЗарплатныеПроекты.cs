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
    [Table("ZarplatnyeProekty")]
    [Description1C8(Name = "ЗарплатныеПроекты", Comment = "", Synonym = "Зарплатные проекты")]
    public class ЗарплатныеПроекты
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
    [Description1C8(Name = "Банк", Comment = "", Synonym = "Банк")]
    public Catalogs.Банки Банк {get; set;}
    [Description1C8(Name = "Валюта", Comment = "", Synonym = "Валюта")]
    public Catalogs.Валюты Валюта {get; set;}
    [Description1C8(Name = "ДатаДоговора", Comment = "", Synonym = "Дата договора")]
    public DateTime ДатаДоговора {get; set;}
    [Description1C8(Name = "ИспользоватьЭлектронныйДокументооборотСБанком", Comment = "При использовании, факт оплаты банком платежных ведомостей регистрируется в системе при загрузке файла подтверждения из банка", Synonym = "Использовать электронный документооборот с банком")]
    public bool ИспользоватьЭлектронныйДокументооборотСБанком {get; set;}
    [Description1C8(Name = "КодировкаФайла", Comment = "", Synonym = "Кодировка файла")]
    public Enums.КодировкаФайловОбменаПоЗарплатномуПроекту КодировкаФайла {get; set;}
    [Description1C8(Name = "НомерДоговора", Comment = "", Synonym = "Номер договора")]
    [StringLength(8)]
    public string НомерДоговора {get; set;}
    [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
    public Catalogs.Организации Организация {get; set;}
    [Description1C8(Name = "ОтделениеБанка", Comment = "", Synonym = "Отделение банка")]
    [StringLength(4)]
    public string ОтделениеБанка {get; set;}
    [Description1C8(Name = "РасчетныйСчет", Comment = "", Synonym = "Расчетный счет")]
    [StringLength(20)]
    public string РасчетныйСчет {get; set;}
    [Description1C8(Name = "ФилиалОтделенияБанка", Comment = "", Synonym = "Филиал отделения банка")]
    [StringLength(4)]
    public string ФилиалОтделенияБанка {get; set;}
    [Description1C8(Name = "ФорматФайла", Comment = "", Synonym = "Формат файла")]
    public Enums.ФорматыФайловОбменаПоЗарплатномуПроекту ФорматФайла {get; set;}
    #endregion реквізити
    }
}
