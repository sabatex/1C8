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
    [Table("DopolnytelnyeOtchetyYObrabotky")]
    [Description1C8(Name = "ДополнительныеОтчетыИОбработки", Comment = "", Synonym = "Дополнительные отчеты и обработки")]
    public class ДополнительныеОтчетыИОбработки:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "БезопасныйРежим", Comment = "", Synonym = "Безопасный режим")]
        public bool БезопасныйРежим {get; set;}
        [Description1C8(Name = "Версия", Comment = "", Synonym = "Версия")]
        [StringLength(10)]
        public string Версия {get; set;}
        [Description1C8(Name = "Вид", Comment = "", Synonym = "Вид")]
        public Enums.ВидыДополнительныхОтчетовИОбработок Вид {get; set;}
        [Description1C8(Name = "ИмяОбъекта", Comment = "", Synonym = "Имя объекта")]
        [StringLength(256)]
        public string ИмяОбъекта {get; set;}
        [Description1C8(Name = "ИмяФайла", Comment = "", Synonym = "Имя файла")]
        [StringLength(260)]
        public string ИмяФайла {get; set;}
        [Description1C8(Name = "Информация", Comment = "", Synonym = "Информация")]
        [StringLength(1024)]
        public string Информация {get; set;}
        [Description1C8(Name = "ИспользоватьДляФормыОбъекта", Comment = "", Synonym = "Использовать для формы объекта")]
        public bool ИспользоватьДляФормыОбъекта {get; set;}
        [Description1C8(Name = "ИспользоватьДляФормыСписка", Comment = "", Synonym = "Использовать для формы списка")]
        public bool ИспользоватьДляФормыСписка {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Публикация", Comment = "", Synonym = "Публикация")]
        public Enums.ВариантыПубликацииДополнительныхОтчетовИОбработок Публикация {get; set;}
        [Description1C8(Name = "ХранилищеНастроек", Comment = "", Synonym = "Хранилище настроек")]
        // Сховище значень
        public byte[] ХранилищеНастроек {get; set;}
        [Description1C8(Name = "ХранилищеОбработки", Comment = "", Synonym = "Хранилище обработки")]
        // Сховище значень
        public byte[] ХранилищеОбработки {get; set;}
        [Description1C8(Name = "ИспользуетХранилищеВариантов", Comment = "Когда Истина то дополнительный отчет подключен к хранилищу вариантов 'ХранилищеВариантовОтчетов'.", Synonym = "Использует хранилище вариантов")]
        public bool ИспользуетХранилищеВариантов {get; set;}
        [Description1C8(Name = "ТеснаяИнтеграцияСФормойОтчета", Comment = "Когда Истина то у отчета есть программный интерфейс для тесной интеграции с общей формой 'ФормаОтчета'.", Synonym = "Тесная интеграция с формой отчета")]
        public bool ТеснаяИнтеграцияСФормойОтчета {get; set;}
        [Description1C8(Name = "РежимСовместимостиРазрешений", Comment = "", Synonym = "Режим совместимости разрешений")]
        public Enums.РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок РежимСовместимостиРазрешений {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Команды", Comment = "", Synonym = "Команды")]
        public List<ДополнительныеОтчетыИОбработки_Команды> ДополнительныеОтчетыИОбработкиКоманды {get;set;}
        [Description1C8(Name = "Назначение", Comment = "", Synonym = "Назначение")]
        public List<ДополнительныеОтчетыИОбработки_Назначение> ДополнительныеОтчетыИОбработкиНазначение {get;set;}
        [Description1C8(Name = "Разделы", Comment = "", Synonym = "Разделы")]
        public List<ДополнительныеОтчетыИОбработки_Разделы> ДополнительныеОтчетыИОбработкиРазделы {get;set;}
        [Description1C8(Name = "Разрешения", Comment = "", Synonym = "Разрешения")]
        public List<ДополнительныеОтчетыИОбработки_Разрешения> ДополнительныеОтчетыИОбработкиРазрешения {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Команды", Comment = "", Synonym = "Команды")]
    [Table("DopolnytelnyeOtchetyYObrabotky_Komandy")]
    public class ДополнительныеОтчетыИОбработки_Команды
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "Идентификатор", Comment = "", Synonym = "Идентификатор")]
        [StringLength(100)]
        public string Идентификатор {get; set;}
        [Description1C8(Name = "ВариантЗапуска", Comment = "", Synonym = "Вариант запуска")]
        public Enums.СпособыВызоваДополнительныхОбработок ВариантЗапуска {get; set;}
        [Description1C8(Name = "Представление", Comment = "", Synonym = "Наименование")]
        [StringLength(200)]
        public string Представление {get; set;}
        [Description1C8(Name = "ПоказыватьОповещение", Comment = "", Synonym = "Показывать оповещение")]
        public bool ПоказыватьОповещение {get; set;}
        [Description1C8(Name = "Модификатор", Comment = "", Synonym = "Модификатор")]
        [StringLength(256)]
        public string Модификатор {get; set;}
        [Description1C8(Name = "РегламентноеЗаданиеGUID", Comment = "", Synonym = "Регламентное задание GUID")]
        public Guid РегламентноеЗаданиеGUID {get; set;}
        [Description1C8(Name = "Скрыть", Comment = "", Synonym = "Скрыть")]
        public bool Скрыть {get; set;}
        [Description1C8(Name = "ЗаменяемыеКоманды", Comment = "", Synonym = "Заменяемые команды")]
        public string ЗаменяемыеКоманды {get; set;}
    }
    [Description1C8(Name = "Назначение", Comment = "", Synonym = "Назначение")]
    [Table("DopolnytelnyeOtchetyYObrabotky_Naznachenye")]
    public class ДополнительныеОтчетыИОбработки_Назначение
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "ОбъектНазначения", Comment = "", Synonym = "Объект назначения")]
        public Catalogs.ИдентификаторыОбъектовМетаданных ОбъектНазначения {get; set;}
        [Description1C8(Name = "УдалитьПолноеИмяОбъектаМетаданных", Comment = "", Synonym = "(не используется) Полное имя объекта метаданных")]
        [StringLength(200)]
        public string УдалитьПолноеИмяОбъектаМетаданных {get; set;}
    }
    [Description1C8(Name = "Разделы", Comment = "", Synonym = "Разделы")]
    [Table("DopolnytelnyeOtchetyYObrabotky_Razdely")]
    public class ДополнительныеОтчетыИОбработки_Разделы
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "Раздел", Comment = "", Synonym = "Раздел")]
        public Catalogs.ИдентификаторыОбъектовМетаданных Раздел {get; set;}
        [Description1C8(Name = "УдалитьИмяРаздела", Comment = "", Synonym = "(не используется) Имя раздела")]
        [StringLength(100)]
        public string УдалитьИмяРаздела {get; set;}
    }
    [Description1C8(Name = "Разрешения", Comment = "", Synonym = "Разрешения")]
    [Table("DopolnytelnyeOtchetyYObrabotky_Razreshenyia")]
    public class ДополнительныеОтчетыИОбработки_Разрешения
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "ВидРазрешения", Comment = "", Synonym = "Вид разрешения")]
        [StringLength(255)]
        public string ВидРазрешения {get; set;}
        [Description1C8(Name = "Параметры", Comment = "", Synonym = "Параметры")]
        // Сховище значень
        public byte[] Параметры {get; set;}
    }
}
