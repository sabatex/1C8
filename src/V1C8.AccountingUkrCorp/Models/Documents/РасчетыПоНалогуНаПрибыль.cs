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
    [Table("RaschetyPoNalohuNaPrybyl")]
    [Description1C8(Name = "РасчетыПоНалогуНаПрибыль", Comment = "", Synonym = "Расчеты по налогу на прибыль")]
    public class РасчетыПоНалогуНаПрибыль:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "ТекущийНалогНаПрибыль", Comment = "Сумма налога на прибыль по данным налогового учета", Synonym = "Текущий налог на прибыль")]
        // Format 15.2
        public decimal ТекущийНалогНаПрибыль {get; set;}
        [Description1C8(Name = "СчетДоходовПоНалогуНаПрибыль", Comment = "", Synonym = "Счет доходов по налогу на прибыль")]
        public ПланСчетов.Хозрасчетный СчетДоходовПоНалогуНаПрибыль {get; set;}
        [Description1C8(Name = "СубконтоДоходов1", Comment = "", Synonym = "Субконто доходов1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДоходов1 {get; set;}
        [Description1C8(Name = "СубконтоДоходов2", Comment = "", Synonym = "Субконто доходов2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДоходов2 {get; set;}
        [Description1C8(Name = "СубконтоДоходов3", Comment = "", Synonym = "Субконто доходов3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДоходов3 {get; set;}
        [Description1C8(Name = "СчетРасходовПоНалогуНаПрибыль", Comment = "", Synonym = "Счет расходов по налогу на прибыль")]
        public ПланСчетов.Хозрасчетный СчетРасходовПоНалогуНаПрибыль {get; set;}
        [Description1C8(Name = "СубконтоРасходов1", Comment = "", Synonym = "Субконто расходов1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоРасходов1 {get; set;}
        [Description1C8(Name = "СубконтоРасходов2", Comment = "", Synonym = "Субконто расходов2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоРасходов2 {get; set;}
        [Description1C8(Name = "СубконтоРасходов3", Comment = "", Synonym = "Субконто расходов3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоРасходов3 {get; set;}
        [Description1C8(Name = "РассчитыватьОНАиОНО", Comment = "", Synonym = "Рассчитывать ОНА и ОНО")]
        public bool РассчитыватьОНАиОНО {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Статьи", Comment = "", Synonym = "Статьи")]
        public List<РасчетыПоНалогуНаПрибыль_Статьи> РасчетыПоНалогуНаПрибыльСтатьи {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Статьи", Comment = "", Synonym = "Статьи")]
    [Table("RaschetyPoNalohuNaPrybyl_Staty")]
    public class РасчетыПоНалогуНаПрибыль_Статьи
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Статья", Comment = "", Synonym = "Статья")]
        public Catalogs.СтатьиОтсроченныхНалоговыхАктивовИОбязательств Статья {get; set;}
        [Description1C8(Name = "ВидНалоговойДеятельности", Comment = "", Synonym = "Вид налоговой деятельности")]
        public Catalogs.ВидыНалоговойДеятельности ВидНалоговойДеятельности {get; set;}
        [Description1C8(Name = "СтавкаНалога", Comment = "", Synonym = "Ставка налога")]
        // Format 4.2
        public decimal СтавкаНалога {get; set;}
        [Description1C8(Name = "ОценкаСтатьиПоБУ", Comment = "", Synonym = "Оценка статьи по БУ")]
        // Format 15.2
        public decimal ОценкаСтатьиПоБУ {get; set;}
        [Description1C8(Name = "ОценкаСтатьиПоНУ", Comment = "", Synonym = "Оценка статьи по НУ")]
        // Format 15.2
        public decimal ОценкаСтатьиПоНУ {get; set;}
        [Description1C8(Name = "СуммаВременнойРазницы", Comment = "", Synonym = "Сумма временной разницы")]
        // Format 15.2
        public decimal СуммаВременнойРазницы {get; set;}
        [Description1C8(Name = "СуммаОНА", Comment = "Сумма отсроченных налоговых активов", Synonym = "Сумма ОНА")]
        // Format 15.2
        public decimal СуммаОНА {get; set;}
        [Description1C8(Name = "СуммаОНО", Comment = "Сумма отсроченных налоговых обязательств", Synonym = "Сумма ОНО")]
        // Format 15.2
        public decimal СуммаОНО {get; set;}
    }
}
