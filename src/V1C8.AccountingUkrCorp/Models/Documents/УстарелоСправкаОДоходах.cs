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
    [Table("UstareloSpravkaODokhodakh")]
    [Description1C8(Name = "УстарелоСправкаОДоходах", Comment = "", Synonym = "ѳ(устарело) Справка о доходах")]
    public class УстарелоСправкаОДоходах:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ДатаНач", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНач {get; set;}
        [Description1C8(Name = "ДатаКон", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаКон {get; set;}
        [Description1C8(Name = "НазначениеСправки", Comment = "", Synonym = "Назначение справки")]
        public string НазначениеСправки {get; set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "ВидСправки", Comment = "", Synonym = "Вид справки")]
        public Enums.ВидыСправокОДоходах ВидСправки {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Доходы", Comment = "", Synonym = "Доходы")]
        public List<УстарелоСправкаОДоходах_Доходы> УстарелоСправкаОДоходахДоходы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Доходы", Comment = "", Synonym = "Доходы")]
    [Table("UstareloSpravkaODokhodakh_Dokhody")]
    public class УстарелоСправкаОДоходах_Доходы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "СовокупныйДоход", Comment = "", Synonym = "Совокупный доход")]
        // Format 15.2
        public decimal СовокупныйДоход {get; set;}
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        // Format 15.2
        public decimal Удержания {get; set;}
        [Description1C8(Name = "СуммаКВыплате", Comment = "", Synonym = "Сумма к выплате")]
        // Format 15.2
        public decimal СуммаКВыплате {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 15.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ВсегоОблагаемое", Comment = "", Synonym = "Всего облагаемое")]
        // Format 15.2
        public decimal ВсегоОблагаемое {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 15.2
        public decimal Предел {get; set;}
        [Description1C8(Name = "РезультатОсновное", Comment = "", Synonym = "Результат основное")]
        // Format 15.2
        public decimal РезультатОсновное {get; set;}
        [Description1C8(Name = "РезультатСовместительство", Comment = "", Synonym = "Результат совместительство")]
        // Format 15.2
        public decimal РезультатСовместительство {get; set;}
        [Description1C8(Name = "РезультатВсего", Comment = "", Synonym = "Результат всего")]
        // Format 15.2
        public decimal РезультатВсего {get; set;}
        [Description1C8(Name = "НачисленоЗП", Comment = "", Synonym = "Начислено ЗП")]
        // Format 15.2
        public decimal НачисленоЗП {get; set;}
        [Description1C8(Name = "НачисленоПрочее", Comment = "", Synonym = "Начислено прочее")]
        // Format 15.2
        public decimal НачисленоПрочее {get; set;}
        [Description1C8(Name = "Алименты", Comment = "", Synonym = "Алименты")]
        // Format 15.2
        public decimal Алименты {get; set;}
        [Description1C8(Name = "КалендарныеДни", Comment = "", Synonym = "Календарные дни")]
        // Format 15.2
        public decimal КалендарныеДни {get; set;}
        [Description1C8(Name = "РезультатВзносы", Comment = "", Synonym = "Удержано взносов")]
        // Format 15.2
        public decimal РезультатВзносы {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "", Synonym = "Доход, облагаемый НДФЛ")]
        // Format 15.2
        public decimal ДоходНДФЛ {get; set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "Сумма НДФЛ")]
        // Format 15.2
        public decimal НДФЛ {get; set;}
        [Description1C8(Name = "ОблагаемоеЕСВ", Comment = "", Synonym = "Облагаемое ЕСВ")]
        // Format 15.2
        public decimal ОблагаемоеЕСВ {get; set;}
        [Description1C8(Name = "ОблагаемоеЕСВПредел", Comment = "", Synonym = "Облагаемое ЕСВ с учетом предела")]
        // Format 15.2
        public decimal ОблагаемоеЕСВПредел {get; set;}
        [Description1C8(Name = "Выплачено", Comment = "", Synonym = "Выплачено")]
        // Format 15.2
        public decimal Выплачено {get; set;}
        [Description1C8(Name = "ДоходВоенныйСбор", Comment = "", Synonym = "Доход для военного сбора")]
        // Format 15.2
        public decimal ДоходВоенныйСбор {get; set;}
        [Description1C8(Name = "ВоенныйСбор", Comment = "", Synonym = "Сумма военного сбора")]
        // Format 15.2
        public decimal ВоенныйСбор {get; set;}
        [Description1C8(Name = "ДоходЗаВычетомНДФЛ", Comment = "", Synonym = "Сумма дохода за вычетом НДФЛ")]
        // Format 15.2
        public decimal ДоходЗаВычетомНДФЛ {get; set;}
        [Description1C8(Name = "НДФЛПрочее", Comment = "", Synonym = "Сумма НДФЛ (прочее)")]
        // Format 15.2
        public decimal НДФЛПрочее {get; set;}
        [Description1C8(Name = "СтавкаВзносов", Comment = "", Synonym = "Ставка взносов")]
        // Format 10.2
        public decimal СтавкаВзносов {get; set;}
    }
}
