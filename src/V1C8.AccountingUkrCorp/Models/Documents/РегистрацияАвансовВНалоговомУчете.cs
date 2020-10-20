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
    [Table("RehystratsyiaAvansovVNalohovomUchete")]
    [Description1C8(Name = "РегистрацияАвансовВНалоговомУчете", Comment = "(Регл)", Synonym = "Регистрация авансов (сложный учет НДС)")]
    public class РегистрацияАвансовВНалоговомУчете:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Приобретения", Comment = "", Synonym = "Приобретения")]
        public List<РегистрацияАвансовВНалоговомУчете_Приобретения> РегистрацияАвансовВНалоговомУчетеПриобретения {get;set;}
        [Description1C8(Name = "Продажи", Comment = "", Synonym = "Продажи")]
        public List<РегистрацияАвансовВНалоговомУчете_Продажи> РегистрацияАвансовВНалоговомУчетеПродажи {get;set;}
        [Description1C8(Name = "Возвраты", Comment = "", Synonym = "Возвраты")]
        public List<РегистрацияАвансовВНалоговомУчете_Возвраты> РегистрацияАвансовВНалоговомУчетеВозвраты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Приобретения", Comment = "", Synonym = "Приобретения")]
    [Table("RehystratsyiaAvansovVNalohovomUchete_Pryobretenyia")]
    public class РегистрацияАвансовВНалоговомУчете_Приобретения
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "", Synonym = "По таре")]
        public bool ВозвратнаяТара {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийРегистрацияАвансовВНалоговомУчете ВидОперации {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "%НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаВзаиморасчетовРегл", Comment = "", Synonym = "Сумма (регл)")]
        // Format 15.2
        public decimal СуммаВзаиморасчетовРегл {get; set;}
        [Description1C8(Name = "БазаНДС", Comment = "", Synonym = "База НДС (грн)")]
        // Format 15.2
        public decimal БазаНДС {get; set;}
        [Description1C8(Name = "НДСВходящий", Comment = "", Synonym = "Сумма НДС (грн)")]
        // Format 15.2
        public decimal НДСВходящий {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "", Synonym = "Счет НДС  (н/к)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСНеподтвержденный", Comment = "", Synonym = "Счет НДС (неподтв. н/к)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСНеподтвержденный {get; set;}
        [Description1C8(Name = "РегистрацияПоНДС", Comment = "", Synonym = "Регистрация по НДС")]
        public bool РегистрацияПоНДС {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Нал. назн.")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СуммаВзаиморасчетов", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаВзаиморасчетов {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ)", Synonym = "Курс")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (проп.)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
        [Description1C8(Name = "Амортизируется", Comment = "", Synonym = "Поставка ОФ")]
        public bool Амортизируется {get; set;}
    }
    [Description1C8(Name = "Продажи", Comment = "", Synonym = "Продажи")]
    [Table("RehystratsyiaAvansovVNalohovomUchete_Prodazhy")]
    public class РегистрацияАвансовВНалоговомУчете_Продажи
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "", Synonym = "По таре")]
        public bool ВозвратнаяТара {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийРегистрацияАвансовВНалоговомУчете ВидОперации {get; set;}
        [Description1C8(Name = "РегистрацияПоНДС", Comment = "", Synonym = "Регистрация по НДС")]
        public bool РегистрацияПоНДС {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаВзаиморасчетовРегл", Comment = "", Synonym = "Сумма (грн)")]
        // Format 15.2
        public decimal СуммаВзаиморасчетовРегл {get; set;}
        [Description1C8(Name = "БазаНДС", Comment = "", Synonym = "База НДС (грн)")]
        // Format 15.2
        public decimal БазаНДС {get; set;}
        [Description1C8(Name = "НДС", Comment = "", Synonym = "Сумма НДС (грн)")]
        // Format 15.2
        public decimal НДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "", Synonym = "Счет НДС (н/о)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСНеподтвержденный", Comment = "", Synonym = "Счет НДС (неподтв. н/о)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСНеподтвержденный {get; set;}
        [Description1C8(Name = "СуммаВзаиморасчетов", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal СуммаВзаиморасчетов {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ)", Synonym = "Курс")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
    }
    [Description1C8(Name = "Возвраты", Comment = "", Synonym = "Возвраты")]
    [Table("RehystratsyiaAvansovVNalohovomUchete_Vozvraty")]
    public class РегистрацияАвансовВНалоговомУчете_Возвраты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ВозвратнаяТара", Comment = "", Synonym = "По таре")]
        public bool ВозвратнаяТара {get; set;}
        [Description1C8(Name = "ПревышениеОтгрузкиНадОплатой", Comment = "", Synonym = "Сумма возврата")]
        // Format 15.2
        public decimal ПревышениеОтгрузкиНадОплатой {get; set;}
        [Description1C8(Name = "НеПредполагаетсяЗакрывающаяОперация", Comment = "", Synonym = "Не будет закрываться")]
        public bool НеПредполагаетсяЗакрывающаяОперация {get; set;}
        [Description1C8(Name = "ТипКонтрагента", Comment = "(Нал)", Synonym = "Тип контрагента")]
        public Enums.СтатусыКонтрагентов ТипКонтрагента {get; set;}
    }
}
