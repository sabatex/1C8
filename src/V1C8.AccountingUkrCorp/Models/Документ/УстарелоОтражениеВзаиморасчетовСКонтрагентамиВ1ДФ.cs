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
    [Table("UstareloOtrazhenyeVzaymoraschetovSKontrahentamyV1DF")]
    [Description1C8(Name = "УстарелоОтражениеВзаиморасчетовСКонтрагентамиВ1ДФ", Comment = "(Регл)", Synonym = "ѳ(устарело) Отражение взаиморасчетов с контрагентами в 1-ДФ")]
    public class УстарелоОтражениеВзаиморасчетовСКонтрагентамиВ1ДФ:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Период регистрации")]
        public DateTime ПериодРегистрации {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Контрагенты", Comment = "", Synonym = "Контрагенты")]
        public List<УстарелоОтражениеВзаиморасчетовСКонтрагентамиВ1ДФ_Контрагенты> УстарелоОтражениеВзаиморасчетовСКонтрагентамиВ1ДФКонтрагенты {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<УстарелоОтражениеВзаиморасчетовСКонтрагентамиВ1ДФ_НДФЛ> УстарелоОтражениеВзаиморасчетовСКонтрагентамиВ1ДФНДФЛ {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Контрагенты", Comment = "", Synonym = "Контрагенты")]
    [Table("UstareloOtrazhenyeVzaymoraschetovSKontrahentamyV1DF_Kontrahenty")]
    public class УстарелоОтражениеВзаиморасчетовСКонтрагентамиВ1ДФ_Контрагенты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("UstareloOtrazhenyeVzaymoraschetovSKontrahentamyV1DF_NDFL")]
    public class УстарелоОтражениеВзаиморасчетовСКонтрагентамиВ1ДФ_НДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "ВидДохода", Comment = "", Synonym = "Вид дохода")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ВидДохода {get; set;}
        [Description1C8(Name = "Доход", Comment = "", Synonym = "Доход")]
        // Format 12.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        // Format 12.2
        public decimal Налог {get; set;}
        [Description1C8(Name = "УдалитьПеречисленныйДоход", Comment = "", Synonym = "(не используется) Перечисленный доход")]
        // Format 12.2
        public decimal УдалитьПеречисленныйДоход {get; set;}
        [Description1C8(Name = "УдалитьПеречисленныйНалог", Comment = "", Synonym = "(не используется) Перечисленый налог")]
        // Format 12.2
        public decimal УдалитьПеречисленныйНалог {get; set;}
    }
}
