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
    public class ПоставляемыеДополнительныеОтчетыИОбработки:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Вид", Comment = "", Synonym = "Вид")]
    public Enums.ВидыДополнительныхОтчетовИОбработок Вид {get; set;}
    [Description1C8(Name = "ИспользоватьДляФормыОбъекта", Comment = "", Synonym = "Использовать для формы объекта")]
    public bool ИспользоватьДляФормыОбъекта {get; set;}
    [Description1C8(Name = "ИспользоватьДляФормыСписка", Comment = "", Synonym = "Использовать для формы списка")]
    public bool ИспользоватьДляФормыСписка {get; set;}
    [Description1C8(Name = "Публикация", Comment = "", Synonym = "Публикация")]
    public Enums.ВариантыПубликацииДополнительныхОтчетовИОбработок Публикация {get; set;}
    [Description1C8(Name = "ПричинаОтключения", Comment = "", Synonym = "Причина отключения")]
    public Enums.ПричиныОтключенияДополнительныхОтчетовИОбработокВМоделиСервиса ПричинаОтключения {get; set;}
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
    // Сховище значень
    public byte[] ХранилищеОбработки {get; set;}
    [Description1C8(Name = "ХранилищеВариантов", Comment = "", Synonym = "Хранилище вариантов")]
    [StringLength(150)]
    public string ХранилищеВариантов {get; set;}
    [Description1C8(Name = "ВерсияGUID", Comment = "", Synonym = "Версия GUID")]
    public Guid ВерсияGUID {get; set;}
    [Description1C8(Name = "КонтролироватьСовместимостьСВерсиямиКонфигурации", Comment = "", Synonym = "Контролировать совместимость с версиями конфигурации")]
    public bool КонтролироватьСовместимостьСВерсиямиКонфигурации {get; set;}
    [Description1C8(Name = "ИспользуетХранилищеВариантов", Comment = "", Synonym = "Использует хранилище вариантов")]
    public bool ИспользуетХранилищеВариантов {get; set;}
    [Description1C8(Name = "РежимСовместимостиРазрешений", Comment = "", Synonym = "Режим совместимости разрешений")]
    public Enums.РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок РежимСовместимостиРазрешений {get; set;}
    #endregion реквізити
    #region tables
    [Description1C8(Name = "Команды", Comment = "", Synonym = "Команды")]
    public List<ПоставляемыеДополнительныеОтчетыИОбработки_Команды> ПоставляемыеДополнительныеОтчетыИОбработкиКоманды
    [Description1C8(Name = "Совместимость", Comment = "", Synonym = "Совместимость")]
    public List<ПоставляемыеДополнительныеОтчетыИОбработки_Совместимость> ПоставляемыеДополнительныеОтчетыИОбработкиСовместимость
    [Description1C8(Name = "Разрешения", Comment = "", Synonym = "Разрешения")]
    public List<ПоставляемыеДополнительныеОтчетыИОбработки_Разрешения> ПоставляемыеДополнительныеОтчетыИОбработкиРазрешения
    #endregion tables
    }
}
