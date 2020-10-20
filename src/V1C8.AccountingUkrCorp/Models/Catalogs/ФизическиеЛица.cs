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
    #region tables
    [Description1C8(Name = "СоставСемьи", Comment = "(Общ)", Synonym = "Состав семьи физического лица")]
    public List<ФизическиеЛица_СоставСемьи> ФизическиеЛицаСоставСемьи
    [Description1C8(Name = "КонтактнаяИнформация", Comment = "", Synonym = "Контактная информация")]
    public List<ФизическиеЛица_КонтактнаяИнформация> ФизическиеЛицаКонтактнаяИнформация
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    public List<ФизическиеЛица_ДополнительныеРеквизиты> ФизическиеЛицаДополнительныеРеквизиты
    [Description1C8(Name = "УдалитьСоставСемьи", Comment = "", Synonym = "(не используется) Состав семьи")]
    public List<ФизическиеЛица_УдалитьСоставСемьи> ФизическиеЛицаУдалитьСоставСемьи
    [Description1C8(Name = "УдалитьОбразование", Comment = "", Synonym = "(не используется) Образование")]
    public List<ФизическиеЛица_УдалитьОбразование> ФизическиеЛицаУдалитьОбразование
    [Description1C8(Name = "УдалитьТрудоваяДеятельность", Comment = "", Synonym = "(не используется) Трудовая деятельность")]
    public List<ФизическиеЛица_УдалитьТрудоваяДеятельность> ФизическиеЛицаУдалитьТрудоваяДеятельность
    [Description1C8(Name = "УдалитьЗнаниеЯзыков", Comment = "", Synonym = "(не используется) Знание языков")]
    public List<ФизическиеЛица_УдалитьЗнаниеЯзыков> ФизическиеЛицаУдалитьЗнаниеЯзыков
    [Description1C8(Name = "УдалитьПрофессии", Comment = "", Synonym = "(не используется) Профессии")]
    public List<ФизическиеЛица_УдалитьПрофессии> ФизическиеЛицаУдалитьПрофессии
    [Description1C8(Name = "УдалитьСтажи", Comment = "", Synonym = "(не используется) Стажи")]
    public List<ФизическиеЛица_УдалитьСтажи> ФизическиеЛицаУдалитьСтажи
    [Description1C8(Name = "УдалитьНаграды", Comment = "", Synonym = "(не используется) Награды")]
    public List<ФизическиеЛица_УдалитьНаграды> ФизическиеЛицаУдалитьНаграды
    [Description1C8(Name = "УдалитьУченыеСтепени", Comment = "", Synonym = "(не используется) Ученые степени")]
    public List<ФизическиеЛица_УдалитьУченыеСтепени> ФизическиеЛицаУдалитьУченыеСтепени
    [Description1C8(Name = "УдалитьУченыеЗвания", Comment = "", Synonym = "(не используется) Ученые звания")]
    public List<ФизическиеЛица_УдалитьУченыеЗвания> ФизическиеЛицаУдалитьУченыеЗвания
    #endregion tables
    }
}
