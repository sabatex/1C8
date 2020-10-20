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
    [Table("UvolnenyeSpyskom")]
    [Description1C8(Name = "УвольнениеСписком", Comment = "", Synonym = "Увольнение списком")]
    public class УвольнениеСписком:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Период регистрации")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ДатаСобытия", Comment = "", Synonym = "Дата события")]
        public DateTime ДатаСобытия {get; set;}
        [Description1C8(Name = "Начислено", Comment = "", Synonym = "Начислено")]
        // Format 13.2
        public decimal Начислено {get; set;}
        [Description1C8(Name = "Удержано", Comment = "", Synonym = "Удержано")]
        // Format 13.2
        public decimal Удержано {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.УвольнениеСписком ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "ДокументРассчитан", Comment = "", Synonym = "Документ рассчитан")]
        public bool ДокументРассчитан {get; set;}
        [Description1C8(Name = "Рассчитал", Comment = "", Synonym = "Рассчитал")]
        public Catalogs.Пользователи Рассчитал {get; set;}
        [Description1C8(Name = "ПредставлениеПериода", Comment = "", Synonym = "Представление периода")]
        [StringLength(19)]
        public string ПредставлениеПериода {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "ГлавныйБухгалтер", Comment = "", Synonym = "Главный бухгалтер")]
        public Catalogs.ФизическиеЛица ГлавныйБухгалтер {get; set;}
        [Description1C8(Name = "Бухгалтер", Comment = "", Synonym = "Бухгалтер")]
        public Catalogs.ФизическиеЛица Бухгалтер {get; set;}
        [Description1C8(Name = "РаботникКадровойСлужбы", Comment = "", Synonym = "Работник кадровой службы")]
        public Catalogs.ФизическиеЛица РаботникКадровойСлужбы {get; set;}
        [Description1C8(Name = "ДолжностьРаботникаКадровойСлужбы", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРаботникаКадровойСлужбы {get; set;}
        [Description1C8(Name = "Исполнитель", Comment = "", Synonym = "Исполнитель")]
        public Catalogs.ФизическиеЛица Исполнитель {get; set;}
        [Description1C8(Name = "ДолжностьИсполнителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьИсполнителя {get; set;}
        [Description1C8(Name = "ВидДоговора", Comment = "", Synonym = "Вид договора")]
        public Enums.ВидыДоговоровССотрудниками ВидДоговора {get; set;}
        [Description1C8(Name = "ПорядокВыплаты", Comment = "", Synonym = "Порядок выплаты")]
        public Enums.ХарактерВыплатыЗарплаты ПорядокВыплаты {get; set;}
        [Description1C8(Name = "ПланируемаяДатаВыплаты", Comment = "", Synonym = "Планируемая дата выплаты")]
        public DateTime ПланируемаяДатаВыплаты {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<УвольнениеСписком_Сотрудники> УвольнениеСпискомСотрудники {get;set;}
        [Description1C8(Name = "ДанныеОбИндексации", Comment = "", Synonym = "Данные об индексации")]
        public List<УвольнениеСписком_ДанныеОбИндексации> УвольнениеСпискомДанныеОбИндексации {get;set;}
        [Description1C8(Name = "ДополнительныеОтпуска", Comment = "", Synonym = "Дополнительные отпуска")]
        public List<УвольнениеСписком_ДополнительныеОтпуска> УвольнениеСпискомДополнительныеОтпуска {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<УвольнениеСписком_Взносы> УвольнениеСпискомВзносы {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<УвольнениеСписком_НДФЛ> УвольнениеСпискомНДФЛ {get;set;}
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<УвольнениеСписком_Начисления> УвольнениеСпискомНачисления {get;set;}
        [Description1C8(Name = "НачисленияПерерасчет", Comment = "", Synonym = "Начисления перерасчет")]
        public List<УвольнениеСписком_НачисленияПерерасчет> УвольнениеСпискомНачисленияПерерасчет {get;set;}
        [Description1C8(Name = "ОтработанноеВремяДляСреднегоОбщий", Comment = "", Synonym = "Отработанное время для среднего общий")]
        public List<УвольнениеСписком_ОтработанноеВремяДляСреднегоОбщий> УвольнениеСпискомОтработанноеВремяДляСреднегоОбщий {get;set;}
        [Description1C8(Name = "ПогашениеЗаймов", Comment = "", Synonym = "Погашение займов")]
        public List<УвольнениеСписком_ПогашениеЗаймов> УвольнениеСпискомПогашениеЗаймов {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<УвольнениеСписком_Показатели> УвольнениеСпискомПоказатели {get;set;}
        [Description1C8(Name = "Пособия", Comment = "", Synonym = "Пособия")]
        public List<УвольнениеСписком_Пособия> УвольнениеСпискомПособия {get;set;}
        [Description1C8(Name = "ПособияПерерасчет", Comment = "", Synonym = "Пособия перерасчет")]
        public List<УвольнениеСписком_ПособияПерерасчет> УвольнениеСпискомПособияПерерасчет {get;set;}
        [Description1C8(Name = "СреднийЗаработокОбщий", Comment = "", Synonym = "Средний заработок общий")]
        public List<УвольнениеСписком_СреднийЗаработокОбщий> УвольнениеСпискомСреднийЗаработокОбщий {get;set;}
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        public List<УвольнениеСписком_Удержания> УвольнениеСпискомУдержания {get;set;}
        [Description1C8(Name = "РаспределениеРезультатовНачислений", Comment = "", Synonym = "Распределение результатов начислений")]
        public List<УвольнениеСписком_РаспределениеРезультатовНачислений> УвольнениеСпискомРаспределениеРезультатовНачислений {get;set;}
        [Description1C8(Name = "РаспределениеРезультатовУдержаний", Comment = "", Synonym = "Распределение результатов удержаний")]
        public List<УвольнениеСписком_РаспределениеРезультатовУдержаний> УвольнениеСпискомРаспределениеРезультатовУдержаний {get;set;}
        [Description1C8(Name = "ДенежноеСодержание", Comment = "", Synonym = "Денежное содержание")]
        public List<УвольнениеСписком_ДенежноеСодержание> УвольнениеСпискомДенежноеСодержание {get;set;}
        [Description1C8(Name = "ДенежноеСодержаниеФактическиеНачисления", Comment = "", Synonym = "Денежное содержание фактические начисления")]
        public List<УвольнениеСписком_ДенежноеСодержаниеФактическиеНачисления> УвольнениеСпискомДенежноеСодержаниеФактическиеНачисления {get;set;}
        [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
        public List<УвольнениеСписком_Льготы> УвольнениеСпискомЛьготы {get;set;}
        [Description1C8(Name = "КадровыйРезерв", Comment = "", Synonym = "Кадровый резерв")]
        public List<УвольнениеСписком_КадровыйРезерв> УвольнениеСпискомКадровыйРезерв {get;set;}
        [Description1C8(Name = "РаспределениеПоТерриториямУсловиямТруда", Comment = "", Synonym = "Распределение по территориям и условиям труда")]
        public List<УвольнениеСписком_РаспределениеПоТерриториямУсловиямТруда> УвольнениеСпискомРаспределениеПоТерриториямУсловиямТруда {get;set;}
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<УвольнениеСписком_ДополнительныеРеквизиты> УвольнениеСпискомДополнительныеРеквизиты {get;set;}
        [Description1C8(Name = "ОтработанноеВремяДляСреднегоДляВыходногоПособия", Comment = "", Synonym = "Отработанное время для среднего для выходного пособия")]
        public List<УвольнениеСписком_ОтработанноеВремяДляСреднегоДляВыходногоПособия> УвольнениеСпискомОтработанноеВремяДляСреднегоДляВыходногоПособия {get;set;}
        [Description1C8(Name = "СреднийЗаработокДляВыходногоПособия", Comment = "", Synonym = "Средний заработок для выходного пособия")]
        public List<УвольнениеСписком_СреднийЗаработокДляВыходногоПособия> УвольнениеСпискомСреднийЗаработокДляВыходногоПособия {get;set;}
        [Description1C8(Name = "ДанныеОбИндексацииДляВыходногоПособия", Comment = "", Synonym = "Данные об индексации для выходного пособия")]
        public List<УвольнениеСписком_ДанныеОбИндексацииДляВыходногоПособия> УвольнениеСпискомДанныеОбИндексацииДляВыходногоПособия {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
        public List<УвольнениеСписком_ВзносыФОТ> УвольнениеСпискомВзносыФОТ {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("UvolnenyeSpyskom_Sotrudnyky")]
    public class УвольнениеСписком_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаУвольнения", Comment = "", Synonym = "Дата увольнения")]
        public DateTime ДатаУвольнения {get; set;}
        [Description1C8(Name = "СтатьяКЗоТ", Comment = "", Synonym = "Статья КЗоТ")]
        public Catalogs.ОснованияУвольнения СтатьяКЗоТ {get; set;}
        [Description1C8(Name = "ОснованиеУвольнения", Comment = "", Synonym = "Основание увольнения")]
        public string ОснованиеУвольнения {get; set;}
        [Description1C8(Name = "ВыходноеПособие", Comment = "", Synonym = "Выходное пособие")]
        public ПланВидовРасчета.Начисления ВыходноеПособие {get; set;}
        [Description1C8(Name = "ДнейЧасовВыходногоПособия", Comment = "", Synonym = "Дней часов выходного пособия")]
        // Format 3.0
        public long ДнейЧасовВыходногоПособия {get; set;}
        [Description1C8(Name = "СуммированныйУчет", Comment = "", Synonym = "Суммированный учет рабочего времени")]
        public bool СуммированныйУчет {get; set;}
        [Description1C8(Name = "ДнейКомпенсацииУдержанияОтпуска", Comment = "", Synonym = "Дней компенсации (удержания) отпуска")]
        // Format 5.2
        public decimal ДнейКомпенсацииУдержанияОтпуска {get; set;}
        [Description1C8(Name = "ПризнакКомпенсацииУдержанияОтпуска", Comment = "", Synonym = "Признак компенсации (удержания) отпуска")]
        public Enums.КомпенсацияУдержаниеОтпускаПриУвольнении ПризнакКомпенсацииУдержанияОтпуска {get; set;}
        [Description1C8(Name = "ВидРасчетаКомпенсацииУдержанияОтпуска", Comment = "", Synonym = "Вид начисления компенсации (удержания)")]
        public ПланВидовРасчета.Начисления ВидРасчетаКомпенсацииУдержанияОтпуска {get; set;}
        [Description1C8(Name = "РабочийГодС", Comment = "", Synonym = "Рабочий год с")]
        public DateTime РабочийГодС {get; set;}
        [Description1C8(Name = "РабочийГодПо", Comment = "", Synonym = "Рабочий год по")]
        public DateTime РабочийГодПо {get; set;}
        [Description1C8(Name = "ПериодРасчетаСреднегоЗаработкаНачало", Comment = "Дата начала расчетного периода", Synonym = "Период расчета среднего заработка начало")]
        public DateTime ПериодРасчетаСреднегоЗаработкаНачало {get; set;}
        [Description1C8(Name = "ПериодРасчетаСреднегоЗаработкаОкончание", Comment = "Дата окончания расчетного периода", Synonym = "Период расчета среднего заработка окончание")]
        public DateTime ПериодРасчетаСреднегоЗаработкаОкончание {get; set;}
        [Description1C8(Name = "ФиксПериодРасчетаСреднегоЗаработка", Comment = "", Synonym = "Фикс период расчета среднего заработка")]
        public bool ФиксПериодРасчетаСреднегоЗаработка {get; set;}
        [Description1C8(Name = "СреднийЗаработок", Comment = "", Synonym = "Средний заработок по календарным дням")]
        // Format 15.2
        public decimal СреднийЗаработок {get; set;}
        [Description1C8(Name = "СреднийЗаработокПоРабочимДням", Comment = "", Synonym = "Средний заработок по рабочим дням")]
        // Format 15.2
        public decimal СреднийЗаработокПоРабочимДням {get; set;}
        [Description1C8(Name = "СреднийЗаработокВыходногоПособия", Comment = "", Synonym = "Средний заработок (для выходного пособия)")]
        // Format 15.2
        public decimal СреднийЗаработокВыходногоПособия {get; set;}
        [Description1C8(Name = "УдалитьПереноситьДанныеВДругойУчетСреднегоЗаработка", Comment = "", Synonym = "(не используется) Использовать данные общего среднего заработка для расчета пособий")]
        public bool УдалитьПереноситьДанныеВДругойУчетСреднегоЗаработка {get; set;}
        [Description1C8(Name = "РасчетДенежногоСодержания", Comment = "", Synonym = "Расчет денежного содержания")]
        public bool РасчетДенежногоСодержания {get; set;}
        [Description1C8(Name = "СохраняемоеДенежноеСодержание", Comment = "", Synonym = "Сохраняемое денежное содержание")]
        // Format 13.2
        public decimal СохраняемоеДенежноеСодержание {get; set;}
        [Description1C8(Name = "МесячноеДенежноеСодержание", Comment = "", Synonym = "Месячное денежное содержание")]
        // Format 13.2
        public decimal МесячноеДенежноеСодержание {get; set;}
        [Description1C8(Name = "КоличествоМесяцевВыплатыДенежногоСодержания", Comment = "", Synonym = "Количество месяцев выплаты денежного содержания")]
        // Format 2.0
        public long КоличествоМесяцевВыплатыДенежногоСодержания {get; set;}
        [Description1C8(Name = "ВидРасчетаМесячноеДенежноеСодержание", Comment = "", Synonym = "Вид расчета месячное денежное содержание")]
        public ПланВидовРасчета.Начисления ВидРасчетаМесячноеДенежноеСодержание {get; set;}
        [Description1C8(Name = "ДолжностьЗамещаласьМенее12Месяцев", Comment = "", Synonym = "Должность замещалась менее 12 месяцев")]
        public bool ДолжностьЗамещаласьМенее12Месяцев {get; set;}
        [Description1C8(Name = "Сверхурочно1_5", Comment = "", Synonym = "Сверхурочные часы х1,5")]
        // Format 7.2
        public decimal Сверхурочно1_5 {get; set;}
        [Description1C8(Name = "Сверхурочно2", Comment = "", Synonym = "х2")]
        // Format 7.2
        public decimal Сверхурочно2 {get; set;}
        [Description1C8(Name = "РучнаяКорректировкаСреднегоЗаработка", Comment = "", Synonym = "Ручная корректировка среднего заработка")]
        public bool РучнаяКорректировкаСреднегоЗаработка {get; set;}
        [Description1C8(Name = "РучнаяКорректировкаСреднегоЗаработкаВыходногоПособия", Comment = "", Synonym = "Ручная корректировка среднего заработка выходного пособия")]
        public bool РучнаяКорректировкаСреднегоЗаработкаВыходногоПособия {get; set;}
    }
    [Description1C8(Name = "ДанныеОбИндексации", Comment = "", Synonym = "Данные об индексации")]
    [Table("UvolnenyeSpyskom_DannyeObYndeksatsyy")]
    public class УвольнениеСписком_ДанныеОбИндексации
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "КоэффициентИндексации", Comment = "", Synonym = "Коэффициент индексации")]
        // Format 9.8
        public decimal КоэффициентИндексации {get; set;}
    }
    [Description1C8(Name = "ДополнительныеОтпуска", Comment = "", Synonym = "Дополнительные отпуска")]
    [Table("UvolnenyeSpyskom_DopolnytelnyeOtpuska")]
    public class УвольнениеСписком_ДополнительныеОтпуска
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ВидОтпуска", Comment = "", Synonym = "Вид ежегодного отпуска")]
        public Catalogs.ВидыОтпусков ВидОтпуска {get; set;}
        [Description1C8(Name = "ДнейКомпенсацииУдержания", Comment = "", Synonym = "Дней компенсации (удержания)")]
        // Format 5.2
        public decimal ДнейКомпенсацииУдержания {get; set;}
        [Description1C8(Name = "ВидРасчетаКомпенсацииУдержания", Comment = "", Synonym = "Вид начисления")]
        public ПланВидовРасчета.Начисления ВидРасчетаКомпенсацииУдержания {get; set;}
        [Description1C8(Name = "ПризнакКомпенсацииУдержания", Comment = "", Synonym = "Признак компенсации (удержания)")]
        public Enums.КомпенсацияУдержаниеОтпускаПриУвольнении ПризнакКомпенсацииУдержания {get; set;}
        [Description1C8(Name = "НачалоПериодаЗаКоторыйПредоставляетсяОтпуск", Comment = "", Synonym = "Начало периода, за который предоставляется отпуск")]
        public DateTime НачалоПериодаЗаКоторыйПредоставляетсяОтпуск {get; set;}
        [Description1C8(Name = "КонецПериодаЗаКоторыйПредоставляетсяОтпуск", Comment = "", Synonym = "Конец периода, за который предоставляется отпуск")]
        public DateTime КонецПериодаЗаКоторыйПредоставляетсяОтпуск {get; set;}
    }
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("UvolnenyeSpyskom_Vznosy")]
    public class УвольнениеСписком_Взносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаПолученияДохода", Comment = "", Synonym = "Дата получения дохода")]
        public DateTime ДатаПолученияДохода {get; set;}
        [Description1C8(Name = "ВидЕСВ", Comment = "", Synonym = "Вид ЕСВ")]
        public Enums.ВидыЕСВ ВидЕСВ {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "Период параметров налога начало", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "Период параметров налога окончания", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "База", Comment = "", Synonym = "База")]
        // Format 16.2
        public decimal База {get; set;}
        [Description1C8(Name = "БазаОтпускные", Comment = "", Synonym = "База (отпускные)")]
        // Format 16.2
        public decimal БазаОтпускные {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "База налога с учетом ограничений", Synonym = "База взноса")]
        // Format 16.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "БазаДоначисление", Comment = "", Synonym = "База (доначисление)")]
        // Format 16.2
        public decimal БазаДоначисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.6
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатДоначисление", Comment = "", Synonym = "Результат (доначисление)")]
        // Format 16.2
        public decimal РезультатДоначисление {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 15.3
        public decimal Предел {get; set;}
        [Description1C8(Name = "Ставка", Comment = "", Synonym = "Ставка")]
        // Format 10.4
        public decimal Ставка {get; set;}
        [Description1C8(Name = "МинимальнаяБаза", Comment = "", Synonym = "Минимальная база")]
        // Format 15.3
        public decimal МинимальнаяБаза {get; set;}
        [Description1C8(Name = "БазаВычет", Comment = "База (вычет)", Synonym = "База (вычет)")]
        // Format 16.2
        public decimal БазаВычет {get; set;}
        [Description1C8(Name = "КоэффициентСтавки", Comment = "", Synonym = "Коэффициент ставки")]
        // Format 10.4
        public decimal КоэффициентСтавки {get; set;}
        [Description1C8(Name = "ТипНачисления", Comment = "", Synonym = "Тип начисления")]
        // Format 2.0
        public long ТипНачисления {get; set;}
        [Description1C8(Name = "СтавкаПолная", Comment = "", Synonym = "Ставка полная")]
        // Format 10.4
        public decimal СтавкаПолная {get; set;}
        [Description1C8(Name = "РезультатПолная", Comment = "", Synonym = "Результат по полн. ставке")]
        // Format 16.2
        public decimal РезультатПолная {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("UvolnenyeSpyskom_NDFL")]
    public class УвольнениеСписком_НДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "НалоговыйПериод", Comment = "", Synonym = "Налоговый период")]
        public DateTime НалоговыйПериод {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ТерриторииВыполненияРабот Подразделение {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        // Format 15.2
        public decimal Налог {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиНДФЛ", Comment = "", Synonym = "Идентификатор строки НДФЛ")]
        // Format 7.0
        public long ИдентификаторСтрокиНДФЛ {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "Доход", Comment = "ВидСтавки", Synonym = "Доход")]
        // Format 15.2
        public decimal Доход {get; set;}
        [Description1C8(Name = "ВидСтавки", Comment = "", Synonym = "Вид ставки")]
        public Enums.ВидыСтавокНДФЛ ВидСтавки {get; set;}
        [Description1C8(Name = "УвеличеннаяСтавка", Comment = "", Synonym = "Увеличенная ставка")]
        public Enums.ВидыСтавокНДФЛ УвеличеннаяСтавка {get; set;}
        [Description1C8(Name = "КодДохода", Comment = "", Synonym = "Код дохода")]
        public Catalogs.ВидыДоходовНДФЛ КодДохода {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public Catalogs.ВидыЛьготПоНДФЛ Льгота {get; set;}
        [Description1C8(Name = "КоличествоЛьгот", Comment = "", Synonym = "Количество льгот")]
        // Format 5.2
        public decimal КоличествоЛьгот {get; set;}
        [Description1C8(Name = "СуммаЛьготы", Comment = "", Synonym = "Сумма льготы")]
        // Format 15.2
        public decimal СуммаЛьготы {get; set;}
        [Description1C8(Name = "ДоходПолный", Comment = "", Synonym = "Доход полный")]
        // Format 15.2
        public decimal ДоходПолный {get; set;}
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("UvolnenyeSpyskom_Nachyslenyia")]
    public class УвольнениеСписком_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "Отработано часов")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "НормаДней", Comment = "", Synonym = "Норма дней")]
        // Format 7.2
        public decimal НормаДней {get; set;}
        [Description1C8(Name = "НормаЧасов", Comment = "", Synonym = "Норма часов")]
        // Format 7.2
        public decimal НормаЧасов {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчетВремени", Comment = "", Synonym = "Фиксирован расчет времени")]
        public bool ФиксРасчетВремени {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "РасчетнаяБазаЗаЕдиницуНормыВремени", Comment = "Расчетная база на единицу нормы времени для расчета сторно-записей", Synonym = "Расчетная база за единицу нормы времени")]
        // Format 15.2
        public decimal РасчетнаяБазаЗаЕдиницуНормыВремени {get; set;}
        [Description1C8(Name = "КодВычета", Comment = "", Synonym = "Код вычета")]
        public Catalogs.ВидыЛьготПоНДФЛ КодВычета {get; set;}
        [Description1C8(Name = "СуммаВычета", Comment = "", Synonym = "Сумма вычета")]
        // Format 15.2
        public decimal СуммаВычета {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "ВидУчетаВремени", Comment = "", Synonym = "Вид учета времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидУчетаВремени {get; set;}
        [Description1C8(Name = "ВремяВЧасах", Comment = "", Synonym = "Время в часах")]
        public bool ВремяВЧасах {get; set;}
        [Description1C8(Name = "ГрафикРаботыНорма", Comment = "", Synonym = "График работы норма")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботыНорма {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ПериодРегистрацииВремени", Comment = "", Synonym = "Период регистрации времени")]
        public DateTime ПериодРегистрацииВремени {get; set;}
        [Description1C8(Name = "ОплаченоДней", Comment = "", Synonym = "Оплачено дней")]
        // Format 15.2
        public decimal ОплаченоДней {get; set;}
        [Description1C8(Name = "ОплаченоЧасов", Comment = "", Synonym = "Оплачено часов")]
        // Format 15.2
        public decimal ОплаченоЧасов {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
    }
    [Description1C8(Name = "НачисленияПерерасчет", Comment = "", Synonym = "Начисления перерасчет")]
    [Table("UvolnenyeSpyskom_NachyslenyiaPereraschet")]
    public class УвольнениеСписком_НачисленияПерерасчет
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "дн.")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "чс.")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "НормаДней", Comment = "", Synonym = "Норма дней")]
        // Format 7.2
        public decimal НормаДней {get; set;}
        [Description1C8(Name = "НормаЧасов", Comment = "", Synonym = "Норма часов")]
        // Format 7.2
        public decimal НормаЧасов {get; set;}
        [Description1C8(Name = "Сторно", Comment = "", Synonym = "Сторно")]
        public bool Сторно {get; set;}
        [Description1C8(Name = "СторнируемыйДокумент", Comment = "Документ, который зарегистрировал сторнируемое начисление", Synonym = "Сторнируемый документ")]
        public Документ.СторнированиеНачислений СторнируемыйДокумент {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "РасчетнаяБазаЗаЕдиницуНормыВремени", Comment = "Расчетная база на единицу нормы времени для расчета сторно-записей", Synonym = "Расчетная база за единицу нормы времени")]
        // Format 15.2
        public decimal РасчетнаяБазаЗаЕдиницуНормыВремени {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "КодВычета", Comment = "", Synonym = "Код вычета")]
        public Catalogs.ВидыЛьготПоНДФЛ КодВычета {get; set;}
        [Description1C8(Name = "СуммаВычета", Comment = "", Synonym = "Сумма вычета")]
        // Format 15.2
        public decimal СуммаВычета {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "ГрафикРаботыНорма", Comment = "", Synonym = "График работы норма")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботыНорма {get; set;}
        [Description1C8(Name = "ВидУчетаВремени", Comment = "", Synonym = "Вид учета времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидУчетаВремени {get; set;}
        [Description1C8(Name = "ВремяВЧасах", Comment = "", Synonym = "Время в часах")]
        public bool ВремяВЧасах {get; set;}
        [Description1C8(Name = "ПериодРегистрацииВремени", Comment = "", Synonym = "Период регистрации времени")]
        public DateTime ПериодРегистрацииВремени {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчетВремени", Comment = "", Synonym = "Фиксирован расчет времени")]
        public bool ФиксРасчетВремени {get; set;}
        [Description1C8(Name = "ФиксСторно", Comment = "", Synonym = "Не рассчитываемая сторно-запись")]
        public bool ФиксСторно {get; set;}
        [Description1C8(Name = "ОплаченоДней", Comment = "", Synonym = "Оплачено дней")]
        // Format 15.2
        public decimal ОплаченоДней {get; set;}
        [Description1C8(Name = "ОплаченоЧасов", Comment = "", Synonym = "Оплачено часов")]
        // Format 15.2
        public decimal ОплаченоЧасов {get; set;}
        [Description1C8(Name = "РезультатВТомЧислеЗаСчетФБ", Comment = "", Synonym = "В том числе")]
        // Format 15.2
        public decimal РезультатВТомЧислеЗаСчетФБ {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
    }
    [Description1C8(Name = "ОтработанноеВремяДляСреднегоОбщий", Comment = "", Synonym = "Отработанное время для среднего общий")]
    [Table("UvolnenyeSpyskom_OtrabotannoeVremiaDliaSrednehoObshchyi")]
    public class УвольнениеСписком_ОтработанноеВремяДляСреднегоОбщий
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ПорядокРасчета", Comment = "", Synonym = "Порядок расчета")]
        public Enums.ПорядокРасчетаСреднегоЗаработкаОбщий ПорядокРасчета {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноДнейПятидневка", Comment = "", Synonym = "Отработано дней по пятидневке")]
        // Format 7.2
        public decimal ОтработаноДнейПятидневка {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "Отработано часов")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "ОтработаноДнейШестидневка", Comment = "", Synonym = "Отработано дней по шестидневке")]
        // Format 7.2
        public decimal ОтработаноДнейШестидневка {get; set;}
        [Description1C8(Name = "ОтработаноДнейКалендарных", Comment = "", Synonym = "Отработано дней календарных")]
        // Format 7.2
        public decimal ОтработаноДнейКалендарных {get; set;}
        [Description1C8(Name = "НормаДнейПроизводственныйКалендарь", Comment = "", Synonym = "Норма дней по производственному календарю")]
        // Format 7.2
        public decimal НормаДнейПроизводственныйКалендарь {get; set;}
        [Description1C8(Name = "ОтработаноЧасовПятидневка", Comment = "", Synonym = "Отработано часов по пятидневке")]
        // Format 5.2
        public decimal ОтработаноЧасовПятидневка {get; set;}
        [Description1C8(Name = "НормаЧасовПроизводственныйКалендарь", Comment = "", Synonym = "Норма часов по производственному календарю")]
        // Format 5.2
        public decimal НормаЧасовПроизводственныйКалендарь {get; set;}
        [Description1C8(Name = "УдалитьКорректировка", Comment = "", Synonym = "(Не используется) Корректировка")]
        public bool УдалитьКорректировка {get; set;}
        [Description1C8(Name = "Источник", Comment = "", Synonym = "Источник")]
        public Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка Источник {get; set;}
        [Description1C8(Name = "НормаДнейПоГрафикуСотрудника", Comment = "", Synonym = "Норма дней по графику сотрудника")]
        // Format 5.2
        public decimal НормаДнейПоГрафикуСотрудника {get; set;}
        [Description1C8(Name = "НормаЧасовПоГрафикуСотрудника", Comment = "", Synonym = "Норма часов по графику сотрудника")]
        // Format 5.2
        public decimal НормаЧасовПоГрафикуСотрудника {get; set;}
        [Description1C8(Name = "СреднемесячноеКоличествоДней", Comment = "", Synonym = "Среднемесячное количество дней")]
        // Format 5.2
        public decimal СреднемесячноеКоличествоДней {get; set;}
    }
    [Description1C8(Name = "ПогашениеЗаймов", Comment = "", Synonym = "Погашение займов")]
    [Table("UvolnenyeSpyskom_PohashenyeZaimov")]
    public class УвольнениеСписком_ПогашениеЗаймов
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДоговорЗайма", Comment = "", Synonym = "Договор займа")]
        public Документ.ДоговорЗаймаСотруднику ДоговорЗайма {get; set;}
        [Description1C8(Name = "НачисленоПроцентов", Comment = "", Synonym = "Начислено процентов")]
        // Format 15.2
        public decimal НачисленоПроцентов {get; set;}
        [Description1C8(Name = "ПогашениеПроцентов", Comment = "", Synonym = "Погашение процентов")]
        // Format 15.2
        public decimal ПогашениеПроцентов {get; set;}
        [Description1C8(Name = "ПогашениеЗайма", Comment = "", Synonym = "Погашение займа")]
        // Format 15.2
        public decimal ПогашениеЗайма {get; set;}
        [Description1C8(Name = "МатериальнаяВыгода", Comment = "", Synonym = "Материальная выгода")]
        // Format 15.2
        public decimal МатериальнаяВыгода {get; set;}
        [Description1C8(Name = "НалогНаМатериальнуюВыгоду", Comment = "", Synonym = "Налог на материальную выгоду")]
        // Format 13.0
        public long НалогНаМатериальнуюВыгоду {get; set;}
        [Description1C8(Name = "СтавкаНалогообложенияМатвыгоды", Comment = "", Synonym = "Ставка налогообложения матвыгоды")]
        [StringLength(10)]
        public string СтавкаНалогообложенияМатвыгоды {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 7.0
        public long ИдентификаторСтроки {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("UvolnenyeSpyskom_Pokazately")]
    public class УвольнениеСписком_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
    }
    [Description1C8(Name = "Пособия", Comment = "", Synonym = "Пособия")]
    [Table("UvolnenyeSpyskom_Posobyia")]
    public class УвольнениеСписком_Пособия
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ВидЗанятости", Comment = "", Synonym = "Вид занятости")]
        public Enums.ВидыЗанятости ВидЗанятости {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатВТомЧислеЗаСчетФБ", Comment = "", Synonym = "В том числе")]
        // Format 15.2
        public decimal РезультатВТомЧислеЗаСчетФБ {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчетВремени", Comment = "", Synonym = "Фиксирован расчет времени")]
        public bool ФиксРасчетВремени {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "РасчетнаяБазаЗаЕдиницуНормыВремени", Comment = "Расчетная база на единицу нормы времени для расчета сторно-записей", Synonym = "Расчетная база за единицу нормы времени")]
        // Format 15.2
        public decimal РасчетнаяБазаЗаЕдиницуНормыВремени {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ОплаченоДней", Comment = "", Synonym = "Оплачено дней")]
        // Format 7.2
        public decimal ОплаченоДней {get; set;}
        [Description1C8(Name = "ОплаченоЧасов", Comment = "", Synonym = "Оплачено часов")]
        // Format 7.2
        public decimal ОплаченоЧасов {get; set;}
        [Description1C8(Name = "СуммаВсегоПоУходуЗаПервымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за первым ребенком, всего")]
        // Format 15.2
        public decimal СуммаВсегоПоУходуЗаПервымРебенком {get; set;}
        [Description1C8(Name = "СуммаСверхНормПоУходуЗаПервымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за первым ребенком, сверх норм")]
        // Format 15.2
        public decimal СуммаСверхНормПоУходуЗаПервымРебенком {get; set;}
        [Description1C8(Name = "СуммаВсегоПоУходуЗаВторымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за вторым ребенком, всего")]
        // Format 15.2
        public decimal СуммаВсегоПоУходуЗаВторымРебенком {get; set;}
        [Description1C8(Name = "СуммаСверхНормПоУходуЗаВторымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за вторым ребенком, сверх норм")]
        // Format 15.2
        public decimal СуммаСверхНормПоУходуЗаВторымРебенком {get; set;}
        [Description1C8(Name = "ЛьготаПоПособию", Comment = "", Synonym = "Льгота по пособию")]
        public Enums.ОснованияЛьготПоПособию ЛьготаПоПособию {get; set;}
        [Description1C8(Name = "СтраховойСлучай", Comment = "", Synonym = "Страховой случай")]
        public Документ.ОтпускПоУходуЗаРебенком СтраховойСлучай {get; set;}
        [Description1C8(Name = "КоличествоДетей", Comment = "", Synonym = "Количество детей")]
        // Format 2.0
        public long КоличествоДетей {get; set;}
        [Description1C8(Name = "КоличествоПервыхДетей", Comment = "", Synonym = "Количество первых детей")]
        // Format 1.0
        public long КоличествоПервыхДетей {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
    }
    [Description1C8(Name = "ПособияПерерасчет", Comment = "", Synonym = "Пособия перерасчет")]
    [Table("UvolnenyeSpyskom_PosobyiaPereraschet")]
    public class УвольнениеСписком_ПособияПерерасчет
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ВидЗанятости", Comment = "", Synonym = "Вид занятости")]
        public Enums.ВидыЗанятости ВидЗанятости {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатВТомЧислеЗаСчетФБ", Comment = "", Synonym = "В том числе")]
        // Format 15.2
        public decimal РезультатВТомЧислеЗаСчетФБ {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчетВремени", Comment = "", Synonym = "Фиксирован расчет времени")]
        public bool ФиксРасчетВремени {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "ФиксСторно", Comment = "", Synonym = "Не рассчитываемая сторно-запись")]
        public bool ФиксСторно {get; set;}
        [Description1C8(Name = "РасчетнаяБазаЗаЕдиницуНормыВремени", Comment = "Расчетная база на единицу нормы времени для расчета сторно-записей", Synonym = "Расчетная база за единицу нормы времени")]
        // Format 15.2
        public decimal РасчетнаяБазаЗаЕдиницуНормыВремени {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ОплаченоДней", Comment = "", Synonym = "Оплачено дней")]
        // Format 7.2
        public decimal ОплаченоДней {get; set;}
        [Description1C8(Name = "ОплаченоЧасов", Comment = "", Synonym = "Оплачено часов")]
        // Format 7.2
        public decimal ОплаченоЧасов {get; set;}
        [Description1C8(Name = "СуммаВсегоПоУходуЗаПервымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за первым ребенком, всего")]
        // Format 15.2
        public decimal СуммаВсегоПоУходуЗаПервымРебенком {get; set;}
        [Description1C8(Name = "СуммаСверхНормПоУходуЗаПервымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за первым ребенком, сверх норм")]
        // Format 15.2
        public decimal СуммаСверхНормПоУходуЗаПервымРебенком {get; set;}
        [Description1C8(Name = "СуммаВсегоПоУходуЗаВторымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за вторым ребенком, всего")]
        // Format 15.2
        public decimal СуммаВсегоПоУходуЗаВторымРебенком {get; set;}
        [Description1C8(Name = "СуммаСверхНормПоУходуЗаВторымРебенком", Comment = "", Synonym = "Сумма пособия по уходу за вторым ребенком, сверх норм")]
        // Format 15.2
        public decimal СуммаСверхНормПоУходуЗаВторымРебенком {get; set;}
        [Description1C8(Name = "Сторно", Comment = "", Synonym = "Сторно")]
        public bool Сторно {get; set;}
        [Description1C8(Name = "СторнируемыйДокумент", Comment = "Документ, который зарегистрировал сторнируемое начисление", Synonym = "Сторнируемый документ")]
        public Документ.СторнированиеНачислений СторнируемыйДокумент {get; set;}
        [Description1C8(Name = "ЛьготаПоПособию", Comment = "", Synonym = "Льгота по пособию")]
        public Enums.ОснованияЛьготПоПособию ЛьготаПоПособию {get; set;}
        [Description1C8(Name = "СтраховойСлучай", Comment = "", Synonym = "Страховой случай")]
        public Документ.ОтпускПоУходуЗаРебенком СтраховойСлучай {get; set;}
        [Description1C8(Name = "КоличествоДетей", Comment = "", Synonym = "Количество детей")]
        // Format 2.0
        public long КоличествоДетей {get; set;}
        [Description1C8(Name = "КоличествоПервыхДетей", Comment = "", Synonym = "Количество первых детей")]
        // Format 1.0
        public long КоличествоПервыхДетей {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
    }
    [Description1C8(Name = "СреднийЗаработокОбщий", Comment = "", Synonym = "Средний заработок общий")]
    [Table("UvolnenyeSpyskom_SrednyiZarabotokObshchyi")]
    public class УвольнениеСписком_СреднийЗаработокОбщий
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ПорядокРасчета", Comment = "", Synonym = "Порядок расчета")]
        public Enums.ПорядокРасчетаСреднегоЗаработкаОбщий ПорядокРасчета {get; set;}
        [Description1C8(Name = "СоставнаяЧасть", Comment = "", Synonym = "Составная часть")]
        public Enums.УчетНачисленийВСреднемЗаработкеОбщий СоставнаяЧасть {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "Индексируется", Comment = "", Synonym = "Индексируется")]
        public bool Индексируется {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "УдалитьКорректировка", Comment = "", Synonym = "(Не используется) Корректировка")]
        public bool УдалитьКорректировка {get; set;}
        [Description1C8(Name = "Год", Comment = "", Synonym = "Год")]
        // Format 4.0
        public long Год {get; set;}
        [Description1C8(Name = "ДатаНачалаБазовогоПериода", Comment = "", Synonym = "Дата начала базового периода")]
        public DateTime ДатаНачалаБазовогоПериода {get; set;}
        [Description1C8(Name = "КоличествоМесяцев", Comment = "", Synonym = "Количество месяцев")]
        // Format 3.0
        public long КоличествоМесяцев {get; set;}
        [Description1C8(Name = "Источник", Comment = "", Synonym = "Источник")]
        public Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка Источник {get; set;}
    }
    [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
    [Table("UvolnenyeSpyskom_Uderzhanyia")]
    public class УвольнениеСписком_Удержания
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Удержание", Comment = "", Synonym = "Удержание")]
        public ПланВидовРасчета.Удержания Удержание {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.УдержаниеВСчетРасчетовПоПрочимОперациям ДокументОснование {get; set;}
        [Description1C8(Name = "Получатель", Comment = "", Synonym = "Получатель")]
        public Catalogs.Контрагенты Получатель {get; set;}
        [Description1C8(Name = "ПлатежныйАгент", Comment = "", Synonym = "Платежный агент")]
        public Catalogs.Контрагенты ПлатежныйАгент {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
    }
    [Description1C8(Name = "РаспределениеРезультатовНачислений", Comment = "", Synonym = "Распределение результатов начислений")]
    [Table("UvolnenyeSpyskom_RaspredelenyeRezultatovNachyslenyi")]
    public class УвольнениеСписком_РаспределениеРезультатовНачислений
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 7.0
        public long ИдентификаторСтроки {get; set;}
        [Description1C8(Name = "Территория", Comment = "", Synonym = "Территория")]
        public Catalogs.ТерриторииВыполненияРабот Территория {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "СтатьяРасходов", Comment = "", Synonym = "Статья расходов")]
        public Catalogs.СтатьиРасходовЗарплата СтатьяРасходов {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "ОблагаетсяЕНВД", Comment = "", Synonym = "Облагается ЕНВД")]
        public bool ОблагаетсяЕНВД {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
    }
    [Description1C8(Name = "РаспределениеРезультатовУдержаний", Comment = "", Synonym = "Распределение результатов удержаний")]
    [Table("UvolnenyeSpyskom_RaspredelenyeRezultatovUderzhanyi")]
    public class УвольнениеСписком_РаспределениеРезультатовУдержаний
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 7.0
        public long ИдентификаторСтроки {get; set;}
        [Description1C8(Name = "ВидУдержания", Comment = "", Synonym = "Вид удержания")]
        public Enums.ВидыОсобыхНачисленийИУдержаний ВидУдержания {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "СтатьяРасходов", Comment = "", Synonym = "Статья расходов")]
        public Catalogs.СтатьиРасходовЗарплата СтатьяРасходов {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
    }
    [Description1C8(Name = "ДенежноеСодержание", Comment = "", Synonym = "Денежное содержание")]
    [Table("UvolnenyeSpyskom_DenezhnoeSoderzhanye")]
    public class УвольнениеСписком_ДенежноеСодержание
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "СоставнаяЧасть", Comment = "", Synonym = "Составная часть")]
        public Enums.УчетНачисленийВСреднемЗаработкеОбщий СоставнаяЧасть {get; set;}
        [Description1C8(Name = "НазначениеРасчета", Comment = "", Synonym = "Назначение расчета")]
        [StringLength(10)]
        public string НазначениеРасчета {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 15.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фикс расчет")]
        public bool ФиксРасчет {get; set;}
    }
    [Description1C8(Name = "ДенежноеСодержаниеФактическиеНачисления", Comment = "", Synonym = "Денежное содержание фактические начисления")]
    [Table("UvolnenyeSpyskom_DenezhnoeSoderzhanyeFaktycheskyeNachyslenyia")]
    public class УвольнениеСписком_ДенежноеСодержаниеФактическиеНачисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "НазначениеРасчета", Comment = "", Synonym = "Назначение расчета")]
        [StringLength(10)]
        public string НазначениеРасчета {get; set;}
        [Description1C8(Name = "СоставнаяЧасть", Comment = "", Synonym = "Составная часть")]
        [StringLength(10)]
        public string СоставнаяЧасть {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "Корректировка", Comment = "", Synonym = "Корректировка")]
        public bool Корректировка {get; set;}
    }
    [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
    [Table("UvolnenyeSpyskom_Lhoty")]
    public class УвольнениеСписком_Льготы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "дн.")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "чс.")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "НормаДней", Comment = "", Synonym = "Норма дн.")]
        // Format 7.2
        public decimal НормаДней {get; set;}
        [Description1C8(Name = "НормаЧасов", Comment = "", Synonym = "Норма чс.")]
        // Format 7.2
        public decimal НормаЧасов {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчетВремени", Comment = "", Synonym = "Фиксирован расчет времени")]
        public bool ФиксРасчетВремени {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "РасчетнаяБазаЗаЕдиницуНормыВремени", Comment = "Расчетная база на единицу нормы времени для расчета сторно-записей", Synonym = "Расчетная база за единицу нормы времени")]
        // Format 15.2
        public decimal РасчетнаяБазаЗаЕдиницуНормыВремени {get; set;}
        [Description1C8(Name = "КодВычета", Comment = "", Synonym = "Код вычета")]
        public Catalogs.ВидыЛьготПоНДФЛ КодВычета {get; set;}
        [Description1C8(Name = "СуммаВычета", Comment = "", Synonym = "Сумма вычета")]
        // Format 15.2
        public decimal СуммаВычета {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "ВидУчетаВремени", Comment = "", Synonym = "Вид учета времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидУчетаВремени {get; set;}
        [Description1C8(Name = "ВремяВЧасах", Comment = "", Synonym = "Время в часах")]
        public bool ВремяВЧасах {get; set;}
        [Description1C8(Name = "ГрафикРаботыНорма", Comment = "", Synonym = "График работы норма")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботыНорма {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ПериодРегистрацииВремени", Comment = "", Synonym = "Период регистрации времени")]
        public DateTime ПериодРегистрацииВремени {get; set;}
        [Description1C8(Name = "ОплаченоДней", Comment = "", Synonym = "Оплачено дней")]
        // Format 7.2
        public decimal ОплаченоДней {get; set;}
        [Description1C8(Name = "ОплаченоЧасов", Comment = "", Synonym = "Оплачено часов")]
        // Format 7.2
        public decimal ОплаченоЧасов {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "ПериодДействия", Comment = "", Synonym = "Период действия")]
        public DateTime ПериодДействия {get; set;}
    }
    [Description1C8(Name = "КадровыйРезерв", Comment = "", Synonym = "Кадровый резерв")]
    [Table("UvolnenyeSpyskom_KadrovyiRezerv")]
    public class УвольнениеСписком_КадровыйРезерв
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ПозицияРезерва", Comment = "", Synonym = "Позиция резерва")]
        [StringLength(10)]
        public string ПозицияРезерва {get; set;}
        [Description1C8(Name = "ВидРезерва", Comment = "", Synonym = "Вид резерва")]
        [StringLength(10)]
        public string ВидРезерва {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        [StringLength(10)]
        public string Действие {get; set;}
        [Description1C8(Name = "Статус", Comment = "", Synonym = "Статус")]
        public Enums.СостоянияСогласования Статус {get; set;}
    }
    [Description1C8(Name = "РаспределениеПоТерриториямУсловиямТруда", Comment = "", Synonym = "Распределение по территориям и условиям труда")]
    [Table("UvolnenyeSpyskom_RaspredelenyePoTerrytoryiamUslovyiamTruda")]
    public class УвольнениеСписком_РаспределениеПоТерриториямУсловиямТруда
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 7.0
        public long ИдентификаторСтроки {get; set;}
        [Description1C8(Name = "Территория", Comment = "", Synonym = "Территория")]
        public Catalogs.ТерриторииВыполненияРабот Территория {get; set;}
        [Description1C8(Name = "УсловияТруда", Comment = "", Synonym = "Условия труда")]
        public Catalogs.УсловияТруда УсловияТруда {get; set;}
        [Description1C8(Name = "ДоляРаспределения", Comment = "", Synonym = "Доля распределения")]
        // Format 15.4
        public decimal ДоляРаспределения {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 15.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиПоказателей", Comment = "", Synonym = "Идентификатор строки показателей")]
        // Format 7.0
        public long ИдентификаторСтрокиПоказателей {get; set;}
    }
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("UvolnenyeSpyskom_DopolnytelnyeRekvyzyty")]
    public class УвольнениеСписком_ДополнительныеРеквизиты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Свойство", Comment = "", Synonym = "Свойство")]
        public ПланВидовХарактеристик.ДополнительныеРеквизитыИСведения Свойство {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public Catalogs.Склады Значение {get; set;}
        [Description1C8(Name = "ТекстоваяСтрока", Comment = "", Synonym = "Текстовая строка")]
        public string ТекстоваяСтрока {get; set;}
    }
    [Description1C8(Name = "ОтработанноеВремяДляСреднегоДляВыходногоПособия", Comment = "", Synonym = "Отработанное время для среднего для выходного пособия")]
    [Table("UvolnenyeSpyskom_OtrabotannoeVremiaDliaSrednehoDliaVykhodnohoPosobyia")]
    public class УвольнениеСписком_ОтработанноеВремяДляСреднегоДляВыходногоПособия
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ПорядокРасчета", Comment = "", Synonym = "Порядок расчета")]
        public Enums.ПорядокРасчетаСреднегоЗаработкаОбщий ПорядокРасчета {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "Отработано часов")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "ОтработаноДнейКалендарных", Comment = "", Synonym = "Отработано дней календарных")]
        // Format 7.2
        public decimal ОтработаноДнейКалендарных {get; set;}
        [Description1C8(Name = "НормаДнейПроизводственныйКалендарь", Comment = "", Synonym = "Норма дней по производственному календарю")]
        // Format 7.2
        public decimal НормаДнейПроизводственныйКалендарь {get; set;}
        [Description1C8(Name = "НормаЧасовПроизводственныйКалендарь", Comment = "", Synonym = "Норма часов по производственному календарю")]
        // Format 5.2
        public decimal НормаЧасовПроизводственныйКалендарь {get; set;}
        [Description1C8(Name = "Источник", Comment = "", Synonym = "Источник")]
        public Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка Источник {get; set;}
        [Description1C8(Name = "НормаДнейПоГрафикуСотрудника", Comment = "", Synonym = "Норма дней по графику сотрудника")]
        // Format 5.2
        public decimal НормаДнейПоГрафикуСотрудника {get; set;}
        [Description1C8(Name = "НормаЧасовПоГрафикуСотрудника", Comment = "", Synonym = "Норма часов по графику сотрудника")]
        // Format 5.2
        public decimal НормаЧасовПоГрафикуСотрудника {get; set;}
        [Description1C8(Name = "СреднемесячноеКоличествоДней", Comment = "", Synonym = "Среднемесячное количество дней")]
        // Format 5.2
        public decimal СреднемесячноеКоличествоДней {get; set;}
    }
    [Description1C8(Name = "СреднийЗаработокДляВыходногоПособия", Comment = "", Synonym = "Средний заработок для выходного пособия")]
    [Table("UvolnenyeSpyskom_SrednyiZarabotokDliaVykhodnohoPosobyia")]
    public class УвольнениеСписком_СреднийЗаработокДляВыходногоПособия
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ПорядокРасчета", Comment = "", Synonym = "Порядок расчета")]
        public Enums.ПорядокРасчетаСреднегоЗаработкаОбщий ПорядокРасчета {get; set;}
        [Description1C8(Name = "СоставнаяЧасть", Comment = "", Synonym = "Составная часть")]
        public Enums.УчетНачисленийВСреднемЗаработкеОбщий СоставнаяЧасть {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "Индексируется", Comment = "", Synonym = "Индексируется")]
        public bool Индексируется {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "УдалитьКорректировка", Comment = "", Synonym = "(Не используется) Корректировка")]
        public bool УдалитьКорректировка {get; set;}
        [Description1C8(Name = "Год", Comment = "", Synonym = "Год")]
        // Format 4.0
        public long Год {get; set;}
        [Description1C8(Name = "ДатаНачалаБазовогоПериода", Comment = "", Synonym = "Дата начала базового периода")]
        public DateTime ДатаНачалаБазовогоПериода {get; set;}
        [Description1C8(Name = "КоличествоМесяцев", Comment = "", Synonym = "Количество месяцев")]
        // Format 3.0
        public long КоличествоМесяцев {get; set;}
        [Description1C8(Name = "Источник", Comment = "", Synonym = "Источник")]
        public Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка Источник {get; set;}
    }
    [Description1C8(Name = "ДанныеОбИндексацииДляВыходногоПособия", Comment = "", Synonym = "Данные об индексации для выходного пособия")]
    [Table("UvolnenyeSpyskom_DannyeObYndeksatsyyDliaVykhodnohoPosobyia")]
    public class УвольнениеСписком_ДанныеОбИндексацииДляВыходногоПособия
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "КоэффициентИндексации", Comment = "", Synonym = "Коэффициент индексации")]
        // Format 9.8
        public decimal КоэффициентИндексации {get; set;}
    }
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
    [Table("UvolnenyeSpyskom_VznosyFOT")]
    public class УвольнениеСписком_ВзносыФОТ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаПолученияДохода", Comment = "", Synonym = "Дата получения дохода")]
        public DateTime ДатаПолученияДохода {get; set;}
        [Description1C8(Name = "ВидЕСВ", Comment = "", Synonym = "Вид ЕСВ")]
        public Enums.ВидыЕСВ ВидЕСВ {get; set;}
        [Description1C8(Name = "КатегорияЕСВ", Comment = "", Synonym = "Категория ЕСВ")]
        public Catalogs.КатегорииЗастрахованныхЛицЕСВ КатегорияЕСВ {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "Период параметров налога начало", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "Период параметров налога окончания", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "База", Comment = "", Synonym = "База")]
        // Format 16.2
        public decimal База {get; set;}
        [Description1C8(Name = "БазаОтпускные", Comment = "", Synonym = "База (отпускные)")]
        // Format 16.2
        public decimal БазаОтпускные {get; set;}
        [Description1C8(Name = "БазаВзноса", Comment = "База налога с учетом ограничений", Synonym = "База взноса")]
        // Format 16.2
        public decimal БазаВзноса {get; set;}
        [Description1C8(Name = "БазаДоначисление", Comment = "", Synonym = "База (доначисление)")]
        // Format 16.2
        public decimal БазаДоначисление {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 16.6
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатДоначисление", Comment = "", Synonym = "Результат (доначисление)")]
        // Format 16.2
        public decimal РезультатДоначисление {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 15.3
        public decimal Предел {get; set;}
        [Description1C8(Name = "Ставка", Comment = "", Synonym = "Ставка")]
        // Format 10.4
        public decimal Ставка {get; set;}
        [Description1C8(Name = "МинимальнаяБаза", Comment = "", Synonym = "Минимальная база")]
        // Format 15.3
        public decimal МинимальнаяБаза {get; set;}
        [Description1C8(Name = "БазаВычет", Comment = "База (вычет)", Synonym = "База (вычет)")]
        // Format 16.2
        public decimal БазаВычет {get; set;}
        [Description1C8(Name = "КоэффициентСтавки", Comment = "", Synonym = "Коэффициент ставки")]
        // Format 10.4
        public decimal КоэффициентСтавки {get; set;}
        [Description1C8(Name = "ТипНачисления", Comment = "", Synonym = "Тип начисления")]
        // Format 2.0
        public long ТипНачисления {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "СтавкаПолная", Comment = "", Synonym = "Ставка полная")]
        // Format 10.4
        public decimal СтавкаПолная {get; set;}
        [Description1C8(Name = "РезультатПолная", Comment = "", Synonym = "Результат по полн. ставке")]
        // Format 16.2
        public decimal РезультатПолная {get; set;}
    }
}
