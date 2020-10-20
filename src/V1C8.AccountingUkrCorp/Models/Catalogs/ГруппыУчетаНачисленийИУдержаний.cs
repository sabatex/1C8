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
    [Table("HruppyUchetaNachyslenyiYUderzhanyi")]
    [Description1C8(Name = "ГруппыУчетаНачисленийИУдержаний", Comment = "", Synonym = "Группы учета начислений и удержаний")]
    public class ГруппыУчетаНачисленийИУдержаний:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Вид", Comment = "", Synonym = "Вид")]
    public Enums.ВидыГруппУчетаНачисленийИУдержаний Вид {get; set;}
    [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
    public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
    [Description1C8(Name = "СубконтоУчета", Comment = "", Synonym = "Субконто учета")]
    public ПланВидовХарактеристик.ВидыСубконтоХозрасчетные СубконтоУчета {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
