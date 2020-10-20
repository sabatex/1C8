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
    [Table("YzmenenyeNalohovohoNaznachenyiaTZR")]
    [Description1C8(Name = "ИзменениеНалоговогоНазначенияТЗР", Comment = "(Регл)", Synonym = "Изменение налогового назначения ТЗР")]
    public class ИзменениеНалоговогоНазначенияТЗР:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "СчетУчетаНДС_НО", Comment = "", Synonym = "Счет НДС (н/о)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС_НО {get; set;}
        [Description1C8(Name = "СчетУчетаКорректировкиНДСКредит", Comment = "", Synonym = "Счет корректировки НДС н/к")]
        public ПланСчетов.Хозрасчетный СчетУчетаКорректировкиНДСКредит {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Затраты", Comment = "(Общ)", Synonym = "Затраты")]
        public List<ИзменениеНалоговогоНазначенияТЗР_Затраты> ИзменениеНалоговогоНазначенияТЗРЗатраты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Затраты", Comment = "(Общ)", Synonym = "Затраты")]
    [Table("YzmenenyeNalohovohoNaznachenyiaTZR_Zatraty")]
    public class ИзменениеНалоговогоНазначенияТЗР_Затраты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетТЗР", Comment = "(Регл)", Synonym = "Счет ТЗР")]
        public ПланСчетов.Хозрасчетный СчетТЗР {get; set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Целевое налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеНовое", Comment = "", Synonym = "Фактическое налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеНовое {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "МетодКорректировкиНалоговогоКредита", Comment = "", Synonym = "Метод корректировки налогового кредита")]
        public Enums.МетодыКорректировкиНалоговогоКредита МетодКорректировкиНалоговогоКредита {get; set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "Субконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1 {get; set;}
        [Description1C8(Name = "Субконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2 {get; set;}
        [Description1C8(Name = "Субконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3 {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
    }
}
