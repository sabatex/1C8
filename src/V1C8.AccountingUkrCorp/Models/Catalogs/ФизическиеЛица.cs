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
    [Table("FyzycheskyeLytsa")]
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    public class ФизическиеЛица:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ДатаРождения", Comment = "", Synonym = "Дата рождения")]
        public DateTime ДатаРождения {get; set;}
        [Description1C8(Name = "КодПоДРФО", Comment = "", Synonym = "Код по ДРФО")]
        [StringLength(10)]
        public string КодПоДРФО {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ)", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Пол", Comment = "", Synonym = "Пол")]
        public Enums.ПолФизическогоЛица Пол {get; set;}
        [Description1C8(Name = "УдалитьСтраховойНомерПФ", Comment = "(Регл)", Synonym = "(не используется)  Страховой номер ПФ")]
        [StringLength(14)]
        public string УдалитьСтраховойНомерПФ {get; set;}
        [Description1C8(Name = "МестоРождения", Comment = "", Synonym = "Место рождения")]
        [StringLength(240)]
        public string МестоРождения {get; set;}
        [Description1C8(Name = "ИмеетНаучныеТруды", Comment = "", Synonym = "Имеет научные труды")]
        public bool ИмеетНаучныеТруды {get; set;}
        [Description1C8(Name = "ИмеетИзобретения", Comment = "", Synonym = "Имеет изобретения")]
        public bool ИмеетИзобретения {get; set;}
        [Description1C8(Name = "ГруппаДоступа", Comment = "", Synonym = "Группа доступа")]
        public Catalogs.ГруппыДоступаФизическихЛиц ГруппаДоступа {get; set;}
        [Description1C8(Name = "УдалитьПол", Comment = "Пол", Synonym = "(не используется) Пол")]
        public Enums.УдалитьПолФизическихЛиц УдалитьПол {get; set;}
        [Description1C8(Name = "ФИО", Comment = "", Synonym = "ФИО")]
        [StringLength(50)]
        public string ФИО {get; set;}
        [Description1C8(Name = "УточнениеНаименования", Comment = "", Synonym = "Уточнение наименования")]
        [StringLength(15)]
        public string УточнениеНаименования {get; set;}
        [Description1C8(Name = "ДатаРегистрации", Comment = "Дата регистрации", Synonym = "Дата регистрации")]
        public DateTime ДатаРегистрации {get; set;}
        [Description1C8(Name = "ЛьготаПриНачисленииПособий", Comment = "", Synonym = "Льгота при начислении пособий")]
        public Enums.ОснованияЛьготПоПособию ЛьготаПриНачисленииПособий {get; set;}
        [Description1C8(Name = "Фотография", Comment = "", Synonym = "Фотография")]
        public Catalogs.Файлы Фотография {get; set;}
        [Description1C8(Name = "НаименованиеСлужебное", Comment = "", Synonym = "Наименование служебное")]
        [StringLength(70)]
        public string НаименованиеСлужебное {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "СоставСемьи", Comment = "(Общ)", Synonym = "Состав семьи физического лица")]
        public List<ФизическиеЛица_СоставСемьи> ФизическиеЛицаСоставСемьи {get;set;}
        [Description1C8(Name = "КонтактнаяИнформация", Comment = "", Synonym = "Контактная информация")]
        public List<ФизическиеЛица_КонтактнаяИнформация> ФизическиеЛицаКонтактнаяИнформация {get;set;}
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<ФизическиеЛица_ДополнительныеРеквизиты> ФизическиеЛицаДополнительныеРеквизиты {get;set;}
        [Description1C8(Name = "УдалитьСоставСемьи", Comment = "", Synonym = "(не используется) Состав семьи")]
        public List<ФизическиеЛица_УдалитьСоставСемьи> ФизическиеЛицаУдалитьСоставСемьи {get;set;}
        [Description1C8(Name = "УдалитьОбразование", Comment = "", Synonym = "(не используется) Образование")]
        public List<ФизическиеЛица_УдалитьОбразование> ФизическиеЛицаУдалитьОбразование {get;set;}
        [Description1C8(Name = "УдалитьТрудоваяДеятельность", Comment = "", Synonym = "(не используется) Трудовая деятельность")]
        public List<ФизическиеЛица_УдалитьТрудоваяДеятельность> ФизическиеЛицаУдалитьТрудоваяДеятельность {get;set;}
        [Description1C8(Name = "УдалитьЗнаниеЯзыков", Comment = "", Synonym = "(не используется) Знание языков")]
        public List<ФизическиеЛица_УдалитьЗнаниеЯзыков> ФизическиеЛицаУдалитьЗнаниеЯзыков {get;set;}
        [Description1C8(Name = "УдалитьПрофессии", Comment = "", Synonym = "(не используется) Профессии")]
        public List<ФизическиеЛица_УдалитьПрофессии> ФизическиеЛицаУдалитьПрофессии {get;set;}
        [Description1C8(Name = "УдалитьСтажи", Comment = "", Synonym = "(не используется) Стажи")]
        public List<ФизическиеЛица_УдалитьСтажи> ФизическиеЛицаУдалитьСтажи {get;set;}
        [Description1C8(Name = "УдалитьНаграды", Comment = "", Synonym = "(не используется) Награды")]
        public List<ФизическиеЛица_УдалитьНаграды> ФизическиеЛицаУдалитьНаграды {get;set;}
        [Description1C8(Name = "УдалитьУченыеСтепени", Comment = "", Synonym = "(не используется) Ученые степени")]
        public List<ФизическиеЛица_УдалитьУченыеСтепени> ФизическиеЛицаУдалитьУченыеСтепени {get;set;}
        [Description1C8(Name = "УдалитьУченыеЗвания", Comment = "", Synonym = "(не используется) Ученые звания")]
        public List<ФизическиеЛица_УдалитьУченыеЗвания> ФизическиеЛицаУдалитьУченыеЗвания {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "СоставСемьи", Comment = "(Общ)", Synonym = "Состав семьи физического лица")]
    [Table("FyzycheskyeLytsa_SostavSemy")]
    public class ФизическиеЛица_СоставСемьи
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СтепеньРодства", Comment = "(Общ)", Synonym = "Степень родства")]
        public Catalogs.УстарелоСтепениРодстваФизЛиц СтепеньРодства {get; set;}
        [Description1C8(Name = "ФизЛицо", Comment = "(Общ)", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "ГодРождения", Comment = "(Общ)", Synonym = "Год рождения")]
        // Format 4.0
        public long ГодРождения {get; set;}
        [Description1C8(Name = "Иждивенец", Comment = "", Synonym = "На иждивении")]
        public bool Иждивенец {get; set;}
    }
    [Description1C8(Name = "КонтактнаяИнформация", Comment = "", Synonym = "Контактная информация")]
    [Table("FyzycheskyeLytsa_KontaktnaiaYnformatsyia")]
    public class ФизическиеЛица_КонтактнаяИнформация
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Тип", Comment = "", Synonym = "Тип")]
        public Enums.ТипыКонтактнойИнформации Тип {get; set;}
        [Description1C8(Name = "Вид", Comment = "", Synonym = "Вид")]
        public Catalogs.ВидыКонтактнойИнформации Вид {get; set;}
        [Description1C8(Name = "Представление", Comment = "", Synonym = "Представление")]
        [StringLength(500)]
        public string Представление {get; set;}
        [Description1C8(Name = "ЗначенияПолей", Comment = "", Synonym = "Значения полей")]
        public string ЗначенияПолей {get; set;}
        [Description1C8(Name = "Страна", Comment = "", Synonym = "Страна")]
        [StringLength(100)]
        public string Страна {get; set;}
        [Description1C8(Name = "Регион", Comment = "", Synonym = "Область")]
        [StringLength(50)]
        public string Регион {get; set;}
        [Description1C8(Name = "Город", Comment = "", Synonym = "Город")]
        [StringLength(50)]
        public string Город {get; set;}
        [Description1C8(Name = "АдресЭП", Comment = "", Synonym = "Адрес ЭП")]
        [StringLength(100)]
        public string АдресЭП {get; set;}
        [Description1C8(Name = "ДоменноеИмяСервера", Comment = "", Synonym = "Доменное имя сервера")]
        [StringLength(100)]
        public string ДоменноеИмяСервера {get; set;}
        [Description1C8(Name = "НомерТелефона", Comment = "", Synonym = "Номер телефона")]
        [StringLength(20)]
        public string НомерТелефона {get; set;}
        [Description1C8(Name = "НомерТелефонаБезКодов", Comment = "", Synonym = "Номер телефона без кодов")]
        [StringLength(20)]
        public string НомерТелефонаБезКодов {get; set;}
        [Description1C8(Name = "ВидДляСписка", Comment = "", Synonym = "Вид для списка")]
        public Catalogs.ВидыКонтактнойИнформации ВидДляСписка {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public string Значение {get; set;}
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("FyzycheskyeLytsa_DopolnytelnyeRekvyzyty")]
    public class ФизическиеЛица_ДополнительныеРеквизиты
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
    [Description1C8(Name = "УдалитьСоставСемьи", Comment = "", Synonym = "(не используется) Состав семьи")]
    [Table("FyzycheskyeLytsa_UdalytSostavSemy")]
    public class ФизическиеЛица_УдалитьСоставСемьи
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СтепеньРодства", Comment = "", Synonym = "Степень родства")]
        public Catalogs.СтепениРодстваФизическихЛиц СтепеньРодства {get; set;}
        [Description1C8(Name = "Имя", Comment = "", Synonym = "Имя")]
        [StringLength(50)]
        public string Имя {get; set;}
        [Description1C8(Name = "ДатаРождения", Comment = "", Synonym = "Дата рождения")]
        public DateTime ДатаРождения {get; set;}
    }
    [Description1C8(Name = "УдалитьОбразование", Comment = "", Synonym = "(не используется) Образование")]
    [Table("FyzycheskyeLytsa_UdalytObrazovanye")]
    public class ФизическиеЛица_УдалитьОбразование
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидОбразования", Comment = "", Synonym = "Вид образования")]
        public Catalogs.ВидыОбразованияФизическихЛиц ВидОбразования {get; set;}
        [Description1C8(Name = "УчебноеЗаведение", Comment = "", Synonym = "Учебное заведение")]
        public Catalogs.УчебныеЗаведения УчебноеЗаведение {get; set;}
        [Description1C8(Name = "Специальность", Comment = "", Synonym = "Специальность")]
        public Catalogs.КлассификаторСпециальностейПоОбразованию Специальность {get; set;}
        [Description1C8(Name = "Диплом", Comment = "", Synonym = "Диплом")]
        [StringLength(50)]
        public string Диплом {get; set;}
        [Description1C8(Name = "ГодОкончания", Comment = "", Synonym = "Год окончания")]
        // Format 4.0
        public long ГодОкончания {get; set;}
        [Description1C8(Name = "Квалификация", Comment = "", Synonym = "Квалификация")]
        [StringLength(100)]
        public string Квалификация {get; set;}
    }
    [Description1C8(Name = "УдалитьТрудоваяДеятельность", Comment = "", Synonym = "(не используется) Трудовая деятельность")]
    [Table("FyzycheskyeLytsa_UdalytTrudovaiaDeiatelnost")]
    public class ФизическиеЛица_УдалитьТрудоваяДеятельность
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        [StringLength(100)]
        public string Организация {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        [StringLength(100)]
        public string Должность {get; set;}
    }
    [Description1C8(Name = "УдалитьЗнаниеЯзыков", Comment = "", Synonym = "(не используется) Знание языков")]
    [Table("FyzycheskyeLytsa_UdalytZnanyeIazykov")]
    public class ФизическиеЛица_УдалитьЗнаниеЯзыков
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Язык", Comment = "", Synonym = "Язык")]
        public Catalogs.ЯзыкиНародовМира Язык {get; set;}
        [Description1C8(Name = "СтепеньЗнанияЯзыка", Comment = "", Synonym = "Степень знания языка")]
        public Catalogs.СтепениЗнанияЯзыка СтепеньЗнанияЯзыка {get; set;}
    }
    [Description1C8(Name = "УдалитьПрофессии", Comment = "", Synonym = "(не используется) Профессии")]
    [Table("FyzycheskyeLytsa_UdalytProfessyy")]
    public class ФизическиеЛица_УдалитьПрофессии
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Профессия", Comment = "", Synonym = "Профессия")]
        public Catalogs.ПрофессииРабочих Профессия {get; set;}
    }
    [Description1C8(Name = "УдалитьСтажи", Comment = "", Synonym = "(не используется) Стажи")]
    [Table("FyzycheskyeLytsa_UdalytStazhy")]
    public class ФизическиеЛица_УдалитьСтажи
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ВидСтажа", Comment = "", Synonym = "Вид стажа")]
        public Catalogs.ВидыСтажа ВидСтажа {get; set;}
        [Description1C8(Name = "ДатаОтсчета", Comment = "", Synonym = "Дата отсчета")]
        public DateTime ДатаОтсчета {get; set;}
        [Description1C8(Name = "РазмерМесяцев", Comment = "", Synonym = "Размер месяцев")]
        // Format 3.0
        public long РазмерМесяцев {get; set;}
        [Description1C8(Name = "РазмерДней", Comment = "", Synonym = "Размер дней")]
        // Format 2.0
        public long РазмерДней {get; set;}
    }
    [Description1C8(Name = "УдалитьНаграды", Comment = "", Synonym = "(не используется) Награды")]
    [Table("FyzycheskyeLytsa_UdalytNahrady")]
    public class ФизическиеЛица_УдалитьНаграды
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Награда", Comment = "", Synonym = "Награда")]
        public Catalogs.Награды Награда {get; set;}
        [Description1C8(Name = "НомерПриказа", Comment = "", Synonym = "Номер приказа")]
        [StringLength(10)]
        public string НомерПриказа {get; set;}
        [Description1C8(Name = "ДатаПриказа", Comment = "", Synonym = "Дата приказа")]
        public DateTime ДатаПриказа {get; set;}
        [Description1C8(Name = "ЧейПриказ", Comment = "", Synonym = "Чей приказ")]
        public string ЧейПриказ {get; set;}
    }
    [Description1C8(Name = "УдалитьУченыеСтепени", Comment = "", Synonym = "(не используется) Ученые степени")]
    [Table("FyzycheskyeLytsa_UdalytUchenyeStepeny")]
    public class ФизическиеЛица_УдалитьУченыеСтепени
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "УченаяСтепень", Comment = "", Synonym = "Ученая степень")]
        public Catalogs.УченыеСтепени УченаяСтепень {get; set;}
        [Description1C8(Name = "ДатаПрисужденияУченойСтепени", Comment = "", Synonym = "Дата присуждения ученой степени")]
        public DateTime ДатаПрисужденияУченойСтепени {get; set;}
        [Description1C8(Name = "ОтрасльНауки", Comment = "", Synonym = "Отрасль науки")]
        public string ОтрасльНауки {get; set;}
        [Description1C8(Name = "ДиссертационныйСовет", Comment = "", Synonym = "Диссертационный совет")]
        public string ДиссертационныйСовет {get; set;}
        [Description1C8(Name = "ДипломСерияНомер", Comment = "", Synonym = "Диплом серия номер")]
        [StringLength(50)]
        public string ДипломСерияНомер {get; set;}
        [Description1C8(Name = "ДипломВыданОрганизация", Comment = "", Synonym = "Диплом выдан организация")]
        public string ДипломВыданОрганизация {get; set;}
    }
    [Description1C8(Name = "УдалитьУченыеЗвания", Comment = "", Synonym = "(не используется) Ученые звания")]
    [Table("FyzycheskyeLytsa_UdalytUchenyeZvanyia")]
    public class ФизическиеЛица_УдалитьУченыеЗвания
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "УченоеЗвание", Comment = "", Synonym = "Ученое звание")]
        public Catalogs.УченыеЗвания УченоеЗвание {get; set;}
        [Description1C8(Name = "ДатаПрисвоенияУченогоЗвания", Comment = "", Synonym = "Дата присвоения ученого звания")]
        public DateTime ДатаПрисвоенияУченогоЗвания {get; set;}
        [Description1C8(Name = "АттестатСерия", Comment = "", Synonym = "Аттестат серия")]
        [StringLength(50)]
        public string АттестатСерия {get; set;}
        [Description1C8(Name = "АттестатНомер", Comment = "", Synonym = "Аттестат номер")]
        [StringLength(50)]
        public string АттестатНомер {get; set;}
        [Description1C8(Name = "АттестатВыданОрганизация", Comment = "", Synonym = "Аттестат выдан организация")]
        public string АттестатВыданОрганизация {get; set;}
        [Description1C8(Name = "НаучнаяСпециальность", Comment = "", Synonym = "Научная специальность")]
        public Catalogs.КлассификаторСпециальностейПоОбразованию НаучнаяСпециальность {get; set;}
    }
}
