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
    [Table("VvodSvedenyiDliaRaschetaStrakhovohoStazha")]
    [Description1C8(Name = "ВводСведенийДляРасчетаСтраховогоСтажа", Comment = "", Synonym = "Ввод сведений для расчета страхового стажа")]
    public class ВводСведенийДляРасчетаСтраховогоСтажа:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ПериодС", Comment = "", Synonym = "Период С")]
        public DateTime ПериодС {get; set;}
        [Description1C8(Name = "ПериодПо", Comment = "", Synonym = "Период по")]
        public DateTime ПериодПо {get; set;}
        [Description1C8(Name = "ДнейНачальногоСтажа", Comment = "", Synonym = "Дней начального стажа")]
        // Format 2.0
        public long ДнейНачальногоСтажа {get; set;}
        [Description1C8(Name = "МесяцевНачальногоСтажа", Comment = "", Synonym = "Месяцев начального стажа")]
        // Format 2.0
        public long МесяцевНачальногоСтажа {get; set;}
        [Description1C8(Name = "ЛетНачальногоСтажа", Comment = "", Synonym = "Лет начального стажа")]
        // Format 2.0
        public long ЛетНачальногоСтажа {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "СтраховойСтаж", Comment = "", Synonym = "Страховой стаж")]
        public List<ВводСведенийДляРасчетаСтраховогоСтажа_СтраховойСтаж> ВводСведенийДляРасчетаСтраховогоСтажаСтраховойСтаж {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "СтраховойСтаж", Comment = "", Synonym = "Страховой стаж")]
    [Table("VvodSvedenyiDliaRaschetaStrakhovohoStazha_StrakhovoiStazh")]
    public class ВводСведенийДляРасчетаСтраховогоСтажа_СтраховойСтаж
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Год", Comment = "", Synonym = "Год")]
        // Format 4.0
        public long Год {get; set;}
        [Description1C8(Name = "Месяц1", Comment = "", Synonym = "Месяц 1")]
        // Format 5.0
        public long Месяц1 {get; set;}
        [Description1C8(Name = "Месяц2", Comment = "", Synonym = "Месяц 2")]
        // Format 5.0
        public long Месяц2 {get; set;}
        [Description1C8(Name = "Месяц3", Comment = "", Synonym = "Месяц 3")]
        // Format 5.0
        public long Месяц3 {get; set;}
        [Description1C8(Name = "Месяц4", Comment = "", Synonym = "Месяц 2")]
        // Format 5.0
        public long Месяц4 {get; set;}
        [Description1C8(Name = "Месяц5", Comment = "", Synonym = "Месяц 5")]
        // Format 5.0
        public long Месяц5 {get; set;}
        [Description1C8(Name = "Месяц6", Comment = "", Synonym = "Месяц 6")]
        // Format 5.0
        public long Месяц6 {get; set;}
        [Description1C8(Name = "Месяц7", Comment = "", Synonym = "Месяц 7")]
        // Format 5.0
        public long Месяц7 {get; set;}
        [Description1C8(Name = "Месяц8", Comment = "", Synonym = "Месяц 8")]
        // Format 5.0
        public long Месяц8 {get; set;}
        [Description1C8(Name = "Месяц9", Comment = "", Synonym = "Месяц 9")]
        // Format 5.0
        public long Месяц9 {get; set;}
        [Description1C8(Name = "Месяц10", Comment = "", Synonym = "Месяц 10")]
        // Format 5.0
        public long Месяц10 {get; set;}
        [Description1C8(Name = "Месяц11", Comment = "", Synonym = "Месяц 11")]
        // Format 5.0
        public long Месяц11 {get; set;}
        [Description1C8(Name = "Месяц12", Comment = "", Synonym = "Месяц 12")]
        // Format 5.0
        public long Месяц12 {get; set;}
        [Description1C8(Name = "ВсегоМесяцев", Comment = "", Synonym = "Всего месяцев")]
        // Format 10.0
        public long ВсегоМесяцев {get; set;}
        [Description1C8(Name = "ВсегоДней", Comment = "", Synonym = "Всего дней")]
        // Format 5.0
        public long ВсегоДней {get; set;}
        [Description1C8(Name = "ПолныйМесяц1", Comment = "", Synonym = "Полный месяц1")]
        // Format 1.0
        public long ПолныйМесяц1 {get; set;}
        [Description1C8(Name = "ПолныйМесяц2", Comment = "", Synonym = "Полный месяц2")]
        // Format 1.0
        public long ПолныйМесяц2 {get; set;}
        [Description1C8(Name = "ПолныйМесяц3", Comment = "", Synonym = "Полный месяц3")]
        // Format 1.0
        public long ПолныйМесяц3 {get; set;}
        [Description1C8(Name = "ПолныйМесяц4", Comment = "", Synonym = "Полный месяц4")]
        // Format 1.0
        public long ПолныйМесяц4 {get; set;}
        [Description1C8(Name = "ПолныйМесяц5", Comment = "", Synonym = "Полный месяц5")]
        // Format 1.0
        public long ПолныйМесяц5 {get; set;}
        [Description1C8(Name = "ПолныйМесяц6", Comment = "", Synonym = "Полный месяц6")]
        // Format 1.0
        public long ПолныйМесяц6 {get; set;}
        [Description1C8(Name = "ПолныйМесяц7", Comment = "", Synonym = "Полный месяц7")]
        // Format 1.0
        public long ПолныйМесяц7 {get; set;}
        [Description1C8(Name = "ПолныйМесяц8", Comment = "", Synonym = "Полный месяц8")]
        // Format 1.0
        public long ПолныйМесяц8 {get; set;}
        [Description1C8(Name = "ПолныйМесяц9", Comment = "", Synonym = "Полный месяц9")]
        // Format 1.0
        public long ПолныйМесяц9 {get; set;}
        [Description1C8(Name = "ПолныйМесяц10", Comment = "", Synonym = "Полный месяц10")]
        // Format 1.0
        public long ПолныйМесяц10 {get; set;}
        [Description1C8(Name = "ПолныйМесяц11", Comment = "", Synonym = "Полный месяц11")]
        // Format 1.0
        public long ПолныйМесяц11 {get; set;}
        [Description1C8(Name = "ПолныйМесяц12", Comment = "", Synonym = "Полный месяц12")]
        // Format 1.0
        public long ПолныйМесяц12 {get; set;}
        [Description1C8(Name = "ВсегоДнейНеполногоМесяца", Comment = "", Synonym = "Всего дней неполного месяца")]
        // Format 5.0
        public long ВсегоДнейНеполногоМесяца {get; set;}
        [Description1C8(Name = "МесяцНачала", Comment = "", Synonym = "Месяц начала")]
        // Format 2.0
        public long МесяцНачала {get; set;}
        [Description1C8(Name = "МесяцОкончания", Comment = "", Synonym = "Месяц окончания")]
        // Format 2.0
        public long МесяцОкончания {get; set;}
    }
}
