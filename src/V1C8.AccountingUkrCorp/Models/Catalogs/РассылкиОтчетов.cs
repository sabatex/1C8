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
    [Table("RassylkyOtchetov")]
    [Description1C8(Name = "РассылкиОтчетов", Comment = "", Synonym = "Рассылки отчетов")]
    public class РассылкиОтчетов:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "FTPКаталог", Comment = "", Synonym = "Каталог")]
        [StringLength(200)]
        public string FTPКаталог {get; set;}
        [Description1C8(Name = "FTPЛогин", Comment = "", Synonym = "Логин")]
        [StringLength(50)]
        public string FTPЛогин {get; set;}
        [Description1C8(Name = "FTPПассивноеСоединение", Comment = "", Synonym = "Пассивное соединение")]
        public bool FTPПассивноеСоединение {get; set;}
        [Description1C8(Name = "FTPПорт", Comment = "", Synonym = "Порт")]
        // Format 5.0
        public long FTPПорт {get; set;}
        [Description1C8(Name = "FTPСервер", Comment = "", Synonym = "Сервер")]
        [StringLength(100)]
        public string FTPСервер {get; set;}
        [Description1C8(Name = "Автор", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Автор {get; set;}
        [Description1C8(Name = "АдресОтвета", Comment = "", Synonym = "Адрес ответа")]
        [StringLength(100)]
        public string АдресОтвета {get; set;}
        [Description1C8(Name = "Архивировать", Comment = "", Synonym = "Архивировать")]
        public bool Архивировать {get; set;}
        [Description1C8(Name = "ВидПочтовогоАдресаПолучателей", Comment = "", Synonym = "Почтовый адрес")]
        public Catalogs.ВидыКонтактнойИнформации ВидПочтовогоАдресаПолучателей {get; set;}
        [Description1C8(Name = "ВыполнятьПоРасписанию", Comment = "", Synonym = "Выполнять по расписанию")]
        public bool ВыполнятьПоРасписанию {get; set;}
        [Description1C8(Name = "ИмяАрхива", Comment = "", Synonym = "Имя архива")]
        [StringLength(75)]
        public string ИмяАрхива {get; set;}
        [Description1C8(Name = "ИспользоватьFTPРесурс", Comment = "", Synonym = "Использовать FTP ресурс")]
        public bool ИспользоватьFTPРесурс {get; set;}
        [Description1C8(Name = "ИспользоватьПапку", Comment = "", Synonym = "Использовать папку")]
        public bool ИспользоватьПапку {get; set;}
        [Description1C8(Name = "ИспользоватьСетевойКаталог", Comment = "", Synonym = "Использовать сетевой каталог")]
        public bool ИспользоватьСетевойКаталог {get; set;}
        [Description1C8(Name = "ИспользоватьЭлектроннуюПочту", Comment = "", Synonym = "Отправлять по электронной почте:")]
        public bool ИспользоватьЭлектроннуюПочту {get; set;}
        [Description1C8(Name = "КартинкиПисьмаВФорматеHTML", Comment = "", Synonym = "Картинки письма в формате HTML")]
        // Сховище значень
        public byte[] КартинкиПисьмаВФорматеHTML {get; set;}
        [Description1C8(Name = "Личная", Comment = "", Synonym = "Личная")]
        public bool Личная {get; set;}
        [Description1C8(Name = "Папка", Comment = "", Synonym = "Папка")]
        public Catalogs.ПапкиФайлов Папка {get; set;}
        [Description1C8(Name = "ПериодичностьРасписания", Comment = "", Synonym = "Периодичность расписания")]
        public Enums.ПериодичностиРасписанийРассылокОтчетов ПериодичностьРасписания {get; set;}
        [Description1C8(Name = "Персонализирована", Comment = "", Synonym = "Персонализирована")]
        public bool Персонализирована {get; set;}
        [Description1C8(Name = "ПисьмоВФорматеHTML", Comment = "", Synonym = "Письмо в формате HTML")]
        public bool ПисьмоВФорматеHTML {get; set;}
        [Description1C8(Name = "Подготовлена", Comment = "", Synonym = "Подготовлена")]
        public bool Подготовлена {get; set;}
        [Description1C8(Name = "РегламентноеЗадание", Comment = "", Synonym = "Регламентное задание")]
        public Guid РегламентноеЗадание {get; set;}
        [Description1C8(Name = "СетевойКаталогLinux", Comment = "", Synonym = "Сетевой каталог linux")]
        [StringLength(200)]
        public string СетевойКаталогLinux {get; set;}
        [Description1C8(Name = "СетевойКаталогWindows", Comment = "", Synonym = "Сетевой каталог windows")]
        [StringLength(200)]
        public string СетевойКаталогWindows {get; set;}
        [Description1C8(Name = "СкрытыеКопии", Comment = "", Synonym = "Отправлять письма через скрытые копии")]
        public bool СкрытыеКопии {get; set;}
        [Description1C8(Name = "ТекстПисьма", Comment = "", Synonym = "Текст письма")]
        public string ТекстПисьма {get; set;}
        [Description1C8(Name = "ТекстПисьмаВФорматеHTML", Comment = "", Synonym = "Текст письма в формате HTML")]
        public string ТекстПисьмаВФорматеHTML {get; set;}
        [Description1C8(Name = "ТемаПисьма", Comment = "", Synonym = "Тема")]
        public string ТемаПисьма {get; set;}
        [Description1C8(Name = "ТипПолучателейРассылки", Comment = "", Synonym = "Кому")]
        public Catalogs.ИдентификаторыОбъектовМетаданных ТипПолучателейРассылки {get; set;}
        [Description1C8(Name = "ТолькоУведомить", Comment = "", Synonym = "Отправлять только уведомления")]
        public bool ТолькоУведомить {get; set;}
        [Description1C8(Name = "ТранслитерироватьИменаФайлов", Comment = "", Synonym = "Транслитерировать имена файлов")]
        public bool ТранслитерироватьИменаФайлов {get; set;}
        [Description1C8(Name = "УдалитьFTPПароль", Comment = "", Synonym = "(не используется) Пароль")]
        [StringLength(50)]
        public string УдалитьFTPПароль {get; set;}
        [Description1C8(Name = "УдалитьПарольАрхива", Comment = "", Synonym = "(не используется) Пароль архива")]
        [StringLength(75)]
        public string УдалитьПарольАрхива {get; set;}
        [Description1C8(Name = "УчетнаяЗапись", Comment = "", Synonym = "От")]
        public Catalogs.УчетныеЗаписиЭлектроннойПочты УчетнаяЗапись {get; set;}
        [Description1C8(Name = "СозданаИзФормыОтчета", Comment = "", Synonym = "Создана из формы отчета")]
        public bool СозданаИзФормыОтчета {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Отчеты", Comment = "", Synonym = "Отчеты")]
        public List<РассылкиОтчетов_Отчеты> РассылкиОтчетовОтчеты {get;set;}
        [Description1C8(Name = "ФорматыОтчетов", Comment = "", Synonym = "Форматы отчетов")]
        public List<РассылкиОтчетов_ФорматыОтчетов> РассылкиОтчетовФорматыОтчетов {get;set;}
        [Description1C8(Name = "Получатели", Comment = "", Synonym = "Получатели")]
        public List<РассылкиОтчетов_Получатели> РассылкиОтчетовПолучатели {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Отчеты", Comment = "", Synonym = "Отчеты")]
    [Table("RassylkyOtchetov_Otchety")]
    public class РассылкиОтчетов_Отчеты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Отчет", Comment = "", Synonym = "Отчет")]
        public Catalogs.ДополнительныеОтчетыИОбработки Отчет {get; set;}
        [Description1C8(Name = "ОтправлятьЕслиПустой", Comment = "", Synonym = "Отправлять пустой")]
        public bool ОтправлятьЕслиПустой {get; set;}
        [Description1C8(Name = "Настройки", Comment = "ПользовательскиеНастройкиКомпоновкиДанных или ТаблицаЗначений", Synonym = "Настройки")]
        // Сховище значень
        public byte[] Настройки {get; set;}
    }
    [Description1C8(Name = "ФорматыОтчетов", Comment = "", Synonym = "Форматы отчетов")]
    [Table("RassylkyOtchetov_FormatyOtchetov")]
    public class РассылкиОтчетов_ФорматыОтчетов
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Отчет", Comment = "", Synonym = "Отчет")]
        public Catalogs.ДополнительныеОтчетыИОбработки Отчет {get; set;}
        [Description1C8(Name = "Формат", Comment = "", Synonym = "Формат")]
        public Enums.ФорматыСохраненияОтчетов Формат {get; set;}
    }
    [Description1C8(Name = "Получатели", Comment = "", Synonym = "Получатели")]
    [Table("RassylkyOtchetov_Poluchately")]
    public class РассылкиОтчетов_Получатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Получатель", Comment = "", Synonym = "Получатель")]
        public Catalogs.КонтактныеЛица Получатель {get; set;}
        [Description1C8(Name = "Исключен", Comment = "", Synonym = "Исключен")]
        public bool Исключен {get; set;}
    }
}
