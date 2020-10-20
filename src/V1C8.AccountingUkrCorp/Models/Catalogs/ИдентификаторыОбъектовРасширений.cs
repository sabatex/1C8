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
    [Table("YdentyfykatoryObektovRasshyrenyi")]
    [Description1C8(Name = "ИдентификаторыОбъектовРасширений", Comment = "", Synonym = "Идентификаторы объектов расширений")]
    public class ИдентификаторыОбъектовРасширений:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ПорядокКоллекции", Comment = "", Synonym = "Порядок коллекции")]
        // Format 2.0
        public long ПорядокКоллекции {get; set;}
        [Description1C8(Name = "Имя", Comment = "Например, 'ОбъектыАдресацииЗадач'", Synonym = "Имя")]
        [StringLength(255)]
        public string Имя {get; set;}
        [Description1C8(Name = "Синоним", Comment = "", Synonym = "Синоним")]
        [StringLength(255)]
        public string Синоним {get; set;}
        [Description1C8(Name = "ПолноеИмя", Comment = "Например, 'ПланВидовХарактеристик.ОбъектыАдресацииЗадач'", Synonym = "Полное имя")]
        [StringLength(430)]
        public string ПолноеИмя {get; set;}
        [Description1C8(Name = "ПолныйСиноним", Comment = "", Synonym = "Полный синоним")]
        [StringLength(430)]
        public string ПолныйСиноним {get; set;}
        [Description1C8(Name = "БезДанных", Comment = "", Synonym = "Без данных")]
        public bool БезДанных {get; set;}
        [Description1C8(Name = "ЗначениеПустойСсылки", Comment = "", Synonym = "Значение пустой ссылки")]
        public Documents.СторнированиеНачислений ЗначениеПустойСсылки {get; set;}
        [Description1C8(Name = "КлючОбъектаМетаданных", Comment = "", Synonym = "Ключ объекта метаданных")]
        // Сховище значень
        public byte[] КлючОбъектаМетаданных {get; set;}
        [Description1C8(Name = "НоваяСсылка", Comment = "", Synonym = "Новая ссылка")]
        public Catalogs.ИдентификаторыОбъектовРасширений НоваяСсылка {get; set;}
        [Description1C8(Name = "ИмяРасширения", Comment = "", Synonym = "Имя расширения")]
        [StringLength(128)]
        public string ИмяРасширения {get; set;}
        [Description1C8(Name = "ХешСуммаРасширения", Comment = "", Synonym = "Хеш сумма расширения")]
        [StringLength(30)]
        public string ХешСуммаРасширения {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
