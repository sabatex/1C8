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
    [Table("YndeksatsyiaShtatnohoRaspysanyia")]
    [Description1C8(Name = "ИндексацияШтатногоРасписания", Comment = "", Synonym = "Индексация штатного расписания")]
    public class ИндексацияШтатногоРасписания:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "МесяцИндексации", Comment = "", Synonym = "Месяц индексации")]
        public DateTime МесяцИндексации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "КоэффициентИндексации", Comment = "", Synonym = "Коэффициент индексации")]
        // Format 5.4
        public decimal КоэффициентИндексации {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "УстановитьБазовыйПериод", Comment = "", Synonym = "Установить базовый период")]
        public bool УстановитьБазовыйПериод {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ИндексируемыеПоказатели", Comment = "", Synonym = "Индексируемые показатели")]
        public List<ИндексацияШтатногоРасписания_ИндексируемыеПоказатели> ИндексацияШтатногоРасписанияИндексируемыеПоказатели {get;set;}
        [Description1C8(Name = "Позиции", Comment = "", Synonym = "Позиции")]
        public List<ИндексацияШтатногоРасписания_Позиции> ИндексацияШтатногоРасписанияПозиции {get;set;}
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<ИндексацияШтатногоРасписания_Начисления> ИндексацияШтатногоРасписанияНачисления {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<ИндексацияШтатногоРасписания_Показатели> ИндексацияШтатногоРасписанияПоказатели {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ИндексируемыеПоказатели", Comment = "", Synonym = "Индексируемые показатели")]
    [Table("YndeksatsyiaShtatnohoRaspysanyia_YndeksyruemyePokazately")]
    public class ИндексацияШтатногоРасписания_ИндексируемыеПоказатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "СпособОкругления", Comment = "", Synonym = "Округление")]
        public Catalogs.СпособыОкругленияПриРасчетеЗарплаты СпособОкругления {get; set;}
    }
    [Description1C8(Name = "Позиции", Comment = "", Synonym = "Позиции")]
    [Table("YndeksatsyiaShtatnohoRaspysanyia_Pozytsyy")]
    public class ИндексацияШтатногоРасписания_Позиции
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ПозицияШтатногоРасписания", Comment = "", Synonym = "Позиция штатного расписания")]
        public Catalogs.ШтатноеРасписание ПозицияШтатногоРасписания {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиПозиции", Comment = "", Synonym = "Идентификатор строки позиции")]
        // Format 5.0
        public long ИдентификаторСтрокиПозиции {get; set;}
        [Description1C8(Name = "ОкладТариф", Comment = "", Synonym = "Оклад (тариф)")]
        // Format 15.3
        public decimal ОкладТариф {get; set;}
        [Description1C8(Name = "ОкладТарифМин", Comment = "", Synonym = "Оклад (тариф), мин")]
        // Format 15.3
        public decimal ОкладТарифМин {get; set;}
        [Description1C8(Name = "ОкладТарифМакс", Comment = "", Synonym = "Оклад (тариф), макс")]
        // Format 15.3
        public decimal ОкладТарифМакс {get; set;}
        [Description1C8(Name = "ФОТ", Comment = "", Synonym = "ФОТ")]
        // Format 19.2
        public decimal ФОТ {get; set;}
        [Description1C8(Name = "ФОТМин", Comment = "", Synonym = "ФОТ, мин.")]
        // Format 19.2
        public decimal ФОТМин {get; set;}
        [Description1C8(Name = "ФОТМакс", Comment = "", Synonym = "ФОТ, макс.")]
        // Format 19.2
        public decimal ФОТМакс {get; set;}
        [Description1C8(Name = "НадбавкаЗаВредностьРазмер", Comment = "", Synonym = "Надбавка за вредность размер")]
        // Format 15.2
        public decimal НадбавкаЗаВредностьРазмер {get; set;}
        [Description1C8(Name = "НадбавкаЗаВредностьРазмерМин", Comment = "", Synonym = "Надбавка за вредность размер мин")]
        // Format 15.2
        public decimal НадбавкаЗаВредностьРазмерМин {get; set;}
        [Description1C8(Name = "НадбавкаЗаВредностьРазмерМакс", Comment = "", Synonym = "Надбавка за вредность размер макс")]
        // Format 15.2
        public decimal НадбавкаЗаВредностьРазмерМакс {get; set;}
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("YndeksatsyiaShtatnohoRaspysanyia_Nachyslenyia")]
    public class ИндексацияШтатногоРасписания_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтрокиПозиции", Comment = "", Synonym = "Идентификатор строки позиции")]
        // Format 5.0
        public long ИдентификаторСтрокиПозиции {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Вклад в ФОТ")]
        // Format 15.2
        public decimal Размер {get; set;}
        [Description1C8(Name = "РазмерМин", Comment = "", Synonym = "Вклад в ФОТ мин.")]
        // Format 15.2
        public decimal РазмерМин {get; set;}
        [Description1C8(Name = "РазмерМакс", Comment = "", Synonym = "Вклад в ФОТ макс.")]
        // Format 15.2
        public decimal РазмерМакс {get; set;}
    }
    [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
    [Table("YndeksatsyiaShtatnohoRaspysanyia_Pokazately")]
    public class ИндексацияШтатногоРасписания_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтрокиПозиции", Comment = "", Synonym = "Идентификатор строки позиции")]
        // Format 5.0
        public long ИдентификаторСтрокиПозиции {get; set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
        [Description1C8(Name = "ЗначениеМин", Comment = "", Synonym = "Значение (мин.)")]
        // Format 15.4
        public decimal ЗначениеМин {get; set;}
        [Description1C8(Name = "ЗначениеМакс", Comment = "", Synonym = "Значение (макс.)")]
        // Format 15.4
        public decimal ЗначениеМакс {get; set;}
    }
}
