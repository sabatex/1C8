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
    [Table("UdalytVvodNachalnykhOstatkovMalotsennykhAktyvovVЕkspluatatsyy")]
    [Description1C8(Name = "УдалитьВводНачальныхОстатковМалоценныхАктивовВЭксплуатации", Comment = "(Общ)", Synonym = "(не используется) Ввод начальных остатков малоценных активов в эксплуатации")]
    public class УдалитьВводНачальныхОстатковМалоценныхАктивовВЭксплуатации:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "ПодразделениеОрганизации", Comment = "(Регл)", Synonym = "Подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций ПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "Основание", Comment = "", Synonym = "Основание")]
        public string Основание {get; set;}
        [Description1C8(Name = "ЧерезКого", Comment = "(Общ)", Synonym = "Через кого")]
        public Catalogs.ФизическиеЛица ЧерезКого {get; set;}
        [Description1C8(Name = "ОтпускРазрешил", Comment = "(Общ)", Synonym = "Отпуск разрешил")]
        public Catalogs.ФизическиеЛица ОтпускРазрешил {get; set;}
        [Description1C8(Name = "Отпустил", Comment = "(Общ)", Synonym = "Отпустил")]
        public Catalogs.ФизическиеЛица Отпустил {get; set;}
        [Description1C8(Name = "ПредседательКомиссии", Comment = "", Synonym = "Председатель комиссии")]
        public Catalogs.ФизическиеЛица ПредседательКомиссии {get; set;}
        [Description1C8(Name = "ПервыйЧленКомиссии", Comment = "", Synonym = "Первый член комиссии")]
        public Catalogs.ФизическиеЛица ПервыйЧленКомиссии {get; set;}
        [Description1C8(Name = "ВторойЧленКомиссии", Comment = "", Synonym = "Второй член комиссии")]
        public Catalogs.ФизическиеЛица ВторойЧленКомиссии {get; set;}
        [Description1C8(Name = "ТретийЧленКомиссии", Comment = "", Synonym = "Третий член комиссии")]
        public Catalogs.ФизическиеЛица ТретийЧленКомиссии {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "МалоценныеАктивы", Comment = "(Общ)", Synonym = "Малоценные активы")]
        public List<УдалитьВводНачальныхОстатковМалоценныхАктивовВЭксплуатации_МалоценныеАктивы> УдалитьВводНачальныхОстатковМалоценныхАктивовВЭксплуатацииМалоценныеАктивы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "МалоценныеАктивы", Comment = "(Общ)", Synonym = "Малоценные активы")]
    [Table("UdalytVvodNachalnykhOstatkovMalotsennykhAktyvovVЕkspluatatsyy_MalotsennyeAktyvy")]
    public class УдалитьВводНачальныхОстатковМалоценныхАктивовВЭксплуатации_МалоценныеАктивы
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Номенклатура", Comment = "(Общ)", Synonym = "Номенклатура")]
        public Catalogs.Номенклатура Номенклатура {get; set;}
        [Description1C8(Name = "НазначениеИспользования", Comment = "", Synonym = "Назначение использования")]
        public Catalogs.НазначенияИспользования НазначениеИспользования {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
        [Description1C8(Name = "ФизЛицо", Comment = "(Общ)", Synonym = "Физическое лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "Стоимость", Comment = "(Упр)", Synonym = "Стоимость")]
        // Format 15.2
        public decimal Стоимость {get; set;}
        [Description1C8(Name = "ЕдиницаИзмерения", Comment = "(Общ)", Synonym = "Единица измерения")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаИзмерения {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 10.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "СтоимостьНУ", Comment = "", Synonym = "Стоимость НУ")]
        // Format 15.2
        public decimal СтоимостьНУ {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
}
