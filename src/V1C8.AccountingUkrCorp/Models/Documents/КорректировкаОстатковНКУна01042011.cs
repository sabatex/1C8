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
    [Table("KorrektyrovkaOstatkovNKUna01042011")]
    [Description1C8(Name = "КорректировкаОстатковНКУна01042011", Comment = "(регл)", Synonym = "Корректировка остатков в связи с вступлением в силу норм НКУ на 01.04.2011")]
    public class КорректировкаОстатковНКУна01042011:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "РазделУчета", Comment = "", Synonym = "Раздел учета")]
        public Enums.РазделыУчетаДляКорректировкиОстатковНКУна01042011 РазделУчета {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "КоэффициентМатериальнойСоставляющей", Comment = "", Synonym = "Коэффициент материальной составляющей продукции")]
        // Format 10.3
        public decimal КоэффициентМатериальнойСоставляющей {get; set;}
        [Description1C8(Name = "ВводитьОСВременнаяНалоговаяРазница", Comment = "", Synonym = "Ввести ОС 'Временная налоговая разница'")]
        public bool ВводитьОСВременнаяНалоговаяРазница {get; set;}
        [Description1C8(Name = "ОсновноеСредствоВременнаяНалоговаяРазница", Comment = "(Общ)", Synonym = "Основное средство 'Временная налоговая разница'")]
        public Catalogs.ОсновныеСредства ОсновноеСредствоВременнаяНалоговаяРазница {get; set;}
        [Description1C8(Name = "СтоимостьНУВременнаяНалоговаяРазница", Comment = "(Регл)", Synonym = "Стоимость (НУ) 'Временная разница'")]
        // Format 15.2
        public decimal СтоимостьНУВременнаяНалоговаяРазница {get; set;}
        [Description1C8(Name = "ОтборСчет", Comment = "", Synonym = "Счет")]
        public ПланСчетов.Хозрасчетный ОтборСчет {get; set;}
        [Description1C8(Name = "ОтборГруппаНоменклатуры", Comment = "", Synonym = "Группа номенклатуры")]
        public Catalogs.Номенклатура ОтборГруппаНоменклатуры {get; set;}
        [Description1C8(Name = "ОтборНоменклатурнаяГруппа", Comment = "", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы ОтборНоменклатурнаяГруппа {get; set;}
        [Description1C8(Name = "ОтборСклад", Comment = "", Synonym = "Склад")]
        public Catalogs.Склады ОтборСклад {get; set;}
        [Description1C8(Name = "ОтборКонтрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты ОтборКонтрагент {get; set;}
        [Description1C8(Name = "ОтборПодразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ОтборПодразделение {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "БухСправка", Comment = "", Synonym = "Бух справка")]
        public List<КорректировкаОстатковНКУна01042011_БухСправка> КорректировкаОстатковНКУна01042011БухСправка {get;set;}
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<КорректировкаОстатковНКУна01042011_ОС> КорректировкаОстатковНКУна01042011ОС {get;set;}
        [Description1C8(Name = "НМА", Comment = "", Synonym = "НМА")]
        public List<КорректировкаОстатковНКУна01042011_НМА> КорректировкаОстатковНКУна01042011НМА {get;set;}
        [Description1C8(Name = "ЗапасыВсе", Comment = "", Synonym = "Запасы все")]
        public List<КорректировкаОстатковНКУна01042011_ЗапасыВсе> КорректировкаОстатковНКУна01042011ЗапасыВсе {get;set;}
        [Description1C8(Name = "ТоварыПоПродажнойЦенеАТТ", Comment = "", Synonym = "Товары по продажной цене АТТ")]
        public List<КорректировкаОстатковНКУна01042011_ТоварыПоПродажнойЦенеАТТ> КорректировкаОстатковНКУна01042011ТоварыПоПродажнойЦенеАТТ {get;set;}
        [Description1C8(Name = "ТоварыПоПродажнойЦенеНТТ", Comment = "", Synonym = "Товары по продажной цене НТТ")]
        public List<КорректировкаОстатковНКУна01042011_ТоварыПоПродажнойЦенеНТТ> КорректировкаОстатковНКУна01042011ТоварыПоПродажнойЦенеНТТ {get;set;}
        [Description1C8(Name = "Затраты", Comment = "ТЗР и НЗП", Synonym = "Затраты")]
        public List<КорректировкаОстатковНКУна01042011_Затраты> КорректировкаОстатковНКУна01042011Затраты {get;set;}
        [Description1C8(Name = "РасходыБудущихПериодов", Comment = "", Synonym = "Расходы будущих периодов")]
        public List<КорректировкаОстатковНКУна01042011_РасходыБудущихПериодов> КорректировкаОстатковНКУна01042011РасходыБудущихПериодов {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "БухСправка", Comment = "", Synonym = "Бух справка")]
    [Table("KorrektyrovkaOstatkovNKUna01042011_BukhSpravka")]
    public class КорректировкаОстатковНКУна01042011_БухСправка
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Субконто1", Comment = "", Synonym = "Субконто1")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1 {get; set;}
        [Description1C8(Name = "Субконто2", Comment = "", Synonym = "Субконто2")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2 {get; set;}
        [Description1C8(Name = "Субконто3", Comment = "", Synonym = "Субконто3")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3 {get; set;}
        [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма Дт (БУ)")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СуммаКт", Comment = "", Synonym = "Сумма Кт (БУ)")]
        // Format 15.2
        public decimal СуммаКт {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма НУ")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("KorrektyrovkaOstatkovNKUna01042011_OS")]
    public class КорректировкаОстатковНКУна01042011_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДатаВводаВЭксплуатациюРегл", Comment = "(Регл)", Synonym = "Дата ввода в эксплуатацию")]
        public DateTime ДатаВводаВЭксплуатациюРегл {get; set;}
        [Description1C8(Name = "ИнвентарныйНомерРегл", Comment = "(Регл)", Synonym = "Инвентарный номер")]
        [StringLength(9)]
        public string ИнвентарныйНомерРегл {get; set;}
        [Description1C8(Name = "НакопленнаяАмортизацияБУ", Comment = "(Регл)", Synonym = "Накопленная амортизация (БУ)")]
        // Format 15.2
        public decimal НакопленнаяАмортизацияБУ {get; set;}
        [Description1C8(Name = "НачислятьАмортизациюБУ", Comment = "(Регл)", Synonym = "Начислять амортизацию (БУ)")]
        public bool НачислятьАмортизациюБУ {get; set;}
        [Description1C8(Name = "НачислятьАмортизациюНУ", Comment = "(Регл)", Synonym = "Начислять амортизацию (НУ)")]
        public bool НачислятьАмортизациюНУ {get; set;}
        [Description1C8(Name = "ОбъемПродукцииРаботДляВычисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Объем продукции (работ) для исчисления амортизации в натуральных ед. (БУ)")]
        // Format 10.0
        public long ОбъемПродукцииРаботДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "ПараметрВыработкиБУ", Comment = "(Регл)", Synonym = "Параметр выработки (БУ)")]
        public Catalogs.ПараметрыВыработкиОС ПараметрВыработкиБУ {get; set;}
        [Description1C8(Name = "ПервоначальнаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Первоначальная стоимость (БУ)")]
        // Format 15.2
        public decimal ПервоначальнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Способ начисления амортизации (БУ)")]
        public Enums.СпособыНачисленияАмортизацииОС СпособНачисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СрокИспользованияДляВычисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Срок использования для вычисления амортизации, мес. (БУ)")]
        // Format 4.0
        public long СрокИспользованияДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СрокВЭксплуатацииБУ", Comment = "", Synonym = "Срок в эксплуатации (БУ)")]
        // Format 4.0
        public long СрокВЭксплуатацииБУ {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета (БУ)")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "ТекущаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Остаточная стоимость (БУ)")]
        // Format 15.2
        public decimal ТекущаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "БалансоваяСтоимостьНУ", Comment = "(Регл)", Synonym = "Балансовая стоимость (НУ)")]
        // Format 15.2
        public decimal БалансоваяСтоимостьНУ {get; set;}
        [Description1C8(Name = "ЛиквидационнаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Ликвидационная стоимость (БУ)")]
        // Format 15.2
        public decimal ЛиквидационнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговаяГруппаОС", Comment = "(Регл)", Synonym = "Налоговая группа ОС")]
        public Catalogs.НалоговыеГруппыОсновныхСредств НалоговаяГруппаОС {get; set;}
        [Description1C8(Name = "НепроизводственноеНУ", Comment = "(Регл)", Synonym = "Непроизводственное (НУ)")]
        public bool НепроизводственноеНУ {get; set;}
        [Description1C8(Name = "СрокИспользованияДляВычисленияАмортизацииНУ", Comment = "(Регл)", Synonym = "Срок использования для вычисления амортизации, мес. (НУ)")]
        // Format 4.0
        public long СрокИспользованияДляВычисленияАмортизацииНУ {get; set;}
        [Description1C8(Name = "ИзмененыПараметрыАмортизации", Comment = "(Регл)", Synonym = "Изменены параметры амортизации")]
        public bool ИзмененыПараметрыАмортизации {get; set;}
        [Description1C8(Name = "СчетАмортизацииБУ", Comment = "(Регл)", Synonym = "Счет амортизации (БУ)")]
        public ПланСчетов.Хозрасчетный СчетАмортизацииБУ {get; set;}
    }
    [Description1C8(Name = "НМА", Comment = "", Synonym = "НМА")]
    [Table("KorrektyrovkaOstatkovNKUna01042011_NMA")]
    public class КорректировкаОстатковНКУна01042011_НМА
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НакопленнаяАмортизацияБУ", Comment = "Сумма начисленной амортизации (БУ)", Synonym = "Сумма начисленной амортизации (БУ)")]
        // Format 15.2
        public decimal НакопленнаяАмортизацияБУ {get; set;}
        [Description1C8(Name = "НачислятьАмортизациюБУ", Comment = "(Регл)", Synonym = "Начислять амортизацию (БУ)")]
        public bool НачислятьАмортизациюБУ {get; set;}
        [Description1C8(Name = "НачислятьАмортизациюНУ", Comment = "(Регл)", Synonym = "Начислять амортизацию (НУ)")]
        public bool НачислятьАмортизациюНУ {get; set;}
        [Description1C8(Name = "НематериальныйАктив", Comment = "", Synonym = "Нематериальный актив")]
        public Catalogs.НематериальныеАктивы НематериальныйАктив {get; set;}
        [Description1C8(Name = "ПервоначальнаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Первоначальная стоимость (БУ)")]
        // Format 15.2
        public decimal ПервоначальнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "БалансоваяСтоимостьНУ", Comment = "(Регл)", Synonym = "Балансовая стоимость (НУ)")]
        // Format 15.2
        public decimal БалансоваяСтоимостьНУ {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Способ начисления амортизации (БУ)")]
        public Enums.СпособыНачисленияАмортизацииНМА СпособНачисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияБУ", Comment = "(Регл)", Synonym = "Срок полезного использования, мес.")]
        // Format 4.0
        public long СрокПолезногоИспользованияБУ {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета (БУ)")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "ДатаПринятияКУчетуРегл", Comment = "", Synonym = "Дата ввода в эксплуатацию")]
        public DateTime ДатаПринятияКУчетуРегл {get; set;}
        [Description1C8(Name = "НалоговаяГруппаОС", Comment = "", Synonym = "Налоговая группа ОС")]
        public Catalogs.НалоговыеГруппыОсновныхСредств НалоговаяГруппаОС {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияНУ", Comment = "(Регл)", Synonym = "Срок полезного использования (НУ), мес.")]
        // Format 4.0
        public long СрокПолезногоИспользованияНУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "ТекущаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Остаточная стоимость (БУ)")]
        // Format 15.2
        public decimal ТекущаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "СрокВЭксплуатацииБУ", Comment = "", Synonym = "Срок в эксплуатации (БУ)")]
        // Format 4.0
        public long СрокВЭксплуатацииБУ {get; set;}
        [Description1C8(Name = "СчетАмортизацииБУ", Comment = "(Регл)", Synonym = "Счет амортизации (БУ)")]
        public ПланСчетов.Хозрасчетный СчетАмортизацииБУ {get; set;}
    }
    [Description1C8(Name = "ЗапасыВсе", Comment = "", Synonym = "Запасы все")]
    [Table("KorrektyrovkaOstatkovNKUna01042011_ZapasyVse")]
    public class КорректировкаОстатковНКУна01042011_ЗапасыВсе
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Номенклатура", Comment = "", Synonym = "Номенклатура")]
        public Catalogs.ОсновныеСредства Номенклатура {get; set;}
        [Description1C8(Name = "Партия", Comment = "", Synonym = "Партия")]
        public Documents.ОтчетПроизводстваЗаСмену Партия {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "Склад", Comment = "", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма (бух. учет)")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма НУ")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
    }
    [Description1C8(Name = "ТоварыПоПродажнойЦенеАТТ", Comment = "", Synonym = "Товары по продажной цене АТТ")]
    [Table("KorrektyrovkaOstatkovNKUna01042011_TovaryPoProdazhnoiTseneATT")]
    public class КорректировкаОстатковНКУна01042011_ТоварыПоПродажнойЦенеАТТ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Номенклатура", Comment = "", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Склад", Comment = "", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "Партия", Comment = "", Synonym = "Партия")]
        public Documents.ОтчетПроизводстваЗаСмену Партия {get; set;}
        [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "(Общ)", Synonym = "Цена БУ (себестоимость)")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма БУ (себестоимость)")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "ЦенаНУ", Comment = "(Общ)", Synonym = "Цена НУ (себестоимость)")]
        // Format 15.2
        public decimal ЦенаНУ {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма НУ (себестоимость)")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
        [Description1C8(Name = "ЦенаПродажи", Comment = "(Общ)", Synonym = "Цена (продажи)")]
        // Format 15.2
        public decimal ЦенаПродажи {get; set;}
        [Description1C8(Name = "СуммаПродажи", Comment = "", Synonym = "Сумма (продажи)")]
        // Format 15.2
        public decimal СуммаПродажи {get; set;}
    }
    [Description1C8(Name = "ТоварыПоПродажнойЦенеНТТ", Comment = "", Synonym = "Товары по продажной цене НТТ")]
    [Table("KorrektyrovkaOstatkovNKUna01042011_TovaryPoProdazhnoiTseneNTT")]
    public class КорректировкаОстатковНКУна01042011_ТоварыПоПродажнойЦенеНТТ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Склад", Comment = "(Общ)", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма (себестоимость)")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма НУ (себестоимость)")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
        [Description1C8(Name = "СуммаПродажи", Comment = "", Synonym = "Сумма (продажи)")]
        // Format 15.2
        public decimal СуммаПродажи {get; set;}
    }
    [Description1C8(Name = "Затраты", Comment = "ТЗР и НЗП", Synonym = "Затраты")]
    [Table("KorrektyrovkaOstatkovNKUna01042011_Zatraty")]
    public class КорректировкаОстатковНКУна01042011_Затраты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "(Регл.)", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма (БУ)")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма (НУ)")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
    }
    [Description1C8(Name = "РасходыБудущихПериодов", Comment = "", Synonym = "Расходы будущих периодов")]
    [Table("KorrektyrovkaOstatkovNKUna01042011_RaskhodyBudushchykhPeryodov")]
    public class КорректировкаОстатковНКУна01042011_РасходыБудущихПериодов
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетУчета", Comment = "Счет учета", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма (БУ)")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "РБП", Comment = "", Synonym = "РБП")]
        public Catalogs.РасходыБудущихПериодов РБП {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма (НУ)")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
    }
}
