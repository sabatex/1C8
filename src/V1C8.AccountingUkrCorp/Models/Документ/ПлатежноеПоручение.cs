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
    [Table("PlatezhnoePoruchenye")]
    [Description1C8(Name = "ПлатежноеПоручение", Comment = "", Synonym = "Платежное поручение")]
    public class ПлатежноеПоручение:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ-основание")]
        public Документ.СписаниеСРасчетногоСчета ДокументОснование {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "КодПоЕДРПОУОрганизации", Comment = "", Synonym = "Код плательщика")]
        [StringLength(15)]
        public string КодПоЕДРПОУОрганизации {get; set;}
        [Description1C8(Name = "СчетОрганизации", Comment = "", Synonym = "Банковский счет")]
        public Catalogs.БанковскиеСчета СчетОрганизации {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Получатель")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "КодПоЕДРПОУКонтрагента", Comment = "", Synonym = "Код по ЕДРПОУ Контрагенте")]
        [StringLength(15)]
        public string КодПоЕДРПОУКонтрагента {get; set;}
        [Description1C8(Name = "СчетКонтрагента", Comment = "", Synonym = "Счет получателя")]
        public Catalogs.БанковскиеСчета СчетКонтрагента {get; set;}
        [Description1C8(Name = "СуммаДокумента", Comment = "", Synonym = "Сумма платежа")]
        // Format 15.2
        public decimal СуммаДокумента {get; set;}
        [Description1C8(Name = "НомерПоручения", Comment = "(Регл)", Synonym = "Номер поручения")]
        [StringLength(10)]
        public string НомерПоручения {get; set;}
        [Description1C8(Name = "СтавкаНДС", Comment = "", Synonym = "% НДС")]
        public Enums.СтавкиНДС СтавкаНДС {get; set;}
        [Description1C8(Name = "СуммаНДС", Comment = "", Synonym = "Сумма НДС")]
        // Format 15.2
        public decimal СуммаНДС {get; set;}
        [Description1C8(Name = "НазначениеПлатежа", Comment = "", Synonym = "Назначение платежа")]
        [StringLength(250)]
        public string НазначениеПлатежа {get; set;}
        [Description1C8(Name = "ВалютаДокумента", Comment = "", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаДокумента {get; set;}
        [Description1C8(Name = "ТекстПлательщика", Comment = "", Synonym = "Наименование плательщика")]
        [StringLength(500)]
        public string ТекстПлательщика {get; set;}
        [Description1C8(Name = "НаименованиеБанкаПлательщика", Comment = "", Synonym = "Наименование банка плательщика")]
        [StringLength(500)]
        public string НаименованиеБанкаПлательщика {get; set;}
        [Description1C8(Name = "МФОБанкаПлательщика", Comment = "", Synonym = "МФОБанка плательщика")]
        [StringLength(9)]
        public string МФОБанкаПлательщика {get; set;}
        [Description1C8(Name = "ТекстПолучателя", Comment = "", Synonym = "Наименование получателя")]
        [StringLength(500)]
        public string ТекстПолучателя {get; set;}
        [Description1C8(Name = "НаименованиеБанкаПолучателя", Comment = "", Synonym = "Наименование банка получателя")]
        [StringLength(500)]
        public string НаименованиеБанкаПолучателя {get; set;}
        [Description1C8(Name = "МФОБанкаПолучателя", Comment = "", Synonym = "МФО банка получателя")]
        [StringLength(9)]
        public string МФОБанкаПолучателя {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ПоказательДаты", Comment = "", Synonym = "Показатель даты")]
        [StringLength(10)]
        public string ПоказательДаты {get; set;}
        [Description1C8(Name = "ПоказательНомера", Comment = "", Synonym = "Показатель номера")]
        [StringLength(18)]
        public string ПоказательНомера {get; set;}
        [Description1C8(Name = "ПоказательОснования", Comment = "", Synonym = "Показатель основания")]
        [StringLength(2)]
        public string ПоказательОснования {get; set;}
        [Description1C8(Name = "ПоказательПериода", Comment = "", Synonym = "Показатель периода")]
        [StringLength(10)]
        public string ПоказательПериода {get; set;}
        [Description1C8(Name = "ПоказательТипа", Comment = "", Synonym = "Тип платежа")]
        [StringLength(2)]
        public string ПоказательТипа {get; set;}
        [Description1C8(Name = "СтатусСоставителя", Comment = "", Synonym = "Статус составителя")]
        [StringLength(2)]
        public string СтатусСоставителя {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "ПереводНаДругойСчет", Comment = "", Synonym = "Перевод на другой счет")]
        public bool ПереводНаДругойСчет {get; set;}
        [Description1C8(Name = "Оплачено", Comment = "", Synonym = "Оплачено")]
        public bool Оплачено {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
