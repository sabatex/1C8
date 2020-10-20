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
    [Table("YndeksatsyiaOS")]
    [Description1C8(Name = "ИндексацияОС", Comment = "(Общ)", Synonym = "Индексация ОС (НУ)")]
    public class ИндексацияОС:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "СобытиеОС", Comment = "(Регл)", Synonym = "Событие с основными средствами")]
        public Catalogs.СобытияОС СобытиеОС {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "КоэффициентИндексации", Comment = "", Synonym = "Коэффициент индексации")]
        // Format 4.3
        public decimal КоэффициентИндексации {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "", Synonym = "ОС")]
        public List<ИндексацияОС_ОС> ИндексацияОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "", Synonym = "ОС")]
    [Table("YndeksatsyiaOS_OS")]
    public class ИндексацияОС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "СтоимостьДляВычисленияАмортизацииНУ", Comment = "(Регл)", Synonym = "Стоимость для вычисления амортизации")]
        // Format 15.2
        public decimal СтоимостьДляВычисленияАмортизацииНУ {get; set;}
        [Description1C8(Name = "НакопленнаяАмортизацияНУ", Comment = "", Synonym = "Накопленная амортизация")]
        // Format 15.2
        public decimal НакопленнаяАмортизацияНУ {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияНУ", Comment = "(Регл)", Synonym = "Срок полезного использования, мес.")]
        // Format 4.0
        public long СрокПолезногоИспользованияНУ {get; set;}
        [Description1C8(Name = "СрокИспользованияДляВычисленияАмортизацииНУ", Comment = "(Регл)", Synonym = "Срок использования для вычисления амортизации, мес.")]
        // Format 4.0
        public long СрокИспользованияДляВычисленияАмортизацииНУ {get; set;}
        [Description1C8(Name = "БалансоваяСтоимостьНУ", Comment = "", Synonym = "Балансовая стоимость")]
        // Format 15.2
        public decimal БалансоваяСтоимостьНУ {get; set;}
        [Description1C8(Name = "НоваяСтоимостьДляВычисленияАмортизацииНУ", Comment = "(Регл)", Synonym = "Стоимость для вычисления амортизации (новая)")]
        // Format 15.2
        public decimal НоваяСтоимостьДляВычисленияАмортизацииНУ {get; set;}
        [Description1C8(Name = "НоваяБалансоваяСтоимостьНУ", Comment = "", Synonym = "Балансовая стоимость (новая)")]
        // Format 15.2
        public decimal НоваяБалансоваяСтоимостьНУ {get; set;}
        [Description1C8(Name = "НоваяНакопленнаяАмортизацияНУ", Comment = "", Synonym = "Накопленная амортизация (новая)")]
        // Format 15.2
        public decimal НоваяНакопленнаяАмортизацияНУ {get; set;}
    }
}
