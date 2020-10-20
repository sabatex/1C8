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
    [Table("YnventaryzatsyiaRaschetovSKontrahentamy")]
    [Description1C8(Name = "ИнвентаризацияРасчетовСКонтрагентами", Comment = "(Регл) Акт инвентаризации расчетов с покупателями, поставщиками и прочими дебиторами и кредиторами", Synonym = "Акт инвентаризации расчетов")]
    public class ИнвентаризацияРасчетовСКонтрагентами:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ДокументОснованиеВид", Comment = "Документ-основание для проведения инвентаризации", Synonym = "Документ-основание")]
        [StringLength(50)]
        public string ДокументОснованиеВид {get; set;}
        [Description1C8(Name = "ДокументОснованиеНомер", Comment = "", Synonym = "Номер документа-основания")]
        [StringLength(10)]
        public string ДокументОснованиеНомер {get; set;}
        [Description1C8(Name = "ДокументОснованиеДата", Comment = "", Synonym = "Дата документа-основания")]
        public DateTime ДокументОснованиеДата {get; set;}
        [Description1C8(Name = "ПричинаПроведенияИнвентаризации", Comment = "", Synonym = "Причина проведения инвентаризации")]
        public string ПричинаПроведенияИнвентаризации {get; set;}
        [Description1C8(Name = "ДатаНачалаИнвентаризации", Comment = "", Synonym = "Дата начала инвентаризации")]
        public DateTime ДатаНачалаИнвентаризации {get; set;}
        [Description1C8(Name = "ДатаОкончанияИнвентаризации", Comment = "", Synonym = "Дата окончания инвентаризации")]
        public DateTime ДатаОкончанияИнвентаризации {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Комментарий к документу", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ПервыйЧленКомиссии", Comment = "", Synonym = "Первый член комиссии")]
        public Catalogs.ФизическиеЛица ПервыйЧленКомиссии {get; set;}
        [Description1C8(Name = "ВторойЧленКомиссии", Comment = "", Synonym = "Второй член комиссии")]
        public Catalogs.ФизическиеЛица ВторойЧленКомиссии {get; set;}
        [Description1C8(Name = "ТретийЧленКомиссии", Comment = "", Synonym = "Третий член комиссии")]
        public Catalogs.ФизическиеЛица ТретийЧленКомиссии {get; set;}
        [Description1C8(Name = "ПредседательКомиссии", Comment = "", Synonym = "Председатель комиссии")]
        public Catalogs.ФизическиеЛица ПредседательКомиссии {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Контрагенты", Comment = "(Общ)", Synonym = "Контрагенты")]
        public List<ИнвентаризацияРасчетовСКонтрагентами_Контрагенты> ИнвентаризацияРасчетовСКонтрагентамиКонтрагенты {get;set;}
        [Description1C8(Name = "СчетаРасчетов", Comment = "", Synonym = "Счета расчетов")]
        public List<ИнвентаризацияРасчетовСКонтрагентами_СчетаРасчетов> ИнвентаризацияРасчетовСКонтрагентамиСчетаРасчетов {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Контрагенты", Comment = "(Общ)", Synonym = "Контрагенты")]
    [Table("YnventaryzatsyiaRaschetovSKontrahentamy_Kontrahenty")]
    public class ИнвентаризацияРасчетовСКонтрагентами_Контрагенты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидЗадолженности", Comment = "", Synonym = "Вид задолженности")]
        public Enums.ВидыЗадолженности ВидЗадолженности {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ) Контрагент, в расчетах с которым возникла задолженность", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "СчетРасчетов", Comment = "", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетРасчетов {get; set;}
        [Description1C8(Name = "Подтверждено", Comment = "Подтвержденная сумма задолженности", Synonym = "Подтверждено")]
        // Format 15.2
        public decimal Подтверждено {get; set;}
        [Description1C8(Name = "НеПодтверждено", Comment = "Не подтвержденная сумма задолженности", Synonym = "Не подтверждено")]
        // Format 15.2
        public decimal НеПодтверждено {get; set;}
        [Description1C8(Name = "ИстекСрокДавности", Comment = "Сумма задолженности, по которой истек срок давности", Synonym = "Истек срок давности")]
        // Format 15.2
        public decimal ИстекСрокДавности {get; set;}
    }
    [Description1C8(Name = "СчетаРасчетов", Comment = "", Synonym = "Счета расчетов")]
    [Table("YnventaryzatsyiaRaschetovSKontrahentamy_SchetaRaschetov")]
    public class ИнвентаризацияРасчетовСКонтрагентами_СчетаРасчетов
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетРасчетов", Comment = "", Synonym = "Счет расчетов")]
        public ПланСчетов.Хозрасчетный СчетРасчетов {get; set;}
    }
}
