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
    [Table("BolnychnyiLyst")]
    [Description1C8(Name = "БольничныйЛист", Comment = "", Synonym = "Больничный лист")]
    public class БольничныйЛист:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Месяц")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ПричинаНетрудоспособности", Comment = "", Synonym = "Причина нетрудоспособности")]
        public Enums.ПричиныНетрудоспособности ПричинаНетрудоспособности {get; set;}
        [Description1C8(Name = "ПроцентОплаты", Comment = "Процент оплаты", Synonym = "Процент оплаты")]
        // Format 5.2
        public decimal ПроцентОплаты {get; set;}
        [Description1C8(Name = "ЯвляетсяПродолжениемБолезни", Comment = "", Synonym = "Является продолжением болезни")]
        public bool ЯвляетсяПродолжениемБолезни {get; set;}
        [Description1C8(Name = "ПервичныйБольничныйЛист", Comment = "", Synonym = "Первичный больничный лист")]
        public Документ.БольничныйЛист ПервичныйБольничныйЛист {get; set;}
        [Description1C8(Name = "ДатаНачалаСобытия", Comment = "Дата начала события, оплачиваемого по среднему заработку", Synonym = "Дата начала события")]
        public DateTime ДатаНачалаСобытия {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ДатаНачалаОплаты", Comment = "", Synonym = "Дата начала оплаты")]
        public DateTime ДатаНачалаОплаты {get; set;}
        [Description1C8(Name = "ДатаОкончанияОплаты", Comment = "", Synonym = "Дата окончания оплаты")]
        public DateTime ДатаОкончанияОплаты {get; set;}
        [Description1C8(Name = "ОграничениеПособия", Comment = "", Synonym = "Ограничение пособия")]
        public Enums.ВидыОграниченияПособия ОграничениеПособия {get; set;}
        [Description1C8(Name = "СлучайУходаЗаБольнымРебенком", Comment = "", Synonym = "Случай ухода за больным ребенком")]
        public Enums.СлучаиУходаЗаБольнымиДетьми СлучайУходаЗаБольнымРебенком {get; set;}
        [Description1C8(Name = "ДнейОплаты", Comment = "", Synonym = "Дней оплаты")]
        // Format 3.0
        public long ДнейОплаты {get; set;}
        [Description1C8(Name = "ВидОплатыПособия", Comment = "", Synonym = "Вид оплаты пособия")]
        public ПланВидовРасчета.Начисления ВидОплатыПособия {get; set;}
        [Description1C8(Name = "ВидОплатыЗаСчетРаботодателя", Comment = "", Synonym = "Вид оплаты за счет работодателя")]
        public ПланВидовРасчета.Начисления ВидОплатыЗаСчетРаботодателя {get; set;}
        [Description1C8(Name = "ВидНеоплачиваемогоВремени", Comment = "", Synonym = "Вид неоплачиваемого времени")]
        public ПланВидовРасчета.Начисления ВидНеоплачиваемогоВремени {get; set;}
        [Description1C8(Name = "ДоплачиватьДоСреднегоЗаработка", Comment = "", Synonym = "Доплачивать до среднего заработка")]
        public bool ДоплачиватьДоСреднегоЗаработка {get; set;}
        [Description1C8(Name = "ПроцентДоплатыЗаДниНетрудоспособности", Comment = "Процент доплаты до среднего заработка", Synonym = "Процент доплаты за дни нетрудоспособности")]
        // Format 5.2
        public decimal ПроцентДоплатыЗаДниНетрудоспособности {get; set;}
        [Description1C8(Name = "ВидРасчетаДоплаты", Comment = "", Synonym = "Вид расчета доплаты")]
        public ПланВидовРасчета.Начисления ВидРасчетаДоплаты {get; set;}
        [Description1C8(Name = "ПериодРасчетаСреднегоЗаработкаНачало", Comment = "Дата начала расчетного периода", Synonym = "Период расчета среднего заработка начало")]
        public DateTime ПериодРасчетаСреднегоЗаработкаНачало {get; set;}
        [Description1C8(Name = "ПериодРасчетаСреднегоЗаработкаОкончание", Comment = "Дата окончания расчетного периода", Synonym = "Период расчета среднего заработка окончание")]
        public DateTime ПериодРасчетаСреднегоЗаработкаОкончание {get; set;}
        [Description1C8(Name = "ФиксПериодРасчетаСреднегоЗаработка", Comment = "", Synonym = "Фикс период расчета среднего заработка")]
        public bool ФиксПериодРасчетаСреднегоЗаработка {get; set;}
        [Description1C8(Name = "ПериодРасчетаСреднегоЗаработкаПервыйГод", Comment = "", Synonym = "Период расчета среднего заработка первый год")]
        // Format 4.0
        public long ПериодРасчетаСреднегоЗаработкаПервыйГод {get; set;}
        [Description1C8(Name = "ПериодРасчетаСреднегоЗаработкаВторойГод", Comment = "", Synonym = "Период расчета среднего заработка второй год")]
        // Format 4.0
        public long ПериодРасчетаСреднегоЗаработкаВторойГод {get; set;}
        [Description1C8(Name = "ПроцентОплатыБезЛьгот", Comment = "Процент оплаты", Synonym = "Процент оплаты без льгот")]
        // Format 5.2
        public decimal ПроцентОплатыБезЛьгот {get; set;}
        [Description1C8(Name = "ОграничениеПособияБезЛьгот", Comment = "", Synonym = "Ограничение пособия без льгот")]
        public Enums.ВидыОграниченияПособия ОграничениеПособияБезЛьгот {get; set;}
        [Description1C8(Name = "ПрименятьЛьготыПриНачисленииПособия", Comment = "", Synonym = "Применять льготы при начислении пособия")]
        public bool ПрименятьЛьготыПриНачисленииПособия {get; set;}
        [Description1C8(Name = "ЛьготаПоПособию", Comment = "", Synonym = "Льгота по пособию")]
        public Enums.ОснованияЛьготПоПособию ЛьготаПоПособию {get; set;}
        [Description1C8(Name = "УдалитьПереноситьДанныеВДругойУчетСреднегоЗаработка", Comment = "", Synonym = "(не используется) Использовать данные заработка расчета пособий для расчета общего среднего заработка")]
        public bool УдалитьПереноситьДанныеВДругойУчетСреднегоЗаработка {get; set;}
        [Description1C8(Name = "СреднийДневнойЗаработок", Comment = "", Synonym = "Средний дневной заработок")]
        // Format 8.2
        public decimal СреднийДневнойЗаработок {get; set;}
        [Description1C8(Name = "МинимальныйСреднедневнойЗаработок", Comment = "", Synonym = "Минимальный среднедневной заработок")]
        // Format 15.2
        public decimal МинимальныйСреднедневнойЗаработок {get; set;}
        [Description1C8(Name = "Начислено", Comment = "", Synonym = "Начислено")]
        // Format 13.2
        public decimal Начислено {get; set;}
        [Description1C8(Name = "Удержано", Comment = "", Synonym = "Удержано")]
        // Format 13.2
        public decimal Удержано {get; set;}
        [Description1C8(Name = "ПредоставленДубликатЛисткаНетрудоспособности", Comment = "", Synonym = "дубликат")]
        public bool ПредоставленДубликатЛисткаНетрудоспособности {get; set;}
        [Description1C8(Name = "НомерПервичногоЛисткаНетрудоспособности", Comment = "", Synonym = "№ первичного ЛН")]
        [StringLength(12)]
        public string НомерПервичногоЛисткаНетрудоспособности {get; set;}
        [Description1C8(Name = "НомерЛисткаНетрудоспособности", Comment = "", Synonym = "№ ЛН")]
        [StringLength(12)]
        public string НомерЛисткаНетрудоспособности {get; set;}
        [Description1C8(Name = "ДатаВыдачиЛисткаНетрудоспособности", Comment = "", Synonym = "Дата выдачи")]
        public DateTime ДатаВыдачиЛисткаНетрудоспособности {get; set;}
        [Description1C8(Name = "КодПричиныНетрудоспособности", Comment = "", Synonym = "Код причины нетрудоспособности")]
        [StringLength(2)]
        public string КодПричиныНетрудоспособности {get; set;}
        [Description1C8(Name = "ДополнительныйКодПричиныНетрудоспособности", Comment = "", Synonym = "Дополнительный код причины нетрудоспособности")]
        [StringLength(3)]
        public string ДополнительныйКодПричиныНетрудоспособности {get; set;}
        [Description1C8(Name = "ВторойКодПричиныНетрудоспособности", Comment = "", Synonym = "Второй код причины нетрудоспособности")]
        [StringLength(2)]
        public string ВторойКодПричиныНетрудоспособности {get; set;}
        [Description1C8(Name = "НаименованиеОрганизацииВЛисткеНетрудоспособности", Comment = "", Synonym = "Место работы - наименование организации")]
        [StringLength(29)]
        public string НаименованиеОрганизацииВЛисткеНетрудоспособности {get; set;}
        [Description1C8(Name = "ОсновноеМестоРаботы", Comment = "", Synonym = "Основное место работы")]
        public bool ОсновноеМестоРаботы {get; set;}
        [Description1C8(Name = "НомерЛисткаПоОсновномуМестуРаботы", Comment = "", Synonym = "Номер ЛН по основному месту работы")]
        [StringLength(12)]
        public string НомерЛисткаПоОсновномуМестуРаботы {get; set;}
        [Description1C8(Name = "ДатаИзмененияКодаПричиныНетрудоспособности", Comment = "", Synonym = "Дата изменения кода причины нетрудоспособности")]
        public DateTime ДатаИзмененияКодаПричиныНетрудоспособности {get; set;}
        [Description1C8(Name = "РодственникЗаКоторымОсуществляетсяУход1", Comment = "", Synonym = "Родственник, за которым осуществляется уход")]
        public Catalogs.РодственникиФизическихЛиц РодственникЗаКоторымОсуществляетсяУход1 {get; set;}
        [Description1C8(Name = "ДатаНачалаРодственник1", Comment = "", Synonym = "Дата начала болезни родственника")]
        public DateTime ДатаНачалаРодственник1 {get; set;}
        [Description1C8(Name = "ДатаОкончанияРодственник1", Comment = "", Synonym = "Дата окончания болезни родственника")]
        public DateTime ДатаОкончанияРодственник1 {get; set;}
        [Description1C8(Name = "ПоУходуВозрастЛет1", Comment = "", Synonym = "Возраст, лет")]
        // Format 2.0
        public long ПоУходуВозрастЛет1 {get; set;}
        [Description1C8(Name = "ПоУходуВозрастМесяцев1", Comment = "", Synonym = "Возраст, мес")]
        // Format 2.0
        public long ПоУходуВозрастМесяцев1 {get; set;}
        [Description1C8(Name = "ПоУходуРодственнаяСвязь1", Comment = "", Synonym = "родственная связь")]
        [StringLength(2)]
        public string ПоУходуРодственнаяСвязь1 {get; set;}
        [Description1C8(Name = "ПоУходуФИО1", Comment = "", Synonym = "ФИО")]
        [StringLength(39)]
        public string ПоУходуФИО1 {get; set;}
        [Description1C8(Name = "ПоУходуИспользованоДней1", Comment = "", Synonym = "По уходу использовано дней1")]
        // Format 3.0
        public long ПоУходуИспользованоДней1 {get; set;}
        [Description1C8(Name = "РодственникЗаКоторымОсуществляетсяУход2", Comment = "", Synonym = "Родственник, за которым осуществляется уход")]
        public Catalogs.РодственникиФизическихЛиц РодственникЗаКоторымОсуществляетсяУход2 {get; set;}
        [Description1C8(Name = "ДатаНачалаРодственник2", Comment = "", Synonym = "Дата начала болезни родственника")]
        public DateTime ДатаНачалаРодственник2 {get; set;}
        [Description1C8(Name = "ДатаОкончанияРодственник2", Comment = "", Synonym = "Дата окончания болезни родственника")]
        public DateTime ДатаОкончанияРодственник2 {get; set;}
        [Description1C8(Name = "ПоУходуВозрастЛет2", Comment = "", Synonym = "Возраст, лет")]
        // Format 2.0
        public long ПоУходуВозрастЛет2 {get; set;}
        [Description1C8(Name = "ПоУходуВозрастМесяцев2", Comment = "", Synonym = "Возраст, мес.")]
        // Format 2.0
        public long ПоУходуВозрастМесяцев2 {get; set;}
        [Description1C8(Name = "ПоУходуРодственнаяСвязь2", Comment = "", Synonym = "родственная связь")]
        [StringLength(2)]
        public string ПоУходуРодственнаяСвязь2 {get; set;}
        [Description1C8(Name = "ПоУходуФИО2", Comment = "", Synonym = "ФИО")]
        [StringLength(39)]
        public string ПоУходуФИО2 {get; set;}
        [Description1C8(Name = "ПоУходуИспользованоДней2", Comment = "", Synonym = "По уходу использовано дней2")]
        // Format 3.0
        public long ПоУходуИспользованоДней2 {get; set;}
        [Description1C8(Name = "ПоставленаНаУчетВРанниеСрокиБеременности", Comment = "", Synonym = "Поставлена на учет в ранние сроки беременности")]
        public bool ПоставленаНаУчетВРанниеСрокиБеременности {get; set;}
        [Description1C8(Name = "КодНарушенияРежима", Comment = "", Synonym = "Код нарушения режима")]
        [StringLength(2)]
        public string КодНарушенияРежима {get; set;}
        [Description1C8(Name = "ДатаНарушенияРежима", Comment = "", Synonym = "Дата нарушения режима")]
        public DateTime ДатаНарушенияРежима {get; set;}
        [Description1C8(Name = "ПериодНахожденияВСтационареСРебенкомС", Comment = "", Synonym = "Период нахождения в стационаре с ребенком: с")]
        public DateTime ПериодНахожденияВСтационареСРебенкомС {get; set;}
        [Description1C8(Name = "ПериодНахожденияВСтационареСРебенкомПо", Comment = "", Synonym = "Период нахождения в стационаре с ребенком: по")]
        public DateTime ПериодНахожденияВСтационареСРебенкомПо {get; set;}
        [Description1C8(Name = "ГруппаИнвалидности", Comment = "", Synonym = "Группа инвалидности")]
        [StringLength(1)]
        public string ГруппаИнвалидности {get; set;}
        [Description1C8(Name = "ОсвобождениеДатаНачала1", Comment = "", Synonym = "Освобождение дата начала1")]
        public DateTime ОсвобождениеДатаНачала1 {get; set;}
        [Description1C8(Name = "ОсвобождениеДатаОкончания1", Comment = "", Synonym = "Освобождение дата окончания1")]
        public DateTime ОсвобождениеДатаОкончания1 {get; set;}
        [Description1C8(Name = "ОсвобождениеДолжностьВрача1", Comment = "", Synonym = "Освобождение должность врача1")]
        [StringLength(30)]
        public string ОсвобождениеДолжностьВрача1 {get; set;}
        [Description1C8(Name = "ОсвобождениеФИОВрача1", Comment = "", Synonym = "ФИО врача")]
        [StringLength(90)]
        public string ОсвобождениеФИОВрача1 {get; set;}
        [Description1C8(Name = "ОсвобождениеИдентификационныйНомерВрача1", Comment = "", Synonym = "Освобождение идентификационный номер врача1")]
        [StringLength(30)]
        public string ОсвобождениеИдентификационныйНомерВрача1 {get; set;}
        [Description1C8(Name = "ОсвобождениеФИОВрачаПредседателяВК1", Comment = "", Synonym = "ФИО врача-председателя ВК")]
        [StringLength(90)]
        public string ОсвобождениеФИОВрачаПредседателяВК1 {get; set;}
        [Description1C8(Name = "ОсвобождениеДолжностьВрачаПредседателяВК1", Comment = "", Synonym = "Освобождение должность врача председателя в к1")]
        [StringLength(30)]
        public string ОсвобождениеДолжностьВрачаПредседателяВК1 {get; set;}
        [Description1C8(Name = "ОсвобождениеИдентификационныйНомерВрачаПредседателяВК1", Comment = "", Synonym = "Освобождение идентификационный номер врача председателя в к1")]
        [StringLength(30)]
        public string ОсвобождениеИдентификационныйНомерВрачаПредседателяВК1 {get; set;}
        [Description1C8(Name = "ОсвобождениеДатаНачала2", Comment = "", Synonym = "Освобождение дата начала2")]
        public DateTime ОсвобождениеДатаНачала2 {get; set;}
        [Description1C8(Name = "ОсвобождениеДатаОкончания2", Comment = "", Synonym = "Освобождение дата окончания2")]
        public DateTime ОсвобождениеДатаОкончания2 {get; set;}
        [Description1C8(Name = "ОсвобождениеДолжностьВрача2", Comment = "", Synonym = "Освобождение должность врача2")]
        [StringLength(30)]
        public string ОсвобождениеДолжностьВрача2 {get; set;}
        [Description1C8(Name = "ОсвобождениеФИОВрача2", Comment = "", Synonym = "ФИО врача")]
        [StringLength(90)]
        public string ОсвобождениеФИОВрача2 {get; set;}
        [Description1C8(Name = "ОсвобождениеИдентификационныйНомерВрача2", Comment = "", Synonym = "Освобождение идентификационный номер врача2")]
        [StringLength(30)]
        public string ОсвобождениеИдентификационныйНомерВрача2 {get; set;}
        [Description1C8(Name = "ОсвобождениеФИОВрачаПредседателяВК2", Comment = "", Synonym = "ФИО врача-председателя ВК")]
        [StringLength(90)]
        public string ОсвобождениеФИОВрачаПредседателяВК2 {get; set;}
        [Description1C8(Name = "ОсвобождениеДолжностьВрачаПредседателяВК2", Comment = "", Synonym = "Освобождение должность врача председателя в к2")]
        [StringLength(30)]
        public string ОсвобождениеДолжностьВрачаПредседателяВК2 {get; set;}
        [Description1C8(Name = "ОсвобождениеИдентификационныйНомерВрачаПредседателяВК2", Comment = "", Synonym = "Освобождение идентификационный номер врача председателя в к2")]
        [StringLength(30)]
        public string ОсвобождениеИдентификационныйНомерВрачаПредседателяВК2 {get; set;}
        [Description1C8(Name = "ОсвобождениеДатаНачала3", Comment = "", Synonym = "Освобождение дата начала3")]
        public DateTime ОсвобождениеДатаНачала3 {get; set;}
        [Description1C8(Name = "ОсвобождениеДатаОкончания3", Comment = "", Synonym = "Освобождение дата окончания3")]
        public DateTime ОсвобождениеДатаОкончания3 {get; set;}
        [Description1C8(Name = "ОсвобождениеДолжностьВрача3", Comment = "", Synonym = "Освобождение должность врача3")]
        [StringLength(30)]
        public string ОсвобождениеДолжностьВрача3 {get; set;}
        [Description1C8(Name = "ОсвобождениеФИОВрача3", Comment = "", Synonym = "ФИО врача")]
        [StringLength(90)]
        public string ОсвобождениеФИОВрача3 {get; set;}
        [Description1C8(Name = "ОсвобождениеИдентификационныйНомерВрача3", Comment = "", Synonym = "Освобождение идентификационный номер врача3")]
        [StringLength(30)]
        public string ОсвобождениеИдентификационныйНомерВрача3 {get; set;}
        [Description1C8(Name = "ОсвобождениеФИОВрачаПредседателяВК3", Comment = "", Synonym = "ФИО врача-председателя ВК")]
        [StringLength(90)]
        public string ОсвобождениеФИОВрачаПредседателяВК3 {get; set;}
        [Description1C8(Name = "ОсвобождениеДолжностьВрачаПредседателяВК3", Comment = "", Synonym = "Освобождение должность врача председателя в к3")]
        [StringLength(30)]
        public string ОсвобождениеДолжностьВрачаПредседателяВК3 {get; set;}
        [Description1C8(Name = "ОсвобождениеИдентификационныйНомерВрачаПредседателяВК3", Comment = "", Synonym = "Освобождение идентификационный номер врача председателя в к3")]
        [StringLength(30)]
        public string ОсвобождениеИдентификационныйНомерВрачаПредседателяВК3 {get; set;}
        [Description1C8(Name = "ПриступитьКРаботеС", Comment = "", Synonym = "Приступить к работе с")]
        public DateTime ПриступитьКРаботеС {get; set;}
        [Description1C8(Name = "ДатаНовыйСтатусНетрудоспособного", Comment = "", Synonym = "Дата новый статус нетрудоспособного")]
        public DateTime ДатаНовыйСтатусНетрудоспособного {get; set;}
        [Description1C8(Name = "НовыйСтатусНетрудоспособного", Comment = "", Synonym = "Новый статус нетрудоспособного")]
        [StringLength(2)]
        public string НовыйСтатусНетрудоспособного {get; set;}
        [Description1C8(Name = "НомерЛисткаПродолжения", Comment = "", Synonym = "Номер листка продолжения")]
        [StringLength(12)]
        public string НомерЛисткаПродолжения {get; set;}
        [Description1C8(Name = "УсловияИсчисленияКод1", Comment = "", Synonym = "Условия исчисления: код")]
        [StringLength(2)]
        public string УсловияИсчисленияКод1 {get; set;}
        [Description1C8(Name = "УсловияИсчисленияКод2", Comment = "", Synonym = "Условия исчисления: код")]
        [StringLength(2)]
        public string УсловияИсчисленияКод2 {get; set;}
        [Description1C8(Name = "УсловияИсчисленияКод3", Comment = "", Synonym = "Условия исчисления: код")]
        [StringLength(2)]
        public string УсловияИсчисленияКод3 {get; set;}
        [Description1C8(Name = "ДатаАктаН1", Comment = "", Synonym = "Дата акта Н-1")]
        public DateTime ДатаАктаН1 {get; set;}
        [Description1C8(Name = "ДатаНачалаРаботы", Comment = "", Synonym = "Дата начала работы (в случае аннулирования трудового договора)")]
        public DateTime ДатаНачалаРаботы {get; set;}
        [Description1C8(Name = "ПорядокВыплаты", Comment = "", Synonym = "Порядок выплаты")]
        public Enums.ХарактерВыплатыЗарплаты ПорядокВыплаты {get; set;}
        [Description1C8(Name = "ПланируемаяДатаВыплаты", Comment = "", Synonym = "Планируемая дата выплаты")]
        public DateTime ПланируемаяДатаВыплаты {get; set;}
        [Description1C8(Name = "УчитыватьЗаработокПредыдущихСтрахователей", Comment = "", Synonym = "Учитывать заработок предыдущих страхователей")]
        public bool УчитыватьЗаработокПредыдущихСтрахователей {get; set;}
        [Description1C8(Name = "НазначитьПособие", Comment = "", Synonym = "Назначить пособие")]
        public bool НазначитьПособие {get; set;}
        [Description1C8(Name = "РасчетПоПравилам2010Года", Comment = "", Synonym = "Расчет по правилам 2010 года")]
        public bool РасчетПоПравилам2010Года {get; set;}
        [Description1C8(Name = "СтажЛет", Comment = "", Synonym = "Стаж: лет")]
        // Format 2.0
        public long СтажЛет {get; set;}
        [Description1C8(Name = "СтажМесяцев", Comment = "", Synonym = "Стаж: месяцев")]
        // Format 2.0
        public long СтажМесяцев {get; set;}
        [Description1C8(Name = "СтажРасширенныйЛет", Comment = "", Synonym = "Стаж расширенный: лет")]
        // Format 2.0
        public long СтажРасширенныйЛет {get; set;}
        [Description1C8(Name = "СтажРасширенныйМесяцев", Comment = "", Synonym = "Стаж расширенный: месяцев")]
        // Format 2.0
        public long СтажРасширенныйМесяцев {get; set;}
        [Description1C8(Name = "ДатаНачалаПоловиннойОплаты", Comment = "", Synonym = "Дата начала оплаты в размере 50%")]
        public DateTime ДатаНачалаПоловиннойОплаты {get; set;}
        [Description1C8(Name = "ДоляНеполногоВремени", Comment = "", Synonym = "Доля неполного времени")]
        // Format 3.2
        public decimal ДоляНеполногоВремени {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.БольничныйЛист ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "ДокументРассчитан", Comment = "", Synonym = "Документ рассчитан")]
        public bool ДокументРассчитан {get; set;}
        [Description1C8(Name = "Рассчитал", Comment = "", Synonym = "Рассчитал")]
        public Catalogs.Пользователи Рассчитал {get; set;}
        [Description1C8(Name = "ПредставлениеПериода", Comment = "", Synonym = "Представление периода")]
        [StringLength(19)]
        public string ПредставлениеПериода {get; set;}
        [Description1C8(Name = "ПособиеВыплачиваетсяФСС", Comment = "", Synonym = "Пособие выплачивается ФСС")]
        public bool ПособиеВыплачиваетсяФСС {get; set;}
        [Description1C8(Name = "РассчитатьЗарплату", Comment = "", Synonym = "Рассчитать зарплату")]
        public bool РассчитатьЗарплату {get; set;}
        [Description1C8(Name = "ОсвобождатьСтавку", Comment = "", Synonym = "Освободить ставку на период отсутствия")]
        public bool ОсвобождатьСтавку {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "СохраняемоеДенежноеСодержание", Comment = "", Synonym = "Сохраняемое денежное содержание")]
        // Format 13.2
        public decimal СохраняемоеДенежноеСодержание {get; set;}
        [Description1C8(Name = "ДоплачиватьДоДенежногоСодержания", Comment = "", Synonym = "Доплачивать до денежного содержания")]
        public bool ДоплачиватьДоДенежногоСодержания {get; set;}
        [Description1C8(Name = "Хеш", Comment = "", Synonym = "Хеш")]
        [StringLength(32)]
        public string Хеш {get; set;}
        [Description1C8(Name = "ДнейОплатыЗаСчетФСС", Comment = "", Synonym = "Дней оплаты за счет ФСС")]
        // Format 3.0
        public long ДнейОплатыЗаСчетФСС {get; set;}
        [Description1C8(Name = "СуммаЧернобыльскойЛьготы", Comment = "", Synonym = "Сумма чернобыльской льготы")]
        // Format 15.2
        public decimal СуммаЧернобыльскойЛьготы {get; set;}
        [Description1C8(Name = "РучнаяКорректировкаСреднегоЗаработка", Comment = "", Synonym = "Ручная корректировка среднего заработка")]
        public bool РучнаяКорректировкаСреднегоЗаработка {get; set;}
        [Description1C8(Name = "НачисленоРаботодатель", Comment = "", Synonym = "Начислено за счет работодателя")]
        // Format 14.2
        public decimal НачисленоРаботодатель {get; set;}
        [Description1C8(Name = "НачисленоФСС", Comment = "", Synonym = "Начислено за счет ФСС")]
        // Format 14.2
        public decimal НачисленоФСС {get; set;}
        [Description1C8(Name = "СтажМенее182дней", Comment = "", Synonym = "Стаж менее 182 дней")]
        public bool СтажМенее182дней {get; set;}
        [Description1C8(Name = "СтажЗа12МесяцевВМесяцах", Comment = "", Synonym = "Стаж за12 месяцев в месяцах")]
        // Format 2.0
        public long СтажЗа12МесяцевВМесяцах {get; set;}
        [Description1C8(Name = "СтажВМесяцах", Comment = "", Synonym = "Стаж в месяцах")]
        // Format 3.0
        public long СтажВМесяцах {get; set;}
        [Description1C8(Name = "ЗарегистрироватьДляЕСВ", Comment = "", Synonym = "Зарегистрировать для ЕСВ")]
        public bool ЗарегистрироватьДляЕСВ {get; set;}
        [Description1C8(Name = "СтажДней", Comment = "", Synonym = "Стаж: дней")]
        // Format 2.0
        public long СтажДней {get; set;}
        [Description1C8(Name = "СтажВведенПоДаннымПФУ", Comment = "", Synonym = "Стаж введен по данным ПФУ")]
        public bool СтажВведенПоДаннымПФУ {get; set;}
        [Description1C8(Name = "СтажЗа12МесяцевВДнях", Comment = "", Synonym = "Стаж за12 месяцев в днях")]
        // Format 3.0
        public long СтажЗа12МесяцевВДнях {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<БольничныйЛист_Начисления> БольничныйЛистНачисления {get;set;}
        [Description1C8(Name = "НачисленияПерерасчет", Comment = "", Synonym = "Начисления перерасчет")]
        public List<БольничныйЛист_НачисленияПерерасчет> БольничныйЛистНачисленияПерерасчет {get;set;}
        [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<БольничныйЛист_НДФЛ> БольничныйЛистНДФЛ {get;set;}
        [Description1C8(Name = "ОтработанноеВремяДляСреднегоФСС", Comment = "", Synonym = "Отработанное время для среднего ФСС")]
        public List<БольничныйЛист_ОтработанноеВремяДляСреднегоФСС> БольничныйЛистОтработанноеВремяДляСреднегоФСС {get;set;}
        [Description1C8(Name = "ПогашениеЗаймов", Comment = "", Synonym = "Погашение займов")]
        public List<БольничныйЛист_ПогашениеЗаймов> БольничныйЛистПогашениеЗаймов {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<БольничныйЛист_Показатели> БольничныйЛистПоказатели {get;set;}
        [Description1C8(Name = "РаспределениеРезультатовНачислений", Comment = "", Synonym = "Распределение результатов начислений")]
        public List<БольничныйЛист_РаспределениеРезультатовНачислений> БольничныйЛистРаспределениеРезультатовНачислений {get;set;}
        [Description1C8(Name = "РаспределениеРезультатовУдержаний", Comment = "", Synonym = "Распределение результатов удержаний")]
        public List<БольничныйЛист_РаспределениеРезультатовУдержаний> БольничныйЛистРаспределениеРезультатовУдержаний {get;set;}
        [Description1C8(Name = "СреднийЗаработокДанныеСтрахователей", Comment = "", Synonym = "Средний заработок данные страхователей")]
        public List<БольничныйЛист_СреднийЗаработокДанныеСтрахователей> БольничныйЛистСреднийЗаработокДанныеСтрахователей {get;set;}
        [Description1C8(Name = "СреднийЗаработокФСС", Comment = "", Synonym = "Средний заработок ФСС")]
        public List<БольничныйЛист_СреднийЗаработокФСС> БольничныйЛистСреднийЗаработокФСС {get;set;}
        [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
        public List<БольничныйЛист_Удержания> БольничныйЛистУдержания {get;set;}
        [Description1C8(Name = "РаспределениеПоТерриториямУсловиямТруда", Comment = "", Synonym = "Распределение по территориям и условиям труда")]
        public List<БольничныйЛист_РаспределениеПоТерриториямУсловиямТруда> БольничныйЛистРаспределениеПоТерриториямУсловиямТруда {get;set;}
        [Description1C8(Name = "ПериодыБолезниУходаЗаДетьми", Comment = "", Synonym = "Периоды болезни, ухода за детьми и пр.")]
        public List<БольничныйЛист_ПериодыБолезниУходаЗаДетьми> БольничныйЛистПериодыБолезниУходаЗаДетьми {get;set;}
        [Description1C8(Name = "ДенежноеСодержание", Comment = "", Synonym = "Денежное содержание")]
        public List<БольничныйЛист_ДенежноеСодержание> БольничныйЛистДенежноеСодержание {get;set;}
        [Description1C8(Name = "ДенежноеСодержаниеФактическиеНачисления", Comment = "", Synonym = "Денежное содержание фактические начисления")]
        public List<БольничныйЛист_ДенежноеСодержаниеФактическиеНачисления> БольничныйЛистДенежноеСодержаниеФактическиеНачисления {get;set;}
        [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
        public List<БольничныйЛист_ДополнительныеРеквизиты> БольничныйЛистДополнительныеРеквизиты {get;set;}
        [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
        public List<БольничныйЛист_ВзносыФОТ> БольничныйЛистВзносыФОТ {get;set;}
        [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
        public List<БольничныйЛист_Взносы> БольничныйЛистВзносы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("BolnychnyiLyst_Nachyslenyia")]
    public class БольничныйЛист_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "РезультатВТомЧислеЗаСчетФБ", Comment = "", Synonym = "В том числе")]
        // Format 15.2
        public decimal РезультатВТомЧислеЗаСчетФБ {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ВидЗанятости", Comment = "", Synonym = "Вид занятости")]
        public Enums.ВидыЗанятости ВидЗанятости {get; set;}
        [Description1C8(Name = "НормаДней", Comment = "", Synonym = "Норма дней")]
        // Format 7.2
        public decimal НормаДней {get; set;}
        [Description1C8(Name = "НормаЧасов", Comment = "", Synonym = "Норма часов")]
        // Format 7.2
        public decimal НормаЧасов {get; set;}
        [Description1C8(Name = "ОтработаноДней", Comment = "", Synonym = "Отработано дней")]
        // Format 7.2
        public decimal ОтработаноДней {get; set;}
        [Description1C8(Name = "ОтработаноЧасов", Comment = "", Synonym = "Отработано часов")]
        // Format 7.2
        public decimal ОтработаноЧасов {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "РасчетнаяБазаЗаЕдиницуНормыВремени", Comment = "Расчетная база на единицу нормы времени для расчета сторно-записей", Synonym = "Расчетная база за единицу нормы времени")]
        // Format 15.2
        public decimal РасчетнаяБазаЗаЕдиницуНормыВремени {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
        [Description1C8(Name = "ВидУчетаВремени", Comment = "", Synonym = "Вид учета времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидУчетаВремени {get; set;}
        [Description1C8(Name = "ФиксСтрока", Comment = "", Synonym = "Фикс строка")]
        public bool ФиксСтрока {get; set;}
        [Description1C8(Name = "ФиксЗаполнение", Comment = "", Synonym = "Фиксировано заполнение")]
        public bool ФиксЗаполнение {get; set;}
        [Description1C8(Name = "ФиксРасчетВремени", Comment = "", Synonym = "Фиксирован расчет времени")]
        public bool ФиксРасчетВремени {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "ВремяВЧасах", Comment = "", Synonym = "Время в часах")]
        public bool ВремяВЧасах {get; set;}
        [Description1C8(Name = "ГрафикРаботыНорма", Comment = "", Synonym = "График работы норма")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботыНорма {get; set;}
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
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
    }
    [Description1C8(Name = "НачисленияПерерасчет", Comment = "", Synonym = "Начисления перерасчет")]
    [Table("BolnychnyiLyst_NachyslenyiaPereraschet")]
    public class БольничныйЛист_НачисленияПерерасчет
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
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
        [Description1C8(Name = "Сторно", Comment = "", Synonym = "Сторно")]
        public bool Сторно {get; set;}
        [Description1C8(Name = "СторнируемыйДокумент", Comment = "Документ, который зарегистрировал сторнируемое начисление", Synonym = "Сторнируемый документ")]
        public Документ.СторнированиеНачислений СторнируемыйДокумент {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "РасчетнаяБазаЗаЕдиницуНормыВремени", Comment = "Расчетная база на единицу нормы времени для расчета сторно-записей", Synonym = "Расчетная база за единицу нормы времени")]
        // Format 15.2
        public decimal РасчетнаяБазаЗаЕдиницуНормыВремени {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботы {get; set;}
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
        [Description1C8(Name = "ГрафикРаботыНорма", Comment = "", Synonym = "График работы норма")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботыНорма {get; set;}
        [Description1C8(Name = "ПериодРегистрацииВремени", Comment = "", Synonym = "Период регистрации времени")]
        public DateTime ПериодРегистрацииВремени {get; set;}
        [Description1C8(Name = "ВремяВЧасах", Comment = "", Synonym = "Время в часах")]
        public bool ВремяВЧасах {get; set;}
        [Description1C8(Name = "ВидУчетаВремени", Comment = "", Synonym = "Вид учета времени")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидУчетаВремени {get; set;}
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
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
    }
    [Description1C8(Name = "НДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("BolnychnyiLyst_NDFL")]
    public class БольничныйЛист_НДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
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
    [Description1C8(Name = "ОтработанноеВремяДляСреднегоФСС", Comment = "", Synonym = "Отработанное время для среднего ФСС")]
    [Table("BolnychnyiLyst_OtrabotannoeVremiaDliaSrednehoFSS")]
    public class БольничныйЛист_ОтработанноеВремяДляСреднегоФСС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "УдалитьСотрудник", Comment = "", Synonym = "Удалить сотрудник")]
        public Catalogs.Сотрудники УдалитьСотрудник {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "ОтработаноДнейКалендарных", Comment = "", Synonym = "Отработано дней календарных")]
        // Format 7.2
        public decimal ОтработаноДнейКалендарных {get; set;}
        [Description1C8(Name = "ДнейБолезниУходаЗаДетьми", Comment = "", Synonym = "Дней болезни, ухода за детьми и др.")]
        // Format 7.0
        public long ДнейБолезниУходаЗаДетьми {get; set;}
        [Description1C8(Name = "Источник", Comment = "", Synonym = "Источник")]
        public Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка Источник {get; set;}
        [Description1C8(Name = "УдалитьКорректировка", Comment = "", Synonym = "(Не используется) Корректировка")]
        public bool УдалитьКорректировка {get; set;}
    }
    [Description1C8(Name = "ПогашениеЗаймов", Comment = "", Synonym = "Погашение займов")]
    [Table("BolnychnyiLyst_PohashenyeZaimov")]
    public class БольничныйЛист_ПогашениеЗаймов
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
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
    [Table("BolnychnyiLyst_Pokazately")]
    public class БольничныйЛист_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
    }
    [Description1C8(Name = "РаспределениеРезультатовНачислений", Comment = "", Synonym = "Распределение результатов начислений")]
    [Table("BolnychnyiLyst_RaspredelenyeRezultatovNachyslenyi")]
    public class БольничныйЛист_РаспределениеРезультатовНачислений
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
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
    [Table("BolnychnyiLyst_RaspredelenyeRezultatovUderzhanyi")]
    public class БольничныйЛист_РаспределениеРезультатовУдержаний
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
    [Description1C8(Name = "СреднийЗаработокДанныеСтрахователей", Comment = "", Synonym = "Средний заработок данные страхователей")]
    [Table("BolnychnyiLyst_SrednyiZarabotokDannyeStrakhovatelei")]
    public class БольничныйЛист_СреднийЗаработокДанныеСтрахователей
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Год", Comment = "", Synonym = "Год")]
        // Format 4.0
        public long Год {get; set;}
        [Description1C8(Name = "Месяц", Comment = "", Synonym = "Месяц")]
        public DateTime Месяц {get; set;}
        [Description1C8(Name = "Страхователь", Comment = "", Synonym = "Страхователь")]
        public Catalogs.Работодатели Страхователь {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ДнейБолезниУходаЗаДетьми", Comment = "", Synonym = "Дней болезни, ухода за детьми и др.")]
        // Format 5.2
        public decimal ДнейБолезниУходаЗаДетьми {get; set;}
    }
    [Description1C8(Name = "СреднийЗаработокФСС", Comment = "", Synonym = "Средний заработок ФСС")]
    [Table("BolnychnyiLyst_SrednyiZarabotokFSS")]
    public class БольничныйЛист_СреднийЗаработокФСС
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "УдалитьСотрудник", Comment = "", Synonym = "(не используется) Удалить сотрудник")]
        public Catalogs.Сотрудники УдалитьСотрудник {get; set;}
        [Description1C8(Name = "ПорядокРасчета", Comment = "", Synonym = "Порядок расчета")]
        public Enums.ПорядокРасчетаСреднегоЗаработкаФСС ПорядокРасчета {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Статья финансирования")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "Период", Comment = "", Synonym = "Период")]
        public DateTime Период {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "Источник", Comment = "", Synonym = "Источник")]
        public Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка Источник {get; set;}
        [Description1C8(Name = "УдалитьКорректировка", Comment = "", Synonym = "(Не используется) Корректировка")]
        public bool УдалитьКорректировка {get; set;}
        [Description1C8(Name = "Предел", Comment = "", Synonym = "Предел")]
        // Format 12.2
        public decimal Предел {get; set;}
        [Description1C8(Name = "УчтеннаяСумма", Comment = "", Synonym = "Учтенная сумма")]
        // Format 15.2
        public decimal УчтеннаяСумма {get; set;}
        [Description1C8(Name = "СуммаСУчетомОграничений", Comment = "", Synonym = "Сумма с учетом ограничений")]
        // Format 15.2
        public decimal СуммаСУчетомОграничений {get; set;}
    }
    [Description1C8(Name = "Удержания", Comment = "", Synonym = "Удержания")]
    [Table("BolnychnyiLyst_Uderzhanyia")]
    public class БольничныйЛист_Удержания
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ДатаНачала", Comment = "", Synonym = "Дата начала")]
        public DateTime ДатаНачала {get; set;}
        [Description1C8(Name = "ДатаОкончания", Comment = "", Synonym = "Дата окончания")]
        public DateTime ДатаОкончания {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.УдержаниеВСчетРасчетовПоПрочимОперациям ДокументОснование {get; set;}
        [Description1C8(Name = "Получатель", Comment = "", Synonym = "Получатель")]
        public Catalogs.Контрагенты Получатель {get; set;}
        [Description1C8(Name = "ПлатежныйАгент", Comment = "", Synonym = "Платежный агент")]
        public Catalogs.Контрагенты ПлатежныйАгент {get; set;}
        [Description1C8(Name = "Удержание", Comment = "", Synonym = "Удержание")]
        public ПланВидовРасчета.Удержания Удержание {get; set;}
        [Description1C8(Name = "ФиксРасчет", Comment = "", Synonym = "Фиксирован расчет")]
        public bool ФиксРасчет {get; set;}
        [Description1C8(Name = "Результат", Comment = "", Synonym = "Результат")]
        // Format 13.2
        public decimal Результат {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
    }
    [Description1C8(Name = "РаспределениеПоТерриториямУсловиямТруда", Comment = "", Synonym = "Распределение по территориям и условиям труда")]
    [Table("BolnychnyiLyst_RaspredelenyePoTerrytoryiamUslovyiamTruda")]
    public class БольничныйЛист_РаспределениеПоТерриториямУсловиямТруда
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
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
    [Description1C8(Name = "ПериодыБолезниУходаЗаДетьми", Comment = "", Synonym = "Периоды болезни, ухода за детьми и пр.")]
    [Table("BolnychnyiLyst_PeryodyBoleznyUkhodaZaDetmy")]
    public class БольничныйЛист_ПериодыБолезниУходаЗаДетьми
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Начало", Comment = "", Synonym = "Начало")]
        public DateTime Начало {get; set;}
        [Description1C8(Name = "Окончание", Comment = "", Synonym = "Окончание")]
        public DateTime Окончание {get; set;}
        [Description1C8(Name = "Дни", Comment = "", Synonym = "Дни")]
        // Format 10.0
        public long Дни {get; set;}
        [Description1C8(Name = "ВидБолезниУходаЗаДетьми", Comment = "", Synonym = "Вид болезни, ухода за детьми и пр.")]
        [StringLength(100)]
        public string ВидБолезниУходаЗаДетьми {get; set;}
        [Description1C8(Name = "Источник", Comment = "", Synonym = "Источник")]
        public Enums.ИсточникиДанныхДляРасчетаСреднегоЗаработка Источник {get; set;}
        [Description1C8(Name = "УдалитьКорректировка", Comment = "", Synonym = "(Не используется) Корректировка")]
        public bool УдалитьКорректировка {get; set;}
    }
    [Description1C8(Name = "ДенежноеСодержание", Comment = "", Synonym = "Денежное содержание")]
    [Table("BolnychnyiLyst_DenezhnoeSoderzhanye")]
    public class БольничныйЛист_ДенежноеСодержание
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
    [Table("BolnychnyiLyst_DenezhnoeSoderzhanyeFaktycheskyeNachyslenyia")]
    public class БольничныйЛист_ДенежноеСодержаниеФактическиеНачисления
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
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    [Table("BolnychnyiLyst_DopolnytelnyeRekvyzyty")]
    public class БольничныйЛист_ДополнительныеРеквизиты
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
    [Description1C8(Name = "ВзносыФОТ", Comment = "", Synonym = "Взносы ФОТ")]
    [Table("BolnychnyiLyst_VznosyFOT")]
    public class БольничныйЛист_ВзносыФОТ
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
        [Description1C8(Name = "СтавкаПолная", Comment = "", Synonym = "Ставка полная")]
        // Format 10.4
        public decimal СтавкаПолная {get; set;}
        [Description1C8(Name = "РезультатПолная", Comment = "", Synonym = "Результат по полн. ставке")]
        // Format 16.2
        public decimal РезультатПолная {get; set;}
    }
    [Description1C8(Name = "Взносы", Comment = "", Synonym = "Взносы")]
    [Table("BolnychnyiLyst_Vznosy")]
    public class БольничныйЛист_Взносы
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
        [Description1C8(Name = "СтавкаПолная", Comment = "", Synonym = "Ставка полная")]
        // Format 10.4
        public decimal СтавкаПолная {get; set;}
        [Description1C8(Name = "РезультатПолная", Comment = "", Synonym = "Результат по полн. ставке")]
        // Format 16.2
        public decimal РезультатПолная {get; set;}
    }
}
