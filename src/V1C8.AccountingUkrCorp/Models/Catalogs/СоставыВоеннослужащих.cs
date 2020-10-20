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
    [Table("SostavyVoennosluzhashchykh")]
    [Description1C8(Name = "СоставыВоеннослужащих", Comment = "", Synonym = "Составы военнослужащих")]
    public class СоставыВоеннослужащих:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "РеквизитДопУпорядочивания", Comment = "", Synonym = "Порядок")]
        // Format 5.0
        public long РеквизитДопУпорядочивания {get; set;}
        [Description1C8(Name = "ОфицерскийСостав", Comment = "", Synonym = "Офицерский состав")]
        public bool ОфицерскийСостав {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
