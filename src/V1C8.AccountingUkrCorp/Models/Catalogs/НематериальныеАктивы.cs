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
    [Table("NemateryalnyeAktyvy")]
    [Description1C8(Name = "НематериальныеАктивы", Comment = "", Synonym = "Нематериальные активы")]
    public class НематериальныеАктивы:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "НаименованиеПолное", Comment = "", Synonym = "Полное наименование")]
    [StringLength(1000)]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "ПрочиеСведения", Comment = "", Synonym = "Прочие сведения")]
    public string ПрочиеСведения {get; set;}
    [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
    public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    #endregion реквізити
    #region tables
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    public List<НематериальныеАктивы_ДополнительныеРеквизиты> НематериальныеАктивыДополнительныеРеквизиты
    #endregion tables
    }
}
