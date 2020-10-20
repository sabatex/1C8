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
    public class РассылкиОтчетов:EnumItem
    {
    #region Стандартні реквізити
    public Guid Id {get; set;}
    public bool IsFolder {get; set;}
    public bool DeletionMark {get; set;}
    public bool Predefined {get; set;}
    public string Code {get; set;}
    public string Description {get; set;}
    public Guid? Parent {get; set;}
    public Guid? Owner {get; set;}
    #endregion Стандартні реквізити
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
    public DBNull FTPПорт {get; set;}
    [Description1C8(Name = "FTPСервер", Comment = "", Synonym = "Сервер")]
    [StringLength(100)]
    public string FTPСервер {get; set;}
    [Description1C8(Name = "Автор", Comment = "", Synonym = "Ответственный")]
    public DBNull Автор {get; set;}
    [Description1C8(Name = "АдресОтвета", Comment = "", Synonym = "Адрес ответа")]
    [StringLength(100)]
    public string АдресОтвета {get; set;}
    [Description1C8(Name = "Архивировать", Comment = "", Synonym = "Архивировать")]
    public bool Архивировать {get; set;}
    [Description1C8(Name = "ВидПочтовогоАдресаПолучателей", Comment = "", Synonym = "Почтовый адрес")]
    public DBNull ВидПочтовогоАдресаПолучателей {get; set;}
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
    public DBNull КартинкиПисьмаВФорматеHTML {get; set;}
    [Description1C8(Name = "Личная", Comment = "", Synonym = "Личная")]
    public bool Личная {get; set;}
    [Description1C8(Name = "Папка", Comment = "", Synonym = "Папка")]
    public DBNull Папка {get; set;}
    [Description1C8(Name = "ПериодичностьРасписания", Comment = "", Synonym = "Периодичность расписания")]
    public DBNull ПериодичностьРасписания {get; set;}
    [Description1C8(Name = "Персонализирована", Comment = "", Synonym = "Персонализирована")]
    public bool Персонализирована {get; set;}
    [Description1C8(Name = "ПисьмоВФорматеHTML", Comment = "", Synonym = "Письмо в формате HTML")]
    public bool ПисьмоВФорматеHTML {get; set;}
    [Description1C8(Name = "Подготовлена", Comment = "", Synonym = "Подготовлена")]
    public bool Подготовлена {get; set;}
    [Description1C8(Name = "РегламентноеЗадание", Comment = "", Synonym = "Регламентное задание")]
    public DBNull РегламентноеЗадание {get; set;}
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
    public DBNull ТипПолучателейРассылки {get; set;}
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
    public DBNull УчетнаяЗапись {get; set;}
    [Description1C8(Name = "СозданаИзФормыОтчета", Comment = "", Synonym = "Создана из формы отчета")]
    public bool СозданаИзФормыОтчета {get; set;}
    #endregion реквізити
    }
}
