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
    [Table("UstareloZaiavlenyeNaPrymenenyeLhoty")]
    [Description1C8(Name = "УстарелоЗаявлениеНаПрименениеЛьготы", Comment = "", Synonym = "ѳ(устарело) Заявление на применение льготы НДФЛ")]
    public class УстарелоЗаявлениеНаПрименениеЛьготы:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Краткий состав документа")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Работники", Comment = "", Synonym = "Работники")]
        public List<УстарелоЗаявлениеНаПрименениеЛьготы_Работники> УстарелоЗаявлениеНаПрименениеЛьготыРаботники {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Работники", Comment = "", Synonym = "Работники")]
    [Table("UstareloZaiavlenyeNaPrymenenyeLhoty_Rabotnyky")]
    public class УстарелоЗаявлениеНаПрименениеЛьготы_Работники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public Catalogs.УстарелоВидыЛьготПоНДФЛ Льгота {get; set;}
        [Description1C8(Name = "ДатаИзменения", Comment = "", Synonym = "Дата изменения")]
        public DateTime ДатаИзменения {get; set;}
        [Description1C8(Name = "Актуальность", Comment = "", Synonym = "Актуальность")]
        public bool Актуальность {get; set;}
        [Description1C8(Name = "УдалитьСотрудник", Comment = "", Synonym = "(не используется) Сотрудник")]
        public Catalogs.Сотрудники УдалитьСотрудник {get; set;}
    }
}
