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
    [Table("YzmenenyeParametrovNachyslenyiaAmortyzatsyyNMA")]
    [Description1C8(Name = "ИзменениеПараметровНачисленияАмортизацииНМА", Comment = "(Общ)", Synonym = "Изменение параметров амортизации НМА")]
    public class ИзменениеПараметровНачисленияАмортизацииНМА:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "УдалитьСобытиеОС", Comment = "(Регл)", Synonym = "Событие с основными средствами")]
        public Catalogs.СобытияОС УдалитьСобытиеОС {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "НМА", Comment = "", Synonym = "НМА")]
        public List<ИзменениеПараметровНачисленияАмортизацииНМА_НМА> ИзменениеПараметровНачисленияАмортизацииНМАНМА {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "НМА", Comment = "", Synonym = "НМА")]
    [Table("YzmenenyeParametrovNachyslenyiaAmortyzatsyyNMA_NMA")]
    public class ИзменениеПараметровНачисленияАмортизацииНМА_НМА
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НематериальныйАктив", Comment = "(Общ)", Synonym = "Нематериальный актив")]
        public Catalogs.НематериальныеАктивы НематериальныйАктив {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияБУ", Comment = "(Регл)", Synonym = "Срок полезного использования (БУ)")]
        // Format 4.0
        public long СрокПолезногоИспользованияБУ {get; set;}
        [Description1C8(Name = "ОбъемПродукцииРаботДляВычисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Объем работ для амортизации (БУ)")]
        // Format 10.0
        public long ОбъемПродукцииРаботДляВычисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "ЛиквидационнаяСтоимостьБУ", Comment = "(Регл)", Synonym = "Ликвидационная стоимость (БУ)")]
        // Format 15.2
        public decimal ЛиквидационнаяСтоимостьБУ {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииБУ", Comment = "(Регл)", Synonym = "Способ начисления амортизации (БУ)")]
        public Enums.СпособыНачисленияАмортизацииНМА СпособНачисленияАмортизацииБУ {get; set;}
        [Description1C8(Name = "СрокПолезногоИспользованияНУ", Comment = "(Регл)", Synonym = "Срок полезного использования (НУ)")]
        // Format 4.0
        public long СрокПолезногоИспользованияНУ {get; set;}
        [Description1C8(Name = "СпособНачисленияАмортизацииНУ", Comment = "(Регл)", Synonym = "Способ начисления амортизации (НУ)")]
        public Enums.СпособыНачисленияАмортизацииНМА СпособНачисленияАмортизацииНУ {get; set;}
    }
}
