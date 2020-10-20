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
    [Table("SpysanyeNMA")]
    [Description1C8(Name = "СписаниеНМА", Comment = "(Регл)", Synonym = "Списание НМА")]
    public class СписаниеНМА:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "СчетСписанияБУ", Comment = "(Регл)", Synonym = "Счет")]
        public ПланСчетов.Хозрасчетный СчетСписанияБУ {get; set;}
        [Description1C8(Name = "СубконтоБУ1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоБУ1 {get; set;}
        [Description1C8(Name = "СубконтоБУ2", Comment = "(Регл)", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоБУ2 {get; set;}
        [Description1C8(Name = "СубконтоБУ3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоБУ3 {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
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
        #endregion реквізити
        #region tables
        [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
        public List<СписаниеНМА_НМА> СписаниеНМАНМА {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
    [Table("SpysanyeNMA_NMA")]
    public class СписаниеНМА_НМА
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НематериальныйАктив", Comment = "(Общ)", Synonym = "Нематериальный актив")]
        public Catalogs.НематериальныеАктивы НематериальныйАктив {get; set;}
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
        [Description1C8(Name = "АмортизацияНУ", Comment = "(Регл)", Synonym = "Амортизация (НУ)")]
        // Format 15.2
        public decimal АмортизацияНУ {get; set;}
        [Description1C8(Name = "АмортизацияЗаМесяцНУ", Comment = "(Регл)", Synonym = "Амортизация за месяц (НУ)")]
        // Format 15.2
        public decimal АмортизацияЗаМесяцНУ {get; set;}
    }
}
