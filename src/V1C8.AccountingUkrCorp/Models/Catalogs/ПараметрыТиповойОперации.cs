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
    [Table("ParametryTypovoiOperatsyy")]
    [Description1C8(Name = "ПараметрыТиповойОперации", Comment = "", Synonym = "Параметры типовой операции")]
    public class ПараметрыТиповойОперации:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ПорядокПараметра", Comment = "", Synonym = "Порядок параметра")]
        // Format 3.0
        public long ПорядокПараметра {get; set;}
        [Description1C8(Name = "ОписаниеТипаРеквизита", Comment = "", Synonym = "Описание типа реквизита")]
        // Сховище значень
        public byte[] ОписаниеТипаРеквизита {get; set;}
        [Description1C8(Name = "Подсказка", Comment = "", Synonym = "Подсказка")]
        [StringLength(200)]
        public string Подсказка {get; set;}
        [Description1C8(Name = "СвязьПоВладельцу", Comment = "", Synonym = "Связь по владельцу")]
        public Catalogs.ПараметрыТиповойОперации СвязьПоВладельцу {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
