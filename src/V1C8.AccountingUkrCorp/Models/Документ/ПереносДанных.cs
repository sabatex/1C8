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
    [Table("PerenosDannykh")]
    [Description1C8(Name = "ПереносДанных", Comment = "", Synonym = "Перенос данных")]
    public class ПереносДанных:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Период регистрации")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ТаблицаРегистров", Comment = "", Synonym = "Таблица регистров")]
        public List<ПереносДанных_ТаблицаРегистров> ПереносДанныхТаблицаРегистров {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ТаблицаРегистров", Comment = "", Synonym = "Таблица регистров")]
    [Table("PerenosDannykh_TablytsaRehystrov")]
    public class ПереносДанных_ТаблицаРегистров
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Имя", Comment = "", Synonym = "Имя")]
        [StringLength(255)]
        public string Имя {get; set;}
    }
}
