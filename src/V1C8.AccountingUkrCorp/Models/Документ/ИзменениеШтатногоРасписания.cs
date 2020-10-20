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
    [Table("YzmenenyeShtatnohoRaspysanyia")]
    [Description1C8(Name = "ИзменениеШтатногоРасписания", Comment = "", Synonym = "Изменение штатного расписания")]
    public class ИзменениеШтатногоРасписания:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ДатаВступленияВСилу", Comment = "", Synonym = "Дата изменений")]
        public DateTime ДатаВступленияВСилу {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "Руководитель", Comment = "", Synonym = "Руководитель")]
        public Catalogs.ФизическиеЛица Руководитель {get; set;}
        [Description1C8(Name = "ДолжностьРуководителя", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителя {get; set;}
        [Description1C8(Name = "РуководительКадровойСлужбы", Comment = "", Synonym = "Руководитель кадровой службы")]
        public Catalogs.ФизическиеЛица РуководительКадровойСлужбы {get; set;}
        [Description1C8(Name = "ДолжностьРуководителяКадровойСлужбы", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности ДолжностьРуководителяКадровойСлужбы {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Позиции", Comment = "", Synonym = "Позиции")]
        public List<ИзменениеШтатногоРасписания_Позиции> ИзменениеШтатногоРасписанияПозиции {get;set;}
        [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
        public List<ИзменениеШтатногоРасписания_Начисления> ИзменениеШтатногоРасписанияНачисления {get;set;}
        [Description1C8(Name = "Показатели", Comment = "", Synonym = "Показатели")]
        public List<ИзменениеШтатногоРасписания_Показатели> ИзменениеШтатногоРасписанияПоказатели {get;set;}
        [Description1C8(Name = "ЕжегодныеОтпуска", Comment = "", Synonym = "Ежегодные отпуска")]
        public List<ИзменениеШтатногоРасписания_ЕжегодныеОтпуска> ИзменениеШтатногоРасписанияЕжегодныеОтпуска {get;set;}
        [Description1C8(Name = "Специальности", Comment = "", Synonym = "Специальности")]
        public List<ИзменениеШтатногоРасписания_Специальности> ИзменениеШтатногоРасписанияСпециальности {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Позиции", Comment = "", Synonym = "Позиции")]
    [Table("YzmenenyeShtatnohoRaspysanyia_Pozytsyy")]
    public class ИзменениеШтатногоРасписания_Позиции
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Должность", Comment = "", Synonym = "Должность")]
        public Catalogs.Должности Должность {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "РазрядКатегория", Comment = "", Synonym = "Разряд (категория)")]
        public Catalogs.РазрядыКатегорииДолжностей РазрядКатегория {get; set;}
        [Description1C8(Name = "Позиция", Comment = "", Synonym = "Позиция")]
        public Catalogs.ШтатноеРасписание Позиция {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиПозиции", Comment = "", Synonym = "Идентификатор строки позиции")]
        // Format 5.0
        public long ИдентификаторСтрокиПозиции {get; set;}
        [Description1C8(Name = "КоличествоСтавок", Comment = "", Synonym = "Количество ставок")]
        // Format 7.2
        public decimal КоличествоСтавок {get; set;}
        [Description1C8(Name = "ОкладТариф", Comment = "", Synonym = "Оклад (тариф)")]
        // Format 15.3
        public decimal ОкладТариф {get; set;}
        [Description1C8(Name = "ОкладТарифМин", Comment = "", Synonym = "Оклад (тариф), мин")]
        // Format 15.3
        public decimal ОкладТарифМин {get; set;}
        [Description1C8(Name = "ОкладТарифМакс", Comment = "", Synonym = "Оклад (тариф), макс")]
        // Format 15.3
        public decimal ОкладТарифМакс {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСПозициямиШтатногоРасписания Действие {get; set;}
        [Description1C8(Name = "ГрафикРаботыСотрудников", Comment = "", Synonym = "График работы")]
        public Catalogs.ГрафикиРаботыСотрудников ГрафикРаботыСотрудников {get; set;}
        [Description1C8(Name = "ФОТ", Comment = "", Synonym = "ФОТ")]
        // Format 19.2
        public decimal ФОТ {get; set;}
        [Description1C8(Name = "ФОТМин", Comment = "", Synonym = "ФОТ, мин.")]
        // Format 19.2
        public decimal ФОТМин {get; set;}
        [Description1C8(Name = "ФОТМакс", Comment = "", Synonym = "ФОТ, макс.")]
        // Format 19.2
        public decimal ФОТМакс {get; set;}
        [Description1C8(Name = "УсловияПриема", Comment = "", Synonym = "Условия приема на работу, характер работы")]
        public string УсловияПриема {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "СтатьяФинансирования", Comment = "", Synonym = "Финансирование")]
        public Catalogs.СтатьиФинансированияЗарплата СтатьяФинансирования {get; set;}
        [Description1C8(Name = "ТарифнаяСетка", Comment = "", Synonym = "Тарифная группа")]
        public Catalogs.ТарифныеСетки ТарифнаяСетка {get; set;}
        [Description1C8(Name = "ТарифнаяСеткаНадбавки", Comment = "", Synonym = "Тарифная группа надбавки")]
        public Catalogs.ТарифныеСетки ТарифнаяСеткаНадбавки {get; set;}
        [Description1C8(Name = "РазрядКатегорияНадбавки", Comment = "", Synonym = "Разряд (категория) надбавки")]
        public Catalogs.РазрядыКатегорииДолжностей РазрядКатегорияНадбавки {get; set;}
        [Description1C8(Name = "НадбавкаЗаВредностьРазмер", Comment = "", Synonym = "Надбавка за вредность размер")]
        // Format 15.2
        public decimal НадбавкаЗаВредностьРазмер {get; set;}
        [Description1C8(Name = "НадбавкаЗаВредностьРазмерМин", Comment = "", Synonym = "Надбавка за вредность размер мин")]
        // Format 15.2
        public decimal НадбавкаЗаВредностьРазмерМин {get; set;}
        [Description1C8(Name = "НадбавкаЗаВредностьРазмерМакс", Comment = "", Synonym = "Надбавка за вредность размер макс")]
        // Format 15.2
        public decimal НадбавкаЗаВредностьРазмерМакс {get; set;}
        [Description1C8(Name = "КлассУсловийТруда", Comment = "", Synonym = "Класс условий труда")]
        public Enums.КлассыУсловийТрудаПоРезультатамСпециальнойОценки КлассУсловийТруда {get; set;}
        [Description1C8(Name = "КлассУсловийТрудаДатаРегистрацииИзменений", Comment = "", Synonym = "Класс условий труда дата регистрации изменений")]
        public DateTime КлассУсловийТрудаДатаРегистрацииИзменений {get; set;}
        [Description1C8(Name = "ВыплачиваетсяНадбавкаЗаВредность", Comment = "", Synonym = "Выплачивается надбавка за вредность")]
        public bool ВыплачиваетсяНадбавкаЗаВредность {get; set;}
        [Description1C8(Name = "ПроцентНадбавкиЗаВредность", Comment = "", Synonym = "% надбавки")]
        // Format 5.2
        public decimal ПроцентНадбавкиЗаВредность {get; set;}
        [Description1C8(Name = "МестоВСтруктуреПредприятия", Comment = "", Synonym = "В структуре предприятия")]
        public Catalogs.СтруктураПредприятия МестоВСтруктуреПредприятия {get; set;}
        [Description1C8(Name = "СозданоНовыхРабочихМест", Comment = "", Synonym = "Создано новых рабочих мест")]
        // Format 7.2
        public decimal СозданоНовыхРабочихМест {get; set;}
    }
    [Description1C8(Name = "Начисления", Comment = "", Synonym = "Начисления")]
    [Table("YzmenenyeShtatnohoRaspysanyia_Nachyslenyia")]
    public class ИзменениеШтатногоРасписания_Начисления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтрокиПозиции", Comment = "", Synonym = "Идентификатор строки позиции")]
        // Format 5.0
        public long ИдентификаторСтрокиПозиции {get; set;}
        [Description1C8(Name = "Начисление", Comment = "", Synonym = "Начисление")]
        public ПланВидовРасчета.Начисления Начисление {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСНачислениямиИУдержаниями Действие {get; set;}
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
    [Table("YzmenenyeShtatnohoRaspysanyia_Pokazately")]
    public class ИзменениеШтатногоРасписания_Показатели
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтрокиВидаРасчета", Comment = "", Synonym = "Идентификатор строки вида расчета")]
        // Format 7.0
        public long ИдентификаторСтрокиВидаРасчета {get; set;}
        [Description1C8(Name = "Показатель", Comment = "", Synonym = "Показатель")]
        public Catalogs.ПоказателиРасчетаЗарплаты Показатель {get; set;}
        [Description1C8(Name = "ИдентификаторСтрокиПозиции", Comment = "", Synonym = "Идентификатор строки позиции")]
        // Format 5.0
        public long ИдентификаторСтрокиПозиции {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        // Format 15.4
        public decimal Значение {get; set;}
        [Description1C8(Name = "ЗначениеМин", Comment = "", Synonym = "Значение мин")]
        // Format 15.4
        public decimal ЗначениеМин {get; set;}
        [Description1C8(Name = "ЗначениеМакс", Comment = "", Synonym = "Значение макс")]
        // Format 15.4
        public decimal ЗначениеМакс {get; set;}
    }
    [Description1C8(Name = "ЕжегодныеОтпуска", Comment = "", Synonym = "Ежегодные отпуска")]
    [Table("YzmenenyeShtatnohoRaspysanyia_EzhehodnyeOtpuska")]
    public class ИзменениеШтатногоРасписания_ЕжегодныеОтпуска
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтрокиПозиции", Comment = "", Synonym = "Идентификатор строки позиции")]
        // Format 5.0
        public long ИдентификаторСтрокиПозиции {get; set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Enums.ДействияСЕжегоднымиОтпусками Действие {get; set;}
        [Description1C8(Name = "ВидЕжегодногоОтпуска", Comment = "", Synonym = "Вид ежегодного отпуска")]
        public Catalogs.ВидыОтпусков ВидЕжегодногоОтпуска {get; set;}
        [Description1C8(Name = "КоличествоДнейВГод", Comment = "", Synonym = "Количество дней в год")]
        // Format 2.0
        public long КоличествоДнейВГод {get; set;}
    }
    [Description1C8(Name = "Специальности", Comment = "", Synonym = "Специальности")]
    [Table("YzmenenyeShtatnohoRaspysanyia_Spetsyalnosty")]
    public class ИзменениеШтатногоРасписания_Специальности
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ИдентификаторСтрокиПозиции", Comment = "", Synonym = "Идентификатор строки позиции")]
        // Format 5.0
        public long ИдентификаторСтрокиПозиции {get; set;}
        [Description1C8(Name = "Специальность", Comment = "", Synonym = "Специальность")]
        public Catalogs.КлассификаторСпециальностейПоОбразованию Специальность {get; set;}
    }
}
