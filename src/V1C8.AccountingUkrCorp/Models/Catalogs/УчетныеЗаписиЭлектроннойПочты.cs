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
    [Table("UchetnyeZapysyЕlektronnoiPochty")]
    [Description1C8(Name = "УчетныеЗаписиЭлектроннойПочты", Comment = "", Synonym = "Учетные записи электронной почты")]
    public class УчетныеЗаписиЭлектроннойПочты:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "SMTPАутентификация", Comment = "", Synonym = "SMTP аутентификация")]
    public Enums.ВариантыSMTPАутентификации SMTPАутентификация {get; set;}
    [Description1C8(Name = "АдресЭлектроннойПочты", Comment = "", Synonym = "Адрес электронной почты")]
    [StringLength(255)]
    public string АдресЭлектроннойПочты {get; set;}
    [Description1C8(Name = "ВремяОжидания", Comment = "", Synonym = "Время ожидания сервера (сек)")]
    // Format 3.0
    public long ВремяОжидания {get; set;}
    [Description1C8(Name = "ИмяПользователя", Comment = "Имя отправителя", Synonym = "Имя пользователя")]
    [StringLength(100)]
    public string ИмяПользователя {get; set;}
    [Description1C8(Name = "ИспользоватьБезопасныйВходНаСерверВходящейПочты", Comment = "", Synonym = "Использовать безопасный вход на сервер входящей почты")]
    public bool ИспользоватьБезопасныйВходНаСерверВходящейПочты {get; set;}
    [Description1C8(Name = "ИспользоватьБезопасныйВходНаСерверИсходящейПочты", Comment = "", Synonym = "Использовать безопасный вход на сервер исходящей почты")]
    public bool ИспользоватьБезопасныйВходНаСерверИсходящейПочты {get; set;}
    [Description1C8(Name = "ИспользоватьДляОтправки", Comment = "", Synonym = "Использовать для отправки")]
    public bool ИспользоватьДляОтправки {get; set;}
    [Description1C8(Name = "ИспользоватьДляПолучения", Comment = "", Synonym = "Использовать для получения")]
    public bool ИспользоватьДляПолучения {get; set;}
    [Description1C8(Name = "ИспользоватьЗащищенноеСоединениеДляВходящейПочты", Comment = "", Synonym = "Использовать защищенное соединение для входящей почты")]
    public bool ИспользоватьЗащищенноеСоединениеДляВходящейПочты {get; set;}
    [Description1C8(Name = "ИспользоватьЗащищенноеСоединениеДляИсходящейПочты", Comment = "", Synonym = "Использовать защищенное соединение для исходящей почты")]
    public bool ИспользоватьЗащищенноеСоединениеДляИсходящейПочты {get; set;}
    [Description1C8(Name = "ОставлятьКопииСообщенийНаСервере", Comment = "", Synonym = "Оставлять копии сообщений на сервере")]
    public bool ОставлятьКопииСообщенийНаСервере {get; set;}
    [Description1C8(Name = "ПериодХраненияСообщенийНаСервере", Comment = "", Synonym = "Период хранения сообщений на сервере")]
    // Format 3.0
    public long ПериодХраненияСообщенийНаСервере {get; set;}
    [Description1C8(Name = "Пользователь", Comment = "", Synonym = "Пользователь")]
    [StringLength(100)]
    public string Пользователь {get; set;}
    [Description1C8(Name = "ПользовательSMTP", Comment = "", Synonym = "Пользователь SMTP")]
    [StringLength(100)]
    public string ПользовательSMTP {get; set;}
    [Description1C8(Name = "ПортСервераВходящейПочты", Comment = "", Synonym = "Порт сервера входящей почты")]
    // Format 5.0
    public long ПортСервераВходящейПочты {get; set;}
    [Description1C8(Name = "ПортСервераИсходящейПочты", Comment = "", Synonym = "Порт сервера исходящей почты")]
    // Format 5.0
    public long ПортСервераИсходящейПочты {get; set;}
    [Description1C8(Name = "ПротоколВходящейПочты", Comment = "", Synonym = "Протокол входящей почты")]
    [StringLength(4)]
    public string ПротоколВходящейПочты {get; set;}
    [Description1C8(Name = "СерверВходящейПочты", Comment = "", Synonym = "Сервер входящей почты")]
    [StringLength(300)]
    public string СерверВходящейПочты {get; set;}
    [Description1C8(Name = "СерверИсходящейПочты", Comment = "", Synonym = "Сервер исходящей почты (SMTP)")]
    [StringLength(300)]
    public string СерверИсходящейПочты {get; set;}
    [Description1C8(Name = "СпособPOP3Аутентификации", Comment = "", Synonym = "Способ POP3 аутентификации")]
    public Enums.СпособыPOP3Аутентификации СпособPOP3Аутентификации {get; set;}
    [Description1C8(Name = "СпособSMTPАутентификации", Comment = "", Synonym = "Способ SMTP аутентификации")]
    public Enums.СпособыSMTPАутентификации СпособSMTPАутентификации {get; set;}
    [Description1C8(Name = "ТребуетсяВходНаСерверПередОтправкой", Comment = "", Synonym = "Требуется вход на сервер перед отправкой")]
    public bool ТребуетсяВходНаСерверПередОтправкой {get; set;}
    [Description1C8(Name = "УдалитьВПредставлениеВключатьИмяПользователя", Comment = "", Synonym = "(не используется) В представление включать имя пользователя")]
    public bool УдалитьВПредставлениеВключатьИмяПользователя {get; set;}
    [Description1C8(Name = "УдалитьОтветственныйЗаОбработкуПисем", Comment = "", Synonym = "(не используется) Ответственный за обработку писем")]
    public Catalogs.Пользователи УдалитьОтветственныйЗаОбработкуПисем {get; set;}
    [Description1C8(Name = "УдалитьПароль", Comment = "", Synonym = "(не используется) Пароль")]
    [StringLength(100)]
    public string УдалитьПароль {get; set;}
    [Description1C8(Name = "УдалитьПарольSMTP", Comment = "", Synonym = "(не используется) Пароль SMTP")]
    [StringLength(100)]
    public string УдалитьПарольSMTP {get; set;}
    [Description1C8(Name = "ОтправлятьСкрытыеКопииПисемНаЭтотАдрес", Comment = "", Synonym = "Отправлять скрытые копии писем на этот адрес")]
    public bool ОтправлятьСкрытыеКопииПисемНаЭтотАдрес {get; set;}
    [Description1C8(Name = "ВладелецУчетнойЗаписи", Comment = "", Synonym = "Владелец учетной записи")]
    public Catalogs.Пользователи ВладелецУчетнойЗаписи {get; set;}
    #endregion реквізити
    #region tables
    #endregion tables
    }
}
