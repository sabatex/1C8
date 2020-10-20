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
    [Table("VersyyFailov")]
    [Description1C8(Name = "ВерсииФайлов", Comment = "", Synonym = "Версии файлов")]
    public class ВерсииФайлов:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Автор", Comment = "", Synonym = "Автор")]
        public Catalogs.УчетныеЗаписиСинхронизацииФайлов Автор {get; set;}
        [Description1C8(Name = "ДатаМодификацииУниверсальная", Comment = "", Synonym = "Дата изменения (универсальное время)")]
        public DateTime ДатаМодификацииУниверсальная {get; set;}
        [Description1C8(Name = "ДатаМодификацииФайла", Comment = "", Synonym = "Дата изменения (местное время)")]
        public DateTime ДатаМодификацииФайла {get; set;}
        [Description1C8(Name = "ДатаСоздания", Comment = "", Synonym = "Дата создания")]
        public DateTime ДатаСоздания {get; set;}
        [Description1C8(Name = "УдалитьЗашифрован", Comment = "", Synonym = "(не используется) Зашифрована")]
        public bool УдалитьЗашифрован {get; set;}
        [Description1C8(Name = "ИндексКартинки", Comment = "", Synonym = "Индекс значка")]
        // Format 10.0
        public long ИндексКартинки {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "НомерВерсии", Comment = "", Synonym = "Номер")]
        // Format 5.0
        public long НомерВерсии {get; set;}
        [Description1C8(Name = "УдалитьПодписанЭП", Comment = "", Synonym = "(не используется) Подписана электронно")]
        public bool УдалитьПодписанЭП {get; set;}
        [Description1C8(Name = "ПолноеНаименование", Comment = "", Synonym = "Полное наименование")]
        [StringLength(256)]
        public string ПолноеНаименование {get; set;}
        [Description1C8(Name = "ПутьКФайлу", Comment = "", Synonym = "Путь к файлу")]
        public string ПутьКФайлу {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер (байт)")]
        // Format 10.0
        public long Размер {get; set;}
        [Description1C8(Name = "Расширение", Comment = "", Synonym = "Расширение")]
        [StringLength(10)]
        public string Расширение {get; set;}
        [Description1C8(Name = "РодительскаяВерсия", Comment = "", Synonym = "Родительская версия")]
        public Catalogs.ВерсииФайлов РодительскаяВерсия {get; set;}
        [Description1C8(Name = "СтатусИзвлеченияТекста", Comment = "", Synonym = "Статус извлечения текста")]
        public Enums.СтатусыИзвлеченияТекстаФайлов СтатусИзвлеченияТекста {get; set;}
        [Description1C8(Name = "ТекстХранилище", Comment = "", Synonym = "Текст")]
        // Сховище значень
        public byte[] ТекстХранилище {get; set;}
        [Description1C8(Name = "ТипХраненияФайла", Comment = "", Synonym = "Тип хранения версии файла")]
        public Enums.ТипыХраненияФайлов ТипХраненияФайла {get; set;}
        [Description1C8(Name = "Том", Comment = "", Synonym = "Том")]
        public Catalogs.ТомаХраненияФайлов Том {get; set;}
        [Description1C8(Name = "ФайлХранилище", Comment = "", Synonym = "Временное хранилище версии файла")]
        // Сховище значень
        public byte[] ФайлХранилище {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "УдалитьЭлектронныеПодписи", Comment = "", Synonym = "(не используется) Электронные подписи")]
        public List<ВерсииФайлов_УдалитьЭлектронныеПодписи> ВерсииФайловУдалитьЭлектронныеПодписи {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "УдалитьЭлектронныеПодписи", Comment = "", Synonym = "(не используется) Электронные подписи")]
    [Table("VersyyFailov_UdalytЕlektronnyePodpysy")]
    public class ВерсииФайлов_УдалитьЭлектронныеПодписи
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ДатаПодписи", Comment = "", Synonym = "Дата подписи")]
        public DateTime ДатаПодписи {get; set;}
        [Description1C8(Name = "ИмяФайлаПодписи", Comment = "", Synonym = "Имя файла подписи")]
        [StringLength(260)]
        public string ИмяФайлаПодписи {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "КомуВыданСертификат", Comment = "", Synonym = "Кому выдан сертификат")]
        public string КомуВыданСертификат {get; set;}
        [Description1C8(Name = "Отпечаток", Comment = "", Synonym = "Отпечаток")]
        [StringLength(28)]
        public string Отпечаток {get; set;}
        [Description1C8(Name = "Подпись", Comment = "", Synonym = "Подпись")]
        // Сховище значень
        public byte[] Подпись {get; set;}
        [Description1C8(Name = "УстановившийПодпись", Comment = "", Synonym = "Установивший подпись")]
        public Catalogs.Пользователи УстановившийПодпись {get; set;}
        [Description1C8(Name = "Сертификат", Comment = "", Synonym = "Сертификат")]
        // Сховище значень
        public byte[] Сертификат {get; set;}
        [Description1C8(Name = "ДатаПроверкиПодписи", Comment = "", Synonym = "Дата проверки подписи")]
        public DateTime ДатаПроверкиПодписи {get; set;}
        [Description1C8(Name = "ПодписьВерна", Comment = "", Synonym = "Подпись верна")]
        public bool ПодписьВерна {get; set;}
    }
}
