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
    [Table("ShablonyZadanyiOcheredy")]
    [Description1C8(Name = "ШаблоныЗаданийОчереди", Comment = "", Synonym = "Шаблоны заданий очереди")]
    public class ШаблоныЗаданийОчереди:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Использование", Comment = "", Synonym = "Использование")]
    public bool Использование {get; set;}
    [Description1C8(Name = "ИмяМетода", Comment = "", Synonym = "Имя метода")]
    [StringLength(255)]
    public string ИмяМетода {get; set;}
    [Description1C8(Name = "Ключ", Comment = "", Synonym = "Ключ")]
    [StringLength(128)]
    public string Ключ {get; set;}
    [Description1C8(Name = "КоличествоПовторовПриАварийномЗавершении", Comment = "", Synonym = "Количество повторов при аварийном завершении")]
    // Format 10.0
    public long КоличествоПовторовПриАварийномЗавершении {get; set;}
    [Description1C8(Name = "ИнтервалПовтораПриАварийномЗавершении", Comment = "", Synonym = "Интервал повтора при аварийном завершении")]
    // Format 10.0
    public long ИнтервалПовтораПриАварийномЗавершении {get; set;}
    [Description1C8(Name = "Расписание", Comment = "", Synonym = "Расписание")]
    // Сховище значень
    public byte[] Расписание {get; set;}
    [Description1C8(Name = "Имя", Comment = "", Synonym = "Имя")]
    [StringLength(255)]
    public string Имя {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
