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
    [Table("PostuplenyeTovarovUsluhPrysoedynennyeFaily")]
    [Description1C8(Name = "ПоступлениеТоваровУслугПрисоединенныеФайлы", Comment = "", Synonym = "Присоединенные файлы (Поступление товаров и услуг)")]
    public class ПоступлениеТоваровУслугПрисоединенныеФайлы:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Автор", Comment = "Автор - пользователь, добавивший файл", Synonym = "Автор")]
    public Catalogs.УчетныеЗаписиСинхронизацииФайлов Автор {get; set;}
    [Description1C8(Name = "ВладелецФайла", Comment = "", Synonym = "Владелец файла")]
    public Документ.ПоступлениеТоваровУслуг ВладелецФайла {get; set;}
    [Description1C8(Name = "ДатаМодификацииУниверсальная", Comment = "", Synonym = "Дата модификации универсальная")]
    public DateTime ДатаМодификацииУниверсальная {get; set;}
    [Description1C8(Name = "ДатаСоздания", Comment = "Дата добавления файла в базу", Synonym = "Дата создания")]
    public DateTime ДатаСоздания {get; set;}
    [Description1C8(Name = "Зашифрован", Comment = "", Synonym = "Зашифрован")]
    public bool Зашифрован {get; set;}
    [Description1C8(Name = "Изменил", Comment = "Автор - пользователь, добавивший файл", Synonym = "Изменил")]
    public Catalogs.УчетныеЗаписиСинхронизацииФайлов Изменил {get; set;}
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
    public Catalogs.УчетныеЗаписиСинхронизацииФайлов Редактирует {get; set;}
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
    #endregion tables
    }
}
