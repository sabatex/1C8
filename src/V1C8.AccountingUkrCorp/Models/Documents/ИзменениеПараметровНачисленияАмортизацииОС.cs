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
    [Table("YzmenenyeParametrovNachyslenyiaAmortyzatsyyOS")]
    [Description1C8(Name = "ИзменениеПараметровНачисленияАмортизацииОС", Comment = "(Общ)", Synonym = "Изменение параметров амортизации ОС")]
    public class ИзменениеПараметровНачисленияАмортизацииОС:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "СобытиеОС", Comment = "(Регл)", Synonym = "Событие ОС")]
        public Catalogs.СобытияОС СобытиеОС {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "", Synonym = "ОС")]
        public List<ИзменениеПараметровНачисленияАмортизацииОС_ОС> ИзменениеПараметровНачисленияАмортизацииОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "", Synonym = "ОС")]
    [Table("YzmenenyeParametrovNachyslenyiaAmortyzatsyyOS_OS")]
    public class ИзменениеПараметровНачисленияАмортизацииОС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияБУ", Comment = "(Регл)", Synonym = "Срок использования (БУ)")]
        // Format 4.0
        public long СрокПолезногоИспользованияБУ {get; set;}
        [Description1C8(Name = "СрокИспользованияДляВычисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Срок для амортизации (БУ)")]
        // Format 4.0
        public long СрокИспользованияДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "ОбъемПродукцииРаботБУ", Comment = "(Регл)", Synonym = "Объем работ (БУ)")]
        // Format 10.0
        public long ОбъемПродукцииРаботБУ {get; set;}
        [Description1C8(Name = "ОбъемПродукцииРаботДляВычисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Объем работ для амортизации (БУ)")]
        // Format 10.0
        public long ОбъемПродукцииРаботДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СтоимостьДляВычисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Стоимость для вычисления амортизации (БУ)")]
        // Format 15.2
        public decimal СтоимостьДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "ЛиквидационнаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Ликвидационная стоимость (БУ)")]
        // Format 15.2
        public decimal ЛиквидационнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Способ начисления амортизации (БУ)")]
        public Enums.СпособыНачисленияАмортизацииОС СпособНачисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "ПараметрВыработкиБУ", Comment = "", Synonym = "Параметр выработки (БУ)")]
        public Catalogs.ПараметрыВыработкиОС ПараметрВыработкиБУ {get; set;}
        [Description1C8(Name = "СрокИспользованияДляВычисленияАмортизацииНУ", Comment = "(Регл)", Synonym = "Срок использования для вычисления амортизации (НУ), мес.")]
        // Format 4.0
        public long СрокИспользованияДляВычисленияАмортизацииНУ {get; set;}
        [Description1C8(Name = "СтоимостьДляВычисленияАмортизацииНУ", Comment = "(Регл)", Synonym = "Стоимость для вычисления амортизации (НУ)")]
        // Format 15.2
        public decimal СтоимостьДляВычисленияАмортизацииНУ {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияНУ", Comment = "(Регл)", Synonym = "Срок использования (НУ)")]
        // Format 4.0
        public long СрокПолезногоИспользованияНУ {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииНУ", Comment = "(Регл)", Synonym = "Способ начисления амортизации (НУ)")]
        public Enums.СпособыНачисленияАмортизацииОС СпособНачисленияАмортизацииНУ {get; set;}
    }
}
