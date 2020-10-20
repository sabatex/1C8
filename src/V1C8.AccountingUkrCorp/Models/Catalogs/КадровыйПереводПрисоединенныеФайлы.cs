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
    [Table("KadrovyiPerevodPrysoedynennyeFaily")]
    [Description1C8(Name = "КадровыйПереводПрисоединенныеФайлы", Comment = "", Synonym = "Присоединенные файлы (Кадровый перевод)")]
    public class КадровыйПереводПрисоединенныеФайлы:EnumItem
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
    [Description1C8(Name = "Автор", Comment = "Автор - пользователь, добавивший файл", Synonym = "Автор")]
    public DBNull Автор {get; set;}
    [Description1C8(Name = "ВладелецФайла", Comment = "", Synonym = "Владелец файла")]
    public DBNull ВладелецФайла {get; set;}
    [Description1C8(Name = "ДатаМодификацииУниверсальная", Comment = "", Synonym = "Дата модификации универсальная")]
    public DateTime ДатаМодификацииУниверсальная {get; set;}
    [Description1C8(Name = "ДатаСоздания", Comment = "Дата добавления файла в базу", Synonym = "Дата создания")]
    public DateTime ДатаСоздания {get; set;}
    [Description1C8(Name = "Зашифрован", Comment = "", Synonym = "Зашифрован")]
    public bool Зашифрован {get; set;}
    [Description1C8(Name = "Изменил", Comment = "Автор - пользователь, добавивший файл", Synonym = "Изменил")]
    public DBNull Изменил {get; set;}
    [Description1C8(Name = "ИндексКартинки", Comment = "Индекс иконки, соответствующей расширению файла, для показа в списке", Synonym = "Индекс картинки")]
    public DBNull ИндексКартинки {get; set;}
    [Description1C8(Name = "Описание", Comment = "Описание файла", Synonym = "Описание")]
    public string Описание {get; set;}
    [Description1C8(Name = "ПодписанЭП", Comment = "", Synonym = "Подписан ЭП")]
    public bool ПодписанЭП {get; set;}
    [Description1C8(Name = "ПутьКФайлу", Comment = "Дополнительный путь к файлу на диске (в случае если ТипХраненияФайла - на диске)", Synonym = "Путь к файлу")]
    public string ПутьКФайлу {get; set;}
    [Description1C8(Name = "Размер", Comment = "Размер файла", Synonym = "Размер")]
    public DBNull Размер {get; set;}
    [Description1C8(Name = "Расширение", Comment = "Расширение файла версии", Synonym = "Расширение")]
    [StringLength(10)]
    public string Расширение {get; set;}
    [Description1C8(Name = "Редактирует", Comment = "Пользователь, занявший файл для редактирования", Synonym = "Редактирует")]
    public DBNull Редактирует {get; set;}
    [Description1C8(Name = "СтатусИзвлеченияТекста", Comment = "", Synonym = "Статус извлечения текста")]
    public DBNull СтатусИзвлеченияТекста {get; set;}
    [Description1C8(Name = "ТекстХранилище", Comment = "Текст, извлеченный из файла - для полнотекстового поиска", Synonym = "Текст")]
    public DBNull ТекстХранилище {get; set;}
    [Description1C8(Name = "ТипХраненияФайла", Comment = "Где хранятся файлы - в базе как ХранилищеЗначения или в каталоге на диске", Synonym = "Тип хранения файла")]
    public DBNull ТипХраненияФайла {get; set;}
    [Description1C8(Name = "Том", Comment = "Ссылка на том (в случае если ТипХраненияФайла - на диске)", Synonym = "Том")]
    public DBNull Том {get; set;}
    [Description1C8(Name = "ФайлХранилище", Comment = "Служебное поле для обмена файлами в РИБ", Synonym = "Файл хранилище")]
    public DBNull ФайлХранилище {get; set;}
    [Description1C8(Name = "ДатаЗаема", Comment = "", Synonym = "Дата заема")]
    public DateTime ДатаЗаема {get; set;}
    [Description1C8(Name = "ХранитьВерсии", Comment = "", Synonym = "Хранить версии")]
    public bool ХранитьВерсии {get; set;}
    #endregion реквізити
    }
}
