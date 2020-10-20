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
    [Table("ModernyzatsyiaNMA")]
    [Description1C8(Name = "МодернизацияНМА", Comment = "(Общ)", Synonym = "Модернизация НМА")]
    public class МодернизацияНМА:DocumentItem
    {
        #region реквізити
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
        #endregion реквізити
        #region tables
        [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
        public List<МодернизацияНМА_НМА> МодернизацияНМАНМА {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
    [Table("ModernyzatsyiaNMA_NMA")]
    public class МодернизацияНМА_НМА
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "АмортизацияБУ", Comment = "(Регл)", Synonym = "Амортизация (БУ)")]
        // Format 15.2
        public decimal АмортизацияБУ {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцБУ", Comment = "(Регл)", Synonym = "Амортизация за месяц (БУ)")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцБУ {get; set;}
        [Description1C8(Name = "ОбъемПродукцииРаботБУ", Comment = "(Регл)", Synonym = "Предполагаемый объем продукции (работ) в натуральных ед.")]
        // Format 10.0
        public long ОбъемПродукцииРаботБУ {get; set;}
        [Description1C8(Name = "НематериальныйАктив", Comment = "(Общ)", Synonym = "Нематериальный актив")]
        public Catalogs.НематериальныеАктивы НематериальныйАктив {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияБУ", Comment = "(Регл)", Synonym = "Срок полезного использования (БУ)")]
        // Format 4.0
        public long СрокПолезногоИспользованияБУ {get; set;}
        [Description1C8(Name = "СтоимостьБУ", Comment = "(Регл)", Synonym = "Стоимость (БУ)")]
        // Format 15.2
        public decimal СтоимостьБУ {get; set;}
        [Description1C8(Name = "СуммаМодернизацииБУ", Comment = "(Регл)", Synonym = "Сумма модернизации (БУ)")]
        // Format 15.2
        public decimal СуммаМодернизацииБУ {get; set;}
        [Description1C8(Name = "СуммаМодернизацииНУ", Comment = "(Регл)", Synonym = "Сумма модернизации (НУ)")]
        // Format 15.2
        public decimal СуммаМодернизацииНУ {get; set;}
        [Description1C8(Name = "ФактОбъемПродукцииРаботБУ", Comment = "(Регл)", Synonym = "Факт объем продукции работ (БУ)")]
        // Format 15.2
        public decimal ФактОбъемПродукцииРаботБУ {get; set;}
        [Description1C8(Name = "ФактСрокИспользованияБУ", Comment = "(Регл)", Synonym = "Факт срок использования (БУ)")]
        // Format 4.0
        public long ФактСрокИспользованияБУ {get; set;}
        [Description1C8(Name = "ЛиквидационнаяСтоимостьБУ", Comment = "", Synonym = "Ликвидационная стоимость (БУ)")]
        // Format 15.2
        public decimal ЛиквидационнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "АмортизацияНУ", Comment = "(Регл)", Synonym = "Амортизация (НУ)")]
        // Format 15.2
        public decimal АмортизацияНУ {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцНУ", Comment = "(Регл)", Synonym = "Амортизация за месяц (НУ)")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцНУ {get; set;}
        [Description1C8(Name = "СтоимостьНУ", Comment = "(Регл)", Synonym = "Стоимость (НУ)")]
        // Format 15.2
        public decimal СтоимостьНУ {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияНУ", Comment = "(Регл)", Synonym = "Срок полезного использования (НУ)")]
        // Format 4.0
        public long СрокПолезногоИспользованияНУ {get; set;}
    }
}
