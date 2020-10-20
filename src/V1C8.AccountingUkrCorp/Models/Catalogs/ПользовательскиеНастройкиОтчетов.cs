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
    [Table("PolzovatelskyeNastroikyOtchetov")]
    [Description1C8(Name = "ПользовательскиеНастройкиОтчетов", Comment = "Используется для поиска настроек. Содержит только представления. Не содержит самих настроек.", Synonym = "Пользовательские настройки отчетов")]
    public class ПользовательскиеНастройкиОтчетов:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Вариант", Comment = "", Synonym = "Вариант")]
    public Catalogs.ВариантыОтчетов Вариант {get; set;}
    [Description1C8(Name = "Пользователь", Comment = "", Synonym = "Пользователь")]
    public Catalogs.ВнешниеПользователи Пользователь {get; set;}
    [Description1C8(Name = "КлючПользовательскойНастройки", Comment = "", Synonym = "Ключ пользовательской настройки")]
    [StringLength(36)]
    public string КлючПользовательскойНастройки {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
