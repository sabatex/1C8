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
    [Table("VaryantyOtchetov")]
    [Description1C8(Name = "ВариантыОтчетов", Comment = "", Synonym = "Отчеты")]
    public class ВариантыОтчетов
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
    public Catalogs.ВнешниеПользователи Автор {get; set;}
    [Description1C8(Name = "ВидимостьПоУмолчанию", Comment = "", Synonym = "По умолчанию виден в панелях отчетов")]
    public bool ВидимостьПоУмолчанию {get; set;}
    [Description1C8(Name = "ВидимостьПоУмолчаниюПереопределена", Comment = "Когда Истина то вместо флажка ВидимостьПоУмолчанию используется значение аналогичного флажка предопределенного варианта отчета.", Synonym = "Видимость по умолчанию переопределена")]
    public bool ВидимостьПоУмолчаниюПереопределена {get; set;}
    [Description1C8(Name = "ИнтерактивнаяПометкаУдаления", Comment = "", Synonym = "Интерактивная пометка удаления")]
    public bool ИнтерактивнаяПометкаУдаления {get; set;}
    [Description1C8(Name = "КлючВарианта", Comment = "", Synonym = "Ключ варианта")]
    [StringLength(256)]
    public string КлючВарианта {get; set;}
    [Description1C8(Name = "КлючевыеСлова", Comment = "", Synonym = "Ключевые слова")]
    public string КлючевыеСлова {get; set;}
    [Description1C8(Name = "НаименованияПараметровИОтборов", Comment = "", Synonym = "Наименования параметров и отборов")]
    public string НаименованияПараметровИОтборов {get; set;}
    [Description1C8(Name = "НаименованияПолей", Comment = "", Synonym = "Наименования полей")]
    public string НаименованияПолей {get; set;}
    [Description1C8(Name = "Настройки", Comment = "", Synonym = "Настройки")]
    // Сховище значень
    public byte[] Настройки {get; set;}
    [Description1C8(Name = "Описание", Comment = "", Synonym = "Описание")]
    public string Описание {get; set;}
    [Description1C8(Name = "Отчет", Comment = "", Synonym = "Отчет")]
    public Catalogs.ИдентификаторыОбъектовРасширений Отчет {get; set;}
    [Description1C8(Name = "Пользовательский", Comment = "", Synonym = "Пользовательский")]
    public bool Пользовательский {get; set;}
    [Description1C8(Name = "ПредопределенныйВариант", Comment = "Вариант конфигурации", Synonym = "Предопределенный вариант")]
    public Catalogs.ПредопределенныеВариантыОтчетовРасширений ПредопределенныйВариант {get; set;}
    [Description1C8(Name = "ТипОтчета", Comment = "", Synonym = "Тип отчета")]
    public Enums.ТипыОтчетов ТипОтчета {get; set;}
    [Description1C8(Name = "ТолькоДляАвтора", Comment = "", Synonym = "Только для автора")]
    public bool ТолькоДляАвтора {get; set;}
    [Description1C8(Name = "УдалитьКлючОбъекта", Comment = "", Synonym = "(не используется) Ключ объекта")]
    [StringLength(150)]
    public string УдалитьКлючОбъекта {get; set;}
    [Description1C8(Name = "УдалитьПредставлениеОбъекта", Comment = "", Synonym = "(не используется) Представление объекта")]
    [StringLength(256)]
    public string УдалитьПредставлениеОбъекта {get; set;}
    [Description1C8(Name = "ХешНастроек", Comment = "", Synonym = "Хеш настроек")]
    [StringLength(32)]
    public string ХешНастроек {get; set;}
    #endregion реквізити
    }
}
