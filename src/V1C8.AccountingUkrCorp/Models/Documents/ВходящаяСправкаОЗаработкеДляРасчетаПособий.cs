using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Documents
{
    [Table("VkhodiashchaiaSpravkaOZarabotkeDliaRaschetaPosobyi")]
    [Description1C8(Name = "ВходящаяСправкаОЗаработкеДляРасчетаПособий", Comment = "", Synonym = "Входящая справка о заработке для расчета пособий")]
    public class ВходящаяСправкаОЗаработкеДляРасчетаПособий:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Страхователь", Comment = "", Synonym = "Страхователь")]
        public Catalogs.Работодатели Страхователь {get; set;}
        [Description1C8(Name = "ПериодРаботыС", Comment = "", Synonym = "Период работы с")]
        public DateTime ПериодРаботыС {get; set;}
        [Description1C8(Name = "ПериодРаботыПо", Comment = "", Synonym = "Период работы по")]
        public DateTime ПериодРаботыПо {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "КорректировкаДанныхОСтаже", Comment = "", Synonym = "Корректировка данных о стаже")]
        public bool КорректировкаДанныхОСтаже {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДанныеОЗаработке", Comment = "", Synonym = "Данные о заработке")]
        public List<ВходящаяСправкаОЗаработкеДляРасчетаПособий_ДанныеОЗаработке> ВходящаяСправкаОЗаработкеДляРасчетаПособийДанныеОЗаработке {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДанныеОЗаработке", Comment = "", Synonym = "Данные о заработке")]
    [Table("VkhodiashchaiaSpravkaOZarabotkeDliaRaschetaPosobyi_DannyeOZarabotke")]
    public class ВходящаяСправкаОЗаработкеДляРасчетаПособий_ДанныеОЗаработке
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Заработок", Comment = "", Synonym = "Заработок")]
        // Format 15.2
        public decimal Заработок {get; set;}
        [Description1C8(Name = "ДнейБолезниУходаЗаДетьми", Comment = "", Synonym = "Дней болезни, ухода за детьми и др.")]
        // Format 7.2
        public decimal ДнейБолезниУходаЗаДетьми {get; set;}
        [Description1C8(Name = "РасчетныйМесяц", Comment = "", Synonym = "Расчетный месяц")]
        public DateTime РасчетныйМесяц {get; set;}
        [Description1C8(Name = "ДнейСтажа", Comment = "", Synonym = "Страховой стаж за месяц")]
        // Format 5.2
        public decimal ДнейСтажа {get; set;}
        [Description1C8(Name = "Страхователь", Comment = "", Synonym = "Страхователь")]
        public Catalogs.Работодатели Страхователь {get; set;}
    }
}
