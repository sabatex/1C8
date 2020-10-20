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
    [Table("SpysanyeOS")]
    [Description1C8(Name = "СписаниеОС", Comment = "(Общ)", Synonym = "Списание ОС")]
    public class СписаниеОС:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ПричинаСписания", Comment = "(Общ)", Synonym = "Причина списания")]
        public Catalogs.ПричиныСписанияОС ПричинаСписания {get; set;}
        [Description1C8(Name = "СобытиеОС", Comment = "(Общ)", Synonym = "Событие ОС")]
        public Catalogs.СобытияОС СобытиеОС {get; set;}
        [Description1C8(Name = "СчетСписанияБУ", Comment = "(Регл)", Synonym = "Счет списания")]
        public ПланСчетов.Хозрасчетный СчетСписанияБУ {get; set;}
        [Description1C8(Name = "СубконтоБУ1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоБУ1 {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
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
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Налоговое назначение затрат")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "СписыватьОСВременнаяНалоговаяРазница", Comment = "", Synonym = "Списать ОС 'Временная налоговая разница'")]
        public bool СписыватьОСВременнаяНалоговаяРазница {get; set;}
        [Description1C8(Name = "ОсновноеСредствоВременнаяНалоговаяРазница", Comment = "(Общ)", Synonym = "Основное средство 'Временная налоговая разница'")]
        public Catalogs.ОсновныеСредства ОсновноеСредствоВременнаяНалоговаяРазница {get; set;}
        [Description1C8(Name = "ОстаточнаяСтоимостьНУВременнаяНалоговаяРазница", Comment = "(Регл)", Synonym = "Остаточная стоимость (НУ) 'Временная разница'")]
        // Format 15.2
        public decimal ОстаточнаяСтоимостьНУВременнаяНалоговаяРазница {get; set;}
        [Description1C8(Name = "АмортизацияНУВременнаяНалоговаяРазница", Comment = "(Регл)", Synonym = "Амортизация (НУ) 'Временная разница'")]
        // Format 15.2
        public decimal АмортизацияНУВременнаяНалоговаяРазница {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<СписаниеОС_ОС> СписаниеОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("SpysanyeOS_OS")]
    public class СписаниеОС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "СтоимостьБУ", Comment = "(Регл)", Synonym = "Стоимость (БУ)")]
        // Format 15.2
        public decimal СтоимостьБУ {get; set;}
        [Description1C8(Name = "АмортизацияБУ", Comment = "(Регл)", Synonym = "Амортизация (БУ)")]
        // Format 15.2
        public decimal АмортизацияБУ {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцБУ", Comment = "(Регл)", Synonym = "Амортизация за месяц (БУ)")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцБУ {get; set;}
        [Description1C8(Name = "СтоимостьНУ", Comment = "(Регл)", Synonym = "Стоимость (НУ)")]
        // Format 15.2
        public decimal СтоимостьНУ {get; set;}
        [Description1C8(Name = "СуммаМодернизацииНУ", Comment = "(Регл)", Synonym = "Сумма модернизации (НУ)")]
        // Format 15.2
        public decimal СуммаМодернизацииНУ {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцНУ", Comment = "(Регл)", Synonym = "Амортизация за месяц (НУ)")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцНУ {get; set;}
        [Description1C8(Name = "АмортизацияНУ", Comment = "(Регл)", Synonym = "Амортизация (НУ)")]
        // Format 15.2
        public decimal АмортизацияНУ {get; set;}
        [Description1C8(Name = "ПревышениеСуммДооценокНадСуммамиУценокБУ", Comment = "", Synonym = "Превышение сумм дооценок над суммами уценок (БУ)")]
        // Format 15.2
        public decimal ПревышениеСуммДооценокНадСуммамиУценокБУ {get; set;}
    }
}
