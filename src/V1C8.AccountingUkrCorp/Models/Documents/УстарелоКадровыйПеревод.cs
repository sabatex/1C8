using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Documents
{
    [Table("UstareloKadrovyiPerevod")]
    [Description1C8(Name = "УстарелоКадровыйПеревод", Comment = "", Synonym = "ѳ(устарело) Кадровый перевод")]
    public class УстарелоКадровыйПеревод:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата перевода")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ОбособленноеПодразделение", Comment = "", Synonym = "Обособленное подразделение")]
        public Catalogs.Организации ОбособленноеПодразделение {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.УстарелоДолжности Должность {get; set;}
        [Description1C8(Name = "ВидЗанятости", Comment = "", Synonym = "Вид занятости")]
        public Enums.УстарелоВидыЗанятости ВидЗанятости {get; set;}
        [Description1C8(Name = "ИзменитьПодразделениеИДолжность", Comment = "", Synonym = "Изменить подразделение и должность")]
        public bool ИзменитьПодразделениеИДолжность {get; set;}
        [Description1C8(Name = "ИзменитьНачисления", Comment = "", Synonym = "Изменить начисления")]
        public bool ИзменитьНачисления {get; set;}
        [Description1C8(Name = "ПричинаПеревода", Comment = "", Synonym = "Причина перевода")]
        public string ПричинаПеревода {get; set;}
        [Description1C8(Name = "ОснованиеПеревода", Comment = "", Synonym = "Основание перевода")]
        [StringLength(254)]
        public string ОснованиеПеревода {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.УстарелоДолжности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "ПринятНаНовоеРабочееМесто", Comment = "", Synonym = "Принят на новое рабочее место")]
        public bool ПринятНаНовоеРабочееМесто {get; set;}
        [Description1C8(Name = "ИзменениеДолжности", Comment = "", Synonym = "Изменение должности")]
        public bool ИзменениеДолжности {get; set;}
        [Description1C8(Name = "ПредыдущаяДолжность", Comment = "", Synonym = "Предыдущая должность")]
        public Catalogs.УстарелоДолжности ПредыдущаяДолжность {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<УстарелоКадровыйПеревод_Начисления> УстарелоКадровыйПереводНачисления {get;set;}
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        public List<УстарелоКадровыйПеревод_Удержания> УстарелоКадровыйПереводУдержания {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("UstareloKadrovyiPerevod_Nachyslenyia")]
    public class УстарелоКадровыйПеревод_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.УстарелоНачисления Начисление {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
    }
    [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
    [Table("UstareloKadrovyiPerevod_Uderzhanyia")]
    public class УстарелоКадровыйПеревод_Удержания
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Удержание", Comment = "", Synonym = "Удержание")]
        public ПланВидовРасчета.УстарелоУдержания Удержание {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
    }
}
