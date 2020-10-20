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
    [Table("TabelUchetaRabochehoVremeny")]
    [Description1C8(Name = "ТабельУчетаРабочегоВремени", Comment = "", Synonym = "Табель учета рабочего времени")]
    public class ТабельУчетаРабочегоВремени:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Период регистрации")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ДатаНачалаПериода", Comment = "", Synonym = "Дата начала периода")]
        public DateTime ДатаНачалаПериода {get; set;}
        [Description1C8(Name = "ДатаОкончанияПериода", Comment = "", Synonym = "Дата окончания периода")]
        public DateTime ДатаОкончанияПериода {get; set;}
        [Description1C8(Name = "ПериодВводаДанныхОВремени", Comment = "", Synonym = "Период ввода данных о времени")]
        public Enums.ПериодыВводаДанныхОВремени ПериодВводаДанныхОВремени {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Documents.ТабельУчетаРабочегоВремени ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "РаботникКадровойСлужбы", Comment = "", Synonym = "Работник кадровой службы")]
        public Catalogs.ФизическиеЛица РаботникКадровойСлужбы {get; set;}
        [Description1C8(Name = "ДолжностьРаботникаКадровойСлужбы", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРаботникаКадровойСлужбы {get; set;}
        [Description1C8(Name = "Исполнитель", Comment = "", Synonym = "Исполнитель")]
        public Catalogs.ФизическиеЛица Исполнитель {get; set;}
        [Description1C8(Name = "ДолжностьИсполнителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьИсполнителя {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ДанныеОВремени", Comment = "", Synonym = "Данные о времени")]
        public List<ТабельУчетаРабочегоВремени_ДанныеОВремени> ТабельУчетаРабочегоВремениДанныеОВремени {get;set;}
        [Description1C8(Name = "СотрудникиСИсправлениями", Comment = "", Synonym = "Сотрудники с исправлениями")]
        public List<ТабельУчетаРабочегоВремени_СотрудникиСИсправлениями> ТабельУчетаРабочегоВремениСотрудникиСИсправлениями {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<ТабельУчетаРабочегоВремени_ФизическиеЛица> ТабельУчетаРабочегоВремениФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ДанныеОВремени", Comment = "", Synonym = "Данные о времени")]
    [Table("TabelUchetaRabochehoVremeny_DannyeOVremeny")]
    public class ТабельУчетаРабочегоВремени_ДанныеОВремени
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Часов1", Comment = "", Synonym = "Часов1")]
        // Format 5.2
        public decimal Часов1 {get; set;}
        [Description1C8(Name = "Часов2", Comment = "", Synonym = "Часов2")]
        // Format 5.2
        public decimal Часов2 {get; set;}
        [Description1C8(Name = "Часов3", Comment = "", Synonym = "Часов3")]
        // Format 5.2
        public decimal Часов3 {get; set;}
        [Description1C8(Name = "Часов4", Comment = "", Synonym = "Часов4")]
        // Format 5.2
        public decimal Часов4 {get; set;}
        [Description1C8(Name = "Часов5", Comment = "", Synonym = "Часов5")]
        // Format 5.2
        public decimal Часов5 {get; set;}
        [Description1C8(Name = "Часов6", Comment = "", Synonym = "Часов6")]
        // Format 5.2
        public decimal Часов6 {get; set;}
        [Description1C8(Name = "Часов7", Comment = "", Synonym = "Часов7")]
        // Format 5.2
        public decimal Часов7 {get; set;}
        [Description1C8(Name = "Часов8", Comment = "", Synonym = "Часов8")]
        // Format 5.2
        public decimal Часов8 {get; set;}
        [Description1C8(Name = "Часов9", Comment = "", Synonym = "Часов9")]
        // Format 5.2
        public decimal Часов9 {get; set;}
        [Description1C8(Name = "Часов10", Comment = "", Synonym = "Часов10")]
        // Format 5.2
        public decimal Часов10 {get; set;}
        [Description1C8(Name = "Часов11", Comment = "", Synonym = "Часов11")]
        // Format 5.2
        public decimal Часов11 {get; set;}
        [Description1C8(Name = "Часов12", Comment = "", Synonym = "Часов12")]
        // Format 5.2
        public decimal Часов12 {get; set;}
        [Description1C8(Name = "Часов13", Comment = "", Synonym = "Часов13")]
        // Format 5.2
        public decimal Часов13 {get; set;}
        [Description1C8(Name = "Часов14", Comment = "", Synonym = "Часов14")]
        // Format 5.2
        public decimal Часов14 {get; set;}
        [Description1C8(Name = "Часов15", Comment = "", Synonym = "Часов15")]
        // Format 5.2
        public decimal Часов15 {get; set;}
        [Description1C8(Name = "Часов16", Comment = "", Synonym = "Часов16")]
        // Format 5.2
        public decimal Часов16 {get; set;}
        [Description1C8(Name = "Часов17", Comment = "", Synonym = "Часов17")]
        // Format 5.2
        public decimal Часов17 {get; set;}
        [Description1C8(Name = "Часов18", Comment = "", Synonym = "Часов18")]
        // Format 5.2
        public decimal Часов18 {get; set;}
        [Description1C8(Name = "Часов19", Comment = "", Synonym = "Часов19")]
        // Format 5.2
        public decimal Часов19 {get; set;}
        [Description1C8(Name = "Часов20", Comment = "", Synonym = "Часов20")]
        // Format 5.2
        public decimal Часов20 {get; set;}
        [Description1C8(Name = "Часов21", Comment = "", Synonym = "Часов21")]
        // Format 5.2
        public decimal Часов21 {get; set;}
        [Description1C8(Name = "Часов22", Comment = "", Synonym = "Часов22")]
        // Format 5.2
        public decimal Часов22 {get; set;}
        [Description1C8(Name = "Часов23", Comment = "", Synonym = "Часов23")]
        // Format 5.2
        public decimal Часов23 {get; set;}
        [Description1C8(Name = "Часов24", Comment = "", Synonym = "Часов24")]
        // Format 5.2
        public decimal Часов24 {get; set;}
        [Description1C8(Name = "Часов25", Comment = "", Synonym = "Часов25")]
        // Format 5.2
        public decimal Часов25 {get; set;}
        [Description1C8(Name = "Часов26", Comment = "", Synonym = "Часов26")]
        // Format 5.2
        public decimal Часов26 {get; set;}
        [Description1C8(Name = "Часов27", Comment = "", Synonym = "Часов27")]
        // Format 5.2
        public decimal Часов27 {get; set;}
        [Description1C8(Name = "Часов28", Comment = "", Synonym = "Часов28")]
        // Format 5.2
        public decimal Часов28 {get; set;}
        [Description1C8(Name = "Часов29", Comment = "", Synonym = "Часов29")]
        // Format 5.2
        public decimal Часов29 {get; set;}
        [Description1C8(Name = "Часов30", Comment = "", Synonym = "Часов30")]
        // Format 5.2
        public decimal Часов30 {get; set;}
        [Description1C8(Name = "Часов31", Comment = "", Synonym = "Часов31")]
        // Format 5.2
        public decimal Часов31 {get; set;}
        [Description1C8(Name = "ВидВремени1", Comment = "", Synonym = "Вид времени1")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени1 {get; set;}
        [Description1C8(Name = "ВидВремени2", Comment = "", Synonym = "Вид времени2")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени2 {get; set;}
        [Description1C8(Name = "ВидВремени3", Comment = "", Synonym = "Вид времени3")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени3 {get; set;}
        [Description1C8(Name = "ВидВремени4", Comment = "", Synonym = "Вид времени4")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени4 {get; set;}
        [Description1C8(Name = "ВидВремени5", Comment = "", Synonym = "Вид времени5")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени5 {get; set;}
        [Description1C8(Name = "ВидВремени6", Comment = "", Synonym = "Вид времени6")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени6 {get; set;}
        [Description1C8(Name = "ВидВремени7", Comment = "", Synonym = "Вид времени7")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени7 {get; set;}
        [Description1C8(Name = "ВидВремени8", Comment = "", Synonym = "Вид времени8")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени8 {get; set;}
        [Description1C8(Name = "ВидВремени9", Comment = "", Synonym = "Вид времени9")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени9 {get; set;}
        [Description1C8(Name = "ВидВремени10", Comment = "", Synonym = "Вид времени10")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени10 {get; set;}
        [Description1C8(Name = "ВидВремени11", Comment = "", Synonym = "Вид времени11")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени11 {get; set;}
        [Description1C8(Name = "ВидВремени12", Comment = "", Synonym = "Вид времени12")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени12 {get; set;}
        [Description1C8(Name = "ВидВремени13", Comment = "", Synonym = "Вид времени13")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени13 {get; set;}
        [Description1C8(Name = "ВидВремени14", Comment = "", Synonym = "Вид времени14")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени14 {get; set;}
        [Description1C8(Name = "ВидВремени15", Comment = "", Synonym = "Вид времени15")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени15 {get; set;}
        [Description1C8(Name = "ВидВремени16", Comment = "", Synonym = "Вид времени16")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени16 {get; set;}
        [Description1C8(Name = "ВидВремени17", Comment = "", Synonym = "Вид времени17")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени17 {get; set;}
        [Description1C8(Name = "ВидВремени18", Comment = "", Synonym = "Вид времени18")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени18 {get; set;}
        [Description1C8(Name = "ВидВремени19", Comment = "", Synonym = "Вид времени19")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени19 {get; set;}
        [Description1C8(Name = "ВидВремени20", Comment = "", Synonym = "Вид времени20")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени20 {get; set;}
        [Description1C8(Name = "ВидВремени21", Comment = "", Synonym = "Вид времени21")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени21 {get; set;}
        [Description1C8(Name = "ВидВремени22", Comment = "", Synonym = "Вид времени22")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени22 {get; set;}
        [Description1C8(Name = "ВидВремени23", Comment = "", Synonym = "Вид времени23")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени23 {get; set;}
        [Description1C8(Name = "ВидВремени24", Comment = "", Synonym = "Вид времени24")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени24 {get; set;}
        [Description1C8(Name = "ВидВремени25", Comment = "", Synonym = "Вид времени25")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени25 {get; set;}
        [Description1C8(Name = "ВидВремени26", Comment = "", Synonym = "Вид времени26")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени26 {get; set;}
        [Description1C8(Name = "ВидВремени27", Comment = "", Synonym = "Вид времени27")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени27 {get; set;}
        [Description1C8(Name = "ВидВремени28", Comment = "", Synonym = "Вид времени28")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени28 {get; set;}
        [Description1C8(Name = "ВидВремени29", Comment = "", Synonym = "Вид времени29")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени29 {get; set;}
        [Description1C8(Name = "ВидВремени30", Comment = "", Synonym = "Вид времени30")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени30 {get; set;}
        [Description1C8(Name = "ВидВремени31", Comment = "", Synonym = "Вид времени31")]
        public Catalogs.ВидыИспользованияРабочегоВремени ВидВремени31 {get; set;}
        [Description1C8(Name = "Территория1", Comment = "", Synonym = "Территория1")]
        public Catalogs.ТерриторииВыполненияРабот Территория1 {get; set;}
        [Description1C8(Name = "Территория2", Comment = "", Synonym = "Территория2")]
        public Catalogs.ТерриторииВыполненияРабот Территория2 {get; set;}
        [Description1C8(Name = "Территория3", Comment = "", Synonym = "Территория3")]
        public Catalogs.ТерриторииВыполненияРабот Территория3 {get; set;}
        [Description1C8(Name = "Территория4", Comment = "", Synonym = "Территория4")]
        public Catalogs.ТерриторииВыполненияРабот Территория4 {get; set;}
        [Description1C8(Name = "Территория5", Comment = "", Synonym = "Территория5")]
        public Catalogs.ТерриторииВыполненияРабот Территория5 {get; set;}
        [Description1C8(Name = "Территория6", Comment = "", Synonym = "Территория6")]
        public Catalogs.ТерриторииВыполненияРабот Территория6 {get; set;}
        [Description1C8(Name = "Территория7", Comment = "", Synonym = "Территория7")]
        public Catalogs.ТерриторииВыполненияРабот Территория7 {get; set;}
        [Description1C8(Name = "Территория8", Comment = "", Synonym = "Территория8")]
        public Catalogs.ТерриторииВыполненияРабот Территория8 {get; set;}
        [Description1C8(Name = "Территория9", Comment = "", Synonym = "Территория9")]
        public Catalogs.ТерриторииВыполненияРабот Территория9 {get; set;}
        [Description1C8(Name = "Территория10", Comment = "", Synonym = "Территория10")]
        public Catalogs.ТерриторииВыполненияРабот Территория10 {get; set;}
        [Description1C8(Name = "Территория11", Comment = "", Synonym = "Территория11")]
        public Catalogs.ТерриторииВыполненияРабот Территория11 {get; set;}
        [Description1C8(Name = "Территория12", Comment = "", Synonym = "Территория12")]
        public Catalogs.ТерриторииВыполненияРабот Территория12 {get; set;}
        [Description1C8(Name = "Территория13", Comment = "", Synonym = "Территория13")]
        public Catalogs.ТерриторииВыполненияРабот Территория13 {get; set;}
        [Description1C8(Name = "Территория14", Comment = "", Synonym = "Территория14")]
        public Catalogs.ТерриторииВыполненияРабот Территория14 {get; set;}
        [Description1C8(Name = "Территория15", Comment = "", Synonym = "Территория15")]
        public Catalogs.ТерриторииВыполненияРабот Территория15 {get; set;}
        [Description1C8(Name = "Территория16", Comment = "", Synonym = "Территория16")]
        public Catalogs.ТерриторииВыполненияРабот Территория16 {get; set;}
        [Description1C8(Name = "Территория17", Comment = "", Synonym = "Территория17")]
        public Catalogs.ТерриторииВыполненияРабот Территория17 {get; set;}
        [Description1C8(Name = "Территория18", Comment = "", Synonym = "Территория18")]
        public Catalogs.ТерриторииВыполненияРабот Территория18 {get; set;}
        [Description1C8(Name = "Территория19", Comment = "", Synonym = "Территория19")]
        public Catalogs.ТерриторииВыполненияРабот Территория19 {get; set;}
        [Description1C8(Name = "Территория20", Comment = "", Synonym = "Территория20")]
        public Catalogs.ТерриторииВыполненияРабот Территория20 {get; set;}
        [Description1C8(Name = "Территория21", Comment = "", Synonym = "Территория21")]
        public Catalogs.ТерриторииВыполненияРабот Территория21 {get; set;}
        [Description1C8(Name = "Территория22", Comment = "", Synonym = "Территория22")]
        public Catalogs.ТерриторииВыполненияРабот Территория22 {get; set;}
        [Description1C8(Name = "Территория23", Comment = "", Synonym = "Территория23")]
        public Catalogs.ТерриторииВыполненияРабот Территория23 {get; set;}
        [Description1C8(Name = "Территория24", Comment = "", Synonym = "Территория24")]
        public Catalogs.ТерриторииВыполненияРабот Территория24 {get; set;}
        [Description1C8(Name = "Территория25", Comment = "", Synonym = "Территория25")]
        public Catalogs.ТерриторииВыполненияРабот Территория25 {get; set;}
        [Description1C8(Name = "Территория26", Comment = "", Synonym = "Территория26")]
        public Catalogs.ТерриторииВыполненияРабот Территория26 {get; set;}
        [Description1C8(Name = "Территория27", Comment = "", Synonym = "Территория27")]
        public Catalogs.ТерриторииВыполненияРабот Территория27 {get; set;}
        [Description1C8(Name = "Территория28", Comment = "", Synonym = "Территория28")]
        public Catalogs.ТерриторииВыполненияРабот Территория28 {get; set;}
        [Description1C8(Name = "Территория29", Comment = "", Synonym = "Территория29")]
        public Catalogs.ТерриторииВыполненияРабот Территория29 {get; set;}
        [Description1C8(Name = "Территория30", Comment = "", Synonym = "Территория30")]
        public Catalogs.ТерриторииВыполненияРабот Территория30 {get; set;}
        [Description1C8(Name = "Территория31", Comment = "", Synonym = "Территория31")]
        public Catalogs.ТерриторииВыполненияРабот Территория31 {get; set;}
        [Description1C8(Name = "УсловияТруда1", Comment = "", Synonym = "Условия труда1")]
        public Catalogs.УсловияТруда УсловияТруда1 {get; set;}
        [Description1C8(Name = "УсловияТруда2", Comment = "", Synonym = "Условия труда2")]
        public Catalogs.УсловияТруда УсловияТруда2 {get; set;}
        [Description1C8(Name = "УсловияТруда3", Comment = "", Synonym = "Условия труда3")]
        public Catalogs.УсловияТруда УсловияТруда3 {get; set;}
        [Description1C8(Name = "УсловияТруда4", Comment = "", Synonym = "Условия труда4")]
        public Catalogs.УсловияТруда УсловияТруда4 {get; set;}
        [Description1C8(Name = "УсловияТруда5", Comment = "", Synonym = "Условия труда5")]
        public Catalogs.УсловияТруда УсловияТруда5 {get; set;}
        [Description1C8(Name = "УсловияТруда6", Comment = "", Synonym = "Условия труда6")]
        public Catalogs.УсловияТруда УсловияТруда6 {get; set;}
        [Description1C8(Name = "УсловияТруда7", Comment = "", Synonym = "Условия труда7")]
        public Catalogs.УсловияТруда УсловияТруда7 {get; set;}
        [Description1C8(Name = "УсловияТруда8", Comment = "", Synonym = "Условия труда8")]
        public Catalogs.УсловияТруда УсловияТруда8 {get; set;}
        [Description1C8(Name = "УсловияТруда9", Comment = "", Synonym = "Условия труда9")]
        public Catalogs.УсловияТруда УсловияТруда9 {get; set;}
        [Description1C8(Name = "УсловияТруда10", Comment = "", Synonym = "Условия труда10")]
        public Catalogs.УсловияТруда УсловияТруда10 {get; set;}
        [Description1C8(Name = "УсловияТруда11", Comment = "", Synonym = "Условия труда11")]
        public Catalogs.УсловияТруда УсловияТруда11 {get; set;}
        [Description1C8(Name = "УсловияТруда12", Comment = "", Synonym = "Условия труда12")]
        public Catalogs.УсловияТруда УсловияТруда12 {get; set;}
        [Description1C8(Name = "УсловияТруда13", Comment = "", Synonym = "Условия труда13")]
        public Catalogs.УсловияТруда УсловияТруда13 {get; set;}
        [Description1C8(Name = "УсловияТруда14", Comment = "", Synonym = "Условия труда14")]
        public Catalogs.УсловияТруда УсловияТруда14 {get; set;}
        [Description1C8(Name = "УсловияТруда15", Comment = "", Synonym = "Условия труда15")]
        public Catalogs.УсловияТруда УсловияТруда15 {get; set;}
        [Description1C8(Name = "УсловияТруда16", Comment = "", Synonym = "Условия труда16")]
        public Catalogs.УсловияТруда УсловияТруда16 {get; set;}
        [Description1C8(Name = "УсловияТруда17", Comment = "", Synonym = "Условия труда17")]
        public Catalogs.УсловияТруда УсловияТруда17 {get; set;}
        [Description1C8(Name = "УсловияТруда18", Comment = "", Synonym = "Условия труда18")]
        public Catalogs.УсловияТруда УсловияТруда18 {get; set;}
        [Description1C8(Name = "УсловияТруда19", Comment = "", Synonym = "Условия труда19")]
        public Catalogs.УсловияТруда УсловияТруда19 {get; set;}
        [Description1C8(Name = "УсловияТруда20", Comment = "", Synonym = "Условия труда20")]
        public Catalogs.УсловияТруда УсловияТруда20 {get; set;}
        [Description1C8(Name = "УсловияТруда21", Comment = "", Synonym = "Условия труда21")]
        public Catalogs.УсловияТруда УсловияТруда21 {get; set;}
        [Description1C8(Name = "УсловияТруда22", Comment = "", Synonym = "Условия труда22")]
        public Catalogs.УсловияТруда УсловияТруда22 {get; set;}
        [Description1C8(Name = "УсловияТруда23", Comment = "", Synonym = "Условия труда23")]
        public Catalogs.УсловияТруда УсловияТруда23 {get; set;}
        [Description1C8(Name = "УсловияТруда24", Comment = "", Synonym = "Условия труда24")]
        public Catalogs.УсловияТруда УсловияТруда24 {get; set;}
        [Description1C8(Name = "УсловияТруда25", Comment = "", Synonym = "Условия труда25")]
        public Catalogs.УсловияТруда УсловияТруда25 {get; set;}
        [Description1C8(Name = "УсловияТруда26", Comment = "", Synonym = "Условия труда26")]
        public Catalogs.УсловияТруда УсловияТруда26 {get; set;}
        [Description1C8(Name = "УсловияТруда27", Comment = "", Synonym = "Условия труда27")]
        public Catalogs.УсловияТруда УсловияТруда27 {get; set;}
        [Description1C8(Name = "УсловияТруда28", Comment = "", Synonym = "Условия труда28")]
        public Catalogs.УсловияТруда УсловияТруда28 {get; set;}
        [Description1C8(Name = "УсловияТруда29", Comment = "", Synonym = "Условия труда29")]
        public Catalogs.УсловияТруда УсловияТруда29 {get; set;}
        [Description1C8(Name = "УсловияТруда30", Comment = "", Synonym = "Условия труда30")]
        public Catalogs.УсловияТруда УсловияТруда30 {get; set;}
        [Description1C8(Name = "УсловияТруда31", Comment = "", Synonym = "Условия труда31")]
        public Catalogs.УсловияТруда УсловияТруда31 {get; set;}
    }
    [Description1C8(Name = "СотрудникиСИсправлениями", Comment = "", Synonym = "Сотрудники с исправлениями")]
    [Table("TabelUchetaRabochehoVremeny_SotrudnykySYspravlenyiamy")]
    public class ТабельУчетаРабочегоВремени_СотрудникиСИсправлениями
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("TabelUchetaRabochehoVremeny_FyzycheskyeLytsa")]
    public class ТабельУчетаРабочегоВремени_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
