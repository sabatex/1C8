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
    [Table("HruppyVneshnykhPolzovatelei")]
    [Description1C8(Name = "ГруппыВнешнихПользователей", Comment = "", Synonym = "Группы внешних пользователей")]
    public class ГруппыВнешнихПользователей:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "УдалитьТипОбъектовАвторизации", Comment = "В качестве типа используется пустая ссылка", Synonym = "(не используется) Тип объектов авторизации")]
    [StringLength(10)]
    public string УдалитьТипОбъектовАвторизации {get; set;}
    [Description1C8(Name = "ВсеОбъектыАвторизации", Comment = "", Synonym = "Все")]
    public bool ВсеОбъектыАвторизации {get; set;}
    #endregion реквізити
    #region tables
    [Description1C8(Name = "Состав", Comment = "", Synonym = "Участники группы")]
    public List<ГруппыВнешнихПользователей_Состав> ГруппыВнешнихПользователейСостав
    [Description1C8(Name = "Роли", Comment = "", Synonym = "Роли")]
    public List<ГруппыВнешнихПользователей_Роли> ГруппыВнешнихПользователейРоли
    [Description1C8(Name = "Назначение", Comment = "", Synonym = "Назначение")]
    public List<ГруппыВнешнихПользователей_Назначение> ГруппыВнешнихПользователейНазначение
    #endregion tables
    }
}
