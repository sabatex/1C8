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
    [Table("DohovorZaimaSotrudnyku")]
    [Description1C8(Name = "ДоговорЗаймаСотруднику", Comment = "", Synonym = "Договор займа сотруднику")]
    public class ДоговорЗаймаСотруднику:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "СпособПредоставления", Comment = "", Synonym = "Способ предоставления")]
        public Enums.СпособыПредоставленияЗаймаСотруднику СпособПредоставления {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ДатаПредоставления", Comment = "", Synonym = "Дата предоставления")]
        public DateTime ДатаПредоставления {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ПроцентнаяСтавка", Comment = "", Synonym = "Процентная ставка")]
        // Format 4.2
        public decimal ПроцентнаяСтавка {get; set;}
        [Description1C8(Name = "СпособПогашения", Comment = "", Synonym = "Способ погашения")]
        public Enums.СпособыПогашенияЗаймаСотруднику СпособПогашения {get; set;}
        [Description1C8(Name = "ВидПлатежей", Comment = "", Synonym = "Вид платежей")]
        public Enums.ВидыПлатежейПогашенияЗаймаСотруднику ВидПлатежей {get; set;}
        [Description1C8(Name = "РазмерПлатежа", Comment = "", Synonym = "Размер платежа")]
        // Format 15.2
        public decimal РазмерПлатежа {get; set;}
        [Description1C8(Name = "РазмерПогашения", Comment = "", Synonym = "Размер погашения")]
        // Format 15.2
        public decimal РазмерПогашения {get; set;}
        [Description1C8(Name = "ДатаНачалаПогашения", Comment = "", Synonym = "Дата начала погашения")]
        public DateTime ДатаНачалаПогашения {get; set;}
        [Description1C8(Name = "ОграничениеПлатежа", Comment = "", Synonym = "Ограничение платежа")]
        // Format 15.2
        public decimal ОграничениеПлатежа {get; set;}
        [Description1C8(Name = "МатериальнаяВыгодаОблагаетсяНДФЛ", Comment = "", Synonym = "Материальная выгода облагается НДФЛ")]
        public bool МатериальнаяВыгодаОблагаетсяНДФЛ {get; set;}
        [Description1C8(Name = "ЗаемПоДоговоруВыданПолностью", Comment = "", Synonym = "Заем по договору выдан полностью")]
        public bool ЗаемПоДоговоруВыданПолностью {get; set;}
        [Description1C8(Name = "ДатаВыдачи", Comment = "", Synonym = "Дата выдачи")]
        public DateTime ДатаВыдачи {get; set;}
        [Description1C8(Name = "ФормаРасчетов", Comment = "", Synonym = "Форма расчетов")]
        public Enums.ФормыОплаты ФормаРасчетов {get; set;}
        [Description1C8(Name = "ЗаемЧастичноПогашен", Comment = "", Synonym = "Заем частично погашен")]
        public bool ЗаемЧастичноПогашен {get; set;}
        [Description1C8(Name = "ДатаПогашения", Comment = "", Synonym = "Дата погашения")]
        public DateTime ДатаПогашения {get; set;}
        [Description1C8(Name = "ПогашеннаяСуммаЗайма", Comment = "", Synonym = "Погашенная сумма займа")]
        // Format 15.2
        public decimal ПогашеннаяСуммаЗайма {get; set;}
        [Description1C8(Name = "ПогашенныеПроценты", Comment = "", Synonym = "Погашенные проценты")]
        // Format 15.2
        public decimal ПогашенныеПроценты {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ТраншиЗайма", Comment = "", Synonym = "Транши займа")]
        public List<ДоговорЗаймаСотруднику_ТраншиЗайма> ДоговорЗаймаСотрудникуТраншиЗайма {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ТраншиЗайма", Comment = "", Synonym = "Транши займа")]
    [Table("DohovorZaimaSotrudnyku_TranshyZaima")]
    public class ДоговорЗаймаСотруднику_ТраншиЗайма
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДатаПредоставления", Comment = "", Synonym = "Месяц предоставления")]
        public DateTime ДатаПредоставления {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "РазмерПогашения", Comment = "", Synonym = "Размер погашения")]
        // Format 15.2
        public decimal РазмерПогашения {get; set;}
        [Description1C8(Name = "ДатаПогашения", Comment = "", Synonym = "Дата погашения")]
        public DateTime ДатаПогашения {get; set;}
    }
}
