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
    [Table("NalohovaiaNakladnaiaPrysoedynennyeFaily")]
    [Description1C8(Name = "НалоговаяНакладнаяПрисоединенныеФайлы", Comment = "", Synonym = "Присоединенные файлы (Налоговая накладная)")]
    public class НалоговаяНакладнаяПрисоединенныеФайлы:EnumItem
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
    [Description1C8(Name = "Автор", Comment = "", Synonym = "Автор")]
    public DBNull Автор {get; set;}
    [Description1C8(Name = "ВладелецФайла", Comment = "", Synonym = "Размещение")]
    public DBNull ВладелецФайла {get; set;}
    [Description1C8(Name = "ДатаМодификацииУниверсальная", Comment = "", Synonym = "Дата изменения (универсальное время)")]
    public DateTime ДатаМодификацииУниверсальная {get; set;}
    [Description1C8(Name = "ДатаСоздания", Comment = "", Synonym = "Дата создания")]
    public DateTime ДатаСоздания {get; set;}
    [Description1C8(Name = "Зашифрован", Comment = "", Synonym = "Зашифрован")]
    public bool Зашифрован {get; set;}
    [Description1C8(Name = "Изменил", Comment = "", Synonym = "Отредактировал")]
    public DBNull Изменил {get; set;}
    [Description1C8(Name = "ИндексКартинки", Comment = "", Synonym = "Индекс значка")]
    public DBNull ИндексКартинки {get; set;}
    [Description1C8(Name = "Описание", Comment = "", Synonym = "Описание")]
    public string Описание {get; set;}
    [Description1C8(Name = "ПодписанЭП", Comment = "", Synonym = "Подписан электронно")]
    public bool ПодписанЭП {get; set;}
    [Description1C8(Name = "ПутьКФайлу", Comment = "", Synonym = "Путь к файлу")]
    public string ПутьКФайлу {get; set;}
    [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер (байт)")]
    public DBNull Размер {get; set;}
    [Description1C8(Name = "Расширение", Comment = "", Synonym = "Расширение")]
    [StringLength(10)]
    public string Расширение {get; set;}
    [Description1C8(Name = "Редактирует", Comment = "", Synonym = "Редактирует")]
    public DBNull Редактирует {get; set;}
    [Description1C8(Name = "СтатусИзвлеченияТекста", Comment = "", Synonym = "Статус извлечения текста")]
    public DBNull СтатусИзвлеченияТекста {get; set;}
    [Description1C8(Name = "ТекстХранилище", Comment = "", Synonym = "Текст")]
    public DBNull ТекстХранилище {get; set;}
    [Description1C8(Name = "ТипХраненияФайла", Comment = "", Synonym = "Тип хранения файла")]
    public DBNull ТипХраненияФайла {get; set;}
    [Description1C8(Name = "Том", Comment = "", Synonym = "Том")]
    public DBNull Том {get; set;}
    [Description1C8(Name = "ФайлХранилище", Comment = "", Synonym = "Временное хранилище файла")]
    public DBNull ФайлХранилище {get; set;}
    [Description1C8(Name = "ДатаЗаема", Comment = "", Synonym = "Дата заема")]
    public DateTime ДатаЗаема {get; set;}
    [Description1C8(Name = "ХранитьВерсии", Comment = "", Synonym = "Хранить версии")]
    public bool ХранитьВерсии {get; set;}
    #endregion реквізити
    }
}
