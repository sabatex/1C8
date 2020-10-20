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
    [Table("UdalytPodtverzhdenyeUplatyNalohovPoZarplate")]
    [Description1C8(Name = "УдалитьПодтверждениеУплатыНалоговПоЗарплате", Comment = "(регл)", Synonym = "(не используется) Подтверждение уплаты налогов по зарплате")]
    public class УдалитьПодтверждениеУплатыНалоговПоЗарплате:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Период регистрации")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "ПеречисленныйНДФЛ", Comment = "", Synonym = "Перечисленный НДФЛ")]
        // Format 15.2
        public decimal ПеречисленныйНДФЛ {get; set;}
        [Description1C8(Name = "НеподтвержденныйНДФЛ", Comment = "", Synonym = "Неподтвержденный НДФЛ")]
        // Format 15.2
        public decimal НеподтвержденныйНДФЛ {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Краткий состав документа")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "РегулярнаяВыплата", Comment = "", Synonym = "Регулярная выплата")]
        public bool РегулярнаяВыплата {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<УдалитьПодтверждениеУплатыНалоговПоЗарплате_Начисления> УдалитьПодтверждениеУплатыНалоговПоЗарплатеНачисления {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<УдалитьПодтверждениеУплатыНалоговПоЗарплате_Взносы> УдалитьПодтверждениеУплатыНалоговПоЗарплатеВзносы {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<УдалитьПодтверждениеУплатыНалоговПоЗарплате_НДФЛ> УдалитьПодтверждениеУплатыНалоговПоЗарплатеНДФЛ {get;set;}
        [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
        public List<УдалитьПодтверждениеУплатыНалоговПоЗарплате_РаботникиОрганизации> УдалитьПодтверждениеУплатыНалоговПоЗарплатеРаботникиОрганизации {get;set;}
        [Description1C8(Name = "ПлатежиПоВзносам", Comment = "", Synonym = "Платежи по взносам")]
        public List<УдалитьПодтверждениеУплатыНалоговПоЗарплате_ПлатежиПоВзносам> УдалитьПодтверждениеУплатыНалоговПоЗарплатеПлатежиПоВзносам {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("UdalytPodtverzhdenyeUplatyNalohovPoZarplate_Nachyslenyia")]
    public class УдалитьПодтверждениеУплатыНалоговПоЗарплате_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Работник")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "Начислено", Comment = "", Synonym = "Начислено")]
        // Format 15.2
        public decimal Начислено {get; set;}
        [Description1C8(Name = "КВыплате", Comment = "", Synonym = "К выплате")]
        // Format 15.2
        public decimal КВыплате {get; set;}
        [Description1C8(Name = "Выплачено", Comment = "", Synonym = "Выплачено")]
        // Format 15.2
        public decimal Выплачено {get; set;}
        [Description1C8(Name = "НачисленоПоФактуВыплаты", Comment = "", Synonym = "Начислено по факту выплаты")]
        // Format 15.2
        public decimal НачисленоПоФактуВыплаты {get; set;}
    }
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("UdalytPodtverzhdenyeUplatyNalohovPoZarplate_Vznosy")]
    public class УдалитьПодтверждениеУплатыНалоговПоЗарплате_Взносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период")]
        public DateTime НалоговыйПериод {get; set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Работник")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
        [Description1C8(Name = "База", Comment = "База расход", Synonym = "База")]
        // Format 15.2
        public decimal База {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "База Налога расход", Synonym = "База взноса")]
        // Format 15.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "Взнос", Comment = "Результат расход", Synonym = "Взнос")]
        // Format 18.6
        public decimal Взнос {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("UdalytPodtverzhdenyeUplatyNalohovPoZarplate_NDFL")]
    public class УдалитьПодтверждениеУплатыНалоговПоЗарплате_НДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период")]
        public DateTime НалоговыйПериод {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public Catalogs.УстарелоВидыЛьготПоНДФЛ Льгота {get; set;}
        [Description1C8(Name = "ВидСтавки", Comment = "", Synonym = "Вид ставки")]
        public Enums.ВидыСтавокНДФЛ ВидСтавки {get; set;}
        [Description1C8(Name = "Доход", Comment = "", Synonym = "Доход")]
        // Format 12.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        // Format 12.2
        public decimal Налог {get; set;}
    }
    [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
    [Table("UdalytPodtverzhdenyeUplatyNalohovPoZarplate_RabotnykyOrhanyzatsyy")]
    public class УдалитьПодтверждениеУплатыНалоговПоЗарплате_РаботникиОрганизации
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
    }
    [Description1C8(Name = "ПлатежиПоВзносам", Comment = "", Synonym = "Платежи по взносам")]
    [Table("UdalytPodtverzhdenyeUplatyNalohovPoZarplate_PlatezhyPoVznosam")]
    public class УдалитьПодтверждениеУплатыНалоговПоЗарплате_ПлатежиПоВзносам
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "НеподтвержденнаяСумма", Comment = "", Synonym = "Неподтвержденная сумма")]
        // Format 15.2
        public decimal НеподтвержденнаяСумма {get; set;}
        [Description1C8(Name = "База", Comment = "База расход", Synonym = "База")]
        // Format 15.2
        public decimal База {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "База Налога расход", Synonym = "База взноса")]
        // Format 15.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "Взнос", Comment = "Результат расход", Synonym = "Взнос")]
        // Format 18.6
        public decimal Взнос {get; set;}
        [Description1C8(Name = "ПеречисленныйВзнос", Comment = "сумма взносов, которые перечислили и 'не подтвержили'", Synonym = "Перечисленный взнос")]
        // Format 15.2
        public decimal ПеречисленныйВзнос {get; set;}
    }
}
