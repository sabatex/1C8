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
    [Table("TaryfnyeSetky")]
    [Description1C8(Name = "ТарифныеСетки", Comment = "", Synonym = "Тарифные группы")]
    public class ТарифныеСетки:EnumItem
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
    [Description1C8(Name = "ПрименениеТарифныхКоэффициентов", Comment = "", Synonym = "Размеры тарифов устанавливаются в привязке к базовому тарифу")]
    public bool ПрименениеТарифныхКоэффициентов {get; set;}
    [Description1C8(Name = "УдалитьВидТарифа", Comment = "", Synonym = "Удалить вид тарифа")]
    public DBNull УдалитьВидТарифа {get; set;}
    [Description1C8(Name = "НаименованиеПолное", Comment = "", Synonym = "Наименование полное")]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "ВидТарифнойСетки", Comment = "", Synonym = "Вид тарифной группы")]
    public DBNull ВидТарифнойСетки {get; set;}
    #endregion реквізити
    }
}
