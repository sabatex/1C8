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
    [Table("VkhodiashchaiaSpravkaORascheteBolnychnoho")]
    [Description1C8(Name = "ВходящаяСправкаОРасчетеБольничного", Comment = "", Synonym = "Входящая справка о расчете больничного")]
    public class ВходящаяСправкаОРасчетеБольничного:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "НомерЛисткаНетрудоспособности", Comment = "", Synonym = "Номер листка нетрудоспособности")]
        [StringLength(12)]
        public string НомерЛисткаНетрудоспособности {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДанныеОЗаработке", Comment = "", Synonym = "Данные о заработке")]
        public List<ВходящаяСправкаОРасчетеБольничного_ДанныеОЗаработке> ВходящаяСправкаОРасчетеБольничногоДанныеОЗаработке {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДанныеОЗаработке", Comment = "", Synonym = "Данные о заработке")]
    [Table("VkhodiashchaiaSpravkaORascheteBolnychnoho_DannyeOZarabotke")]
    public class ВходящаяСправкаОРасчетеБольничного_ДанныеОЗаработке
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Заработок", Comment = "", Synonym = "Заработок")]
        // Format 15.2
        public decimal Заработок {get; set;}
        [Description1C8(Name = "РасчетныйМесяц", Comment = "", Synonym = "Расчетный месяц")]
        public DateTime РасчетныйМесяц {get; set;}
    }
}
