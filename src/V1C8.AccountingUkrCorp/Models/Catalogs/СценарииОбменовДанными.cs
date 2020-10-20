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
    [Table("StsenaryyObmenovDannymy")]
    [Description1C8(Name = "СценарииОбменовДанными", Comment = "", Synonym = "Сценарии синхронизации данных")]
    public class СценарииОбменовДанными:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "ИспользоватьРегламентноеЗадание", Comment = "", Synonym = "Использовать регламентное задание")]
    public bool ИспользоватьРегламентноеЗадание {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "РегламентноеЗаданиеGUID", Comment = "", Synonym = "Регламентное задание GUID")]
    [StringLength(40)]
    public string РегламентноеЗаданиеGUID {get; set;}
    #endregion реквізити
    #region tables
    [Description1C8(Name = "НастройкиОбмена", Comment = "", Synonym = "Настройки синхронизации")]
    public List<СценарииОбменовДанными_НастройкиОбмена> СценарииОбменовДаннымиНастройкиОбмена
    #endregion tables
    }
}
