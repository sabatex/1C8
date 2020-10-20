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
    [Table("UdalytVvodSvedenyiOBankovskykhKartochkakhRabotnykov")]
    [Description1C8(Name = "УдалитьВводСведенийОБанковскихКарточкахРаботников", Comment = "", Synonym = "(не используется) Ввод сведений о банковских карточках работников")]
    public class УдалитьВводСведенийОБанковскихКарточкахРаботников:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Краткий состав документа")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
        public List<УдалитьВводСведенийОБанковскихКарточкахРаботников_РаботникиОрганизации> УдалитьВводСведенийОБанковскихКарточкахРаботниковРаботникиОрганизации {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
    [Table("UdalytVvodSvedenyiOBankovskykhKartochkakhRabotnykov_RabotnykyOrhanyzatsyy")]
    public class УдалитьВводСведенийОБанковскихКарточкахРаботников_РаботникиОрганизации
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ДатаДействия", Comment = "", Synonym = "Дата действия")]
        public DateTime ДатаДействия {get; set;}
        [Description1C8(Name = "Банк", Comment = "", Synonym = "Банк")]
        public Catalogs.Контрагенты Банк {get; set;}
        [Description1C8(Name = "НомерКарточки", Comment = "", Synonym = "Номер карточки")]
        [StringLength(16)]
        public string НомерКарточки {get; set;}
        [Description1C8(Name = "СпособВыплаты", Comment = "", Synonym = "Способ выплаты")]
        public Enums.УстарелоСпособыВыплатыЗарплаты СпособВыплаты {get; set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
    }
}
