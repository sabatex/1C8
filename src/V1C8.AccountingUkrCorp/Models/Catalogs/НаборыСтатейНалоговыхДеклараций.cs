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
    [Table("NaboryStateiNalohovykhDeklaratsyi")]
    [Description1C8(Name = "НаборыСтатейНалоговыхДеклараций", Comment = "", Synonym = "Наборы статей налоговых деклараций")]
    public class НаборыСтатейНалоговыхДеклараций:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ВидНалоговойДекларации", Comment = "", Synonym = "Вид налоговой декларации")]
        public Enums.ВидыНалоговыхДеклараций ВидНалоговойДекларации {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
