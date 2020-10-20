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
    [Table("VvodVЕkspluatatsyiuOS")]
    [Description1C8(Name = "ВводВЭксплуатациюОС", Comment = "(Общ)", Synonym = "Ввод в эксплуатацию ОС")]
    public class ВводВЭксплуатациюОС:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "(Общ)", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПринятияКУчетуОсновныхСредств ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "(Регл)", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "СобытиеОС", Comment = "(Общ)", Synonym = "Событие ОС")]
        public Catalogs.СобытияОС СобытиеОС {get; set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Оборудование")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "Склад", Comment = "(Общ)", Synonym = "Склад")]
        public Catalogs.Склады Склад {get; set;}
        [Description1C8(Name = "ОбъектСтроительства", Comment = "(Общ)", Synonym = "Объект строительства")]
        public Catalogs.ОбъектыСтроительства ОбъектСтроительства {get; set;}
        [Description1C8(Name = "СчетУчетаБУВнеоборотногоАктива", Comment = "(Регл)", Synonym = "Счет инвестиций")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУВнеоборотногоАктива {get; set;}
        [Description1C8(Name = "СтоимостьБУ", Comment = "(Регл)", Synonym = "Стоимость (бух. учет)")]
        // Format 15.2
        public decimal СтоимостьБУ {get; set;}
        [Description1C8(Name = "СтоимостьНУ", Comment = "(Регл)", Synonym = "Стоимость (налог. учет)")]
        // Format 15.2
        public decimal СтоимостьНУ {get; set;}
        [Description1C8(Name = "МОЛБУ", Comment = "(Регл)", Synonym = "МОЛ")]
        public Catalogs.ФизическиеЛица МОЛБУ {get; set;}
        [Description1C8(Name = "ОтражатьВНалоговомУчете", Comment = "(Общ)", Synonym = "Отражать в налоговом учете")]
        public bool ОтражатьВНалоговомУчете {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "СчетНачисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Счет начисления амортизации")]
        public ПланСчетов.Хозрасчетный СчетНачисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "НачислятьАмортизациюБУ", Comment = "(Регл)", Synonym = "Начислять амортизацию (БУ)")]
        public bool НачислятьАмортизациюБУ {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Способ начисления амортизации")]
        public Enums.СпособыНачисленияАмортизацииОС СпособНачисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СоставОсновногоСредства", Comment = "(Упр)", Synonym = "Состав основного средства")]
        public Catalogs.ОсновныеСредства СоставОсновногоСредства {get; set;}
        [Description1C8(Name = "СпособыОтраженияРасходовПоАмортизации", Comment = "(Общ)", Synonym = "Способы отражения расходов по амортизации")]
        public Catalogs.СпособыОтраженияРасходовПоАмортизации СпособыОтраженияРасходовПоАмортизации {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияБУ", Comment = "(Регл)", Synonym = "Срок полезного использования, мес.")]
        // Format 4.0
        public long СрокПолезногоИспользованияБУ {get; set;}
        [Description1C8(Name = "ГрафикАмортизацииПоГодуБУ", Comment = "(Регл)", Synonym = "График амортизации по году")]
        public Catalogs.ГодовыеГрафикиАмортизацииОС ГрафикАмортизацииПоГодуБУ {get; set;}
        [Description1C8(Name = "ПараметрВыработкиБУ", Comment = "(Регл)", Synonym = "Параметр выработки")]
        public Catalogs.ПараметрыВыработкиОС ПараметрВыработкиБУ {get; set;}
        [Description1C8(Name = "ПредполагаемыйОбъемПродукцииБУ", Comment = "(Регл)", Synonym = "Предполагаемый объем продукции")]
        // Format 10.0
        public long ПредполагаемыйОбъемПродукцииБУ {get; set;}
        [Description1C8(Name = "НачислятьАмортизациюНУ", Comment = "(Регл)", Synonym = "Начислять амортизацию (НУ)")]
        public bool НачислятьАмортизациюНУ {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "ЛиквидационнаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Ликвидационная стоимость")]
        // Format 15.2
        public decimal ЛиквидационнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "НалоговаяГруппаОС", Comment = "(Регл)", Synonym = "Налоговая группа ОС")]
        public Catalogs.НалоговыеГруппыОсновныхСредств НалоговаяГруппаОС {get; set;}
        [Description1C8(Name = "СубконтоБУ1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоБУ1 {get; set;}
        [Description1C8(Name = "СубконтоБУ2", Comment = "(Регл)", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоБУ2 {get; set;}
        [Description1C8(Name = "СубконтоБУ3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоБУ3 {get; set;}
        [Description1C8(Name = "ПредседательКомиссии", Comment = "", Synonym = "Председатель комиссии")]
        public Catalogs.ФизическиеЛица ПредседательКомиссии {get; set;}
        [Description1C8(Name = "ПервыйЧленКомиссии", Comment = "", Synonym = "Первый член комиссии")]
        public Catalogs.ФизическиеЛица ПервыйЧленКомиссии {get; set;}
        [Description1C8(Name = "ВторойЧленКомиссии", Comment = "", Synonym = "Второй член комиссии")]
        public Catalogs.ФизическиеЛица ВторойЧленКомиссии {get; set;}
        [Description1C8(Name = "ТретийЧленКомиссии", Comment = "", Synonym = "Третий член комиссии")]
        public Catalogs.ФизическиеЛица ТретийЧленКомиссии {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияНУ", Comment = "(Регл)", Synonym = "Срок полезного использования НУ, мес.")]
        // Format 4.0
        public long СрокПолезногоИспользованияНУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеОборудования", Comment = "", Synonym = "Налоговое назначение оборудования (НДС)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеОборудования {get; set;}
        [Description1C8(Name = "СчетУчетаДооценокОС", Comment = "", Synonym = "Счет учета дооценок ОС")]
        public ПланСчетов.Хозрасчетный СчетУчетаДооценокОС {get; set;}
        [Description1C8(Name = "Сдал", Comment = "(Регл)", Synonym = "Сдал")]
        public Catalogs.ФизическиеЛица Сдал {get; set;}
        [Description1C8(Name = "Принял", Comment = "(Регл)", Synonym = "Принял")]
        public Catalogs.ФизическиеЛица Принял {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииНУ", Comment = "(Регл)", Synonym = "Способ начисления амортизации (НУ)")]
        public Enums.СпособыНачисленияАмортизацииОС СпособНачисленияАмортизацииНУ {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<ВводВЭксплуатациюОС_ОС> ВводВЭксплуатациюОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("VvodVЕkspluatatsyiuOS_OS")]
    public class ВводВЭксплуатациюОС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "ИнвентарныйНомер", Comment = "(Регл)", Synonym = "Инвентарный номер")]
        [StringLength(9)]
        public string ИнвентарныйНомер {get; set;}
    }
}
