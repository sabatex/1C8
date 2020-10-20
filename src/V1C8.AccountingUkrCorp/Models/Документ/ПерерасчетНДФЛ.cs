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
    [Table("PereraschetNDFL")]
    [Description1C8(Name = "ПерерасчетНДФЛ", Comment = "", Synonym = "Перерасчет НДФЛ")]
    public class ПерерасчетНДФЛ:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период (год)")]
        // Format 4.0
        public long НалоговыйПериод {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "МесяцПерерасчета", Comment = "", Synonym = "Месяц перерасчета")]
        public DateTime МесяцПерерасчета {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<ПерерасчетНДФЛ_Сотрудники> ПерерасчетНДФЛСотрудники {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("PereraschetNDFL_Sotrudnyky")]
    public class ПерерасчетНДФЛ_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОбособленноеПодразделение", Comment = "", Synonym = "Обособленное подразделение")]
        public Catalogs.ТерриторииВыполненияРабот ОбособленноеПодразделение {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица Сотрудник {get; set;}
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период")]
        public DateTime НалоговыйПериод {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиНДФЛ", Comment = "", Synonym = "Идентификатор строки НДФЛ")]
        // Format 7.0
        public long ИдентификаторСтрокиНДФЛ {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        // Format 15.2
        public decimal Налог {get; set;}
        [Description1C8(Name = "Доход", Comment = "ВидСтавки", Synonym = "Доход")]
        // Format 15.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "ВидСтавки", Comment = "", Synonym = "Вид ставки")]
        public Enums.ВидыСтавокНДФЛ ВидСтавки {get; set;}
        [Description1C8(Name = "УвеличеннаяСтавка", Comment = "", Synonym = "Увеличенная ставка")]
        public Enums.ВидыСтавокНДФЛ УвеличеннаяСтавка {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public Catalogs.ВидыЛьготПоНДФЛ Льгота {get; set;}
        [Description1C8(Name = "КоличествоЛьгот", Comment = "", Synonym = "Количество льгот")]
        // Format 5.2
        public decimal КоличествоЛьгот {get; set;}
        [Description1C8(Name = "СуммаЛьготы", Comment = "", Synonym = "Сумма льготы")]
        // Format 15.2
        public decimal СуммаЛьготы {get; set;}
        [Description1C8(Name = "КодДохода", Comment = "", Synonym = "Код дохода")]
        public Catalogs.ВидыДоходовНДФЛ КодДохода {get; set;}
        [Description1C8(Name = "ДоходПолный", Comment = "", Synonym = "Доход полный")]
        // Format 15.2
        public decimal ДоходПолный {get; set;}
    }
}
