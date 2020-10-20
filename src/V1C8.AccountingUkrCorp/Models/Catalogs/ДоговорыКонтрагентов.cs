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
    [Table("DohovoryKontrahentov")]
    [Description1C8(Name = "ДоговорыКонтрагентов", Comment = "", Synonym = "Договоры контрагентов")]
    public class ДоговорыКонтрагентов
    {
    #region Стандартні реквізити
    public Guid Id {get; set;}
    public bool IsFolder {get; set;}
    public bool DeletionMark {get; set;}
    public bool Predefined {get; set;}
    public string Code {get; set;}
    public string Description {get; set;}
    public Guid? Parent {get; set;}
    public Guid? Owner {get; set;}
    #endregion Стандартні реквізити
    #region реквізити
    [Description1C8(Name = "ВалютаВзаиморасчетов", Comment = "(Общ) Определяет валюту взаиморасчетов по договору, не может меняться, если по договору проведен хотя бы один документ", Synonym = "Валюта взаиморасчетов")]
    public Catalogs.Валюты ВалютаВзаиморасчетов {get; set;}
    [Description1C8(Name = "ВедениеВзаиморасчетов", Comment = "(Общ)", Synonym = "Ведение взаиморасчетов")]
    public Enums.ВедениеВзаиморасчетовПоДоговорам ВедениеВзаиморасчетов {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
    public Catalogs.Организации Организация {get; set;}
    [Description1C8(Name = "ПроцентКомиссионногоВознаграждения", Comment = "(Общ)", Synonym = "Процент комиссионного вознаграждения")]
    // Format 5.2
    public decimal ПроцентКомиссионногоВознаграждения {get; set;}
    [Description1C8(Name = "СпособРасчетаКомиссионногоВознаграждения", Comment = "(Общ)", Synonym = "Способ расчета комиссионного вознаграждения")]
    public Enums.СпособыРасчетаКомиссионногоВознаграждения СпособРасчетаКомиссионногоВознаграждения {get; set;}
    [Description1C8(Name = "ТипЦен", Comment = "(Общ) Тип цен по умолчанию для офрмления покупок по данному договору", Synonym = "Тип цен")]
    public Catalogs.ТипыЦенНоменклатуры ТипЦен {get; set;}
    [Description1C8(Name = "ВидДоговора", Comment = "(Общ)", Synonym = "Вид договора")]
    public Enums.ВидыДоговоровКонтрагентов ВидДоговора {get; set;}
    [Description1C8(Name = "ВидВзаиморасчетов", Comment = "", Synonym = "Вид взаиморасчетов")]
    public Catalogs.ВидыВзаиморасчетов ВидВзаиморасчетов {get; set;}
    [Description1C8(Name = "Дата", Comment = "", Synonym = "Дата")]
    public DateTime Дата {get; set;}
    [Description1C8(Name = "Номер", Comment = "", Synonym = "Номер")]
    [StringLength(25)]
    public string Номер {get; set;}
    [Description1C8(Name = "СхемаНалоговогоУчета", Comment = "(Регл)", Synonym = "Схема налогового учета")]
    public Catalogs.СхемыНалоговогоУчетаПоДоговорамКонтрагентов СхемаНалоговогоУчета {get; set;}
    [Description1C8(Name = "СхемаНалоговогоУчетаПоТаре", Comment = "(Регл) Схема налогового учета для операций взаиморасчетов по таре", Synonym = "Схема налогового учета по таре")]
    public Catalogs.СхемыНалоговогоУчетаПоДоговорамКонтрагентов СхемаНалоговогоУчетаПоТаре {get; set;}
    [Description1C8(Name = "ВидДеятельностиДляДДС", Comment = "(Регл)", Synonym = "Вид деятельности для ДДС")]
    public Enums.ВидыДеятельностиДляДДС ВидДеятельностиДляДДС {get; set;}
    [Description1C8(Name = "ВедениеВзаиморасчетовНУ", Comment = "(Общ)", Synonym = "Ведение взаиморасчетов по налоговому учету")]
    public Enums.ВедениеВзаиморасчетовПоДоговорам ВедениеВзаиморасчетовНУ {get; set;}
    [Description1C8(Name = "СложныйНалоговыйУчет", Comment = "", Synonym = "Сложный учет НДС")]
    public bool СложныйНалоговыйУчет {get; set;}
    [Description1C8(Name = "УстановленСрокОплаты", Comment = "Если не установлен, для контроля просроченной задолженности используется срок из констант", Synonym = "Установлен срок оплаты по договору")]
    public bool УстановленСрокОплаты {get; set;}
    [Description1C8(Name = "СрокОплаты", Comment = "Срок в днях, после которого долг считается просроченным", Synonym = "Срок оплаты")]
    // Format 5.0
    public long СрокОплаты {get; set;}
    [Description1C8(Name = "НаименованиеДляПечати", Comment = "", Synonym = "Наименование для печати")]
    [StringLength(150)]
    public string НаименованиеДляПечати {get; set;}
    [Description1C8(Name = "НеОтноситьНаЗатратыПоНУ", Comment = "", Synonym = "Не относить на затраты по НУ (действует до 01.01.2012)")]
    public bool НеОтноситьНаЗатратыПоНУ {get; set;}
    [Description1C8(Name = "ВидДоговораПоГК", Comment = "", Synonym = "Вид договора по ГК (для налоговой накладной)")]
    public Catalogs.ВидыДоговоровПоГК ВидДоговораПоГК {get; set;}
    [Description1C8(Name = "ФормаРасчетов", Comment = "", Synonym = "Форма расчетов (для налоговой накладной)")]
    [StringLength(50)]
    public string ФормаРасчетов {get; set;}
    [Description1C8(Name = "ОплатаВВалюте", Comment = "", Synonym = "Оплата в валюте")]
    public bool ОплатаВВалюте {get; set;}
    [Description1C8(Name = "ИспользуетсяПриОбменеДанными", Comment = "", Synonym = "Используется при обмене данными")]
    public bool ИспользуетсяПриОбменеДанными {get; set;}
    [Description1C8(Name = "МногостороннееСоглашениеОРазделеПродукции", Comment = "", Synonym = "Многостороннее соглашение о разделе продукции")]
    public bool МногостороннееСоглашениеОРазделеПродукции {get; set;}
    #endregion реквізити
    }
}
