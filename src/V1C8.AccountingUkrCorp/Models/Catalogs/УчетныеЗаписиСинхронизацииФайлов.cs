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
    [Table("UchetnyeZapysySynkhronyzatsyyFailov")]
    [Description1C8(Name = "УчетныеЗаписиСинхронизацииФайлов", Comment = "", Synonym = "Учетные записи синхронизации файлов")]
    public class УчетныеЗаписиСинхронизацииФайлов:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Сервис", Comment = "", Synonym = "Сервис")]
        [StringLength(100)]
        public string Сервис {get; set;}
        [Description1C8(Name = "КорневаяПапка", Comment = "", Synonym = "Корневая папка")]
        [StringLength(30)]
        public string КорневаяПапка {get; set;}
        [Description1C8(Name = "АвторФайлов", Comment = "", Synonym = "Автор файлов")]
        public Catalogs.ВнешниеПользователи АвторФайлов {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
