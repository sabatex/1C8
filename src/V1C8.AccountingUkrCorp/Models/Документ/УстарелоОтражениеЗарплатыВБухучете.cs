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
    [Table("UstareloOtrazhenyeZarplatyVBukhuchete")]
    [Description1C8(Name = "УстарелоОтражениеЗарплатыВБухучете", Comment = "", Synonym = "ѳ(устарело) Отражение зарплаты в бухгалтерском учете")]
    public class УстарелоОтражениеЗарплатыВБухучете:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Месяц")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ЗарплатаОтраженаВБухучете", Comment = "", Synonym = "Зарплата отражена в бухучете")]
        public bool ЗарплатаОтраженаВБухучете {get; set;}
        [Description1C8(Name = "Бухгалтер", Comment = "", Synonym = "Бухгалтер")]
        public Catalogs.Пользователи Бухгалтер {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "НачисленнаяЗарплатаИВзносы", Comment = "", Synonym = "Начисленная зарплата и взносы")]
        public List<УстарелоОтражениеЗарплатыВБухучете_НачисленнаяЗарплатаИВзносы> УстарелоОтражениеЗарплатыВБухучетеНачисленнаяЗарплатаИВзносы {get;set;}
        [Description1C8(Name = "УдержаннаяЗарплата", Comment = "", Synonym = "Удержанная зарплата")]
        public List<УстарелоОтражениеЗарплатыВБухучете_УдержаннаяЗарплата> УстарелоОтражениеЗарплатыВБухучетеУдержаннаяЗарплата {get;set;}
        [Description1C8(Name = "УдержанныйЕСВ", Comment = "", Synonym = "Удержанный ЕСВ")]
        public List<УстарелоОтражениеЗарплатыВБухучете_УдержанныйЕСВ> УстарелоОтражениеЗарплатыВБухучетеУдержанныйЕСВ {get;set;}
        [Description1C8(Name = "УдержанныйНДФЛ", Comment = "", Synonym = "Удержанный НДФЛ")]
        public List<УстарелоОтражениеЗарплатыВБухучете_УдержанныйНДФЛ> УстарелоОтражениеЗарплатыВБухучетеУдержанныйНДФЛ {get;set;}
        [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
        public List<УстарелоОтражениеЗарплатыВБухучете_ФизическиеЛица> УстарелоОтражениеЗарплатыВБухучетеФизическиеЛица {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "НачисленнаяЗарплатаИВзносы", Comment = "", Synonym = "Начисленная зарплата и взносы")]
    [Table("UstareloOtrazhenyeZarplatyVBukhuchete_NachyslennaiaZarplataYVznosy")]
    public class УстарелоОтражениеЗарплатыВБухучете_НачисленнаяЗарплатаИВзносы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПоЗарплате ВидОперации {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияЗарплатыВБухучете {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "СпособОтраженияЗарплатыВБухучетеВзносы", Comment = "", Synonym = "Способ отражения взносов")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияЗарплатыВБухучетеВзносы {get; set;}
        [Description1C8(Name = "СтатьяЗатратВзносы", Comment = "", Synonym = "Статья затрат взносов")]
        public Catalogs.СтатьиЗатрат СтатьяЗатратВзносы {get; set;}
        [Description1C8(Name = "СуммаВзносы", Comment = "", Synonym = "Сумма взносов")]
        // Format 15.2
        public decimal СуммаВзносы {get; set;}
        [Description1C8(Name = "СчетКт", Comment = "", Synonym = "Счет Кт")]
        public ПланСчетов.Хозрасчетный СчетКт {get; set;}
        [Description1C8(Name = "СчетКтВзносы", Comment = "", Synonym = "Счет Кт взносов")]
        public ПланСчетов.Хозрасчетный СчетКтВзносы {get; set;}
    }
    [Description1C8(Name = "УдержаннаяЗарплата", Comment = "", Synonym = "Удержанная зарплата")]
    [Table("UstareloOtrazhenyeZarplatyVBukhuchete_UderzhannaiaZarplata")]
    public class УстарелоОтражениеЗарплатыВБухучете_УдержаннаяЗарплата
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПоЗарплате ВидОперации {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "", Synonym = "Получатель удержаний")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СпособОтраженияВБухУчете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияВБухУчете {get; set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет Дт")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
    }
    [Description1C8(Name = "УдержанныйЕСВ", Comment = "", Synonym = "Удержанный ЕСВ")]
    [Table("UstareloOtrazhenyeZarplatyVBukhuchete_UderzhannyiESV")]
    public class УстарелоОтражениеЗарплатыВБухучете_УдержанныйЕСВ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "Налог", Comment = "", Synonym = "Налог")]
        public Catalogs.Налоги Налог {get; set;}
        [Description1C8(Name = "СтатьяНалоговойДекларации", Comment = "", Synonym = "Статья налоговой декларации")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяНалоговойДекларации {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПоЗарплате ВидОперации {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СпособОтраженияВБухУчете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияВБухУчете {get; set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет Дт")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
    }
    [Description1C8(Name = "УдержанныйНДФЛ", Comment = "", Synonym = "Удержанный НДФЛ")]
    [Table("UstareloOtrazhenyeZarplatyVBukhuchete_UderzhannyiNDFL")]
    public class УстарелоОтражениеЗарплатыВБухучете_УдержанныйНДФЛ
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПоЗарплате ВидОперации {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СпособОтраженияВБухУчете", Comment = "", Synonym = "Способ отражения")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияВБухУчете {get; set;}
        [Description1C8(Name = "СчетУчета", Comment = "", Synonym = "Счет Дт")]
        public ПланСчетов.Хозрасчетный СчетУчета {get; set;}
    }
    [Description1C8(Name = "ФизическиеЛица", Comment = "", Synonym = "Физические лица")]
    [Table("UstareloOtrazhenyeZarplatyVBukhuchete_FyzycheskyeLytsa")]
    public class УстарелоОтражениеЗарплатыВБухучете_ФизическиеЛица
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
