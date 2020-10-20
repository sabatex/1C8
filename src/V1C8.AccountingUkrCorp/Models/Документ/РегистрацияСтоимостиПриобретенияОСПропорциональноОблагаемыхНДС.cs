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
    [Table("RehystratsyiaStoymostyPryobretenyiaOSProportsyonalnoOblahaemykhNDS")]
    [Description1C8(Name = "РегистрацияСтоимостиПриобретенияОСПропорциональноОблагаемыхНДС", Comment = "(регл)", Synonym = "Регистрация стоимости приобретения ОС, пропорционально облагаемых НДС")]
    public class РегистрацияСтоимостиПриобретенияОСПропорциональноОблагаемыхНДС:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СпецРежимНалогообложения", Comment = "", Synonym = "Спец режим налогообложения")]
        // Format 1.0
        public long СпецРежимНалогообложения {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "", Synonym = "ОС")]
        public List<РегистрацияСтоимостиПриобретенияОСПропорциональноОблагаемыхНДС_ОС> РегистрацияСтоимостиПриобретенияОСПропорциональноОблагаемыхНДСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "", Synonym = "ОС")]
    [Table("RehystratsyiaStoymostyPryobretenyiaOSProportsyonalnoOblahaemykhNDS_OS")]
    public class РегистрацияСтоимостиПриобретенияОСПропорциональноОблагаемыхНДС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НеоборотныйАктив", Comment = "", Synonym = "Необоротный актив")]
        public Catalogs.ОсновныеСредства НеоборотныйАктив {get; set;}
        [Description1C8(Name = "ДатаНачалаИспользования", Comment = "", Synonym = "Дата начала использования")]
        public DateTime ДатаНачалаИспользования {get; set;}
        [Description1C8(Name = "ДатаФормированияКредита", Comment = "", Synonym = "Дата формирования кредита")]
        public DateTime ДатаФормированияКредита {get; set;}
        [Description1C8(Name = "БазаНДС", Comment = "", Synonym = "База НДС")]
        // Format 15.2
        public decimal БазаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "СуммаНДСПропорциональноКредит", Comment = "", Synonym = "Сумма НДС (пропорционально кредит)")]
        // Format 15.2
        public decimal СуммаНДСПропорциональноКредит {get; set;}
    }
}
