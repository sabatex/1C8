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
    [Table("UdalytVvodNachalnykhOstatkovOS")]
    [Description1C8(Name = "УдалитьВводНачальныхОстатковОС", Comment = "(Общ)", Synonym = "(не используется) Ввод начальных остатков по ОС")]
    public class УдалитьВводНачальныхОстатковОС:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ОтражатьВНалоговомУчете", Comment = "(Общ)", Synonym = "Отражать в налоговом учете")]
        public bool ОтражатьВНалоговомУчете {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "(Регл)", Synonym = "Подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<УдалитьВводНачальныхОстатковОС_ОС> УдалитьВводНачальныхОстатковОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("UdalytVvodNachalnykhOstatkovOS_OS")]
    public class УдалитьВводНачальныхОстатковОС_ОС
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
        [Description1C8(Name = "СпособОтраженияРасходовПоАмортизацииБУ", Comment = "(Регл)", Synonym = "Способ отражения расходов по амортизации (БУ)")]
        public Catalogs.СпособыОтраженияРасходовПоАмортизации СпособОтраженияРасходовПоАмортизацииБУ {get; set;}
        [Description1C8(Name = "СрокИспользованияДляВычисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Срок использования для вычисления амортизации, мес. (БУ)")]
        // Format 4.0
        public long СрокИспользованияДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияБУ", Comment = "(Регл)", Synonym = "Срок полезного использования (БУ), мес.")]
        // Format 4.0
        public long СрокПолезногоИспользованияБУ {get; set;}
        [Description1C8(Name = "СтоимостьДляВычисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Стоимость для вычисления амортизации (БУ)")]
        // Format 10.2
        public decimal СтоимостьДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СуммаПоследнейМодернизацииБУ", Comment = "(Регл)", Synonym = "Сумма последней модернизации (БУ)")]
        // Format 15.2
        public decimal СуммаПоследнейМодернизацииБУ {get; set;}
        [Description1C8(Name = "СуммаМодернизацииСНачалаГодаНУ", Comment = "(Регл)", Synonym = "Сумма модернизации  с начала года (НУ)")]
        // Format 15.2
        public decimal СуммаМодернизацииСНачалаГодаНУ {get; set;}
        [Description1C8(Name = "СчетАмортизацииБУ", Comment = "(Регл)", Synonym = "Счет амортизации (БУ)")]
        public ПланСчетов.Хозрасчетный СчетАмортизацииБУ {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета (БУ)")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "ТекущаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Текущая стоимость (БУ)")]
        // Format 15.2
        public decimal ТекущаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "БалансоваяСтоимостьНУ", Comment = "(Регл)", Synonym = "Балансовая стоимость (НУ)")]
        // Format 15.2
        public decimal БалансоваяСтоимостьНУ {get; set;}
        [Description1C8(Name = "УчитываетсяКакЗапасНУ", Comment = "(Регл)", Synonym = "Учитывается как запас НУ")]
        public bool УчитываетсяКакЗапасНУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "ЛиквидационнаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Ликвидационная стоимость (БУ)")]
        // Format 15.2
        public decimal ЛиквидационнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "НепроизводственноеНУ", Comment = "(Регл)", Synonym = "Непроизводственное (НУ)")]
        public bool НепроизводственноеНУ {get; set;}
        [Description1C8(Name = "ПообъектныйУчетНУ", Comment = "(Регл)", Synonym = "Пообъектный учет НУ")]
        public bool ПообъектныйУчетНУ {get; set;}
        [Description1C8(Name = "НалоговаяГруппаОС", Comment = "(Регл)", Synonym = "Налоговая группа ОС")]
        public Catalogs.НалоговыеГруппыОсновныхСредств НалоговаяГруппаОС {get; set;}
    }
}
