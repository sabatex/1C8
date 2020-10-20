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
    [Table("PostavliaemyeDannye")]
    [Description1C8(Name = "ПоставляемыеДанные", Comment = "", Synonym = "Поставляемые данные")]
    public class ПоставляемыеДанные:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "ВидДанных", Comment = "", Synonym = "Вид данных")]
    [StringLength(20)]
    public string ВидДанных {get; set;}
    [Description1C8(Name = "ДатаДобавления", Comment = "", Synonym = "Дата добавления")]
    public DateTime ДатаДобавления {get; set;}
    [Description1C8(Name = "ХранимыйФайл", Comment = "", Synonym = "Хранимый файл")]
    // Сховище значень
    public byte[] ХранимыйФайл {get; set;}
    [Description1C8(Name = "ПутьКФайлу", Comment = "", Synonym = "Путь к файлу")]
    public string ПутьКФайлу {get; set;}
    [Description1C8(Name = "Том", Comment = "", Synonym = "Том")]
    public Catalogs.ТомаХраненияФайлов Том {get; set;}
    [Description1C8(Name = "ТипХраненияФайла", Comment = "", Synonym = "Тип хранения файла")]
    public Enums.ТипыХраненияФайлов ТипХраненияФайла {get; set;}
    [Description1C8(Name = "ИдентификаторФайла", Comment = "", Synonym = "Идентификатор файла")]
    public Guid ИдентификаторФайла {get; set;}
    [Description1C8(Name = "Описание", Comment = "", Synonym = "Описание")]
    public string Описание {get; set;}
    #endregion реквізити
    #region tables
    [Description1C8(Name = "ХарактеристикиДанных", Comment = "", Synonym = "Характеристики данных")]
    public List<ПоставляемыеДанные_ХарактеристикиДанных> ПоставляемыеДанныеХарактеристикиДанных
    #endregion tables
    }
}
