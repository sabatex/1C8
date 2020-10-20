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
    [Table("VozvratYzOtpuskaPoUkhoduZaRebenkom")]
    [Description1C8(Name = "ВозвратИзОтпускаПоУходуЗаРебенком", Comment = "", Synonym = "Возврат из отпуска по уходу")]
    public class ВозвратИзОтпускаПоУходуЗаРебенком:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица Сотрудник {get; set;}
        [Description1C8(Name = "ОсновнойСотрудник", Comment = "", Synonym = "Основной сотрудник")]
        public Catalogs.Сотрудники ОсновнойСотрудник {get; set;}
        [Description1C8(Name = "ДатаВозврата", Comment = "", Synonym = "Дата возврата")]
        public DateTime ДатаВозврата {get; set;}
        [Description1C8(Name = "ДокументОснование", Comment = "", Synonym = "Документ основание")]
        public Документ.ОтпускПоУходуЗаРебенком ДокументОснование {get; set;}
        [Description1C8(Name = "ИзменитьНачисления", Comment = "", Synonym = "Изменить начисления")]
        public bool ИзменитьНачисления {get; set;}
        [Description1C8(Name = "ИзменитьАванс", Comment = "", Synonym = "Изменить аванс")]
        public bool ИзменитьАванс {get; set;}
        [Description1C8(Name = "НачисленияУтверждены", Comment = "", Synonym = "Начисления утверждены")]
        public bool НачисленияУтверждены {get; set;}
        [Description1C8(Name = "ЗаниматьСтавку", Comment = "", Synonym = "Занимать ставку")]
        public bool ЗаниматьСтавку {get; set;}
        [Description1C8(Name = "ИсправленныйДокумент", Comment = "", Synonym = "Исправленный документ")]
        public Документ.ВозвратИзОтпускаПоУходуЗаРебенком ИсправленныйДокумент {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "ГлавныйБухгалтер", Comment = "", Synonym = "Главный бухгалтер")]
        public Catalogs.ФизическиеЛица ГлавныйБухгалтер {get; set;}
        [Description1C8(Name = "РуководительКадровойСлужбы", Comment = "", Synonym = "Руководитель кадровой службы")]
        public Catalogs.ФизическиеЛица РуководительКадровойСлужбы {get; set;}
        [Description1C8(Name = "ДолжностьРуководителяКадровойСлужбы", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителяКадровойСлужбы {get; set;}
        [Description1C8(Name = "ИзменитьЛьготы", Comment = "", Synonym = "Изменить льготы")]
        public bool ИзменитьЛьготы {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<ВозвратИзОтпускаПоУходуЗаРебенком_Начисления> ВозвратИзОтпускаПоУходуЗаРебенкомНачисления {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<ВозвратИзОтпускаПоУходуЗаРебенком_Показатели> ВозвратИзОтпускаПоУходуЗаРебенкомПоказатели {get;set;}
        [Description1C8(Name = "Авансы", Comment = "", Synonym = "Авансы")]
        public List<ВозвратИзОтпускаПоУходуЗаРебенком_Авансы> ВозвратИзОтпускаПоУходуЗаРебенкомАвансы {get;set;}
        [Description1C8(Name = "ПересчетТарифныхСтавок", Comment = "", Synonym = "Пересчет тарифных ставок")]
        public List<ВозвратИзОтпускаПоУходуЗаРебенком_ПересчетТарифныхСтавок> ВозвратИзОтпускаПоУходуЗаРебенкомПересчетТарифныхСтавок {get;set;}
        [Description1C8(Name = "Льготы", Comment = "", Synonym = "Льготы")]
        public List<ВозвратИзОтпускаПоУходуЗаРебенком_Льготы> ВозвратИзОтпускаПоУходуЗаРебенкомЛьготы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("VozvratYzOtpuskaPoUkhoduZaRebenkom_Nachyslenyia")]
    public class ВозвратИзОтпускаПоУходуЗаРебенком_Начисления
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
    [Table("VozvratYzOtpuskaPoUkhoduZaRebenkom_Pokazately")]
    public class ВозвратИзОтпускаПоУходуЗаРебенком_Показатели
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
    [Table("VozvratYzOtpuskaPoUkhoduZaRebenkom_Avansy")]
    public class ВозвратИзОтпускаПоУходуЗаРебенком_Авансы
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
    [Description1C8(Name = "ПересчетТарифныхСтавок", Comment = "", Synonym = "Пересчет тарифных ставок")]
    [Table("VozvratYzOtpuskaPoUkhoduZaRebenkom_PereschetTaryfnykhStavok")]
    public class ВозвратИзОтпускаПоУходуЗаРебенком_ПересчетТарифныхСтавок
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
    [Table("VozvratYzOtpuskaPoUkhoduZaRebenkom_Lhoty")]
    public class ВозвратИзОтпускаПоУходуЗаРебенком_Льготы
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
