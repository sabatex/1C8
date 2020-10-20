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
    [Table("TomaKhranenyiaFailov")]
    [Description1C8(Name = "ТомаХраненияФайлов", Comment = "Каталоги на диске для хранения файлов", Synonym = "Тома хранения файлов")]
    public class ТомаХраненияФайлов:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "МаксимальныйРазмер", Comment = "", Synonym = "Предел, МБ")]
        // Format 10.0
        public long МаксимальныйРазмер {get; set;}
        [Description1C8(Name = "ПолныйПутьLinux", Comment = "", Synonym = "Полный путь linux")]
        public string ПолныйПутьLinux {get; set;}
        [Description1C8(Name = "ПолныйПутьWindows", Comment = "", Synonym = "Полный путь windows")]
        public string ПолныйПутьWindows {get; set;}
        [Description1C8(Name = "ПорядокЗаполнения", Comment = "", Synonym = "Порядок")]
        // Format 3.0
        public long ПорядокЗаполнения {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
