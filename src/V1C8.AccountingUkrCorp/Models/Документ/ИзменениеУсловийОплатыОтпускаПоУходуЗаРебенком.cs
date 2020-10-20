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
    [Table("YzmenenyeUslovyiOplatyOtpuskaPoUkhoduZaRebenkom")]
    [Description1C8(Name = "ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком", Comment = "", Synonym = "Изменение условий отпуска по уходу за ребенком")]
    public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица Сотрудник {get; set;}
        [Description1C8(Name = "ОсновнойСотрудник", Comment = "", Synonym = "Основной сотрудник")]
        public Catalogs.Сотрудники ОсновнойСотрудник {get; set;}
        [Description1C8(Name = "ДатаИзменения", Comment = "", Synonym = "Дата изменения")]
        public DateTime ДатаИзменения {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
        [Description1C8(Name = "ДатаОкончанияПособияДоТрехЛет", Comment = "", Synonym = "Дата окончания пособия до трех лет")]
        public DateTime ДатаОкончанияПособияДоТрехЛет {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.ОтпускПоУходуЗаРебенком ДокументОснование {get; set;}
        [Description1C8(Name = "ВыплачиватьПособиеДоТрехЛет", Comment = "", Synonym = "Выплачивать пособие до трех лет")]
        public bool ВыплачиватьПособиеДоТрехЛет {get; set;}
        [Description1C8(Name = "ПособиеДоТрехЛет", Comment = "", Synonym = "Пособие до трех лет")]
        public ПланВидовРасчета.Начисления ПособиеДоТрехЛет {get; set;}
        [Description1C8(Name = "ИзменитьНачисления", Comment = "", Synonym = "Изменить начисления")]
        public bool ИзменитьНачисления {get; set;}
        [Description1C8(Name = "ИзменитьАванс", Comment = "", Synonym = "Изменить аванс")]
        public bool ИзменитьАванс {get; set;}
        [Description1C8(Name = "ИзменитьПрименениеПлановыхНачислений", Comment = "", Synonym = "Изменить применение плановых начислений")]
        public bool ИзменитьПрименениеПлановыхНачислений {get; set;}
        [Description1C8(Name = "НачисленияУтверждены", Comment = "", Synonym = "Начисления утверждены")]
        public bool НачисленияУтверждены {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "ИзменитьЛьготы", Comment = "", Synonym = "Изменить льготы")]
        public bool ИзменитьЛьготы {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ВидОтпуска", Comment = "", Synonym = "Вид отпуска")]
        public Enums.КатегорииНачисленийИНеоплаченногоВремени ВидОтпуска {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком_Начисления> ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомНачисления {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком_Показатели> ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомПоказатели {get;set;}
        [Description1C8(Name = "Авансы", Comment = "", Synonym = "Авансы")]
        public List<ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком_Авансы> ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомАвансы {get;set;}
        [Description1C8(Name = "ПрименениеПлановыхНачислений", Comment = "", Synonym = "Применение плановых начислений")]
        public List<ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком_ПрименениеПлановыхНачислений> ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомПрименениеПлановыхНачислений {get;set;}
        [Description1C8(Name = "ПересчетТарифныхСтавок", Comment = "", Synonym = "Пересчет тарифных ставок")]
        public List<ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком_ПересчетТарифныхСтавок> ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомПересчетТарифныхСтавок {get;set;}
        [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
        public List<ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком_Льготы> ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенкомЛьготы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("YzmenenyeUslovyiOplatyOtpuskaPoUkhoduZaRebenkom_Nachyslenyia")]
    public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "РабочееМесто", Comment = "", Synonym = "Рабочее место")]
        public Catalogs.Сотрудники РабочееМесто {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Вклад в ФОТ")]
        // Format 15.2
        public decimal Размер {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("YzmenenyeUslovyiOplatyOtpuskaPoUkhoduZaRebenkom_Pokazately")]
    public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
        [Description1C8(Name = "РабочееМесто", Comment = "", Synonym = "Рабочее место")]
        public Catalogs.Сотрудники РабочееМесто {get; set;}
    }
    [Description1C8(Name = "Авансы", Comment = "", Synonym = "Авансы")]
    [Table("YzmenenyeUslovyiOplatyOtpuskaPoUkhoduZaRebenkom_Avansy")]
    public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком_Авансы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "РабочееМесто", Comment = "", Synonym = "Рабочее место")]
        public Catalogs.Сотрудники РабочееМесто {get; set;}
        [Description1C8(Name = "СпособРасчетаАванса", Comment = "", Synonym = "Способ расчета аванса")]
        public Enums.СпособыРасчетаАванса СпособРасчетаАванса {get; set;}
        [Description1C8(Name = "Аванс", Comment = "", Synonym = "Аванс")]
        // Format 15.2
        public decimal Аванс {get; set;}
    }
    [Description1C8(Name = "ПрименениеПлановыхНачислений", Comment = "", Synonym = "Применение плановых начислений")]
    [Table("YzmenenyeUslovyiOplatyOtpuskaPoUkhoduZaRebenkom_PrymenenyePlanovykhNachyslenyi")]
    public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком_ПрименениеПлановыхНачислений
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "РабочееМесто", Comment = "", Synonym = "Рабочее место")]
        public Catalogs.Сотрудники РабочееМесто {get; set;}
        [Description1C8(Name = "Применение", Comment = "", Synonym = "Применение")]
        public bool Применение {get; set;}
    }
    [Description1C8(Name = "ПересчетТарифныхСтавок", Comment = "", Synonym = "Пересчет тарифных ставок")]
    [Table("YzmenenyeUslovyiOplatyOtpuskaPoUkhoduZaRebenkom_PereschetTaryfnykhStavok")]
    public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком_ПересчетТарифныхСтавок
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "РабочееМесто", Comment = "", Synonym = "Рабочее место")]
        public Catalogs.Сотрудники РабочееМесто {get; set;}
        [Description1C8(Name = "ПорядокРасчетаСтоимостиЕдиницыВремени", Comment = "", Synonym = "Порядок расчета стоимости единицы времени")]
        public Enums.ПорядокРасчетаСтоимостиЕдиницыВремениОплатыТруда ПорядокРасчетаСтоимостиЕдиницыВремени {get; set;}
        [Description1C8(Name = "СовокупнаяТарифнаяСтавка", Comment = "", Synonym = "Совокупная тарифная ставка")]
        // Format 15.2
        public decimal СовокупнаяТарифнаяСтавка {get; set;}
        [Description1C8(Name = "ВидТарифнойСтавки", Comment = "", Synonym = "Вид тарифной ставки")]
        public Enums.ВидыТарифныхСтавок ВидТарифнойСтавки {get; set;}
    }
    [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
    [Table("YzmenenyeUslovyiOplatyOtpuskaPoUkhoduZaRebenkom_Lhoty")]
    public class ИзменениеУсловийОплатыОтпускаПоУходуЗаРебенком_Льготы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
        [Description1C8(Name = "Льгота", Comment = "", Synonym = "Льгота")]
        public ПланВидовРасчета.Начисления Льгота {get; set;}
        [Description1C8(Name = "РабочееМесто", Comment = "", Synonym = "Рабочее место")]
        public Catalogs.Сотрудники РабочееМесто {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.НазначениеПлановогоНачисления ДокументОснование {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Размер")]
        // Format 15.2
        public decimal Размер {get; set;}
    }
}
