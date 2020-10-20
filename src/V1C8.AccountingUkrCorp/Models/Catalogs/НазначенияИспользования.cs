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
    public class НазначенияИспользования:EnumItem
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
    [Description1C8(Name = "СрокПолезногоИспользования", Comment = "", Synonym = "Срок полезного использования")]
    public DBNull СрокПолезногоИспользования {get; set;}
    [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
    public DBNull Количество {get; set;}
    [Description1C8(Name = "СпособОтраженияРасходов", Comment = "", Synonym = "Способ отражения расходов")]
    public DBNull СпособОтраженияРасходов {get; set;}
    [Description1C8(Name = "ВидМалоценногоАктива", Comment = "", Synonym = "Вид малоценного актива")]
    public DBNull ВидМалоценногоАктива {get; set;}
    [Description1C8(Name = "СчетПередачиБУ", Comment = "", Synonym = "Счет передачи БУ")]
    public DBNull СчетПередачиБУ {get; set;}
    [Description1C8(Name = "СчетАмортизацииБУ", Comment = "", Synonym = "Счет амортизации БУ")]
    public DBNull СчетАмортизацииБУ {get; set;}
    [Description1C8(Name = "СчетБУДляПечати", Comment = "", Synonym = "Счет БУ для печати")]
    [StringLength(25)]
    public string СчетБУДляПечати {get; set;}
    [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
    public DBNull ЕдиницаИзмерения {get; set;}
    [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
    public DBNull Коэффициент {get; set;}
    #endregion реквізити
    }
}
