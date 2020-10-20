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
    [Table("FyzycheskyeLytsa")]
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    public class ФизическиеЛица:CatalogItem
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
    [Description1C8(Name = "ДатаРождения", Comment = "", Synonym = "Дата рождения")]
    public DateTime ДатаРождения {get; set;}
    [Description1C8(Name = "КодПоДРФО", Comment = "", Synonym = "Код по ДРФО")]
    [StringLength(10)]
    public string КодПоДРФО {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "(Общ)", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "Пол", Comment = "", Synonym = "Пол")]
    public Enums.ПолФизическогоЛица Пол {get; set;}
    [Description1C8(Name = "УдалитьСтраховойНомерПФ", Comment = "(Регл)", Synonym = "(не используется)  Страховой номер ПФ")]
    [StringLength(14)]
    public string УдалитьСтраховойНомерПФ {get; set;}
    [Description1C8(Name = "МестоРождения", Comment = "", Synonym = "Место рождения")]
    [StringLength(240)]
    public string МестоРождения {get; set;}
    [Description1C8(Name = "ИмеетНаучныеТруды", Comment = "", Synonym = "Имеет научные труды")]
    public bool ИмеетНаучныеТруды {get; set;}
    [Description1C8(Name = "ИмеетИзобретения", Comment = "", Synonym = "Имеет изобретения")]
    public bool ИмеетИзобретения {get; set;}
    [Description1C8(Name = "ГруппаДоступа", Comment = "", Synonym = "Группа доступа")]
    public Catalogs.ГруппыДоступаФизическихЛиц ГруппаДоступа {get; set;}
    [Description1C8(Name = "УдалитьПол", Comment = "Пол", Synonym = "(не используется) Пол")]
    public Enums.УдалитьПолФизическихЛиц УдалитьПол {get; set;}
    [Description1C8(Name = "ФИО", Comment = "", Synonym = "ФИО")]
    [StringLength(50)]
    public string ФИО {get; set;}
    [Description1C8(Name = "УточнениеНаименования", Comment = "", Synonym = "Уточнение наименования")]
    [StringLength(15)]
    public string УточнениеНаименования {get; set;}
    [Description1C8(Name = "ДатаРегистрации", Comment = "Дата регистрации", Synonym = "Дата регистрации")]
    public DateTime ДатаРегистрации {get; set;}
    [Description1C8(Name = "ЛьготаПриНачисленииПособий", Comment = "", Synonym = "Льгота при начислении пособий")]
    public Enums.ОснованияЛьготПоПособию ЛьготаПриНачисленииПособий {get; set;}
    [Description1C8(Name = "Фотография", Comment = "", Synonym = "Фотография")]
    public Catalogs.Файлы Фотография {get; set;}
    [Description1C8(Name = "НаименованиеСлужебное", Comment = "", Synonym = "Наименование служебное")]
    [StringLength(70)]
    public string НаименованиеСлужебное {get; set;}
    #endregion реквізити
    }
}
