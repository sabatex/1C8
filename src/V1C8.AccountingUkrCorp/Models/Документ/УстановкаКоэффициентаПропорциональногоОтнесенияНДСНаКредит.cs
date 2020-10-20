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
    [Table("UstanovkaKoeffytsyentaProportsyonalnohoOtnesenyiaNDSNaKredyt")]
    [Description1C8(Name = "УстановкаКоэффициентаПропорциональногоОтнесенияНДСНаКредит", Comment = "(регл)", Synonym = "Установка коэффициента пропорционального НДС")]
    public class УстановкаКоэффициентаПропорциональногоОтнесенияНДСНаКредит:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ПоДаннымПрошлогоГода", Comment = "", Synonym = "По данным прошлого года")]
        public bool ПоДаннымПрошлогоГода {get; set;}
        [Description1C8(Name = "МесяцРасчета", Comment = "", Synonym = "Месяц расчета")]
        // Format 2.0
        public long МесяцРасчета {get; set;}
        [Description1C8(Name = "СуммаОблагаемыхОпераций", Comment = "", Synonym = "Сумма облагаемых операций")]
        // Format 15.2
        public decimal СуммаОблагаемыхОпераций {get; set;}
        [Description1C8(Name = "СуммаВсехОпераций", Comment = "", Synonym = "Сумма всех операций")]
        // Format 15.2
        public decimal СуммаВсехОпераций {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "", Synonym = "Коэфф. (доля использования)")]
        // Format 6.4
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "СпецРежимНалогообложения", Comment = "", Synonym = "Спец режим налогообложения")]
        // Format 1.0
        public long СпецРежимНалогообложения {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
