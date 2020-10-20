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
    [Table("YzmenenyeNalohovohoNaznachenyiaOS")]
    [Description1C8(Name = "ИзменениеНалоговогоНазначенияОС", Comment = "(Общ)", Synonym = "Изменение налогового назначения ОС")]
    public class ИзменениеНалоговогоНазначенияОС:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "СобытиеОС", Comment = "(Общ)", Synonym = "Событие ОС")]
        public Catalogs.СобытияОС СобытиеОС {get; set;}
        [Description1C8(Name = "СчетУчетаЗатрат", Comment = "", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетУчетаЗатрат {get; set;}
        [Description1C8(Name = "ЗатратыСубконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратыСубконто1 {get; set;}
        [Description1C8(Name = "ЗатратыСубконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратыСубконто2 {get; set;}
        [Description1C8(Name = "ЗатратыСубконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности ЗатратыСубконто3 {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение доходов и затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "СпособОтраженияРасходов", Comment = "", Synonym = "Способ отражения расходов по пересчету амортизации")]
        public Catalogs.СпособыОтраженияРасходовПоАмортизации СпособОтраженияРасходов {get; set;}
        [Description1C8(Name = "СчетУчетаКорректировкиНДСКредит", Comment = "", Synonym = "Счет корректировки НДС н/к")]
        public ПланСчетов.Хозрасчетный СчетУчетаКорректировкиНДСКредит {get; set;}
        [Description1C8(Name = "СчетУчетаНДС_НО", Comment = "", Synonym = "Счет НДС (н/о)")]
        public ПланСчетов.Хозрасчетный СчетУчетаНДС_НО {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "ПересчитыватьНакопленнуюАмортизациюВСвязиСКорректировкойНК", Comment = "", Synonym = "Пересчитывать накопленную амортизацию в связи с корректировкой НК")]
        public bool ПересчитыватьНакопленнуюАмортизациюВСвязиСКорректировкойНК {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<ИзменениеНалоговогоНазначенияОС_ОС> ИзменениеНалоговогоНазначенияОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("YzmenenyeNalohovohoNaznachenyiaOS_OS")]
    public class ИзменениеНалоговогоНазначенияОС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеНовое", Comment = "", Synonym = "Налоговое назначение новое")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеНовое {get; set;}
        [Description1C8(Name = "СтоимостьНУ", Comment = "(Регл)", Synonym = "Стоимость по нал. учету")]
        // Format 15.2
        public decimal СтоимостьНУ {get; set;}
        [Description1C8(Name = "АмортизацияНУ", Comment = "(Регл)", Synonym = "Амортизация (НУ)")]
        // Format 15.2
        public decimal АмортизацияНУ {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцНУ", Comment = "(Регл)", Synonym = "Амортизация за месяц по нал. учету")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцНУ {get; set;}
        [Description1C8(Name = "СтоимостьБУ", Comment = "(Регл)", Synonym = "Стоимость по бух. учету")]
        // Format 15.2
        public decimal СтоимостьБУ {get; set;}
        [Description1C8(Name = "АмортизацияБУ", Comment = "(Регл)", Synonym = "Амортизация по бух. учету")]
        // Format 15.2
        public decimal АмортизацияБУ {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцБУ", Comment = "(Регл)", Synonym = "Амортизация за месяц БУ")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцБУ {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "(Общ)", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "МетодКорректировкиНалоговогоКредита", Comment = "", Synonym = "Метод корректировки налогового кредита")]
        public Enums.МетодыКорректировкиНалоговогоКредита МетодКорректировкиНалоговогоКредита {get; set;}
        [Description1C8(Name = "СуммаНУ", Comment = "", Synonym = "Сумма (НУ)")]
        // Format 15.2
        public decimal СуммаНУ {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "(Общ)", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
    }
}
