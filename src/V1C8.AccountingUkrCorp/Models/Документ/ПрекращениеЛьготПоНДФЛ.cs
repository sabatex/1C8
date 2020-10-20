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
    [Table("PrekrashchenyeLhotPoNDFL")]
    [Description1C8(Name = "ПрекращениеЛьготПоНДФЛ", Comment = "", Synonym = "Отмена льгот по НДФЛ")]
    public class ПрекращениеЛьготПоНДФЛ:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Месяц", Comment = "", Synonym = "Месяц")]
        public DateTime Месяц {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица Сотрудник {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
