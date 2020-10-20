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
    [Table("ZaiavkaNaOtkrytyeLytsevykhSchetovSotrudnykov")]
    [Description1C8(Name = "ЗаявкаНаОткрытиеЛицевыхСчетовСотрудников", Comment = "", Synonym = "Заявка на открытие лицевых счетов")]
    public class ЗаявкаНаОткрытиеЛицевыхСчетовСотрудников:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ЗарплатныйПроект", Comment = "", Synonym = "Зарплатный проект")]
        public Catalogs.ЗарплатныеПроекты ЗарплатныйПроект {get; set;}
        [Description1C8(Name = "НомерРеестра", Comment = "", Synonym = "Номер реестра")]
        // Format 10.0
        public long НомерРеестра {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
        public List<ЗаявкаНаОткрытиеЛицевыхСчетовСотрудников_Сотрудники> ЗаявкаНаОткрытиеЛицевыхСчетовСотрудниковСотрудники {get;set;}
        [Description1C8(Name = "ФиксацияИзменений", Comment = "", Synonym = "Фиксация изменений")]
        public List<ЗаявкаНаОткрытиеЛицевыхСчетовСотрудников_ФиксацияИзменений> ЗаявкаНаОткрытиеЛицевыхСчетовСотрудниковФиксацияИзменений {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Сотрудники", Comment = "", Synonym = "Сотрудники")]
    [Table("ZaiavkaNaOtkrytyeLytsevykhSchetovSotrudnykov_Sotrudnyky")]
    public class ЗаявкаНаОткрытиеЛицевыхСчетовСотрудников_Сотрудники
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
        [Description1C8(Name = "ЭмбоссированныйТекст1", Comment = "", Synonym = "Имя (лат.)")]
        [StringLength(19)]
        public string ЭмбоссированныйТекст1 {get; set;}
        [Description1C8(Name = "ЭмбоссированныйТекст2", Comment = "", Synonym = "Фамилия (лат.)")]
        [StringLength(19)]
        public string ЭмбоссированныйТекст2 {get; set;}
        [Description1C8(Name = "ЭмбоссированныйТекст3", Comment = "", Synonym = "Титул (лат.)")]
        [StringLength(19)]
        public string ЭмбоссированныйТекст3 {get; set;}
        [Description1C8(Name = "СистемаРасчетовПоБанковскимКартам", Comment = "", Synonym = "Система расчетов по банковским картам")]
        public string СистемаРасчетовПоБанковскимКартам {get; set;}
        [Description1C8(Name = "СуммаПервоначальногоПополнения", Comment = "", Synonym = "Сумма пополнения")]
        // Format 15.2
        public decimal СуммаПервоначальногоПополнения {get; set;}
        [Description1C8(Name = "ЯвляетсяЗарплатнойКартой", Comment = "", Synonym = "Является зарплатной картой")]
        public bool ЯвляетсяЗарплатнойКартой {get; set;}
        [Description1C8(Name = "ОплатаЗарплатнойКарты", Comment = "", Synonym = "Оплата зарплатной карты")]
        public Enums.ВидыОплатыЗарплатнойКарты ОплатаЗарплатнойКарты {get; set;}
        [Description1C8(Name = "ЯвляетсяСотрудникомБанка", Comment = "", Synonym = "Является сотрудником банка")]
        public bool ЯвляетсяСотрудникомБанка {get; set;}
        [Description1C8(Name = "ИспользуетсяОвердрафт", Comment = "", Synonym = "Используется овердрафт")]
        public bool ИспользуетсяОвердрафт {get; set;}
        [Description1C8(Name = "КатегорияСотрудника", Comment = "", Synonym = "Категория сотрудника")]
        public Enums.КатегорииСотрудниковОбменаСБанками КатегорияСотрудника {get; set;}
        [Description1C8(Name = "ЯвляетсяУчастникомБонуснойПрограммы", Comment = "", Synonym = "Является участником бонусной программы")]
        public bool ЯвляетсяУчастникомБонуснойПрограммы {get; set;}
        [Description1C8(Name = "БонуснаяПрограмма", Comment = "", Synonym = "Бонусная программа")]
        public Enums.БонусныеПрограммыБанков БонуснаяПрограмма {get; set;}
        [Description1C8(Name = "НомерУчастникаБонуснойПрограммы", Comment = "", Synonym = "Номер участника бонусной программы")]
        [StringLength(10)]
        public string НомерУчастникаБонуснойПрограммы {get; set;}
        [Description1C8(Name = "ТарифСледующийГод", Comment = "Тариф за обслуживание ПК на следующий год", Synonym = "Тариф за следующий год")]
        // Format 15.2
        public decimal ТарифСледующийГод {get; set;}
        [Description1C8(Name = "ТарифТекущийГод", Comment = "Тариф за обслуживание ПК на текущий год", Synonym = "Тариф за текущий год")]
        // Format 15.2
        public decimal ТарифТекущийГод {get; set;}
        [Description1C8(Name = "ИспользованиеДоставкиКорреспонденции", Comment = "", Synonym = "Доставка корреспонденции")]
        public bool ИспользованиеДоставкиКорреспонденции {get; set;}
        [Description1C8(Name = "СпособРассылкиОтчета", Comment = "", Synonym = "Способ рассылки отчета")]
        public Enums.СпособыДоставкиКорреспонденцииБанка СпособРассылкиОтчета {get; set;}
        [Description1C8(Name = "АдресЭлектроннойПочты", Comment = "", Synonym = "Адрес электронной почты")]
        [StringLength(64)]
        public string АдресЭлектроннойПочты {get; set;}
        [Description1C8(Name = "СчетДебета", Comment = "", Synonym = "Счет дебета")]
        [StringLength(20)]
        public string СчетДебета {get; set;}
        [Description1C8(Name = "НомерМобильногоТелефона", Comment = "", Synonym = "Мобильный телефон")]
        public string НомерМобильногоТелефона {get; set;}
        [Description1C8(Name = "НомерМобильногоТелефонаПредставление", Comment = "", Synonym = "Мобильный телефон")]
        public string НомерМобильногоТелефонаПредставление {get; set;}
        [Description1C8(Name = "ОператорСвязи", Comment = "", Synonym = "Код оператора")]
        [StringLength(3)]
        public string ОператорСвязи {get; set;}
        [Description1C8(Name = "ИспользованиеМобильногоБанка", Comment = "", Synonym = "Использование мобильного банка")]
        public bool ИспользованиеМобильногоБанка {get; set;}
        [Description1C8(Name = "ТарифМобильногоБанка", Comment = "", Synonym = "Тариф мобильного банка")]
        public Enums.ТарифыМобильногоБанка ТарифМобильногоБанка {get; set;}
        [Description1C8(Name = "РазрешитьПередачуИнформацииВБКИ", Comment = "Разрешить передачу информации в бюро кредитных историй", Synonym = "Разрешить передачу информации в бюро кредитных историй")]
        public bool РазрешитьПередачуИнформацииВБКИ {get; set;}
        [Description1C8(Name = "КонтрольнаяИнформация", Comment = "", Synonym = "Контрольная информация")]
        [StringLength(30)]
        public string КонтрольнаяИнформация {get; set;}
        [Description1C8(Name = "НомерМиграционнойКарты", Comment = "", Synonym = "Номер")]
        [StringLength(255)]
        public string НомерМиграционнойКарты {get; set;}
        [Description1C8(Name = "ДатаНачалаПребыванияМиграционнойКарты", Comment = "", Synonym = "Начало пребывания")]
        public DateTime ДатаНачалаПребыванияМиграционнойКарты {get; set;}
        [Description1C8(Name = "ДатаОкончанияПребыванияМиграционнойКарты", Comment = "", Synonym = "Окончание пребывания")]
        public DateTime ДатаОкончанияПребыванияМиграционнойКарты {get; set;}
        [Description1C8(Name = "ВидМиграционногоДокумента", Comment = "", Synonym = "Вид документа")]
        public Catalogs.ВидыДокументовФизическихЛиц ВидМиграционногоДокумента {get; set;}
        [Description1C8(Name = "НомерМиграционногоДокумента", Comment = "", Synonym = "Номер")]
        public string НомерМиграционногоДокумента {get; set;}
        [Description1C8(Name = "ДатаНачалаПребыванияМиграционногоДокумента", Comment = "", Synonym = "Начало пребывания")]
        public DateTime ДатаНачалаПребыванияМиграционногоДокумента {get; set;}
        [Description1C8(Name = "ДатаОкончанияПребыванияМиграционногоДокумента", Comment = "", Synonym = "Окончание пребывания")]
        public DateTime ДатаОкончанияПребыванияМиграционногоДокумента {get; set;}
        [Description1C8(Name = "ПрогнозируемыйМесячныйДоход", Comment = "", Synonym = "Месячный доход")]
        // Format 15.2
        public decimal ПрогнозируемыйМесячныйДоход {get; set;}
        [Description1C8(Name = "ТабельныйНомер", Comment = "", Synonym = "Табельный номер")]
        [StringLength(10)]
        public string ТабельныйНомер {get; set;}
        [Description1C8(Name = "ДатаПриема", Comment = "", Synonym = "Дата приема на работу")]
        public DateTime ДатаПриема {get; set;}
        [Description1C8(Name = "ДеньВыплатыЗарплаты", Comment = "", Synonym = "День выплаты зарплаты")]
        // Format 2.0
        public long ДеньВыплатыЗарплаты {get; set;}
        [Description1C8(Name = "КодВидаВклада", Comment = "", Synonym = "Вид вклада")]
        [StringLength(2)]
        public string КодВидаВклада {get; set;}
        [Description1C8(Name = "КодПодвидаВклада", Comment = "", Synonym = "Подвид вклада")]
        [StringLength(2)]
        public string КодПодвидаВклада {get; set;}
        [Description1C8(Name = "ВалютаВклада", Comment = "", Synonym = "Валюта")]
        public Catalogs.Валюты ВалютаВклада {get; set;}
        [Description1C8(Name = "ДокументВид", Comment = "", Synonym = "Вид документа")]
        public Catalogs.ВидыДокументовФизическихЛиц ДокументВид {get; set;}
        [Description1C8(Name = "ДокументСерия", Comment = "", Synonym = "Серия")]
        [StringLength(14)]
        public string ДокументСерия {get; set;}
        [Description1C8(Name = "ДокументНомер", Comment = "", Synonym = "Номер")]
        [StringLength(14)]
        public string ДокументНомер {get; set;}
        [Description1C8(Name = "ДокументДатаВыдачи", Comment = "", Synonym = "Дата выдачи")]
        public DateTime ДокументДатаВыдачи {get; set;}
        [Description1C8(Name = "ДокументСрокДействия", Comment = "", Synonym = "Срок действия")]
        public DateTime ДокументСрокДействия {get; set;}
        [Description1C8(Name = "ДокументКемВыдан", Comment = "", Synonym = "Кем выдан")]
        [StringLength(200)]
        public string ДокументКемВыдан {get; set;}
        [Description1C8(Name = "ДокументКодПодразделения", Comment = "", Synonym = "Код подразделения")]
        [StringLength(15)]
        public string ДокументКодПодразделения {get; set;}
        [Description1C8(Name = "ДокументПредставление", Comment = "", Synonym = "Документ удостоверяющий личность")]
        public string ДокументПредставление {get; set;}
        [Description1C8(Name = "Пол", Comment = "", Synonym = "Пол")]
        public Enums.ПолФизическогоЛица Пол {get; set;}
        [Description1C8(Name = "ДатаРождения", Comment = "", Synonym = "Дата рождения")]
        public DateTime ДатаРождения {get; set;}
        [Description1C8(Name = "МестоРождения", Comment = "", Synonym = "Место рождения")]
        [StringLength(240)]
        public string МестоРождения {get; set;}
        [Description1C8(Name = "МестоРожденияПредставление", Comment = "", Synonym = "Место рождения")]
        [StringLength(240)]
        public string МестоРожденияПредставление {get; set;}
        [Description1C8(Name = "АдресДляИнформирования", Comment = "", Synonym = "Адрес для информирования")]
        public string АдресДляИнформирования {get; set;}
        [Description1C8(Name = "АдресДляИнформированияПредставление", Comment = "", Synonym = "Адрес для информирования")]
        public string АдресДляИнформированияПредставление {get; set;}
        [Description1C8(Name = "АдресМестаРаботы", Comment = "", Synonym = "Адрес места работы")]
        public string АдресМестаРаботы {get; set;}
        [Description1C8(Name = "АдресМестаРаботыПредставление", Comment = "", Synonym = "Адрес места работы")]
        public string АдресМестаРаботыПредставление {get; set;}
        [Description1C8(Name = "АдресПоПрописке", Comment = "", Synonym = "Адрес по прописке")]
        public string АдресПоПрописке {get; set;}
        [Description1C8(Name = "АдресПоПропискеПредставление", Comment = "", Synonym = "Адрес по прописке")]
        public string АдресПоПропискеПредставление {get; set;}
        [Description1C8(Name = "АдресМестаПроживания", Comment = "", Synonym = "Адрес места проживания")]
        public string АдресМестаПроживания {get; set;}
        [Description1C8(Name = "АдресМестаПроживанияПредставление", Comment = "", Synonym = "Адрес места проживания")]
        public string АдресМестаПроживанияПредставление {get; set;}
        [Description1C8(Name = "ТелефонДомашний", Comment = "", Synonym = "Телефон домашний")]
        public string ТелефонДомашний {get; set;}
        [Description1C8(Name = "ТелефонДомашнийПредставление", Comment = "", Synonym = "Телефон домашний")]
        public string ТелефонДомашнийПредставление {get; set;}
        [Description1C8(Name = "ТелефонРабочий", Comment = "", Synonym = "Телефон рабочий")]
        public string ТелефонРабочий {get; set;}
        [Description1C8(Name = "ТелефонРабочийПредставление", Comment = "", Synonym = "Телефон рабочий")]
        public string ТелефонРабочийПредставление {get; set;}
        [Description1C8(Name = "ЯвляетсяРезидентом", Comment = "", Synonym = "Является резидентом")]
        public bool ЯвляетсяРезидентом {get; set;}
        [Description1C8(Name = "Гражданство", Comment = "", Synonym = "Гражданство")]
        public Catalogs.СтраныМира Гражданство {get; set;}
        [Description1C8(Name = "Фамилия", Comment = "", Synonym = "Фамилия")]
        [StringLength(50)]
        public string Фамилия {get; set;}
        [Description1C8(Name = "Имя", Comment = "", Synonym = "Имя")]
        [StringLength(50)]
        public string Имя {get; set;}
        [Description1C8(Name = "Отчество", Comment = "", Synonym = "Отчество")]
        [StringLength(50)]
        public string Отчество {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиФикс", Comment = "", Synonym = "Идентификатор строки фикс")]
        // Format 5.0
        public long ИдентификаторСтрокиФикс {get; set;}
        [Description1C8(Name = "ИдентификаторДизайна", Comment = "", Synonym = "Идентификатор дизайна")]
        [StringLength(11)]
        public string ИдентификаторДизайна {get; set;}
        [Description1C8(Name = "ПВК", Comment = "", Synonym = "Удаленный пункт выдачи карты")]
        [StringLength(4)]
        public string ПВК {get; set;}
        [Description1C8(Name = "ПриложениеКартаКод", Comment = "", Synonym = "Код приложения карты")]
        [StringLength(4)]
        public string ПриложениеКартаКод {get; set;}
        [Description1C8(Name = "ПриложениеКартаПараметры", Comment = "", Synonym = "Параметры приложения карты")]
        [StringLength(30)]
        public string ПриложениеКартаПараметры {get; set;}
    }
    [Description1C8(Name = "ФиксацияИзменений", Comment = "", Synonym = "Фиксация изменений")]
    [Table("ZaiavkaNaOtkrytyeLytsevykhSchetovSotrudnykov_FyksatsyiaYzmenenyi")]
    public class ЗаявкаНаОткрытиеЛицевыхСчетовСотрудников_ФиксацияИзменений
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИмяРеквизита", Comment = "", Synonym = "Имя реквизита")]
        public string ИмяРеквизита {get; set;}
        [Description1C8(Name = "Путь", Comment = "", Synonym = "Путь")]
        public string Путь {get; set;}
        [Description1C8(Name = "ИдентификаторСтроки", Comment = "", Synonym = "Идентификатор строки")]
        // Format 5.0
        public long ИдентификаторСтроки {get; set;}
    }
}
