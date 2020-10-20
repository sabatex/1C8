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
    [Table("UdalytVvodNachalnykhOstatkovPoZarplate")]
    [Description1C8(Name = "УдалитьВводНачальныхОстатковПоЗарплате", Comment = "(Регл)", Synonym = "(не используется) Ввод начальных остатков по зарплате")]
    public class УдалитьВводНачальныхОстатковПоЗарплате:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "", Synonym = "Подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Период регистрации")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Краткий состав документа")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
        public List<УдалитьВводНачальныхОстатковПоЗарплате_РаботникиОрганизации> УдалитьВводНачальныхОстатковПоЗарплатеРаботникиОрганизации {get;set;}
        [Description1C8(Name = "ОтражениеВУчете", Comment = "", Synonym = "Отражение в учете")]
        public List<УдалитьВводНачальныхОстатковПоЗарплате_ОтражениеВУчете> УдалитьВводНачальныхОстатковПоЗарплатеОтражениеВУчете {get;set;}
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<УдалитьВводНачальныхОстатковПоЗарплате_Начисления> УдалитьВводНачальныхОстатковПоЗарплатеНачисления {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<УдалитьВводНачальныхОстатковПоЗарплате_Взносы> УдалитьВводНачальныхОстатковПоЗарплатеВзносы {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<УдалитьВводНачальныхОстатковПоЗарплате_НДФЛ> УдалитьВводНачальныхОстатковПоЗарплатеНДФЛ {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
    [Table("UdalytVvodNachalnykhOstatkovPoZarplate_RabotnykyOrhanyzatsyy")]
    public class УдалитьВводНачальныхОстатковПоЗарплате_РаботникиОрганизации
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
    [Description1C8(Name = "ОтражениеВУчете", Comment = "", Synonym = "Отражение в учете")]
    [Table("UdalytVvodNachalnykhOstatkovPoZarplate_OtrazhenyeVUchete")]
    public class УдалитьВводНачальныхОстатковПоЗарплате_ОтражениеВУчете
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетДт", Comment = "", Synonym = "Счет Дт")]
        public ПланСчетов.Хозрасчетный СчетДт {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "", Synonym = "Субконто Дт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "", Synonym = "Субконто Дт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "", Synonym = "Субконто Дт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "СчетКт", Comment = "", Synonym = "Счет Кт")]
        public ПланСчетов.Хозрасчетный СчетКт {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "", Synonym = "Субконто Кт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "", Synonym = "Субконто Кт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "", Synonym = "Субконто Кт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтатьяВаловыхРасходов", Comment = "", Synonym = "Статья в/р")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяВаловыхРасходов {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("UdalytVvodNachalnykhOstatkovPoZarplate_Nachyslenyia")]
    public class УдалитьВводНачальныхОстатковПоЗарплате_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "УдалитьФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица УдалитьФизЛицо {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "Счет", Comment = "", Synonym = "Счет")]
        public ПланСчетов.Хозрасчетный Счет {get; set;}
    }
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("UdalytVvodNachalnykhOstatkovPoZarplate_Vznosy")]
    public class УдалитьВводНачальныхОстатковПоЗарплате_Взносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "УдалитьФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица УдалитьФизЛицо {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "Счет", Comment = "", Synonym = "Счет")]
        public ПланСчетов.Хозрасчетный Счет {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "", Synonym = "Результат")]
        // Format 14.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("UdalytVvodNachalnykhOstatkovPoZarplate_NDFL")]
    public class УдалитьВводНачальныхОстатковПоЗарплате_НДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Счет", Comment = "", Synonym = "Счет Дт")]
        public ПланСчетов.Хозрасчетный Счет {get; set;}
        [Description1C8(Name = "ВидСтавки", Comment = "", Synonym = "Вид ставки")]
        public Enums.ВидыСтавокНДФЛ ВидСтавки {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "'Код дохода НДФЛ' или 'Вид расчета взносов наФОТ'", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ПериодВзаиморасчетов", Comment = "", Synonym = "Период взаиморасчетов")]
        public DateTime ПериодВзаиморасчетов {get; set;}
        [Description1C8(Name = "Доход", Comment = "", Synonym = "Доход")]
        // Format 15.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public Catalogs.УстарелоВидыЛьготПоНДФЛ Льгота {get; set;}
        [Description1C8(Name = "КоличествоЛьгот", Comment = "", Synonym = "Количество льгот")]
        // Format 5.2
        public decimal КоличествоЛьгот {get; set;}
        [Description1C8(Name = "УдалитьФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица УдалитьФизЛицо {get; set;}
    }
}
