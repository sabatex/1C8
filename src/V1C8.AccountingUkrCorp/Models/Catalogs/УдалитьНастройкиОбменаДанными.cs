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
    [Table("UdalytNastroikyObmenaDannymy")]
    [Description1C8(Name = "УдалитьНастройкиОбменаДанными", Comment = "", Synonym = "(не используется) Настройки обмена данными")]
    public class УдалитьНастройкиОбменаДанными
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
    [Description1C8(Name = "УзелИнформационнойБазы", Comment = "", Synonym = "Узел информационной базы")]
    public ПланОбмена.УдалитьОбменУправлениеТорговлейБухгалтерияФоновый УзелИнформационнойБазы {get; set;}
    [Description1C8(Name = "ТипНастройки", Comment = "", Synonym = "Тип настройки")]
    public Enums.УдалитьТипыАвтоматическогоОбменаДанными ТипНастройки {get; set;}
    [Description1C8(Name = "ПроизводитьПриемСообщений", Comment = "", Synonym = "Производить прием сообщений")]
    public bool ПроизводитьПриемСообщений {get; set;}
    [Description1C8(Name = "ПроизводитьОтправкуСообщений", Comment = "", Synonym = "Производить отправку сообщений")]
    public bool ПроизводитьОтправкуСообщений {get; set;}
    [Description1C8(Name = "КоличествоЭлементовВТранзакцииНаВыгрузкуДанных", Comment = "", Synonym = "Количество элементов в транзакции на выгрузку данных")]
    // Format 10.0
    public long КоличествоЭлементовВТранзакцииНаВыгрузкуДанных {get; set;}
    [Description1C8(Name = "КоличествоЭлементовВТранзакцииНаЗагрузкуДанных", Comment = "", Synonym = "Количество элементов в транзакции на загрузку данных")]
    // Format 10.0
    public long КоличествоЭлементовВТранзакцииНаЗагрузкуДанных {get; set;}
    [Description1C8(Name = "ВыполнятьАрхивациюФайловОбмена", Comment = "", Synonym = "Выполнять архивацию файлов обмена")]
    public bool ВыполнятьАрхивациюФайловОбмена {get; set;}
    [Description1C8(Name = "ПарольНаОтправку", Comment = "", Synonym = "Пароль на отправку")]
    public string ПарольНаОтправку {get; set;}
    [Description1C8(Name = "ПарольНаПрием", Comment = "", Synonym = "Пароль на прием")]
    public string ПарольНаПрием {get; set;}
    [Description1C8(Name = "КаталогОбменаИнформацией", Comment = "", Synonym = "Каталог обмена информацией")]
    public string КаталогОбменаИнформацией {get; set;}
    [Description1C8(Name = "FTPАдресОбмена", Comment = "", Synonym = "FTP адрес обмена")]
    public string FTPАдресОбмена {get; set;}
    [Description1C8(Name = "ВестиЛог", Comment = "", Synonym = "Вести протокол обмена данными")]
    public bool ВестиЛог {get; set;}
    [Description1C8(Name = "ВопросПриАвтообмене", Comment = "", Synonym = "Вопрос при автообмене")]
    public bool ВопросПриАвтообмене {get; set;}
    [Description1C8(Name = "ВыводитьСообщенияОбОшибкахПриАвтоматическомОбменеДанными", Comment = "", Synonym = "Выводить сообщения об ошибках при автоматическом обмене данными")]
    public bool ВыводитьСообщенияОбОшибкахПриАвтоматическомОбменеДанными {get; set;}
    [Description1C8(Name = "ВыводитьИнформационныеСообщенияПриАвтоматическомОбменеДанными", Comment = "", Synonym = "Выводить информационные сообщения при автоматическом обмене данными")]
    public bool ВыводитьИнформационныеСообщенияПриАвтоматическомОбменеДанными {get; set;}
    [Description1C8(Name = "НаличиеКаталогаДляЗапускаАвтообмена", Comment = "", Synonym = "Наличие каталога для запуска автообмена")]
    public string НаличиеКаталогаДляЗапускаАвтообмена {get; set;}
    [Description1C8(Name = "ОтсутствиеКаталогаДляЗапускаАвтообмена", Comment = "", Synonym = "Отсутствие каталога для запуска автообмена")]
    public string ОтсутствиеКаталогаДляЗапускаАвтообмена {get; set;}
    [Description1C8(Name = "ПортFTPСоединения", Comment = "", Synonym = "Порт FTP соединения")]
    // Format 10.0
    public long ПортFTPСоединения {get; set;}
    [Description1C8(Name = "ПользовательFTPСоединения", Comment = "", Synonym = "Пользователь FTP соединения")]
    [StringLength(50)]
    public string ПользовательFTPСоединения {get; set;}
    [Description1C8(Name = "ПарольFTPСоединения", Comment = "", Synonym = "Пароль FTP соединения")]
    [StringLength(50)]
    public string ПарольFTPСоединения {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP", Comment = "", Synonym = "Максимальный размер отправляемого получаемого пакета через FTP")]
    // Format 10.0
    public long МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP {get; set;}
    [Description1C8(Name = "ПассивноеFTPСоединение", Comment = "", Synonym = "Пассивное FTP соединение")]
    public bool ПассивноеFTPСоединение {get; set;}
    [Description1C8(Name = "УзелФоновогоОбмена", Comment = "", Synonym = "Узел фонового обмена")]
    public ПланОбмена.УдалитьОбменУправлениеТорговлейБухгалтерияФоновый УзелФоновогоОбмена {get; set;}
    [Description1C8(Name = "ПравилаОбмена", Comment = "", Synonym = "Правила обмена")]
    // Сховище значень
    public byte[] ПравилаОбмена {get; set;}
    [Description1C8(Name = "ПравилаОбменаДляПриемника", Comment = "", Synonym = "Правила обмена для приемника")]
    // Сховище значень
    public byte[] ПравилаОбменаДляПриемника {get; set;}
    [Description1C8(Name = "ДобавлениеОбъектовИзФоновогоОбмена", Comment = "", Synonym = "Добавление объектов из фонового обмена")]
    // Format 10.0
    public long ДобавлениеОбъектовИзФоновогоОбмена {get; set;}
    [Description1C8(Name = "КоличествоОбъектовДляФоновогоОбмена", Comment = "", Synonym = "Количество объектов для фонового обмена")]
    // Format 10.0
    public long КоличествоОбъектовДляФоновогоОбмена {get; set;}
    [Description1C8(Name = "OnLineОбмен", Comment = "", Synonym = "On line обмен")]
    public bool OnLineОбмен {get; set;}
    [Description1C8(Name = "ТипИнформационнойБазыДляПодключения", Comment = "", Synonym = "Тип информационной базы для подключения")]
    public bool ТипИнформационнойБазыДляПодключения {get; set;}
    [Description1C8(Name = "КаталогИнформационнойБазыДляПодключения", Comment = "", Synonym = "Каталог информационной базы для подключения")]
    public string КаталогИнформационнойБазыДляПодключения {get; set;}
    [Description1C8(Name = "ИмяСервераИнформационнойБазыДляПодключения", Comment = "", Synonym = "Имя сервера информационной базы для подключения")]
    public string ИмяСервераИнформационнойБазыДляПодключения {get; set;}
    [Description1C8(Name = "ИмяИнформационнойБазыНаСервереДляПодключения", Comment = "", Synonym = "Имя информационной базы на сервере для подключения")]
    public string ИмяИнформационнойБазыНаСервереДляПодключения {get; set;}
    [Description1C8(Name = "АутентификацияWindowsИнформационнойБазыДляПодключения", Comment = "", Synonym = "Аутентификация windows информационной базы для подключения")]
    public bool АутентификацияWindowsИнформационнойБазыДляПодключения {get; set;}
    [Description1C8(Name = "ПользовательИнформационнойБазыДляПодключения", Comment = "", Synonym = "Пользователь информационной базы для подключения")]
    public string ПользовательИнформационнойБазыДляПодключения {get; set;}
    [Description1C8(Name = "ПарольИнформационнойБазыДляПодключения", Comment = "", Synonym = "Пароль информационной базы для подключения")]
    public string ПарольИнформационнойБазыДляПодключения {get; set;}
    [Description1C8(Name = "ВерсияПлатформыИнформационнойБазыДляПодключения", Comment = "", Synonym = "Версия платформы информационной базы для подключения")]
    [StringLength(5)]
    public string ВерсияПлатформыИнформационнойБазыДляПодключения {get; set;}
    [Description1C8(Name = "РежимОтладкиOnLineОбмена", Comment = "", Synonym = "Режим отладки on line обмена")]
    public bool РежимОтладкиOnLineОбмена {get; set;}
    [Description1C8(Name = "ИмяФайлаПротоколаОбменаOnLineОбмен", Comment = "", Synonym = "Имя файла протокола обмена on line обмен")]
    [StringLength(255)]
    public string ИмяФайлаПротоколаОбменаOnLineОбмен {get; set;}
    [Description1C8(Name = "ТипУзлаИнформационнойБазы", Comment = "", Synonym = "Тип узла информационной базы")]
    public ПланОбмена.УдалитьОбменУправлениеТорговлейБухгалтерияФоновый ТипУзлаИнформационнойБазы {get; set;}
    [Description1C8(Name = "ПослеОшибкиОтложенногоПроведенияПрекратитьОперации", Comment = "", Synonym = "После ошибки отложенного проведения прекратить операции")]
    public bool ПослеОшибкиОтложенногоПроведенияПрекратитьОперации {get; set;}
    [Description1C8(Name = "КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации", Comment = "", Synonym = "Количество ошибок отложенного проведения для прекращения операции")]
    // Format 10.0
    public long КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации {get; set;}
    [Description1C8(Name = "ВыполнитьОтложенноеПроведениеДокументовПоРасписанию", Comment = "", Synonym = "Выполнить отложенное проведение документов по расписанию")]
    public bool ВыполнитьОтложенноеПроведениеДокументовПоРасписанию {get; set;}
    [Description1C8(Name = "УдалитьДинамическиИзменятьИнтервалМеждуОбменами", Comment = "", Synonym = "Динамически изменять интервал между обменами (не используется)")]
    public bool УдалитьДинамическиИзменятьИнтервалМеждуОбменами {get; set;}
    [Description1C8(Name = "УдалитьРегламентноеЗаданиеФоновыйОбмен", Comment = "", Synonym = "Регламентное задание фоновый обмен (не используется)")]
    [StringLength(40)]
    public string УдалитьРегламентноеЗаданиеФоновыйОбмен {get; set;}
    [Description1C8(Name = "УдалитьРегламентноеЗаданиеОтложенныеДвижения", Comment = "", Synonym = "Регламентное задание отложенные движения (не используется)")]
    [StringLength(40)]
    public string УдалитьРегламентноеЗаданиеОтложенныеДвижения {get; set;}
    [Description1C8(Name = "УдалитьВыполнятьОбменПриПоявленииФайла", Comment = "", Synonym = "Выполнять обмен при появлении файла (не используется)")]
    [StringLength(255)]
    public string УдалитьВыполнятьОбменПриПоявленииФайла {get; set;}
    [Description1C8(Name = "УдалитьИспользоватьРегламентныеЗадания", Comment = "", Synonym = "Использовать регламентные задания (не используется)")]
    public bool УдалитьИспользоватьРегламентныеЗадания {get; set;}
    [Description1C8(Name = "УдалитьРегламентноеЗадание", Comment = "", Synonym = "Регламентное задание (не используется)")]
    [StringLength(40)]
    public string УдалитьРегламентноеЗадание {get; set;}
    [Description1C8(Name = "ПочтовыйАдресПолучателя", Comment = "", Synonym = "Почтовый адрес получателя")]
    public string ПочтовыйАдресПолучателя {get; set;}
    [Description1C8(Name = "УчетнаяЗаписьПриемаОтправкиСообщений", Comment = "", Synonym = "Учетная запись приема отправки сообщений")]
    [StringLength(10)]
    public string УчетнаяЗаписьПриемаОтправкиСообщений {get; set;}
    [Description1C8(Name = "АвтоматическиЗакачиватьПочтуПриОбмене", Comment = "", Synonym = "Автоматически закачивать почту при обмене")]
    public bool АвтоматическиЗакачиватьПочтуПриОбмене {get; set;}
    [Description1C8(Name = "МаксимальныйРазмерОтправляемогоПакетаЧерезПочту", Comment = "", Synonym = "Максимальный размер отправляемого пакета через почту")]
    // Format 10.0
    public long МаксимальныйРазмерОтправляемогоПакетаЧерезПочту {get; set;}
    [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Пользователь")]
    public Catalogs.Пользователи Ответственный {get; set;}
    [Description1C8(Name = "ВыполнятьАвтоматически", Comment = "", Synonym = "Выполнять периодически")]
    public bool ВыполнятьАвтоматически {get; set;}
    [Description1C8(Name = "КаталогПроверкиДоступности", Comment = "", Synonym = "Каталог проверки доступности")]
    [StringLength(255)]
    public string КаталогПроверкиДоступности {get; set;}
    [Description1C8(Name = "КаждыйЗапускПрограммы", Comment = "", Synonym = "Каждый запуск программы")]
    public bool КаждыйЗапускПрограммы {get; set;}
    [Description1C8(Name = "КаждоеЗавершениеРаботыСПрограммой", Comment = "", Synonym = "Каждое завершение работы с программой")]
    public bool КаждоеЗавершениеРаботыСПрограммой {get; set;}
    [Description1C8(Name = "УчетнаяЗаписьОтправкиСообщенияОбОшибке", Comment = "", Synonym = "Учетная запись отправки сообщения об ошибке")]
    [StringLength(10)]
    public string УчетнаяЗаписьОтправкиСообщенияОбОшибке {get; set;}
    [Description1C8(Name = "АдресДляОтправкиСообщенийОбОшибке", Comment = "", Synonym = "Адрес для отправки сообщений об ошибке")]
    [StringLength(100)]
    public string АдресДляОтправкиСообщенийОбОшибке {get; set;}
    [Description1C8(Name = "ВыполнятьДействияПодПолнымиПравами", Comment = "", Synonym = "Выполнять действия под полными правами")]
    public bool ВыполнятьДействияПодПолнымиПравами {get; set;}
    [Description1C8(Name = "ПроизводитьОтправкуТолькоПриУспешномПриеме", Comment = "", Synonym = "Производить отправку только при успешном приеме")]
    public bool ПроизводитьОтправкуТолькоПриУспешномПриеме {get; set;}
    [Description1C8(Name = "ПользовательПроксиFTP", Comment = "", Synonym = "Пользователь прокси FTP")]
    [StringLength(50)]
    public string ПользовательПроксиFTP {get; set;}
    [Description1C8(Name = "ПарольПроксиFTP", Comment = "", Synonym = "Пароль прокси FTP")]
    [StringLength(50)]
    public string ПарольПроксиFTP {get; set;}
    [Description1C8(Name = "СерверПроксиFTP", Comment = "", Synonym = "Сервер прокси FTP")]
    [StringLength(50)]
    public string СерверПроксиFTP {get; set;}
    [Description1C8(Name = "ПортПроксиFTP", Comment = "", Synonym = "Порт прокси FTP")]
    // Format 10.0
    public long ПортПроксиFTP {get; set;}
    [Description1C8(Name = "ПротоколПроксиFTP", Comment = "", Synonym = "Протокол прокси FTP")]
    [StringLength(50)]
    public string ПротоколПроксиFTP {get; set;}
    [Description1C8(Name = "ВерсияПодсистемыОбменаДанными", Comment = "", Synonym = "Версия подсистемы обмена данными")]
    public Enums.ВерсииПодсистемыОбменаДанными ВерсияПодсистемыОбменаДанными {get; set;}
    #endregion реквізити
    }
}
