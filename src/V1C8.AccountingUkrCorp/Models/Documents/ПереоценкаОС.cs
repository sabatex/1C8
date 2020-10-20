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
    [Table("PereotsenkaOS")]
    [Description1C8(Name = "ПереоценкаОС", Comment = "(Общ)", Synonym = "Переоценка ОС")]
    public class ПереоценкаОС:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "СобытиеОС", Comment = "(Регл)", Synonym = "Событие ОС")]
        public Catalogs.СобытияОС СобытиеОС {get; set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "ЗатратыСубконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратыСубконто1 {get; set;}
        [Description1C8(Name = "ЗатратыСубконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратыСубконто2 {get; set;}
        [Description1C8(Name = "ЗатратыСубконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратыСубконто3 {get; set;}
        [Description1C8(Name = "СчетДоходов", Comment = "", Synonym = "Счет доходов")]
        public ПланСчетов.Хозрасчетный СчетДоходов {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "ДоходыСубконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности ДоходыСубконто1 {get; set;}
        [Description1C8(Name = "ДоходыСубконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности ДоходыСубконто2 {get; set;}
        [Description1C8(Name = "ДоходыСубконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности ДоходыСубконто3 {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "", Synonym = "ОС")]
        public List<ПереоценкаОС_ОС> ПереоценкаОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "", Synonym = "ОС")]
    [Table("PereotsenkaOS_OS")]
    public class ПереоценкаОС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияБУ", Comment = "(Регл)", Synonym = "Срок полезного использования, мес.")]
        // Format 4.0
        public long СрокПолезногоИспользованияБУ {get; set;}
        [Description1C8(Name = "СрокИспользованияДляВычисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Срок использования для вычисления амортизации, мес.")]
        // Format 4.0
        public long СрокИспользованияДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "ОбъемПродукцииРаботБУ", Comment = "(Регл)", Synonym = "Предполагаемый объем продукции (работ) в натуральных ед.")]
        // Format 10.0
        public long ОбъемПродукцииРаботБУ {get; set;}
        [Description1C8(Name = "ОбъемПродукцииРаботДляВычисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Объем продукции (работ) для исчисления амортизации в натуральных ед.")]
        // Format 10.0
        public long ОбъемПродукцииРаботДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СтоимостьДляВычисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Стоимость для вычисления амортизации")]
        // Format 15.2
        public decimal СтоимостьДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "ЛиквидационнаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Ликвидационная стоимость (БУ)")]
        // Format 15.2
        public decimal ЛиквидационнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "ПараметрВыработкиБУ", Comment = "", Synonym = "Параметр выработки (БУ)")]
        public Catalogs.ПараметрыВыработкиОС ПараметрВыработкиБУ {get; set;}
        [Description1C8(Name = "ПервоначальнаяСтоимостьБУ", Comment = "", Synonym = "Первоначальная стоимость")]
        // Format 15.2
        public decimal ПервоначальнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "НакопленнаяАмортизацияБУ", Comment = "", Synonym = "Накопленная амортизация")]
        // Format 15.2
        public decimal НакопленнаяАмортизацияБУ {get; set;}
        [Description1C8(Name = "ОстаточнаяСтоимостьБУ", Comment = "", Synonym = "Остаточная стоимость")]
        // Format 15.2
        public decimal ОстаточнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "СправедливаяСтоимостьБУ", Comment = "", Synonym = "Справедливая стоимость")]
        // Format 15.2
        public decimal СправедливаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "ИндексПереоценки", Comment = "", Synonym = "Индекс переоценки")]
        // Format 10.6
        public decimal ИндексПереоценки {get; set;}
        [Description1C8(Name = "СуммаПереоценкиПервоначальнойСтоимостиБУ", Comment = "", Synonym = "Сумма переоценки первоначальной стоимости")]
        // Format 15.2
        public decimal СуммаПереоценкиПервоначальнойСтоимостиБУ {get; set;}
        [Description1C8(Name = "СуммаПереоценкиОстаточнойСтоимостиБУ", Comment = "", Synonym = "Сумма переоценки остаточной стоимости")]
        // Format 15.2
        public decimal СуммаПереоценкиОстаточнойСтоимостиБУ {get; set;}
        [Description1C8(Name = "СуммаПереоценкиНакопленнойАмортизацииБУ", Comment = "", Synonym = "Сумма переоценки накопленной амортизации")]
        // Format 15.2
        public decimal СуммаПереоценкиНакопленнойАмортизацииБУ {get; set;}
        [Description1C8(Name = "ПревышениеСуммДооценокНадСуммамиУценокБУ", Comment = "", Synonym = "Превышение сумм дооценок над суммами уценок (БУ)")]
        // Format 15.2
        public decimal ПревышениеСуммДооценокНадСуммамиУценокБУ {get; set;}
    }
}
