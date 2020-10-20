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
    [Table("UdalytUvolnenyeYzOrhanyzatsyi")]
    [Description1C8(Name = "УдалитьУвольнениеИзОрганизаций", Comment = "(Регл)", Synonym = "(не используется) Увольнение из организации")]
    public class УдалитьУвольнениеИзОрганизаций:CatalogItem
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
        public List<УдалитьУвольнениеИзОрганизаций_РаботникиОрганизации> УдалитьУвольнениеИзОрганизацийРаботникиОрганизации {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
    [Table("UdalytUvolnenyeYzOrhanyzatsyi_RabotnykyOrhanyzatsyy")]
    public class УдалитьУвольнениеИзОрганизаций_РаботникиОрганизации
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Физлицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица Физлицо {get; set;}
        [Description1C8(Name = "ДатаУвольнения", Comment = "", Synonym = "Дата увольнения")]
        public DateTime ДатаУвольнения {get; set;}
        [Description1C8(Name = "ОснованиеУвольнения", Comment = "", Synonym = "Основание увольнения")]
        public Catalogs.УстарелоОснованияУвольнения ОснованиеУвольнения {get; set;}
        [Description1C8(Name = "УдалитьПриказ", Comment = "", Synonym = "Удалить приказ")]
        public Документ.УдалитьПриемНаРаботуВОрганизацию УдалитьПриказ {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
}
