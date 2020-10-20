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
    [Table("UdalytRemontOS")]
    [Description1C8(Name = "УдалитьРемонтОС", Comment = "(Общ)", Synonym = "(не используется) Ремонт ОС")]
    public class УдалитьРемонтОС:CatalogItem
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
        [Description1C8(Name = "ОтражатьВНалоговомУчете", Comment = "(Общ)", Synonym = "Отражать в налоговом учете")]
        public bool ОтражатьВНалоговомУчете {get; set;}
        [Description1C8(Name = "СтоимостьБУ", Comment = "(Регл)", Synonym = "Стоимость БУ Объекта строительства")]
        // Format 15.2
        public decimal СтоимостьБУ {get; set;}
        [Description1C8(Name = "СтоимостьНУ", Comment = "(Регл)", Synonym = "Стоимость НУ Объекта строительства")]
        // Format 15.2
        public decimal СтоимостьНУ {get; set;}
        [Description1C8(Name = "СчетУчетаБУВнеоборотногоАктива", Comment = "(Регл)", Synonym = "Счет учета БУ объекта строительства")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУВнеоборотногоАктива {get; set;}
        [Description1C8(Name = "СтатьяВаловыхРасходов", Comment = "", Synonym = "Статья валовых расходов для ОС, учитывающихся как запас.")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяВаловыхРасходов {get; set;}
        [Description1C8(Name = "Сдал", Comment = "(Регл)", Synonym = "Сдал")]
        public Catalogs.ФизическиеЛица Сдал {get; set;}
        [Description1C8(Name = "Принял", Comment = "(Регл)", Synonym = "Принял")]
        public Catalogs.ФизическиеЛица Принял {get; set;}
        [Description1C8(Name = "РуководительОтдела", Comment = "(Регл)", Synonym = "Руководитель отдела")]
        public Catalogs.ФизическиеЛица РуководительОтдела {get; set;}
        [Description1C8(Name = "ДатаНачалаРемонта", Comment = "", Synonym = "Дата начала ремонта")]
        public DateTime ДатаНачалаРемонта {get; set;}
        [Description1C8(Name = "ДатаОкончанияРемонта", Comment = "", Synonym = "Дата окончания ремонта")]
        public DateTime ДатаОкончанияРемонта {get; set;}
        [Description1C8(Name = "ЧтоНеВыполнено", Comment = "", Synonym = "Что не выполнено")]
        public string ЧтоНеВыполнено {get; set;}
        [Description1C8(Name = "ЧтоИзменилось", Comment = "", Synonym = "Что изменилось")]
        public string ЧтоИзменилось {get; set;}
        [Description1C8(Name = "ИспользоватьОбщийСпособОтраженияРасходов", Comment = "", Synonym = "Использовать общий способ отражения расходов")]
        public bool ИспользоватьОбщийСпособОтраженияРасходов {get; set;}
        [Description1C8(Name = "СпособОтраженияРасходов", Comment = "", Synonym = "Способ отражения расходов")]
        public Catalogs.СпособыОтраженияРасходовПоАмортизации СпособОтраженияРасходов {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<УдалитьРемонтОС_ОС> УдалитьРемонтОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("UdalytRemontOS_OS")]
    public class УдалитьРемонтОС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "АмортизацияБУ_Удалить", Comment = "(Регл)", Synonym = "Амортизация б у удалить")]
        // Format 15.2
        public decimal АмортизацияБУ_Удалить {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцБУ_Удалить", Comment = "(Регл)", Synonym = "Амортизация за месяц б у удалить")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцБУ_Удалить {get; set;}
        [Description1C8(Name = "ОбъемПродукцииРаботБУ_Удалить", Comment = "(Регл)", Synonym = "Предполагаемый объем продукции (работ) в натуральных ед.")]
        // Format 10.0
        public long ОбъемПродукцииРаботБУ_Удалить {get; set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияБУ_Удалить", Comment = "(Регл)", Synonym = "Срок полезного использования, мес.")]
        // Format 4.0
        public long СрокПолезногоИспользованияБУ_Удалить {get; set;}
        [Description1C8(Name = "СтоимостьБУ_Удалить", Comment = "(Регл)", Synonym = "Стоимость без учета модернизации БУ")]
        // Format 15.2
        public decimal СтоимостьБУ_Удалить {get; set;}
        [Description1C8(Name = "СуммаРемонтаБУ", Comment = "(Регл)", Synonym = "Сумма ремонта БУ")]
        // Format 15.2
        public decimal СуммаРемонтаБУ {get; set;}
        [Description1C8(Name = "СуммаРемонтаНУ", Comment = "(Регл)", Synonym = "Сумма ремонта НУ")]
        // Format 15.2
        public decimal СуммаРемонтаНУ {get; set;}
        [Description1C8(Name = "ФактОбъемПродукцииРаботБУ_Удалить", Comment = "(Регл)", Synonym = "Факт объем продукции работ б у удалить")]
        // Format 15.2
        public decimal ФактОбъемПродукцииРаботБУ_Удалить {get; set;}
        [Description1C8(Name = "ФактСрокИспользованияБУ_Удалить", Comment = "(Регл)", Synonym = "Факт срок использования б у удалить")]
        // Format 4.0
        public long ФактСрокИспользованияБУ_Удалить {get; set;}
        [Description1C8(Name = "ЛиквидационнаяСтоимостьБУ_Удалить", Comment = "", Synonym = "Ликвидационная стоимость б у удалить")]
        // Format 15.2
        public decimal ЛиквидационнаяСтоимостьБУ_Удалить {get; set;}
    }
}
