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
    [Table("ZvanyiaHrazhdanskohoVoynskohoUcheta")]
    [Description1C8(Name = "ЗванияГражданскогоВоинскогоУчета", Comment = "", Synonym = "Воинские звания")]
    public class ЗванияГражданскогоВоинскогоУчета:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ОбщевойсковоеЗвание", Comment = "", Synonym = "Общевойсковое звание")]
        public Enums.КлассификаторВоинскихЗваний ОбщевойсковоеЗвание {get; set;}
        [Description1C8(Name = "РеквизитДопУпорядочивания", Comment = "", Synonym = "Порядок")]
        // Format 5.0
        public long РеквизитДопУпорядочивания {get; set;}
        [Description1C8(Name = "Состав", Comment = "", Synonym = "Состав")]
        public Catalogs.СоставыВоеннослужащих Состав {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
