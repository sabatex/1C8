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
    [Table("SkhemyNalohovohoUchetaPoDohovoramKontrahentov")]
    [Description1C8(Name = "СхемыНалоговогоУчетаПоДоговорамКонтрагентов", Comment = "(Регл)", Synonym = "Схемы налогового учета по договорам контрагентов")]
    public class СхемыНалоговогоУчетаПоДоговорамКонтрагентов:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "МоментОпределенияБазыНДСПоПокупкам", Comment = "", Synonym = "Момент определения базы НДС по покупкам")]
    public Enums.МоментыОпределенияНалоговойБазы МоментОпределенияБазыНДСПоПокупкам {get; set;}
    [Description1C8(Name = "МоментОпределенияБазыНДСПоПродажам", Comment = "", Synonym = "Момент определения базы НДС по продажам")]
    public Enums.МоментыОпределенияНалоговойБазы МоментОпределенияБазыНДСПоПродажам {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
