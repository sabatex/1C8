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
    [Table("PostuplenyeNMA")]
    [Description1C8(Name = "ПоступлениеНМА", Comment = "(Регл)", Synonym = "Поступление НМА")]
    public class ПоступлениеНМА:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Регл)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ)", Synonym = "Курс взаиморасчетов")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "НомерВходящегоДокумента", Comment = "(Общ)", Synonym = "Номер вх.")]
        [StringLength(30)]
        public string НомерВходящегоДокумента {get; set;}
        [Description1C8(Name = "ДатаВходящегоДокумента", Comment = "(Общ)", Synonym = "Дата вх.")]
        public DateTime ДатаВходящегоДокумента {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "(Общ) Сумма в валюте документа, налоги включены согласно флагам", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "СуммаВключаетНДС", Comment = "(Общ)", Synonym = "Сумма включает НДС")]
        public bool СуммаВключаетНДС {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовСКонтрагентом", Comment = "(Регл)", Synonym = "Счет учета расчетов с контрагентом")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовСКонтрагентом {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетовПоАвансам", Comment = "(Регл)", Synonym = "Счет учета расчетов по авансам")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетовПоАвансам {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "УдалитьУчитыватьНДС", Comment = "(Общ)", Synonym = "(не используется) Учитывать НДС")]
        public bool УдалитьУчитыватьНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Регл)", Synonym = "Счет учета НДС (неподтвержденный)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет учета НДС (налоговый кредит)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноВсего", Comment = "", Synonym = "Сумма НДС (пропорционально, вся)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноВсего {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (пропорционально, в кредит)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "ЕстьАвансДо01042011", Comment = "", Synonym = "Есть валовые расходы, начисленные по авансу до 01.04.2011 р.")]
        public bool ЕстьАвансДо01042011 {get; set;}
        [Description1C8(Name = "СуммаВДВРПоАвансуДо01042011", Comment = "", Synonym = "Сумма валовых расходов, начисленных по авансу до 01.04.2011 р. (грн.)")]
        // Format 15.2
        public decimal СуммаВДВРПоАвансуДо01042011 {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
        public List<ПоступлениеНМА_НМА> ПоступлениеНМАНМА {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
    [Table("PostuplenyeNMA_NMA")]
    public class ПоступлениеНМА_НМА
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НематериальныйАктив", Comment = "(Регл)", Synonym = "Нематериальный актив")]
        public Catalogs.НематериальныеАктивы НематериальныйАктив {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ)", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
    }
}
