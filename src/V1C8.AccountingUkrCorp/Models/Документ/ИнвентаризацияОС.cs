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
    [Table("YnventaryzatsyiaOS")]
    [Description1C8(Name = "ИнвентаризацияОС", Comment = "Инвентаризация ОС", Synonym = "Инвентаризация ОС")]
    public class ИнвентаризацияОС:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "Организация", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "(Упр)", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "ДокументОснованиеВид", Comment = "Документ-основание для проведения инвентаризации", Synonym = "Документ-основание")]
        [StringLength(50)]
        public string ДокументОснованиеВид {get; set;}
        [Description1C8(Name = "ДокументОснованиеНомер", Comment = "", Synonym = "Номер документа-основания")]
        [StringLength(10)]
        public string ДокументОснованиеНомер {get; set;}
        [Description1C8(Name = "ДокументОснованиеДата", Comment = "", Synonym = "Дата документа-основания")]
        public DateTime ДокументОснованиеДата {get; set;}
        [Description1C8(Name = "ДатаНачалаИнвентаризации", Comment = "", Synonym = "Дата начала инвентаризации")]
        public DateTime ДатаНачалаИнвентаризации {get; set;}
        [Description1C8(Name = "ДатаОкончанияИнвентаризации", Comment = "", Synonym = "Дата окончания инвентаризации")]
        public DateTime ДатаОкончанияИнвентаризации {get; set;}
        [Description1C8(Name = "ПричинаПроведенияИнвентаризации", Comment = "", Synonym = "Причина проведения инвентаризации")]
        public string ПричинаПроведенияИнвентаризации {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ПредседательКомиссии", Comment = "", Synonym = "Председатель комиссии")]
        public Catalogs.ФизическиеЛица ПредседательКомиссии {get; set;}
        [Description1C8(Name = "ПервыйЧленКомиссии", Comment = "", Synonym = "Первый член комиссии")]
        public Catalogs.ФизическиеЛица ПервыйЧленКомиссии {get; set;}
        [Description1C8(Name = "ВторойЧленКомиссии", Comment = "", Synonym = "Второй член комиссии")]
        public Catalogs.ФизическиеЛица ВторойЧленКомиссии {get; set;}
        [Description1C8(Name = "ТретийЧленКомиссии", Comment = "", Synonym = "Третий член комиссии")]
        public Catalogs.ФизическиеЛица ТретийЧленКомиссии {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
        public List<ИнвентаризацияОС_ОС> ИнвентаризацияОСОС {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОС", Comment = "(Общ)", Synonym = "ОС")]
    [Table("YnventaryzatsyiaOS_OS")]
    public class ИнвентаризацияОС_ОС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ОсновноеСредство", Comment = "(Общ)", Synonym = "Основное средство")]
        public Catalogs.ОсновныеСредства ОсновноеСредство {get; set;}
        [Description1C8(Name = "СтоимостьПоДаннымУчета", Comment = "", Synonym = "Стоимость по данным учета")]
        // Format 15.2
        public decimal СтоимостьПоДаннымУчета {get; set;}
        [Description1C8(Name = "НаличиеПоДаннымУчета", Comment = "", Synonym = "Наличие по данным учета")]
        public bool НаличиеПоДаннымУчета {get; set;}
        [Description1C8(Name = "СтоимостьФактическая", Comment = "", Synonym = "Фактическая стоимость")]
        // Format 15.2
        public decimal СтоимостьФактическая {get; set;}
        [Description1C8(Name = "НаличиеФактическое", Comment = "", Synonym = "Фактическое наличие")]
        public bool НаличиеФактическое {get; set;}
    }
}
