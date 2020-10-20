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
    [Table("YzmenenyeUslovyiYspolnytelnohoLysta")]
    [Description1C8(Name = "ИзменениеУсловийИсполнительногоЛиста", Comment = "", Synonym = "Изменение условий исполнительного листа")]
    public class ИзменениеУсловийИсполнительногоЛиста:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ИсполнительныйЛист", Comment = "", Synonym = "Исполнительный лист")]
        public Документ.ИсполнительныйЛист ИсполнительныйЛист {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
        [Description1C8(Name = "ДатаИзменения", Comment = "", Synonym = "Дата изменения")]
        public DateTime ДатаИзменения {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "СпособРасчета", Comment = "", Synonym = "Способ расчета")]
        public Enums.СпособыРасчетаУдержанияПоИсполнительномуДокументу СпособРасчета {get; set;}
        [Description1C8(Name = "ВидБазы", Comment = "", Synonym = "Вид базы")]
        public Enums.ВидыБазыУдержанияПоИсполнительномуДокументу ВидБазы {get; set;}
        [Description1C8(Name = "Удержание", Comment = "", Synonym = "Удержание")]
        public ПланВидовРасчета.Удержания Удержание {get; set;}
        [Description1C8(Name = "Процент", Comment = "", Synonym = "Процент")]
        // Format 5.2
        public decimal Процент {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "Числитель", Comment = "", Synonym = "Числитель")]
        // Format 2.0
        public long Числитель {get; set;}
        [Description1C8(Name = "Знаменатель", Comment = "", Synonym = "Знаменатель")]
        // Format 2.0
        public long Знаменатель {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 15.2
        public decimal Предел {get; set;}
        [Description1C8(Name = "УчитыватьБольничныеЛисты", Comment = "", Synonym = "Учитывать больничные листы")]
        public bool УчитыватьБольничныеЛисты {get; set;}
        [Description1C8(Name = "ПлатежныйАгент", Comment = "", Synonym = "Платежный агент")]
        public Catalogs.Контрагенты ПлатежныйАгент {get; set;}
        [Description1C8(Name = "ТарифПлатежногоАгента", Comment = "", Synonym = "Тариф платежного агента")]
        public Catalogs.ТарифыПлатежныхАгентов ТарифПлатежногоАгента {get; set;}
        [Description1C8(Name = "УдержаниеВознагражденияПлатежногоАгента", Comment = "", Synonym = "Удержание вознаграждения платежного агента")]
        public ПланВидовРасчета.Удержания УдержаниеВознагражденияПлатежногоАгента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ПрожиточныйМинимум", Comment = "", Synonym = "Прожиточный минимум")]
        public Enums.СоциальныеГруппыНаселения ПрожиточныйМинимум {get; set;}
        [Description1C8(Name = "УвеличиватьУдержанияДоМинимума", Comment = "", Synonym = "Увеличивать удержания до минимума")]
        public bool УвеличиватьУдержанияДоМинимума {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<ИзменениеУсловийИсполнительногоЛиста_ДополнительныеРеквизиты> ИзменениеУсловийИсполнительногоЛистаДополнительныеРеквизиты {get;set;}
        [Description1C8(Name = "Дети", Comment = "", Synonym = "Дети")]
        public List<ИзменениеУсловийИсполнительногоЛиста_Дети> ИзменениеУсловийИсполнительногоЛистаДети {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("YzmenenyeUslovyiYspolnytelnohoLysta_DopolnytelnyeRekvyzyty")]
    public class ИзменениеУсловийИсполнительногоЛиста_ДополнительныеРеквизиты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Свойство", Comment = "", Synonym = "Свойство")]
        public ПланВидовХарактеристик.ДополнительныеРеквизитыИСведения Свойство {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public Catalogs.Склады Значение {get; set;}
        [Description1C8(Name = "ТекстоваяСтрока", Comment = "", Synonym = "Текстовая строка")]
        public string ТекстоваяСтрока {get; set;}
    }
    [Description1C8(Name = "Дети", Comment = "", Synonym = "Дети")]
    [Table("YzmenenyeUslovyiYspolnytelnohoLysta_Dety")]
    public class ИзменениеУсловийИсполнительногоЛиста_Дети
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаРождения", Comment = "", Synonym = "Дата рождения")]
        public DateTime ДатаРождения {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Нетрудоспособен", Comment = "", Synonym = "Нетрудоспособен")]
        public bool Нетрудоспособен {get; set;}
        [Description1C8(Name = "Учитывать", Comment = "", Synonym = "Учитывать")]
        public bool Учитывать {get; set;}
    }
}
