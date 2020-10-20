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
    [Table("VydyRehystrovUcheta")]
    [Description1C8(Name = "ВидыРегистровУчета", Comment = "", Synonym = "Виды регистров учета")]
    public class ВидыРегистровУчета:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Отчет", Comment = "", Synonym = "Отчет")]
        public Catalogs.ИдентификаторыОбъектовМетаданных Отчет {get; set;}
        [Description1C8(Name = "ВариантОтчета", Comment = "", Synonym = "Вариант отчета")]
        [StringLength(255)]
        public string ВариантОтчета {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
