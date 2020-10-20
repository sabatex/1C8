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
    [Table("VvodNachalnykhOstatkov")]
    [Description1C8(Name = "ВводНачальныхОстатков", Comment = "Ввод начальных остатков", Synonym = "Ввод остатков")]
    public class ВводНачальныхОстатков:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "РазделУчета", Comment = "", Synonym = "Раздел учета")]
        public Enums.РазделыУчетаДляВводаОстатков РазделУчета {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "ВводитьОстаткиЗапасовВРазрезеДатОприходования", Comment = "", Synonym = "Вводить остатки запасов в разрезе дат оприходования")]
        public bool ВводитьОстаткиЗапасовВРазрезеДатОприходования {get; set;}
        [Description1C8(Name = "ВводитьОстаткиЗапасовВРазрезеПоставщиков", Comment = "", Synonym = "Вводить остатки запасов в разрезе поставщиков")]
        public bool ВводитьОстаткиЗапасовВРазрезеПоставщиков {get; set;}
        [Description1C8(Name = "ВводитьСуммыУлучшенияВключенныеВБалансовуюСтоимостьОС", Comment = "", Synonym = "Вводить суммы улучшения, включенные в балансовую стоимость ОС")]
        public bool ВводитьСуммыУлучшенияВключенныеВБалансовуюСтоимостьОС {get; set;}
        [Description1C8(Name = "ВводитьОСВременнаяНалоговаяРазница", Comment = "", Synonym = "Ввести ОС 'Временная налоговая разница'")]
        public bool ВводитьОСВременнаяНалоговаяРазница {get; set;}
        [Description1C8(Name = "ОсновноеСредствоВременнаяНалоговаяРазница", Comment = "(Общ)", Synonym = "Основное средство 'Временная налоговая разница'")]
        public Catalogs.ОсновныеСредства ОсновноеСредствоВременнаяНалоговаяРазница {get; set;}
        [Description1C8(Name = "СтоимостьНУВременнаяНалоговаяРазница", Comment = "(Регл)", Synonym = "Стоимость (НУ) 'Временная разница'")]
        // Format 15.2
        public decimal СтоимостьНУВременнаяНалоговаяРазница {get; set;}
        [Description1C8(Name = "АмортизацияНУВременнаяНалоговаяРазница", Comment = "(Регл)", Synonym = "Накопленная амортизация (НУ) 'Временная разница'")]
        // Format 15.2
        public decimal АмортизацияНУВременнаяНалоговаяРазница {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<ВводНачальныхОстатков_ОС> ВводНачальныхОстатковОС {get;set;}
        [Description1C8(Name = "ЗапасыВсе", Comment = "", Synonym = "Запасы все")]
        public List<ВводНачальныхОстатков_ЗапасыВсе> ВводНачальныхОстатковЗапасыВсе {get;set;}
        [Description1C8(Name = "МалоценныеАктивы", Comment = "", Synonym = "Малоценные активы")]
        public List<ВводНачальныхОстатков_МалоценныеАктивы> ВводНачальныхОстатковМалоценныеАктивы {get;set;}
        [Description1C8(Name = "НМА", Comment = "", Synonym = "НМА")]
        public List<ВводНачальныхОстатков_НМА> ВводНачальныхОстатковНМА {get;set;}
        [Description1C8(Name = "РасчетыСКонтрагентами", Comment = "", Synonym = "Расчеты с контрагентами")]
        public List<ВводНачальныхОстатков_РасчетыСКонтрагентами> ВводНачальныхОстатковРасчетыСКонтрагентами {get;set;}
        [Description1C8(Name = "РасчетыПоЗаработнойПлате", Comment = "", Synonym = "Расчеты по заработной плате")]
        public List<ВводНачальныхОстатков_РасчетыПоЗаработнойПлате> ВводНачальныхОстатковРасчетыПоЗаработнойПлате {get;set;}
        [Description1C8(Name = "БухСправка", Comment = "", Synonym = "Бух справка")]
        public List<ВводНачальныхОстатков_БухСправка> ВводНачальныхОстатковБухСправка {get;set;}
        [Description1C8(Name = "РасходыБудущихПериодов", Comment = "", Synonym = "Расходы будущих периодов")]
        public List<ВводНачальныхОстатков_РасходыБудущихПериодов> ВводНачальныхОстатковРасходыБудущихПериодов {get;set;}
        [Description1C8(Name = "ТоварыПоПродажнойЦене", Comment = "", Synonym = "Товары по продажной цене")]
        public List<ВводНачальныхОстатков_ТоварыПоПродажнойЦене> ВводНачальныхОстатковТоварыПоПродажнойЦене {get;set;}
        [Description1C8(Name = "Затраты", Comment = "ТЗР и НЗП", Synonym = "Затраты")]
        public List<ВводНачальныхОстатков_Затраты> ВводНачальныхОстатковЗатраты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("VvodNachalnykhOstatkov_OS")]
    public class ВводНачальныхОстатков_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВыработкаКоличествоБУ", Comment = "(Регл)", Synonym = "Выработка количество (БУ)")]
        // Format 15.3
        public decimal ВыработкаКоличествоБУ {get; set;}
        [Description1C8(Name = "ГрафикАмортизацииБУ", Comment = "(Регл)", Synonym = "График амортизации (БУ)")]
        public Catalogs.ГодовыеГрафикиАмортизацииОС ГрафикАмортизацииБУ {get; set;}
        [Description1C8(Name = "ДатаВводаВЭксплуатациюРегл", Comment = "(Регл)", Synonym = "Дата ввода в эксплуатацию")]
        public DateTime ДатаВводаВЭксплуатациюРегл {get; set;}
        [Description1C8(Name = "ДатаПоследнейМодернизацииРегл", Comment = "(Регл)", Synonym = "Дата последней модернизации (реконструкции)")]
        public DateTime ДатаПоследнейМодернизацииРегл {get; set;}
        [Description1C8(Name = "ИнвентарныйНомерРегл", Comment = "(Регл)", Synonym = "Инвентарный номер")]
        [StringLength(9)]
        public string ИнвентарныйНомерРегл {get; set;}
        [Description1C8(Name = "МОЛРегл", Comment = "(Регл)", Synonym = "МОЛ")]
        public Catalogs.ФизическиеЛица МОЛРегл {get; set;}
        [Description1C8(Name = "НазваниеДокументаВводаВЭксплуатациюРегл", Comment = "(Регл)", Synonym = "Название документа ввода в эксплуатацию")]
        [StringLength(50)]
        public string НазваниеДокументаВводаВЭксплуатациюРегл {get; set;}
        [Description1C8(Name = "НазваниеДокументаМодернизацииРегл", Comment = "(Регл)", Synonym = "Название документа модернизации")]
        [StringLength(50)]
        public string НазваниеДокументаМодернизацииРегл {get; set;}
        [Description1C8(Name = "НакопленнаяАмортизацияБУ", Comment = "(Регл)", Synonym = "Накопленная амортизация (БУ)")]
        // Format 15.2
        public decimal НакопленнаяАмортизацияБУ {get; set;}
        [Description1C8(Name = "НачислятьАмортизациюБУ", Comment = "(Регл)", Synonym = "Начислять амортизацию (БУ)")]
        public bool НачислятьАмортизациюБУ {get; set;}
        [Description1C8(Name = "НачислятьАмортизациюНУ", Comment = "(Регл)", Synonym = "Начислять амортизацию (НУ)")]
        public bool НачислятьАмортизациюНУ {get; set;}
        [Description1C8(Name = "НомерДокументаВводаВЭксплуатациюРегл", Comment = "(Регл)", Synonym = "Номер документа ввода в эксплуатацию")]
        [StringLength(10)]
        public string НомерДокументаВводаВЭксплуатациюРегл {get; set;}
        [Description1C8(Name = "НомерДокументаМодернизацииРегл", Comment = "(Регл)", Synonym = "Номер документа модернизации")]
        [StringLength(10)]
        public string НомерДокументаМодернизацииРегл {get; set;}
        [Description1C8(Name = "ОбъемПродукцииРаботБУ", Comment = "(Регл)", Synonym = "Предполагаемый объем продукции (работ) в натуральных ед. (БУ)")]
        // Format 10.0
        public long ОбъемПродукцииРаботБУ {get; set;}
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
        [Description1C8(Name = "ПервоначальнаяСтоимостьНУ", Comment = "(Регл)", Synonym = "Первоначальная стоимость (НУ)")]
        // Format 15.2
        public decimal ПервоначальнаяСтоимостьНУ {get; set;}
        [Description1C8(Name = "СобытиеВводаВЭксплуатациюРегл", Comment = "(Регл)", Synonym = "Событие ввода в эксплуатацию")]
        public Catalogs.СобытияОС СобытиеВводаВЭксплуатациюРегл {get; set;}
        [Description1C8(Name = "СобытиеМодернизацииРегл", Comment = "(Регл)", Synonym = "Событие при модернизации")]
        public Catalogs.СобытияОС СобытиеМодернизацииРегл {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Способ начисления амортизации (БУ)")]
        public Enums.СпособыНачисленияАмортизацииОС СпособНачисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СпособОтраженияРасходовПоАмортизацииБУ", Comment = "(Регл)", Synonym = "Способ отражения расходов по амортизации")]
        public Catalogs.СпособыОтраженияРасходовПоАмортизации СпособОтраженияРасходовПоАмортизацииБУ {get; set;}
        [Description1C8(Name = "СрокИспользованияДляВычисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Срок использования для вычисления амортизации, мес. (БУ)")]
        // Format 4.0
        public long СрокИспользованияДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияБУ", Comment = "(Регл)", Synonym = "Срок полезного использования (БУ), мес.")]
        // Format 4.0
        public long СрокПолезногоИспользованияБУ {get; set;}
        [Description1C8(Name = "СуммаПоследнейМодернизацииБУ", Comment = "(Регл)", Synonym = "Сумма последней модернизации (БУ)")]
        // Format 15.2
        public decimal СуммаПоследнейМодернизацииБУ {get; set;}
        [Description1C8(Name = "СчетАмортизацииБУ", Comment = "(Регл)", Synonym = "Счет амортизации (БУ)")]
        public ПланСчетов.Хозрасчетный СчетАмортизацииБУ {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "ТекущаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Текущая стоимость (БУ)")]
        // Format 15.2
        public decimal ТекущаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "БалансоваяСтоимостьНУ", Comment = "(Регл)", Synonym = "Амортизируемая стоимость (НУ)")]
        // Format 15.2
        public decimal БалансоваяСтоимостьНУ {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "(Регл.)", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "ЛиквидационнаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Ликвидационная стоимость (БУ)")]
        // Format 15.2
        public decimal ЛиквидационнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговаяГруппаОС", Comment = "(Регл)", Synonym = "Налоговая группа ОС")]
        public Catalogs.НалоговыеГруппыОсновныхСредств НалоговаяГруппаОС {get; set;}
        [Description1C8(Name = "НепроизводственноеНУ", Comment = "(Регл)", Synonym = "Непроизводственное (НУ)")]
        public bool НепроизводственноеНУ {get; set;}
        [Description1C8(Name = "ДатаВводаВЭксплуатациюРеглБУ", Comment = "(Регл)", Synonym = "Дата ввода в эксплуатацию (БУ)")]
        public DateTime ДатаВводаВЭксплуатациюРеглБУ {get; set;}
        [Description1C8(Name = "НакопленнаяАмортизацияНУ", Comment = "(Регл)", Synonym = "Накопленная амортизация (НУ)")]
        // Format 15.2
        public decimal НакопленнаяАмортизацияНУ {get; set;}
        [Description1C8(Name = "СрокИспользованияДляВычисленияАмортизацииНУ", Comment = "(Регл)", Synonym = "Срок использования для вычисления амортизации, мес. (НУ)")]
        // Format 4.0
        public long СрокИспользованияДляВычисленияАмортизацииНУ {get; set;}
        [Description1C8(Name = "СчетУчетаДооценокОС", Comment = "", Synonym = "Счет учета дооценок ОС")]
        public ПланСчетов.Хозрасчетный СчетУчетаДооценокОС {get; set;}
        [Description1C8(Name = "ПревышениеСуммДооценокНадСуммамиУценокБУ", Comment = "", Synonym = "Превышение сумм дооценок над суммами уценок (БУ)")]
        // Format 15.2
        public decimal ПревышениеСуммДооценокНадСуммамиУценокБУ {get; set;}
        [Description1C8(Name = "СуммаДопКапиталаНачисленногоПриДооценкахОСБУ", Comment = "", Synonym = "Сумма доп. капитала, начисленного при дооценках ОС")]
        // Format 15.2
        public decimal СуммаДопКапиталаНачисленногоПриДооценкахОСБУ {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииНУ", Comment = "(Регл)", Synonym = "Способ начисления амортизации (НУ)")]
        public Enums.СпособыНачисленияАмортизацииОС СпособНачисленияАмортизацииНУ {get; set;}
    }
    [Description1C8(Name = "ЗапасыВсе", Comment = "", Synonym = "Запасы все")]
    [Table("VvodNachalnykhOstatkov_ZapasyVse")]
    public class ВводНачальныхОстатков_ЗапасыВсе
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Номенклатура", Comment = "", Synonym = "Номенклатура")]
        public Catalogs.НематериальныеАктивы Номенклатура {get; set;}
        [Description1C8(Name = "Склад", Comment = "", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "Поставщик", Comment = "", Synonym = "Поставщик")]
        public Catalogs.Контрагенты Поставщик {get; set;}
        [Description1C8(Name = "ДоговорПоставщика", Comment = "", Synonym = "Договор поставщика")]
        public Catalogs.ДоговорыКонтрагентов ДоговорПоставщика {get; set;}
        [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Себестоимость (БУ)")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "ДатаПриобретения", Comment = "", Synonym = "Дата приобретения")]
        public DateTime ДатаПриобретения {get; set;}
        [Description1C8(Name = "Цена", Comment = "(Общ)", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "СуммаНоминальная", Comment = "", Synonym = "Сумма номинальная")]
        // Format 15.2
        public decimal СуммаНоминальная {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма (НУ)")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
    }
    [Description1C8(Name = "МалоценныеАктивы", Comment = "", Synonym = "Малоценные активы")]
    [Table("VvodNachalnykhOstatkov_MalotsennyeAktyvy")]
    public class ВводНачальныхОстатков_МалоценныеАктивы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Номенклатура", Comment = "", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Стоимость", Comment = "", Synonym = "Стоимость")]
        // Format 15.2
        public decimal Стоимость {get; set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Работник")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользования", Comment = "", Synonym = "Срок полезного использования")]
        // Format 4.0
        public long СрокПолезногоИспользования {get; set;}
        [Description1C8(Name = "ДатаПриобретения", Comment = "(Общ)", Synonym = "Дата ввода в эксплуатацию")]
        public DateTime ДатаПриобретения {get; set;}
        [Description1C8(Name = "СтоимостьНУ", Comment = "", Synonym = "Стоимость (НУ)")]
        // Format 15.2
        public decimal СтоимостьНУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
    [Description1C8(Name = "НМА", Comment = "", Synonym = "НМА")]
    [Table("VvodNachalnykhOstatkov_NMA")]
    public class ВводНачальныхОстатков_НМА
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НематериальныйАктив", Comment = "", Synonym = "Нематериальный актив")]
        public Catalogs.НематериальныеАктивы НематериальныйАктив {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "СчетНачисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Счет начисления амортизации (БУ)")]
        public ПланСчетов.Хозрасчетный СчетНачисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "ПервоначальнаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Первоначальная стоимость (БУ)")]
        // Format 15.2
        public decimal ПервоначальнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "ПервоначальнаяСтоимостьНУ", Comment = "(Регл)", Synonym = "Первоначальная стоимость (НУ)")]
        // Format 15.2
        public decimal ПервоначальнаяСтоимостьНУ {get; set;}
        [Description1C8(Name = "НакопленнаяАмортизацияБУ", Comment = "Сумма начисленной амортизации (БУ)", Synonym = "Сумма начисленной амортизации (БУ)")]
        // Format 15.2
        public decimal НакопленнаяАмортизацияБУ {get; set;}
        [Description1C8(Name = "НакопленнаяАмортизацияНУ", Comment = "Сумма начисленной амортизации (НУ)", Synonym = "Сумма начисленной амортизации (НУ)")]
        // Format 15.2
        public decimal НакопленнаяАмортизацияНУ {get; set;}
        [Description1C8(Name = "СпособОтраженияРасходов", Comment = "(Регл)", Synonym = "Способ отражения расходов")]
        public Catalogs.СпособыОтраженияРасходовПоАмортизации СпособОтраженияРасходов {get; set;}
        [Description1C8(Name = "НачислятьАмортизациюБУ", Comment = "(Регл)", Synonym = "Начислять амортизацию (БУ)")]
        public bool НачислятьАмортизациюБУ {get; set;}
        [Description1C8(Name = "НачислятьАмортизациюНУ", Comment = "(Регл)", Synonym = "Начислять амортизацию (НУ)")]
        public bool НачислятьАмортизациюНУ {get; set;}
        [Description1C8(Name = "ОбъемПродукцииРаботДляВычисленияАмортизации", Comment = "", Synonym = "Объем продукции (работ) для исчисления амортизации в натуральных ед.")]
        // Format 10.0
        public long ОбъемПродукцииРаботДляВычисленияАмортизации {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Способ начисления амортизации (БУ)")]
        public Enums.СпособыНачисленияАмортизацииНМА СпособНачисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияБУ", Comment = "(Регл)", Synonym = "Срок полезного использования, мес.")]
        // Format 4.0
        public long СрокПолезногоИспользованияБУ {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "(Регл.)", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "ЛиквидационнаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Ликвидационная стоимость (БУ)")]
        // Format 15.2
        public decimal ЛиквидационнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "ДатаПринятияКУчетуРегл", Comment = "", Synonym = "Дата ввода в эксплуатацию")]
        public DateTime ДатаПринятияКУчетуРегл {get; set;}
        [Description1C8(Name = "НалоговаяГруппаОС", Comment = "", Synonym = "Налоговая группа ОС")]
        public Catalogs.НалоговыеГруппыОсновныхСредств НалоговаяГруппаОС {get; set;}
        [Description1C8(Name = "УчитываетсяКакОСНУ", Comment = "", Synonym = "Учитывается как ОС (НУ)")]
        public bool УчитываетсяКакОСНУ {get; set;}
        [Description1C8(Name = "МОЛБУ", Comment = "(Регл)", Synonym = "Материально-ответственное лицо (БУ)")]
        public Catalogs.ФизическиеЛица МОЛБУ {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияНУ", Comment = "(Регл)", Synonym = "Срок полезного использования (НУ), мес.")]
        // Format 4.0
        public long СрокПолезногоИспользованияНУ {get; set;}
        [Description1C8(Name = "ДатаПринятияКУчетуРеглБУ", Comment = "", Synonym = "Дата ввода в эксплуатацию (БУ)")]
        public DateTime ДатаПринятияКУчетуРеглБУ {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииНУ", Comment = "(Регл)", Synonym = "Способ начисления амортизации (НУ)")]
        public Enums.СпособыНачисленияАмортизацииНМА СпособНачисленияАмортизацииНУ {get; set;}
    }
    [Description1C8(Name = "РасчетыСКонтрагентами", Comment = "", Synonym = "Расчеты с контрагентами")]
    [Table("VvodNachalnykhOstatkov_RaschetySKontrahentamy")]
    public class ВводНачальныхОстатков_РасчетыСКонтрагентами
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "Документ", Comment = "", Synonym = "Документ расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Документ {get; set;}
        [Description1C8(Name = "КратностьВзаиморасчетов", Comment = "(Общ)", Synonym = "Кратность взаиморасчетов")]
        // Format 10.0
        public long КратностьВзаиморасчетов {get; set;}
        [Description1C8(Name = "КурсВзаиморасчетов", Comment = "(Общ) Курс валюты взаиморасчетов по договору", Synonym = "Курс взаиморасчетов")]
        // Format 10.4
        public decimal КурсВзаиморасчетов {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма (регл)")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "Валюта", Comment = "", Synonym = "Валюта")]
        public Catalogs.Валюты Валюта {get; set;}
        [Description1C8(Name = "ВалютнаяСумма", Comment = "", Synonym = "Валютная сумма")]
        // Format 15.2
        public decimal ВалютнаяСумма {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "Грн.сумма остатка вал.расчетов для целей НДС", Synonym = "Сумма для НДС, грн.")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "грн.сумма в оценке для НУ", Synonym = "Сумма для НУ, грн.")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
        [Description1C8(Name = "ТипКонтрагента", Comment = "(Нал)", Synonym = "Тип контрагента")]
        public Enums.СтатусыКонтрагентов ТипКонтрагента {get; set;}
        [Description1C8(Name = "ВидЗадолженности", Comment = "Вид задолженности", Synonym = "Вид задолженности")]
        public Enums.ВидыЗадолженности ВидЗадолженности {get; set;}
        [Description1C8(Name = "ЗаТару", Comment = "(Нал)", Synonym = "Расчеты за тару")]
        public bool ЗаТару {get; set;}
        [Description1C8(Name = "РасчетыВозврат", Comment = "(Нал)", Synonym = "Расчеты возврат")]
        public Enums.РасчетыВозврат РасчетыВозврат {get; set;}
        [Description1C8(Name = "СчетУчетаНДС", Comment = "(Нал)", Synonym = "Счет НДС")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС {get; set;}
        [Description1C8(Name = "СчетУчетаНДСПодтвержденный", Comment = "", Synonym = "Счет НДС подтвержденный")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДСПодтвержденный {get; set;}
        [Description1C8(Name = "НетНалоговойНакладной", Comment = "", Synonym = "Налоговая накладная не получена (не выписана)")]
        public bool НетНалоговойНакладной {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "(Нал)", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "ВзаиморасчетыЗакрыты", Comment = "", Synonym = "Вводится остаток неполученных налоговых накладных при закрытых взаиморасчетах")]
        public bool ВзаиморасчетыЗакрыты {get; set;}
        [Description1C8(Name = "Амортизируется", Comment = "Поставка Основных фондов. Исользуется для запонения Приложения 5 к Декларации по НДС (с 2008 г)", Synonym = "Поставка основных фондов")]
        public bool Амортизируется {get; set;}
    }
    [Description1C8(Name = "РасчетыПоЗаработнойПлате", Comment = "", Synonym = "Расчеты по заработной плате")]
    [Table("VvodNachalnykhOstatkov_RaschetyPoZarabotnoiPlate")]
    public class ВводНачальныхОстатков_РасчетыПоЗаработнойПлате
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Месяц начисления")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Ведомость", Comment = "", Synonym = "Ведомость (для депонентов)")]
        public Документ.УстарелоВедомостьНаВыплатуЗарплаты Ведомость {get; set;}
        [Description1C8(Name = "РаботникОрганизации", Comment = "", Synonym = "Работник")]
        public Catalogs.Сотрудники РаботникОрганизации {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "", Synonym = "База взноса")]
        // Format 14.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Доход", Comment = "", Synonym = "Доход")]
        // Format 15.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "'Код дохода НДФЛ' или 'Вид расчета взносов наФОТ'", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "ВидСтавки", Comment = "", Synonym = "Вид ставки")]
        public Enums.ВидыСтавокНДФЛ ВидСтавки {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public Catalogs.УстарелоВидыЛьготПоНДФЛ Льгота {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "БухСправка", Comment = "", Synonym = "Бух справка")]
    [Table("VvodNachalnykhOstatkov_BukhSpravka")]
    public class ВводНачальныхОстатков_БухСправка
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
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма (бух. учет)")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "Валюта", Comment = "", Synonym = "Валюта")]
        public Catalogs.Валюты Валюта {get; set;}
        [Description1C8(Name = "ВалютнаяСумма", Comment = "", Synonym = "Вал. сумма")]
        // Format 15.2
        public decimal ВалютнаяСумма {get; set;}
        [Description1C8(Name = "СуммаКт", Comment = "", Synonym = "Сумма по кредиту (регл)")]
        // Format 15.2
        public decimal СуммаКт {get; set;}
        [Description1C8(Name = "Курс", Comment = "(Общ)", Synonym = "Курс")]
        // Format 10.4
        public decimal Курс {get; set;}
        [Description1C8(Name = "Цена", Comment = "(Общ)", Synonym = "Цена")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Кратность", Comment = "", Synonym = "Кратность")]
        // Format 10.0
        public long Кратность {get; set;}
    }
    [Description1C8(Name = "РасходыБудущихПериодов", Comment = "", Synonym = "Расходы будущих периодов")]
    [Table("VvodNachalnykhOstatkov_RaskhodyBudushchykhPeryodov")]
    public class ВводНачальныхОстатков_РасходыБудущихПериодов
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетУчета", Comment = "Счет учета", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Наименование", Comment = "", Synonym = "Наименование")]
        [StringLength(100)]
        public string Наименование {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ДатаОкончанияСписания", Comment = "(Общ)", Synonym = "Дата окончания списания")]
        public DateTime ДатаОкончанияСписания {get; set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "Счет затрат", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "Субконто1", Comment = "", Synonym = "Субконто1")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1 {get; set;}
        [Description1C8(Name = "Субконто2", Comment = "", Synonym = "Субконто2")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2 {get; set;}
        [Description1C8(Name = "Субконто3", Comment = "", Synonym = "Субконто3")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3 {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма НУ")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение доходов и затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "МетодРаспределения", Comment = "", Synonym = "Метод распределения")]
        public Enums.МетодыРаспределенияРБП МетодРаспределения {get; set;}
    }
    [Description1C8(Name = "ТоварыПоПродажнойЦене", Comment = "", Synonym = "Товары по продажной цене")]
    [Table("VvodNachalnykhOstatkov_TovaryPoProdazhnoiTsene")]
    public class ВводНачальныхОстатков_ТоварыПоПродажнойЦене
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Номенклатура", Comment = "", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Магазин", Comment = "(Общ)", Synonym = "Магазин")]
        public Catalogs.Склады Магазин {get; set;}
        [Description1C8(Name = "Количество", Comment = "", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "Цена", Comment = "(Общ)", Synonym = "Цена (себестоимость)")]
        // Format 15.2
        public decimal Цена {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма (себестоимость)")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "ДатаПриобретения", Comment = "", Synonym = "Дата приобретения")]
        public DateTime ДатаПриобретения {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма (НУ)")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
        [Description1C8(Name = "Поставщик", Comment = "", Synonym = "Поставщик")]
        public Catalogs.Контрагенты Поставщик {get; set;}
        [Description1C8(Name = "ДоговорПоставщика", Comment = "", Synonym = "Договор поставщика")]
        public Catalogs.ДоговорыКонтрагентов ДоговорПоставщика {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "ЦенаПродажи", Comment = "(Общ)", Synonym = "Цена (продажи)")]
        // Format 15.2
        public decimal ЦенаПродажи {get; set;}
        [Description1C8(Name = "СуммаПродажи", Comment = "", Synonym = "Сумма (продажи)")]
        // Format 15.2
        public decimal СуммаПродажи {get; set;}
        [Description1C8(Name = "НомерСтрокиТЧ", Comment = "", Synonym = "Номер строки")]
        // Format 20.0
        public long НомерСтрокиТЧ {get; set;}
    }
    [Description1C8(Name = "Затраты", Comment = "ТЗР и НЗП", Synonym = "Затраты")]
    [Table("VvodNachalnykhOstatkov_Zatraty")]
    public class ВводНачальныхОстатков_Затраты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "(Регл.)", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "НоменклатурнаяГруппа", Comment = "", Synonym = "Номенклатурная группа")]
        public Catalogs.НоменклатурныеГруппы НоменклатурнаяГруппа {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма (бух. учет)")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма (НУ)")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
    }
}
