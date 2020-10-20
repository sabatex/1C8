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
    [Table("UdalytOtrazhenyeZarplatyVRehlUchete")]
    [Description1C8(Name = "УдалитьОтражениеЗарплатыВРеглУчете", Comment = "(Регл)", Synonym = "(не используется) Отражение зарплаты в регл учете")]
    public class УдалитьОтражениеЗарплатыВРеглУчете:DocumentItem
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
        #endregion реквізити
        #region tables
        [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
        public List<УдалитьОтражениеЗарплатыВРеглУчете_РаботникиОрганизации> УдалитьОтражениеЗарплатыВРеглУчетеРаботникиОрганизации {get;set;}
        [Description1C8(Name = "ОтражениеВУчете", Comment = "", Synonym = "Отражение в учете")]
        public List<УдалитьОтражениеЗарплатыВРеглУчете_ОтражениеВУчете> УдалитьОтражениеЗарплатыВРеглУчетеОтражениеВУчете {get;set;}
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<УдалитьОтражениеЗарплатыВРеглУчете_Начисления> УдалитьОтражениеЗарплатыВРеглУчетеНачисления {get;set;}
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        public List<УдалитьОтражениеЗарплатыВРеглУчете_Удержания> УдалитьОтражениеЗарплатыВРеглУчетеУдержания {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<УдалитьОтражениеЗарплатыВРеглУчете_Взносы> УдалитьОтражениеЗарплатыВРеглУчетеВзносы {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
        public List<УдалитьОтражениеЗарплатыВРеглУчете_ВзносыФОТ> УдалитьОтражениеЗарплатыВРеглУчетеВзносыФОТ {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<УдалитьОтражениеЗарплатыВРеглУчете_НДФЛ> УдалитьОтражениеЗарплатыВРеглУчетеНДФЛ {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "РаботникиОрганизации", Comment = "", Synonym = "Работники организации")]
    [Table("UdalytOtrazhenyeZarplatyVRehlUchete_RabotnykyOrhanyzatsyy")]
    public class УдалитьОтражениеЗарплатыВРеглУчете_РаботникиОрганизации
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
    }
    [Description1C8(Name = "ОтражениеВУчете", Comment = "", Synonym = "Отражение в учете")]
    [Table("UdalytOtrazhenyeZarplatyVRehlUchete_OtrazhenyeVUchete")]
    public class УдалитьОтражениеЗарплатыВРеглУчете_ОтражениеВУчете
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
    [Table("UdalytOtrazhenyeZarplatyVRehlUchete_Nachyslenyia")]
    public class УдалитьОтражениеЗарплатыВРеглУчете_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "УдалитьПриказ", Comment = "", Synonym = "Удалить приказ")]
        public Документ.УдалитьПриемНаРаботуВОрганизацию УдалитьПриказ {get; set;}
        [Description1C8(Name = "ВидРасчетаБазы", Comment = "", Synonym = "Вид расчета базы")]
        public ПланВидовРасчета.УстарелоНачисления ВидРасчетаБазы {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "'Код дохода НДФЛ' или 'Вид расчета взносов наФОТ'", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "БазовыйПериодНачало", Comment = "", Synonym = "Базовый период")]
        public DateTime БазовыйПериодНачало {get; set;}
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
        [Description1C8(Name = "СтатьяВаловыхРасходов", Comment = "", Synonym = "Статья в/р")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяВаловыхРасходов {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "ВзносыОсновногоНачисления", Comment = "Взносы получать от основного начисления (больничный соцстрах)", Synonym = "Взносы основного начисления")]
        public bool ВзносыОсновногоНачисления {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
    [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
    [Table("UdalytOtrazhenyeZarplatyVRehlUchete_Uderzhanyia")]
    public class УдалитьОтражениеЗарплатыВРеглУчете_Удержания
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "УдалитьПриказ", Comment = "", Synonym = "Удалить приказ")]
        public Документ.УдалитьПриемНаРаботуВОрганизацию УдалитьПриказ {get; set;}
        [Description1C8(Name = "ВидРасчетаБазы", Comment = "", Synonym = "Вид расчета базы")]
        public ПланВидовРасчета.УстарелоУдержания ВидРасчетаБазы {get; set;}
        [Description1C8(Name = "БазовыйПериодНачало", Comment = "", Synonym = "Базовый период начало")]
        public DateTime БазовыйПериодНачало {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
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
        [Description1C8(Name = "СтатьяВаловыхРасходов", Comment = "", Synonym = "Статья в/р")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяВаловыхРасходов {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "'Код дохода НДФЛ' или 'Вид расчета взносов наФОТ'", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        [StringLength(10)]
        public string Сотрудник {get; set;}
    }
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("UdalytOtrazhenyeZarplatyVRehlUchete_Vznosy")]
    public class УдалитьОтражениеЗарплатыВРеглУчете_Взносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "УдалитьФизическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "УдалитьПриказ", Comment = "", Synonym = "Удалить приказ")]
        public Документ.УдалитьПриемНаРаботуВОрганизацию УдалитьПриказ {get; set;}
        [Description1C8(Name = "ВидРасчетаБазы", Comment = "", Synonym = "Вид расчета базы")]
        public ПланВидовРасчета.УДАЛИТЬВзносы ВидРасчетаБазы {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "БазовыйПериодНачало", Comment = "", Synonym = "Базовый период начало")]
        public DateTime БазовыйПериодНачало {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатТочный", Comment = "", Synonym = "Результат (точный)")]
        // Format 20.8
        public decimal РезультатТочный {get; set;}
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
        [Description1C8(Name = "СтатьяВаловыхРасходов", Comment = "", Synonym = "Статья в/р")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяВаловыхРасходов {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "'Код дохода НДФЛ' или 'Вид расчета взносов наФОТ'", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "", Synonym = "Результат")]
        // Format 14.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
    [Table("UdalytOtrazhenyeZarplatyVRehlUchete_VznosyFOT")]
    public class УдалитьОтражениеЗарплатыВРеглУчете_ВзносыФОТ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "УдалитьПриказ", Comment = "", Synonym = "Удалить приказ")]
        public Документ.УдалитьПриемНаРаботуВОрганизацию УдалитьПриказ {get; set;}
        [Description1C8(Name = "ВидРасчета", Comment = "", Synonym = "Вид расчета")]
        public ПланВидовРасчета.УДАЛИТЬВзносы ВидРасчета {get; set;}
        [Description1C8(Name = "ВидРасчетаБазы", Comment = "", Synonym = "Вид расчета (базы)")]
        public ПланВидовРасчета.УстарелоНачисления ВидРасчетаБазы {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "БазовыйПериодНачало", Comment = "", Synonym = "Базовый период начало")]
        public DateTime БазовыйПериодНачало {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 18.6
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатТочный", Comment = "", Synonym = "Результат (точный)")]
        // Format 20.8
        public decimal РезультатТочный {get; set;}
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
        [Description1C8(Name = "СтатьяВаловыхРасходов", Comment = "", Synonym = "Статья в/р")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяВаловыхРасходов {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "'Код дохода НДФЛ' или 'Вид расчета взносов наФОТ'", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "", Synonym = "Результат")]
        // Format 14.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("UdalytOtrazhenyeZarplatyVRehlUchete_NDFL")]
    public class УдалитьОтражениеЗарплатыВРеглУчете_НДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "УдалитьПриказ", Comment = "", Synonym = "Удалить приказ")]
        public Документ.УдалитьПриемНаРаботуВОрганизацию УдалитьПриказ {get; set;}
        [Description1C8(Name = "ВидРасчетаБазы", Comment = "", Synonym = "Вид расчета базы")]
        public ПланВидовРасчета.УстарелоНачисления ВидРасчетаБазы {get; set;}
        [Description1C8(Name = "ДоходНДФЛ", Comment = "'Код дохода НДФЛ' или 'Вид расчета взносов наФОТ'", Synonym = "Доход НДФЛ")]
        public Catalogs.УстарелоВидыДоходовНДФЛ ДоходНДФЛ {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "БазовыйПериодНачало", Comment = "", Synonym = "Базовый период начало")]
        public DateTime БазовыйПериодНачало {get; set;}
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
        [Description1C8(Name = "СтатьяВаловыхРасходов", Comment = "", Synonym = "Статья в/р")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяВаловыхРасходов {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
}
