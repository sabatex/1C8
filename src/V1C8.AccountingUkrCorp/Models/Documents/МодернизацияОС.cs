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
    [Table("ModernyzatsyiaOS")]
    [Description1C8(Name = "МодернизацияОС", Comment = "(Общ)", Synonym = "Модернизация и ремонт ОС")]
    public class МодернизацияОС:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "СобытиеОС", Comment = "(Регл)", Synonym = "Событие")]
        public Catalogs.СобытияОС СобытиеОС {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ)", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ОбъектСтроительства", Comment = "(Общ)", Synonym = "Объект строительства")]
        public Catalogs.ОбъектыСтроительства ОбъектСтроительства {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "СтоимостьБУ", Comment = "(Регл)", Synonym = "Общая сумма (БУ)")]
        // Format 15.2
        public decimal СтоимостьБУ {get; set;}
        [Description1C8(Name = "СтоимостьНУ", Comment = "(Регл)", Synonym = "Общая сумма (НУ)")]
        // Format 15.2
        public decimal СтоимостьНУ {get; set;}
        [Description1C8(Name = "СчетУчетаБУВнеоборотногоАктива", Comment = "(Регл)", Synonym = "Счет учета объекта строительства")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУВнеоборотногоАктива {get; set;}
        [Description1C8(Name = "Сдал", Comment = "(Регл)", Synonym = "Сдал")]
        public Catalogs.ФизическиеЛица Сдал {get; set;}
        [Description1C8(Name = "Принял", Comment = "(Регл)", Synonym = "Принял")]
        public Catalogs.ФизическиеЛица Принял {get; set;}
        [Description1C8(Name = "РуководительОтдела", Comment = "(Регл)", Synonym = "Руководитель отдела")]
        public Catalogs.ФизическиеЛица РуководительОтдела {get; set;}
        [Description1C8(Name = "ДатаНачалаМодернизации", Comment = "", Synonym = "Дата начала модернизации")]
        public DateTime ДатаНачалаМодернизации {get; set;}
        [Description1C8(Name = "ДатаОкончанияМодернизации", Comment = "", Synonym = "Дата окончания модернизации")]
        public DateTime ДатаОкончанияМодернизации {get; set;}
        [Description1C8(Name = "ЧтоНеВыполнено", Comment = "", Synonym = "Что не выполнено")]
        public string ЧтоНеВыполнено {get; set;}
        [Description1C8(Name = "ЧтоИзменилось", Comment = "", Synonym = "Что изменилось")]
        public string ЧтоИзменилось {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "ИспользоватьОбщийСпособОтраженияРасходов", Comment = "", Synonym = "Использовать общий способ отражения расходов")]
        public bool ИспользоватьОбщийСпособОтраженияРасходов {get; set;}
        [Description1C8(Name = "СпособОтраженияРасходов", Comment = "", Synonym = "Способ отражения расходов")]
        public Catalogs.СпособыОтраженияРасходовПоАмортизации СпособОтраженияРасходов {get; set;}
        [Description1C8(Name = "ВидУлучшения", Comment = "", Synonym = "Вид улучшения")]
        public Enums.ВидыУлучшения ВидУлучшения {get; set;}
        [Description1C8(Name = "ПриАвтозаполненииНеИзменятьАмортизируемуюСтоимостьОСБУ", Comment = "", Synonym = "При автозаполнении не изменять амортизируемую стоимость ОС")]
        public bool ПриАвтозаполненииНеИзменятьАмортизируемуюСтоимостьОСБУ {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<МодернизацияОС_ОС> МодернизацияОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("ModernyzatsyiaOS_OS")]
    public class МодернизацияОС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияБУ", Comment = "(Регл)", Synonym = "Срок полезного использования, мес.")]
        // Format 4.0
        public long СрокПолезногоИспользованияБУ {get; set;}
        [Description1C8(Name = "ФактСрокИспользованияБУ", Comment = "(Регл)", Synonym = "Факт срок использования (БУ)")]
        // Format 4.0
        public long ФактСрокИспользованияБУ {get; set;}
        [Description1C8(Name = "ОбъемПродукцииРаботБУ", Comment = "(Регл)", Synonym = "Новый объем работ")]
        // Format 10.0
        public long ОбъемПродукцииРаботБУ {get; set;}
        [Description1C8(Name = "ФактОбъемПродукцииРаботБУ", Comment = "(Регл)", Synonym = "Факт объем продукции работ (БУ)")]
        // Format 15.2
        public decimal ФактОбъемПродукцииРаботБУ {get; set;}
        [Description1C8(Name = "СтоимостьБУ", Comment = "(Регл)", Synonym = "Стоимость (БУ)")]
        // Format 15.2
        public decimal СтоимостьБУ {get; set;}
        [Description1C8(Name = "СуммаМодернизацииБУ", Comment = "(Регл)", Synonym = "Сумма модернизации (БУ)")]
        // Format 15.2
        public decimal СуммаМодернизацииБУ {get; set;}
        [Description1C8(Name = "АмортизацияБУ", Comment = "(Регл)", Synonym = "Амортизация БУ")]
        // Format 15.2
        public decimal АмортизацияБУ {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцБУ", Comment = "(Регл)", Synonym = "Амортизация за месяц (БУ)")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцБУ {get; set;}
        [Description1C8(Name = "СуммаМодернизацииНУ", Comment = "(Регл)", Synonym = "Сумма улучшения НУ")]
        // Format 15.2
        public decimal СуммаМодернизацииНУ {get; set;}
        [Description1C8(Name = "ЛиквидационнаяСтоимостьБУ", Comment = "", Synonym = "Ликвидационная стоимость (БУ)")]
        // Format 15.2
        public decimal ЛиквидационнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "СуммаУлучшенияВПределахНормНУ", Comment = "(Регл)", Synonym = "Сумма улучшения в пределах норм (НУ)")]
        // Format 15.2
        public decimal СуммаУлучшенияВПределахНормНУ {get; set;}
        [Description1C8(Name = "АмортизацияНУ", Comment = "(Регл)", Synonym = "Амортизация (НУ)")]
        // Format 15.2
        public decimal АмортизацияНУ {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцНУ", Comment = "(Регл)", Synonym = "Амортизация за месяц (НУ)")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцНУ {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияНУ", Comment = "(Регл)", Synonym = "Срок полезного использования, в месяцах (НУ)")]
        // Format 4.0
        public long СрокПолезногоИспользованияНУ {get; set;}
        [Description1C8(Name = "СтоимостьНУ", Comment = "(Регл)", Synonym = "Стоимость (НУ)")]
        // Format 15.2
        public decimal СтоимостьНУ {get; set;}
        [Description1C8(Name = "СрокИспользованияДляВычисленияАмортизацииБУ", Comment = "", Synonym = "Срок использования для вычисления амортизации (БУ)")]
        // Format 4.0
        public long СрокИспользованияДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СрокИспользованияДляВычисленияАмортизацииНУ", Comment = "", Synonym = "Срок использования для вычисления амортизации )НУ)")]
        // Format 4.0
        public long СрокИспользованияДляВычисленияАмортизацииНУ {get; set;}
        [Description1C8(Name = "СтоимостьДляВычисленияАмортизацииБУ", Comment = "", Synonym = "Стоимость для вычисления амортизации (БУ)")]
        // Format 15.2
        public decimal СтоимостьДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СтоимостьДляВычисленияАмортизацииНУ", Comment = "", Synonym = "Стоимость для вычисления амортизации (НУ)")]
        // Format 15.2
        public decimal СтоимостьДляВычисленияАмортизацииНУ {get; set;}
        [Description1C8(Name = "ФактСрокИспользованияНУ", Comment = "(Регл)", Synonym = "Факт срок использования (НУ)")]
        // Format 4.0
        public long ФактСрокИспользованияНУ {get; set;}
    }
}
