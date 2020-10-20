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
    [Table("RabotaSverkhurochnoPrysoedynennyeFaily")]
    [Description1C8(Name = "РаботаСверхурочноПрисоединенныеФайлы", Comment = "", Synonym = "Присоединенные файлы (Работа сверхурочно)")]
    public class РаботаСверхурочноПрисоединенныеФайлы:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Автор", Comment = "Автор - пользователь, добавивший файл", Synonym = "Автор")]
        public Catalogs.Пользователи Автор {get; set;}
        [Description1C8(Name = "ВладелецФайла", Comment = "", Synonym = "Владелец файла")]
        public Документ.РаботаСверхурочно ВладелецФайла {get; set;}
        [Description1C8(Name = "ДатаМодификацииУниверсальная", Comment = "", Synonym = "Дата модификации универсальная")]
        public DateTime ДатаМодификацииУниверсальная {get; set;}
        [Description1C8(Name = "ДатаСоздания", Comment = "Дата добавления файла в базу", Synonym = "Дата создания")]
        public DateTime ДатаСоздания {get; set;}
        [Description1C8(Name = "Зашифрован", Comment = "", Synonym = "Зашифрован")]
        public bool Зашифрован {get; set;}
        [Description1C8(Name = "Изменил", Comment = "Автор - пользователь, добавивший файл", Synonym = "Изменил")]
        public Catalogs.Пользователи Изменил {get; set;}
        [Description1C8(Name = "ИндексКартинки", Comment = "Индекс иконки, соответствующей расширению файла, для показа в списке", Synonym = "Индекс картинки")]
        // Format 10.0
        public long ИндексКартинки {get; set;}
        [Description1C8(Name = "Описание", Comment = "Описание файла", Synonym = "Описание")]
        public string Описание {get; set;}
        [Description1C8(Name = "ПодписанЭП", Comment = "", Synonym = "Подписан ЭП")]
        public bool ПодписанЭП {get; set;}
        [Description1C8(Name = "ПутьКФайлу", Comment = "Дополнительный путь к файлу на диске (в случае если ТипХраненияФайла - на диске)", Synonym = "Путь к файлу")]
        public string ПутьКФайлу {get; set;}
        [Description1C8(Name = "Размер", Comment = "Размер файла", Synonym = "Размер")]
        // Format 10.0
        public long Размер {get; set;}
        [Description1C8(Name = "Расширение", Comment = "Расширение файла версии", Synonym = "Расширение")]
        [StringLength(10)]
        public string Расширение {get; set;}
        [Description1C8(Name = "Редактирует", Comment = "Пользователь, занявший файл для редактирования", Synonym = "Редактирует")]
        public Catalogs.Пользователи Редактирует {get; set;}
        [Description1C8(Name = "СтатусИзвлеченияТекста", Comment = "", Synonym = "Статус извлечения текста")]
        public Enums.СтатусыИзвлеченияТекстаФайлов СтатусИзвлеченияТекста {get; set;}
        [Description1C8(Name = "ТекстХранилище", Comment = "Текст, извлеченный из файла - для полнотекстового поиска", Synonym = "Текст")]
        // Сховище значень
        public byte[] ТекстХранилище {get; set;}
        [Description1C8(Name = "ТипХраненияФайла", Comment = "Где хранятся файлы - в базе как ХранилищеЗначения или в каталоге на диске", Synonym = "Тип хранения файла")]
        public Enums.ТипыХраненияФайлов ТипХраненияФайла {get; set;}
        [Description1C8(Name = "Том", Comment = "Ссылка на том (в случае если ТипХраненияФайла - на диске)", Synonym = "Том")]
        public Catalogs.ТомаХраненияФайлов Том {get; set;}
        [Description1C8(Name = "ФайлХранилище", Comment = "Служебное поле для обмена файлами в РИБ", Synonym = "Файл хранилище")]
        // Сховище значень
        public byte[] ФайлХранилище {get; set;}
        [Description1C8(Name = "ДатаЗаема", Comment = "", Synonym = "Дата заема")]
        public DateTime ДатаЗаема {get; set;}
        [Description1C8(Name = "ХранитьВерсии", Comment = "", Synonym = "Хранить версии")]
        public bool ХранитьВерсии {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ЭлектронныеПодписи", Comment = "", Synonym = "Электронные подписи")]
        public List<РаботаСверхурочноПрисоединенныеФайлы_ЭлектронныеПодписи> РаботаСверхурочноПрисоединенныеФайлыЭлектронныеПодписи {get;set;}
        [Description1C8(Name = "СертификатыШифрования", Comment = "", Synonym = "Сертификаты шифрования")]
        public List<РаботаСверхурочноПрисоединенныеФайлы_СертификатыШифрования> РаботаСверхурочноПрисоединенныеФайлыСертификатыШифрования {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ЭлектронныеПодписи", Comment = "", Synonym = "Электронные подписи")]
    [Table("RabotaSverkhurochnoPrysoedynennyeFaily_ЕlektronnyePodpysy")]
    public class РаботаСверхурочноПрисоединенныеФайлы_ЭлектронныеПодписи
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
        [StringLength(255)]
        public string Отпечаток {get; set;}
        [Description1C8(Name = "Подпись", Comment = "", Synonym = "Подпись")]
        // Сховище значень
        public byte[] Подпись {get; set;}
        [Description1C8(Name = "УстановившийПодпись", Comment = "", Synonym = "Установивший подпись")]
        public Catalogs.Пользователи УстановившийПодпись {get; set;}
        [Description1C8(Name = "Сертификат", Comment = "Двоичные данные сертификата", Synonym = "Сертификат")]
        // Сховище значень
        public byte[] Сертификат {get; set;}
        [Description1C8(Name = "ДатаПроверкиПодписи", Comment = "", Synonym = "Дата проверки подписи")]
        public DateTime ДатаПроверкиПодписи {get; set;}
        [Description1C8(Name = "ПодписьВерна", Comment = "", Synonym = "Подпись верна")]
        public bool ПодписьВерна {get; set;}
    }
    [Description1C8(Name = "СертификатыШифрования", Comment = "", Synonym = "Сертификаты шифрования")]
    [Table("RabotaSverkhurochnoPrysoedynennyeFaily_SertyfykatyShyfrovanyia")]
    public class РаботаСверхурочноПрисоединенныеФайлы_СертификатыШифрования
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Отпечаток", Comment = "", Synonym = "Отпечаток")]
        [StringLength(255)]
        public string Отпечаток {get; set;}
        [Description1C8(Name = "Представление", Comment = "", Synonym = "Представление")]
        public string Представление {get; set;}
        [Description1C8(Name = "Сертификат", Comment = "Двоичные данные сертификата", Synonym = "Сертификат")]
        // Сховище значень
        public byte[] Сертификат {get; set;}
    }
}
