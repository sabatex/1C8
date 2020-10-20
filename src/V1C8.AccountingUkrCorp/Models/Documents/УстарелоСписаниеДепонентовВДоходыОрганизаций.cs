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
    [Table("UstareloSpysanyeDeponentovVDokhodyOrhanyzatsyi")]
    [Description1C8(Name = "УстарелоСписаниеДепонентовВДоходыОрганизаций", Comment = "", Synonym = "ѳ(устарело) Списание депонентов в доходы организаций")]
    public class УстарелоСписаниеДепонентовВДоходыОрганизаций:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "", Synonym = "Сумма документа")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "СчетУчетаРасходов", Comment = "", Synonym = "Счет учета расходов в БУ")]
        public ПланСчетов.Хозрасчетный СчетУчетаРасходов {get; set;}
        [Description1C8(Name = "Субконто1", Comment = "", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1 {get; set;}
        [Description1C8(Name = "Субконто2", Comment = "", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2 {get; set;}
        [Description1C8(Name = "Субконто3", Comment = "", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3 {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Краткий состав документа")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СписаниеДепонента", Comment = "", Synonym = "Списание депонента")]
        // Format 2.0
        public long СписаниеДепонента {get; set;}
        [Description1C8(Name = "СписаниеДепонентаНаДату", Comment = "", Synonym = "Списание депонента на дату")]
        public DateTime СписаниеДепонентаНаДату {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходов", Comment = "", Synonym = "Налоговое назначение доходов")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходов {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Работники", Comment = "", Synonym = "Работники")]
        public List<УстарелоСписаниеДепонентовВДоходыОрганизаций_Работники> УстарелоСписаниеДепонентовВДоходыОрганизацийРаботники {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Работники", Comment = "", Synonym = "Работники")]
    [Table("UstareloSpysanyeDeponentovVDokhodyOrhanyzatsyi_Rabotnyky")]
    public class УстарелоСписаниеДепонентовВДоходыОрганизаций_Работники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "УдалитьСотрудник", Comment = "", Synonym = "(не используется) Сотрудник")]
        public Catalogs.Сотрудники УдалитьСотрудник {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "Ведомость", Comment = "", Synonym = "Ведомость")]
        public Documents.УстарелоВедомостьНаВыплатуЗарплаты Ведомость {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
