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
    [Table("PostavliaemyeDopolnytelnyeOtchetyYObrabotky")]
    [Description1C8(Name = "ПоставляемыеДополнительныеОтчетыИОбработки", Comment = "", Synonym = "Поставляемые дополнительные отчеты и обработки")]
    public class ПоставляемыеДополнительныеОтчетыИОбработки:EnumItem
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
    [Description1C8(Name = "Вид", Comment = "", Synonym = "Вид")]
    public DBNull Вид {get; set;}
    [Description1C8(Name = "ИспользоватьДляФормыОбъекта", Comment = "", Synonym = "Использовать для формы объекта")]
    public bool ИспользоватьДляФормыОбъекта {get; set;}
    [Description1C8(Name = "ИспользоватьДляФормыСписка", Comment = "", Synonym = "Использовать для формы списка")]
    public bool ИспользоватьДляФормыСписка {get; set;}
    [Description1C8(Name = "Публикация", Comment = "", Synonym = "Публикация")]
    public DBNull Публикация {get; set;}
    [Description1C8(Name = "ПричинаОтключения", Comment = "", Synonym = "Причина отключения")]
    public DBNull ПричинаОтключения {get; set;}
    [Description1C8(Name = "Информация", Comment = "", Synonym = "Информация")]
    [StringLength(1024)]
    public string Информация {get; set;}
    [Description1C8(Name = "Версия", Comment = "", Synonym = "Версия")]
    [StringLength(10)]
    public string Версия {get; set;}
    [Description1C8(Name = "БезопасныйРежим", Comment = "", Synonym = "Безопасный режим")]
    public bool БезопасныйРежим {get; set;}
    [Description1C8(Name = "ИмяОбъекта", Comment = "", Synonym = "Имя объекта")]
    [StringLength(256)]
    public string ИмяОбъекта {get; set;}
    [Description1C8(Name = "ИмяФайла", Comment = "", Synonym = "Имя файла")]
    [StringLength(260)]
    public string ИмяФайла {get; set;}
    [Description1C8(Name = "ХранилищеОбработки", Comment = "", Synonym = "Хранилище обработки")]
    public DBNull ХранилищеОбработки {get; set;}
    [Description1C8(Name = "ХранилищеВариантов", Comment = "", Synonym = "Хранилище вариантов")]
    [StringLength(150)]
    public string ХранилищеВариантов {get; set;}
    [Description1C8(Name = "ВерсияGUID", Comment = "", Synonym = "Версия GUID")]
    public DBNull ВерсияGUID {get; set;}
    [Description1C8(Name = "КонтролироватьСовместимостьСВерсиямиКонфигурации", Comment = "", Synonym = "Контролировать совместимость с версиями конфигурации")]
    public bool КонтролироватьСовместимостьСВерсиямиКонфигурации {get; set;}
    [Description1C8(Name = "ИспользуетХранилищеВариантов", Comment = "", Synonym = "Использует хранилище вариантов")]
    public bool ИспользуетХранилищеВариантов {get; set;}
    [Description1C8(Name = "РежимСовместимостиРазрешений", Comment = "", Synonym = "Режим совместимости разрешений")]
    public DBNull РежимСовместимостиРазрешений {get; set;}
    #endregion реквізити
    }
}
