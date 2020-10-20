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
    [Table("OtrazhenyeZarplatyVFynansovomUchete")]
    [Description1C8(Name = "ОтражениеЗарплатыВФинансовомУчете", Comment = "", Synonym = "Отражение зарплаты в финансовом учете")]
    public class ОтражениеЗарплатыВФинансовомУчете:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Месяц")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "УдалитьДетализацияНачисленийПоФизлицам", Comment = "", Synonym = "(не используется) детализация начислений по физлицам")]
        public bool УдалитьДетализацияНачисленийПоФизлицам {get; set;}
        [Description1C8(Name = "Сводно", Comment = "", Synonym = "Сводно")]
        public bool Сводно {get; set;}
        [Description1C8(Name = "ПроводкиПоРаботникам", Comment = "", Synonym = "Проводки по работникам")]
        public bool ПроводкиПоРаботникам {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "НачисленнаяЗарплатаИВзносы", Comment = "", Synonym = "Начисленния и взносы")]
        public List<ОтражениеЗарплатыВФинансовомУчете_НачисленнаяЗарплатаИВзносы> ОтражениеЗарплатыВФинансовомУчетеНачисленнаяЗарплатаИВзносы {get;set;}
        [Description1C8(Name = "НачисленнаяЗарплатаИВзносыПоФизлицам", Comment = "", Synonym = "Начисленная зарплата и взносы по физлицам")]
        public List<ОтражениеЗарплатыВФинансовомУчете_НачисленнаяЗарплатаИВзносыПоФизлицам> ОтражениеЗарплатыВФинансовомУчетеНачисленнаяЗарплатаИВзносыПоФизлицам {get;set;}
        [Description1C8(Name = "НачисленныйНДФЛ", Comment = "", Synonym = "НДФЛ")]
        public List<ОтражениеЗарплатыВФинансовомУчете_НачисленныйНДФЛ> ОтражениеЗарплатыВФинансовомУчетеНачисленныйНДФЛ {get;set;}
        [Description1C8(Name = "УдержаннаяЗарплата", Comment = "", Synonym = "Удержания")]
        public List<ОтражениеЗарплатыВФинансовомУчете_УдержаннаяЗарплата> ОтражениеЗарплатыВФинансовомУчетеУдержаннаяЗарплата {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<ОтражениеЗарплатыВФинансовомУчете_ФизическиеЛица> ОтражениеЗарплатыВФинансовомУчетеФизическиеЛица {get;set;}
        [Description1C8(Name = "НачисленныеПроцентыПоЗаймам", Comment = "", Synonym = "Проценты по займам")]
        public List<ОтражениеЗарплатыВФинансовомУчете_НачисленныеПроцентыПоЗаймам> ОтражениеЗарплатыВФинансовомУчетеНачисленныеПроцентыПоЗаймам {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "НачисленнаяЗарплатаИВзносы", Comment = "", Synonym = "Начисленния и взносы")]
    [Table("OtrazhenyeZarplatyVFynansovomUchete_NachyslennaiaZarplataYVznosy")]
    public class ОтражениеЗарплатыВФинансовомУчете_НачисленнаяЗарплатаИВзносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ПодразделениеПредприятия", Comment = "", Synonym = "Подразделение-получатель")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеПредприятия {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПоЗарплате ВидОперации {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Начислено")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ВзносыВсего", Comment = "", Synonym = "Взносы")]
        // Format 15.2
        public decimal ВзносыВсего {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "ГруппаУчетаНачислений", Comment = "", Synonym = "Группа учета начислений")]
        public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчетаНачислений {get; set;}
    }
    [Description1C8(Name = "НачисленнаяЗарплатаИВзносыПоФизлицам", Comment = "", Synonym = "Начисленная зарплата и взносы по физлицам")]
    [Table("OtrazhenyeZarplatyVFynansovomUchete_NachyslennaiaZarplataYVznosyPoFyzlytsam")]
    public class ОтражениеЗарплатыВФинансовомУчете_НачисленнаяЗарплатаИВзносыПоФизлицам
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Работник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ПодразделениеПредприятия", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеПредприятия {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПоЗарплате ВидОперации {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.СпособыОтраженияЗарплатыВБухУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ВзносыВсего", Comment = "", Synonym = "Взносы всего")]
        // Format 15.2
        public decimal ВзносыВсего {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "ГруппаУчетаНачислений", Comment = "", Synonym = "Группа учета начислений")]
        public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчетаНачислений {get; set;}
    }
    [Description1C8(Name = "НачисленныйНДФЛ", Comment = "", Synonym = "НДФЛ")]
    [Table("OtrazhenyeZarplatyVFynansovomUchete_NachyslennyiNDFL")]
    public class ОтражениеЗарплатыВФинансовомУчете_НачисленныйНДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ПодразделениеПредприятия", Comment = "", Synonym = "Подразделение")]
        public Catalogs.СтруктураПредприятия ПодразделениеПредприятия {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПоЗарплате ВидОперации {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "ТипНалога", Comment = "", Synonym = "Тип налога")]
        [StringLength(10)]
        public string ТипНалога {get; set;}
        [Description1C8(Name = "КодДохода", Comment = "", Synonym = "Код дохода")]
        public Catalogs.ВидыДоходовНДФЛ КодДохода {get; set;}
        [Description1C8(Name = "ГруппаУчетаНачислений", Comment = "", Synonym = "Группа учета начислений")]
        public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчетаНачислений {get; set;}
    }
    [Description1C8(Name = "УдержаннаяЗарплата", Comment = "", Synonym = "Удержания")]
    [Table("OtrazhenyeZarplatyVFynansovomUchete_UderzhannaiaZarplata")]
    public class ОтражениеЗарплатыВФинансовомУчете_УдержаннаяЗарплата
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ПодразделениеПредприятия", Comment = "", Synonym = "Подразделение")]
        public Catalogs.СтруктураПредприятия ПодразделениеПредприятия {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПоЗарплате ВидОперации {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Получатель")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "СтатьяАктивовПассивов", Comment = "", Synonym = "Статья пассивов")]
        [StringLength(10)]
        public string СтатьяАктивовПассивов {get; set;}
        [Description1C8(Name = "АналитикаАктивовПассивов", Comment = "", Synonym = "Аналитика")]
        [StringLength(10)]
        public string АналитикаАктивовПассивов {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет учета")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
        [Description1C8(Name = "Субконто1", Comment = "", Synonym = "Субконто1")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1 {get; set;}
        [Description1C8(Name = "Субконто2", Comment = "", Synonym = "Субконто2")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2 {get; set;}
        [Description1C8(Name = "Субконто3", Comment = "", Synonym = "Субконто3")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3 {get; set;}
        [Description1C8(Name = "ЦельВыдачи", Comment = "", Synonym = "Цель выдачи")]
        public Catalogs.СтатьиДвиженияДенежныхСредств ЦельВыдачи {get; set;}
        [Description1C8(Name = "СтатьяДоходов", Comment = "", Synonym = "Статья доходов")]
        [StringLength(10)]
        public string СтатьяДоходов {get; set;}
        [Description1C8(Name = "АналитикаДоходов", Comment = "", Synonym = "Аналитика доходов")]
        [StringLength(10)]
        public string АналитикаДоходов {get; set;}
        [Description1C8(Name = "ГруппаУчетаНачислений", Comment = "", Synonym = "Группа учета начислений")]
        public Catalogs.ГруппыУчетаНачисленийИУдержаний ГруппаУчетаНачислений {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("OtrazhenyeZarplatyVFynansovomUchete_FyzycheskyeLytsa")]
    public class ОтражениеЗарплатыВФинансовомУчете_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
    [Description1C8(Name = "НачисленныеПроцентыПоЗаймам", Comment = "", Synonym = "Проценты по займам")]
    [Table("OtrazhenyeZarplatyVFynansovomUchete_NachyslennyeProtsentyPoZaimam")]
    public class ОтражениеЗарплатыВФинансовомУчете_НачисленныеПроцентыПоЗаймам
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ПодразделениеПредприятия", Comment = "", Synonym = "Подразделение")]
        public Catalogs.СтруктураПредприятия ПодразделениеПредприятия {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтатьяДоходов", Comment = "", Synonym = "Статья доходов")]
        [StringLength(10)]
        public string СтатьяДоходов {get; set;}
        [Description1C8(Name = "АналитикаДоходов", Comment = "", Synonym = "Аналитика доходов")]
        [StringLength(10)]
        public string АналитикаДоходов {get; set;}
    }
}
