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
    [Table("ZaiavlenyeNaPredostavlenyeLhotyPoNDFL")]
    [Description1C8(Name = "ЗаявлениеНаПредоставлениеЛьготыПоНДФЛ", Comment = "", Synonym = "Заявление на применение льготы по НДФЛ")]
    public class ЗаявлениеНаПредоставлениеЛьготыПоНДФЛ:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Месяц", Comment = "", Synonym = "Месяц")]
        public DateTime Месяц {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица Сотрудник {get; set;}
        [Description1C8(Name = "ИзменитьЛьготыНаДетей", Comment = "", Synonym = "Изменить льготы на детей")]
        public bool ИзменитьЛьготыНаДетей {get; set;}
        [Description1C8(Name = "ИзменитьЛичнуюЛьготу", Comment = "", Synonym = "Изменить личную льготу")]
        public bool ИзменитьЛичнуюЛьготу {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ЛьготыНаДетей", Comment = "", Synonym = "Льготы на детей")]
        public List<ЗаявлениеНаПредоставлениеЛьготыПоНДФЛ_ЛьготыНаДетей> ЗаявлениеНаПредоставлениеЛьготыПоНДФЛЛьготыНаДетей {get;set;}
        [Description1C8(Name = "ЛичныеЛьготы", Comment = "", Synonym = "Личные льготы")]
        public List<ЗаявлениеНаПредоставлениеЛьготыПоНДФЛ_ЛичныеЛьготы> ЗаявлениеНаПредоставлениеЛьготыПоНДФЛЛичныеЛьготы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ЛьготыНаДетей", Comment = "", Synonym = "Льготы на детей")]
    [Table("ZaiavlenyeNaPredostavlenyeLhotyPoNDFL_LhotyNaDetei")]
    public class ЗаявлениеНаПредоставлениеЛьготыПоНДФЛ_ЛьготыНаДетей
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public Catalogs.ВидыЛьготПоНДФЛ Льгота {get; set;}
        [Description1C8(Name = "ДействуетДо", Comment = "", Synonym = "Предоставляется по (включительно)")]
        public DateTime ДействуетДо {get; set;}
        [Description1C8(Name = "ДокументПодтверждающийПравоНаЛьготу", Comment = "", Synonym = "Документ, подтверждающий право на льготу")]
        public string ДокументПодтверждающийПравоНаЛьготу {get; set;}
    }
    [Description1C8(Name = "ЛичныеЛьготы", Comment = "", Synonym = "Личные льготы")]
    [Table("ZaiavlenyeNaPredostavlenyeLhotyPoNDFL_LychnyeLhoty")]
    public class ЗаявлениеНаПредоставлениеЛьготыПоНДФЛ_ЛичныеЛьготы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public Catalogs.ВидыЛьготПоНДФЛ Льгота {get; set;}
        [Description1C8(Name = "ДокументПодтверждающийПравоНаЛьготу", Comment = "", Synonym = "Документ, подтверждающий право на льготу")]
        public string ДокументПодтверждающийПравоНаЛьготу {get; set;}
    }
}
