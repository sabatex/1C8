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
    [Table("KorrektyrovkaDolha")]
    [Description1C8(Name = "КорректировкаДолга", Comment = "(Общ)", Synonym = "Корректировка долга")]
    public class КорректировкаДолга:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийКорректировкаДолга ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "(Общ)", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "КурсДокумента", Comment = "(Общ)", Synonym = "Курс документа")]
        // Format 10.4
        public decimal КурсДокумента {get; set;}
        [Description1C8(Name = "КратностьДокумента", Comment = "(Общ)", Synonym = "Кратность документа")]
        // Format 10.0
        public long КратностьДокумента {get; set;}
        [Description1C8(Name = "КонтрагентДебитор", Comment = "(Общ)", Synonym = "Дебитор")]
        public Catalogs.Контрагенты КонтрагентДебитор {get; set;}
        [Description1C8(Name = "КонтрагентКредитор", Comment = "(Общ)", Synonym = "Кредитор")]
        public Catalogs.Контрагенты КонтрагентКредитор {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "ИспользоватьВспомогательныйСчет", Comment = "", Synonym = "Использовать вспомогательный счет")]
        public bool ИспользоватьВспомогательныйСчет {get; set;}
        [Description1C8(Name = "СчетДт", Comment = "(Регл)", Synonym = "Вспомогательный счет дебиторской задолженности")]
        public ПланСчетов.Хозрасчетный СчетДт {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "(Регл)", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "СчетКт", Comment = "(Регл)", Synonym = "Вспомогательный счет кредиторской задолженности")]
        public ПланСчетов.Хозрасчетный СчетКт {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ТипКонтрагента", Comment = "(Нал)", Synonym = "Тип контрагента")]
        public Enums.СтатусыКонтрагентов ТипКонтрагента {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СуммаКтЗадолженности", Comment = "", Synonym = "Сумма кт задолженности")]
        // Format 15.2
        public decimal СуммаКтЗадолженности {get; set;}
        [Description1C8(Name = "СуммаДтЗадолженности", Comment = "", Synonym = "Сумма дт задолженности")]
        // Format 15.2
        public decimal СуммаДтЗадолженности {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "НеПереноситьНОНК", Comment = "", Synonym = "Не переносить налоговые обязательства (кредит)")]
        public bool НеПереноситьНОНК {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Нал)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет НДС подтвержденный")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "НеОтноситьНаВРСуммуНДСПриСписании", Comment = "", Synonym = "Не относить сумму НДС на расходы/доходы по НУ")]
        public bool НеОтноситьНаВРСуммуНДСПриСписании {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение доходов и затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "СписыватьИзРезерваСомнительныхДолгов", Comment = "", Synonym = "Списывать из резерва сомнительных долгов (признавать в НУ)")]
        public bool СписыватьИзРезерваСомнительныхДолгов {get; set;}
        [Description1C8(Name = "СчетРезерваСомнительныхДолгов", Comment = "(Нал)", Synonym = "Счет резерва сомнительных долгов")]
        public ПланСчетов.Хозрасчетный СчетРезерваСомнительныхДолгов {get; set;}
        [Description1C8(Name = "НачислятьРезервСомнительныхДолгов", Comment = "", Synonym = "Начислять резерв сомнительных долгов")]
        public bool НачислятьРезервСомнительныхДолгов {get; set;}
        [Description1C8(Name = "ПараметрыСписанияСебестоимостиНУ", Comment = "", Synonym = "Параметры списания себестоимости в НУ")]
        public Catalogs.СхемыРеализации ПараметрыСписанияСебестоимостиНУ {get; set;}
        [Description1C8(Name = "НеСторнироватьДоходыСебестоимостьВНУ", Comment = "", Synonym = "Не сторнировать затраты (доходы). Не применять п. 159.1 НКУ")]
        public bool НеСторнироватьДоходыСебестоимостьВНУ {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "СуммыДолга", Comment = "(Общ)", Synonym = "Суммы долга")]
        public List<КорректировкаДолга_СуммыДолга> КорректировкаДолгаСуммыДолга {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "СуммыДолга", Comment = "(Общ)", Synonym = "Суммы долга")]
    [Table("KorrektyrovkaDolha_SummyDolha")]
    public class КорректировкаДолга_СуммыДолга
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ)", Synonym = "Курс взаиморасчетов")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Документ расчетов")]
        public Documents.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "Сумма", Comment = "(Общ) Сумма изменения долга контрагента в валюте взаиморасчетов со всеми налогами", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СуммаВзаиморасчетов", Comment = "(Общ)", Synonym = "Сумма взаиморасчетов")]
        // Format 15.2
        public decimal СуммаВзаиморасчетов {get; set;}
        [Description1C8(Name = "СчетУчетаРасчетов", Comment = "(Регл)", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасчетов {get; set;}
        [Description1C8(Name = "ВидЗадолженности", Comment = "(Общ.) Вид задолженности: дебеторская, кредиторская", Synonym = "Вид задолженности")]
        public Enums.ВидыЗадолженности ВидЗадолженности {get; set;}
        [Description1C8(Name = "ТипКонтрагента", Comment = "(Нал)", Synonym = "Тип контрагента")]
        public Enums.СтатусыКонтрагентов ТипКонтрагента {get; set;}
        [Description1C8(Name = "РасчетыВозврат", Comment = "(Нал)", Synonym = "Расчеты возврат")]
        public Enums.РасчетыВозврат РасчетыВозврат {get; set;}
        [Description1C8(Name = "ЗаТару", Comment = "(Нал)", Synonym = "Расчеты за тару")]
        public bool ЗаТару {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "(Нал)", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Нал)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "НетНалоговойНакладной", Comment = "", Synonym = "Налоговая накладная не получена (не выписана)")]
        public bool НетНалоговойНакладной {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет НДС подтвержденный")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "Амортизируется", Comment = "Поставка Основных фондов. Исользуется для запонения Приложения 5 к Декларации по НДС (с 2008 г)", Synonym = "Поставка основных фондов")]
        public bool Амортизируется {get; set;}
        [Description1C8(Name = "СуммаСебестоимостиНУ", Comment = "(Общ)", Synonym = "Сумма себестоимости НУ (грн.)")]
        // Format 15.2
        public decimal СуммаСебестоимостиНУ {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (пропорционально, в кредит)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
    }
}
