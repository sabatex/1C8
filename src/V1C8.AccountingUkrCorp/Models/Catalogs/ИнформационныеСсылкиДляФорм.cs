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
    [Table("YnformatsyonnyeSsylkyDliaForm")]
    [Description1C8(Name = "ИнформационныеСсылкиДляФорм", Comment = "", Synonym = "Информационные ссылки для форм")]
    public class ИнформационныеСсылкиДляФорм:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Адрес", Comment = "", Synonym = "Адрес")]
    public string Адрес {get; set;}
    [Description1C8(Name = "Вес", Comment = "", Synonym = "Вес")]
    // Format 10.0
    public long Вес {get; set;}
    [Description1C8(Name = "ДатаНачалаАктуальности", Comment = "", Synonym = "Дата начала актуальности")]
    public DateTime ДатаНачалаАктуальности {get; set;}
    [Description1C8(Name = "ДатаОбновления", Comment = "", Synonym = "Дата обновления")]
    public DateTime ДатаОбновления {get; set;}
    [Description1C8(Name = "ИзКонфигурации", Comment = "", Synonym = "Из конфигурации")]
    public bool ИзКонфигурации {get; set;}
    [Description1C8(Name = "ДатаОкончанияАктуальности", Comment = "", Synonym = "Дата окончания актуальности")]
    public DateTime ДатаОкончанияАктуальности {get; set;}
    [Description1C8(Name = "Идентификатор", Comment = "", Synonym = "Идентификатор")]
    [StringLength(100)]
    public string Идентификатор {get; set;}
    [Description1C8(Name = "Подсказка", Comment = "", Synonym = "Подсказка")]
    [StringLength(200)]
    public string Подсказка {get; set;}
    [Description1C8(Name = "ПолныйПутьКФорме", Comment = "", Synonym = "Полный путь к форме")]
    public Catalogs.ПолныеПутиКФормам ПолныйПутьКФорме {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
