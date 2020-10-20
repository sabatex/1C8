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
    [Table("OsnovanyiaSpetsyalnohoStazha")]
    [Description1C8(Name = "ОснованияСпециальногоСтажа", Comment = "", Synonym = "Основания специального стажа")]
    public class ОснованияСпециальногоСтажа:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "КодОтчености", Comment = "", Synonym = "Код отчености")]
    [StringLength(8)]
    public string КодОтчености {get; set;}
    [Description1C8(Name = "ОграничениеПоПолу", Comment = "", Synonym = "Ограничение по полу")]
    public bool ОграничениеПоПолу {get; set;}
    [Description1C8(Name = "ПолФизическихЛиц", Comment = "", Synonym = "Пол физических лиц")]
    public Enums.ПолФизическогоЛица ПолФизическихЛиц {get; set;}
    [Description1C8(Name = "РазрешеноИспользованиеБезАттестацииРабочихМест", Comment = "", Synonym = "Разрешено использование без аттестации рабочих мест")]
    public bool РазрешеноИспользованиеБезАттестацииРабочихМест {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
