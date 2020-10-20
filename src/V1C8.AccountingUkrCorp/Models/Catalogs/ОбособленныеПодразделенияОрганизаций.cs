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
    [Table("ObosoblennyePodrazdelenyiaOrhanyzatsyi")]
    [Description1C8(Name = "ОбособленныеПодразделенияОрганизаций", Comment = "", Synonym = "Обособленные подразделения")]
    public class ОбособленныеПодразделенияОрганизаций:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "НаименованиеПолное", Comment = "(Общ)", Synonym = "Полное наименование")]
        [StringLength(250)]
        public string НаименованиеПолное {get; set;}
        [Description1C8(Name = "Префикс", Comment = "", Synonym = "Префикс для налоговых документов")]
        [StringLength(4)]
        public string Префикс {get; set;}
        [Description1C8(Name = "НаименованиеДляНалоговыхДокументов", Comment = "", Synonym = "Наименование для налоговых документов (дописывается к наименованию организации)")]
        [StringLength(250)]
        public string НаименованиеДляНалоговыхДокументов {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
