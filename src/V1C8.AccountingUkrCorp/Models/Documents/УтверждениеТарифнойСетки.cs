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
    [Table("UtverzhdenyeTaryfnoiSetky")]
    [Description1C8(Name = "УтверждениеТарифнойСетки", Comment = "", Synonym = "Утверждение тарифной группы")]
    public class УтверждениеТарифнойСетки:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ТарифнаяСетка", Comment = "", Synonym = "Тарифная группа")]
        public Catalogs.ТарифныеСетки ТарифнаяСетка {get; set;}
        [Description1C8(Name = "ДатаВступленияВСилу", Comment = "", Synonym = "Дата вступления в силу")]
        public DateTime ДатаВступленияВСилу {get; set;}
        [Description1C8(Name = "НеобходимРасчетФОТ", Comment = "", Synonym = "Необходим расчет ФОТ")]
        public bool НеобходимРасчетФОТ {get; set;}
        [Description1C8(Name = "БазовыйТарифГруппы", Comment = "", Synonym = "Базовый тариф")]
        // Format 10.2
        public decimal БазовыйТарифГруппы {get; set;}
        [Description1C8(Name = "ВидТарифнойСетки", Comment = "", Synonym = "Вид тарифной сетки")]
        public Enums.ВидыТарифныхСеток ВидТарифнойСетки {get; set;}
        [Description1C8(Name = "СпособОкругления", Comment = "", Synonym = "Округление")]
        public Catalogs.СпособыОкругленияПриРасчетеЗарплаты СпособОкругления {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Тарифы", Comment = "", Synonym = "Тарифы")]
        public List<УтверждениеТарифнойСетки_Тарифы> УтверждениеТарифнойСеткиТарифы {get;set;}
        [Description1C8(Name = "УдалитьНачисленияСотрудников", Comment = "", Synonym = "(не используется) Начисления сотрудников")]
        public List<УтверждениеТарифнойСетки_УдалитьНачисленияСотрудников> УтверждениеТарифнойСеткиУдалитьНачисленияСотрудников {get;set;}
        [Description1C8(Name = "УдалитьПоказатели", Comment = "", Synonym = "(не используется) Показатели")]
        public List<УтверждениеТарифнойСетки_УдалитьПоказатели> УтверждениеТарифнойСеткиУдалитьПоказатели {get;set;}
        [Description1C8(Name = "УдалитьШтатноеРасписание", Comment = "", Synonym = "(не используется) Штатное расписание")]
        public List<УтверждениеТарифнойСетки_УдалитьШтатноеРасписание> УтверждениеТарифнойСеткиУдалитьШтатноеРасписание {get;set;}
        [Description1C8(Name = "УдалитьПересчетТарифныхСтавок", Comment = "", Synonym = "(не используется) Пересчет тарифных ставок")]
        public List<УтверждениеТарифнойСетки_УдалитьПересчетТарифныхСтавок> УтверждениеТарифнойСеткиУдалитьПересчетТарифныхСтавок {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Тарифы", Comment = "", Synonym = "Тарифы")]
    [Table("UtverzhdenyeTaryfnoiSetky_Taryfy")]
    public class УтверждениеТарифнойСетки_Тарифы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "РазрядКатегория", Comment = "", Synonym = "Разряд (категория)")]
        public Catalogs.РазрядыКатегорииДолжностей РазрядКатегория {get; set;}
        [Description1C8(Name = "РазрядныйКоэффициент", Comment = "", Synonym = "Разрядный коэффициент")]
        // Format 15.4
        public decimal РазрядныйКоэффициент {get; set;}
        [Description1C8(Name = "Тариф", Comment = "", Synonym = "Тариф")]
        // Format 15.4
        public decimal Тариф {get; set;}
        [Description1C8(Name = "Отменить", Comment = "", Synonym = "Отменить")]
        public bool Отменить {get; set;}
    }
    [Description1C8(Name = "УдалитьНачисленияСотрудников", Comment = "", Synonym = "(не используется) Начисления сотрудников")]
    [Table("UtverzhdenyeTaryfnoiSetky_UdalytNachyslenyiaSotrudnykov")]
    public class УтверждениеТарифнойСетки_УдалитьНачисленияСотрудников
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "Размер", Comment = "", Synonym = "Вклад в ФОТ")]
        // Format 15.2
        public decimal Размер {get; set;}
    }
    [Description1C8(Name = "УдалитьПоказатели", Comment = "", Synonym = "(не используется) Показатели")]
    [Table("UtverzhdenyeTaryfnoiSetky_UdalytPokazately")]
    public class УтверждениеТарифнойСетки_УдалитьПоказатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
    }
    [Description1C8(Name = "УдалитьШтатноеРасписание", Comment = "", Synonym = "(не используется) Штатное расписание")]
    [Table("UtverzhdenyeTaryfnoiSetky_UdalytShtatnoeRaspysanye")]
    public class УтверждениеТарифнойСетки_УдалитьШтатноеРасписание
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Позиция", Comment = "", Synonym = "Позиция")]
        public Catalogs.ШтатноеРасписание Позиция {get; set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
        [Description1C8(Name = "ЗначениеМин", Comment = "", Synonym = "Значение (мин)")]
        // Format 15.4
        public decimal ЗначениеМин {get; set;}
        [Description1C8(Name = "ЗначениеМакс", Comment = "", Synonym = "Значение (макс)")]
        // Format 15.4
        public decimal ЗначениеМакс {get; set;}
        [Description1C8(Name = "РазрядКатегория", Comment = "", Synonym = "Разряд (категория)")]
        public Catalogs.РазрядыКатегорииДолжностей РазрядКатегория {get; set;}
    }
    [Description1C8(Name = "УдалитьПересчетТарифныхСтавок", Comment = "", Synonym = "(не используется) Пересчет тарифных ставок")]
    [Table("UtverzhdenyeTaryfnoiSetky_UdalytPereschetTaryfnykhStavok")]
    public class УтверждениеТарифнойСетки_УдалитьПересчетТарифныхСтавок
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.Сотрудники Сотрудник {get; set;}
        [Description1C8(Name = "СовокупнаяТарифнаяСтавка", Comment = "", Synonym = "Совокупная тарифная ставка")]
        // Format 15.2
        public decimal СовокупнаяТарифнаяСтавка {get; set;}
        [Description1C8(Name = "ВидТарифнойСтавки", Comment = "", Synonym = "Вид тарифной ставки")]
        public Enums.ВидыТарифныхСтавок ВидТарифнойСтавки {get; set;}
    }
}
