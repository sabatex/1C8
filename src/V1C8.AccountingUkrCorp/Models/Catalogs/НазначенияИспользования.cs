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
    [Table("NaznachenyiaYspolzovanyia")]
    [Description1C8(Name = "НазначенияИспользования", Comment = "", Synonym = "Назначения использования")]
    public class НазначенияИспользования:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "СрокПолезногоИспользования", Comment = "", Synonym = "Срок полезного использования")]
    // Format 4.0
    public long СрокПолезногоИспользования {get; set;}
    [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
    // Format 15.3
    public decimal Количество {get; set;}
    [Description1C8(Name = "СпособОтраженияРасходов", Comment = "", Synonym = "Способ отражения расходов")]
    public Catalogs.СпособыОтраженияРасходовПоАмортизации СпособОтраженияРасходов {get; set;}
    [Description1C8(Name = "ВидМалоценногоАктива", Comment = "", Synonym = "Вид малоценного актива")]
    public Enums.ВидыМалоценныхАктивов ВидМалоценногоАктива {get; set;}
    [Description1C8(Name = "СчетПередачиБУ", Comment = "", Synonym = "Счет передачи БУ")]
    public ПланСчетов.Хозрасчетный СчетПередачиБУ {get; set;}
    [Description1C8(Name = "СчетАмортизацииБУ", Comment = "", Synonym = "Счет амортизации БУ")]
    public ПланСчетов.Хозрасчетный СчетАмортизацииБУ {get; set;}
    [Description1C8(Name = "СчетБУДляПечати", Comment = "", Synonym = "Счет БУ для печати")]
    [StringLength(25)]
    public string СчетБУДляПечати {get; set;}
    [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
    public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
    [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
    // Format 10.3
    public decimal Коэффициент {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
