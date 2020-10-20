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
    [Table("VydyOplatOrhanyzatsyi")]
    [Description1C8(Name = "ВидыОплатОрганизаций", Comment = "", Synonym = "Виды оплат")]
    public class ВидыОплатОрганизаций:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
    public Catalogs.Организации Организация {get; set;}
    [Description1C8(Name = "ТипОплаты", Comment = "", Synonym = "Тип оплаты")]
    public Enums.ТипыОплат ТипОплаты {get; set;}
    [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
    public Catalogs.Контрагенты Контрагент {get; set;}
    [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор контрагента")]
    public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
    [Description1C8(Name = "ПроцентБанковскойКомиссии", Comment = "", Synonym = "Процент банковской комиссии")]
    // Format 5.2
    public decimal ПроцентБанковскойКомиссии {get; set;}
    [Description1C8(Name = "СчетДеньгиВПути", Comment = "", Synonym = "Счет деньги в пути")]
    public ПланСчетов.Хозрасчетный СчетДеньгиВПути {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
