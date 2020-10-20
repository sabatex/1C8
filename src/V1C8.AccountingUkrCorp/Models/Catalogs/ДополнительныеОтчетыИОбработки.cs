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
    [Table("DopolnytelnyeOtchetyYObrabotky")]
    [Description1C8(Name = "ДополнительныеОтчетыИОбработки", Comment = "", Synonym = "Дополнительные отчеты и обработки")]
    public class ДополнительныеОтчетыИОбработки:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "БезопасныйРежим", Comment = "", Synonym = "Безопасный режим")]
    public bool БезопасныйРежим {get; set;}
    [Description1C8(Name = "Версия", Comment = "", Synonym = "Версия")]
    [StringLength(10)]
    public string Версия {get; set;}
    [Description1C8(Name = "Вид", Comment = "", Synonym = "Вид")]
    public Enums.ВидыДополнительныхОтчетовИОбработок Вид {get; set;}
    [Description1C8(Name = "ИмяОбъекта", Comment = "", Synonym = "Имя объекта")]
    [StringLength(256)]
    public string ИмяОбъекта {get; set;}
    [Description1C8(Name = "ИмяФайла", Comment = "", Synonym = "Имя файла")]
    [StringLength(260)]
    public string ИмяФайла {get; set;}
    [Description1C8(Name = "Информация", Comment = "", Synonym = "Информация")]
    [StringLength(1024)]
    public string Информация {get; set;}
    [Description1C8(Name = "ИспользоватьДляФормыОбъекта", Comment = "", Synonym = "Использовать для формы объекта")]
    public bool ИспользоватьДляФормыОбъекта {get; set;}
    [Description1C8(Name = "ИспользоватьДляФормыСписка", Comment = "", Synonym = "Использовать для формы списка")]
    public bool ИспользоватьДляФормыСписка {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
    public Catalogs.Пользователи Ответственный {get; set;}
    [Description1C8(Name = "Публикация", Comment = "", Synonym = "Публикация")]
    public Enums.ВариантыПубликацииДополнительныхОтчетовИОбработок Публикация {get; set;}
    [Description1C8(Name = "ХранилищеНастроек", Comment = "", Synonym = "Хранилище настроек")]
    // Сховище значень
    public byte[] ХранилищеНастроек {get; set;}
    [Description1C8(Name = "ХранилищеОбработки", Comment = "", Synonym = "Хранилище обработки")]
    // Сховище значень
    public byte[] ХранилищеОбработки {get; set;}
    [Description1C8(Name = "ИспользуетХранилищеВариантов", Comment = "Когда Истина то дополнительный отчет подключен к хранилищу вариантов 'ХранилищеВариантовОтчетов'.", Synonym = "Использует хранилище вариантов")]
    public bool ИспользуетХранилищеВариантов {get; set;}
    [Description1C8(Name = "ТеснаяИнтеграцияСФормойОтчета", Comment = "Когда Истина то у отчета есть программный интерфейс для тесной интеграции с общей формой 'ФормаОтчета'.", Synonym = "Тесная интеграция с формой отчета")]
    public bool ТеснаяИнтеграцияСФормойОтчета {get; set;}
    [Description1C8(Name = "РежимСовместимостиРазрешений", Comment = "", Synonym = "Режим совместимости разрешений")]
    public Enums.РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок РежимСовместимостиРазрешений {get; set;}
    #endregion реквізити
    #region tables
    [Description1C8(Name = "Команды", Comment = "", Synonym = "Команды")]
    public List<ДополнительныеОтчетыИОбработки_Команды> ДополнительныеОтчетыИОбработкиКоманды
    [Description1C8(Name = "Назначение", Comment = "", Synonym = "Назначение")]
    public List<ДополнительныеОтчетыИОбработки_Назначение> ДополнительныеОтчетыИОбработкиНазначение
    [Description1C8(Name = "Разделы", Comment = "", Synonym = "Разделы")]
    public List<ДополнительныеОтчетыИОбработки_Разделы> ДополнительныеОтчетыИОбработкиРазделы
    [Description1C8(Name = "Разрешения", Comment = "", Synonym = "Разрешения")]
    public List<ДополнительныеОтчетыИОбработки_Разрешения> ДополнительныеОтчетыИОбработкиРазрешения
    #endregion tables
    }
}
