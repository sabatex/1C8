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
    [Table("ProfylyHruppDostupa")]
    [Description1C8(Name = "ПрофилиГруппДоступа", Comment = "", Synonym = "Профили групп доступа")]
    public class ПрофилиГруппДоступа:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "ИдентификаторПоставляемыхДанных", Comment = "", Synonym = "Идентификатор поставляемых данных")]
    public Guid ИдентификаторПоставляемыхДанных {get; set;}
    [Description1C8(Name = "ПоставляемыйПрофильИзменен", Comment = "", Synonym = "Поставляемый профиль изменен")]
    public bool ПоставляемыйПрофильИзменен {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    #endregion реквізити
    #region tables
    [Description1C8(Name = "Роли", Comment = "", Synonym = "Роли")]
    public List<ПрофилиГруппДоступа_Роли> ПрофилиГруппДоступаРоли
    [Description1C8(Name = "ВидыДоступа", Comment = "", Synonym = "Виды доступа")]
    public List<ПрофилиГруппДоступа_ВидыДоступа> ПрофилиГруппДоступаВидыДоступа
    [Description1C8(Name = "ЗначенияДоступа", Comment = "", Synonym = "Значения доступа")]
    public List<ПрофилиГруппДоступа_ЗначенияДоступа> ПрофилиГруппДоступаЗначенияДоступа
    [Description1C8(Name = "Назначение", Comment = "", Synonym = "Назначение")]
    public List<ПрофилиГруппДоступа_Назначение> ПрофилиГруппДоступаНазначение
    #endregion tables
    }
}
