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
    [Table("YnventaryzatsyiaNZP")]
    [Description1C8(Name = "ИнвентаризацияНЗП", Comment = "", Synonym = "Инвентаризация НЗП")]
    public class ИнвентаризацияНЗП:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "(Регл)", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "(Регл)", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Состав", Comment = "(Общ)", Synonym = "Состав")]
        public List<ИнвентаризацияНЗП_Состав> ИнвентаризацияНЗПСостав {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Состав", Comment = "(Общ)", Synonym = "Состав")]
    [Table("YnventaryzatsyiaNZP_Sostav")]
    public class ИнвентаризацияНЗП_Состав
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "(Упр)", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
        [Description1C8(Name = "СуммаБУ", Comment = "(Общ)", Synonym = "Сумма остатка (БУ)")]
        // Format 15.2
        public decimal СуммаБУ {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "(Общ)", Synonym = "Сумма остатка (НУ)")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
    }
}
