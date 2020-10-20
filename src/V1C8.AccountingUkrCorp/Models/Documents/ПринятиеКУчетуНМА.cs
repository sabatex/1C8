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
    [Table("PryniatyeKUchetuNMA")]
    [Description1C8(Name = "ПринятиеКУчетуНМА", Comment = "(Регл)", Synonym = "Принятие к учету НМА")]
    public class ПринятиеКУчетуНМА:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Регл)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "(Общ)", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПринятияКУчетуНМА ВидОперации {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "(Регл)", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "НематериальныйАктив", Comment = "(Регл)", Synonym = "Нематериальный актив")]
        public Catalogs.НематериальныеАктивы НематериальныйАктив {get; set;}
        [Description1C8(Name = "СчетУчетаБУВнеоборотногоАктива", Comment = "(Регл)", Synonym = "Счет учета инвестиций в НМА")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУВнеоборотногоАктива {get; set;}
        [Description1C8(Name = "СпособОтраженияРасходов", Comment = "(Регл)", Synonym = "Способ отражения расходов по амортизации")]
        public Catalogs.СпособыОтраженияРасходовПоАмортизации СпособОтраженияРасходов {get; set;}
        [Description1C8(Name = "СчетУчетаБУ", Comment = "(Регл)", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчетаБУ {get; set;}
        [Description1C8(Name = "СтоимостьБУ", Comment = "(Регл)", Synonym = "Первоначальная стоимость (БУ)")]
        // Format 15.2
        public decimal СтоимостьБУ {get; set;}
        [Description1C8(Name = "НачислятьАмортизациюБУ", Comment = "(Регл)", Synonym = "Начислять амортизацию (БУ)")]
        public bool НачислятьАмортизациюБУ {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияБУ", Comment = "(Регл)", Synonym = "Срок полезного использования (БУ)")]
        // Format 4.0
        public long СрокПолезногоИспользованияБУ {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Способ начисления")]
        public Enums.СпособыНачисленияАмортизацииНМА СпособНачисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "ОбъемПродукцииРаботДляВычисленияАмортизации", Comment = "", Synonym = "Объем продукции (работ) для исчисления амортизации в натуральных ед.")]
        // Format 10.0
        public long ОбъемПродукцииРаботДляВычисленияАмортизации {get; set;}
        [Description1C8(Name = "СчетНачисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Счет начисления амортизации")]
        public ПланСчетов.Хозрасчетный СчетНачисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СтоимостьНУ", Comment = "(Регл)", Synonym = "Первоначальная стоимость (НУ)")]
        // Format 15.2
        public decimal СтоимостьНУ {get; set;}
        [Description1C8(Name = "НачислятьАмортизациюНУ", Comment = "(Регл)", Synonym = "Начислять амортизацию (НУ)")]
        public bool НачислятьАмортизациюНУ {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияНУ", Comment = "(Регл)", Synonym = "Срок полезного использования (НУ)")]
        // Format 4.0
        public long СрокПолезногоИспользованияНУ {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Регл) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "ЛиквидационнаяСтоимостьБУ", Comment = "", Synonym = "Ликвидационная стоимость")]
        // Format 15.2
        public decimal ЛиквидационнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "НалоговаяГруппаОС", Comment = "", Synonym = "Налоговая группа НМА")]
        public Catalogs.НалоговыеГруппыОсновныхСредств НалоговаяГруппаОС {get; set;}
        [Description1C8(Name = "ВводНачальныхОстатков", Comment = "", Synonym = "Ввод начальных остатков")]
        public bool ВводНачальныхОстатков {get; set;}
        [Description1C8(Name = "НакопленнаяАмортизацияБУ", Comment = "(Регл)", Synonym = "Накопленная амортизация (БУ)")]
        // Format 15.2
        public decimal НакопленнаяАмортизацияБУ {get; set;}
        [Description1C8(Name = "НакопленнаяАмортизацияНУ", Comment = "(Регл)", Synonym = "Накопленная амортизация (НУ)")]
        // Format 15.2
        public decimal НакопленнаяАмортизацияНУ {get; set;}
        [Description1C8(Name = "ПредседательКомиссии", Comment = "", Synonym = "Председатель комиссии")]
        public Catalogs.ФизическиеЛица ПредседательКомиссии {get; set;}
        [Description1C8(Name = "ПервыйЧленКомиссии", Comment = "", Synonym = "Первый член комиссии")]
        public Catalogs.ФизическиеЛица ПервыйЧленКомиссии {get; set;}
        [Description1C8(Name = "ВторойЧленКомиссии", Comment = "", Synonym = "Второй член комиссии")]
        public Catalogs.ФизическиеЛица ВторойЧленКомиссии {get; set;}
        [Description1C8(Name = "ТретийЧленКомиссии", Comment = "", Synonym = "Третий член комиссии")]
        public Catalogs.ФизическиеЛица ТретийЧленКомиссии {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Регл)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "ОбъектСтроительства", Comment = "(Общ)", Synonym = "Объект строительства")]
        public Catalogs.ОбъектыСтроительства ОбъектСтроительства {get; set;}
        [Description1C8(Name = "МОЛБУ", Comment = "(Регл)", Synonym = "МОЛ")]
        public Catalogs.ФизическиеЛица МОЛБУ {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииНУ", Comment = "(Регл)", Synonym = "Способ начисления (НУ)")]
        public Enums.СпособыНачисленияАмортизацииНМА СпособНачисленияАмортизацииНУ {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
