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
    [Table("OperatsyiaBukh")]
    [Description1C8(Name = "ОперацияБух", Comment = "", Synonym = "Операция")]
    public class ОперацияБух:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "СуммаОперации", Comment = "", Synonym = "Сумма операции")]
        // Format 15.2
        public decimal СуммаОперации {get; set;}
        [Description1C8(Name = "Содержание", Comment = "", Synonym = "Содержание")]
        [StringLength(250)]
        public string Содержание {get; set;}
        [Description1C8(Name = "СпособЗаполнения", Comment = "", Synonym = "Способ заполнения")]
        public Catalogs.УдалитьВнешниеОбработки СпособЗаполнения {get; set;}
        [Description1C8(Name = "СторнируемыйДокумент", Comment = "", Synonym = "Сторнируемый документ")]
        public Documents.СторнированиеНачислений СторнируемыйДокумент {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "ТиповаяОперация", Comment = "", Synonym = "Типовая операция")]
        public Documents.СторнированиеНачислений ТиповаяОперация {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ЗаполнениеДвижений", Comment = "", Synonym = "Заполнение движений")]
        public List<ОперацияБух_ЗаполнениеДвижений> ОперацияБухЗаполнениеДвижений {get;set;}
        [Description1C8(Name = "ЗапрашиваемыеПараметры", Comment = "", Synonym = "Запрашиваемые параметры")]
        public List<ОперацияБух_ЗапрашиваемыеПараметры> ОперацияБухЗапрашиваемыеПараметры {get;set;}
        [Description1C8(Name = "ТаблицаРегистровНакопления", Comment = "(Общ)", Synonym = "Таблица регистров накопления")]
        public List<ОперацияБух_ТаблицаРегистровНакопления> ОперацияБухТаблицаРегистровНакопления {get;set;}
        [Description1C8(Name = "ТаблицаРегистровРасчета", Comment = "(Общ)", Synonym = "Таблица регистров расчета")]
        public List<ОперацияБух_ТаблицаРегистровРасчета> ОперацияБухТаблицаРегистровРасчета {get;set;}
        [Description1C8(Name = "ТаблицаРегистровСведений", Comment = "(Общ)", Synonym = "Таблица регистров сведений")]
        public List<ОперацияБух_ТаблицаРегистровСведений> ОперацияБухТаблицаРегистровСведений {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ЗаполнениеДвижений", Comment = "", Synonym = "Заполнение движений")]
    [Table("OperatsyiaBukh_ZapolnenyeDvyzhenyi")]
    public class ОперацияБух_ЗаполнениеДвижений
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Документ", Comment = "", Synonym = "Документ")]
        public Documents.СторнированиеНачислений Документ {get; set;}
        [Description1C8(Name = "Примечание", Comment = "", Synonym = "Примечание")]
        [StringLength(250)]
        public string Примечание {get; set;}
    }
    [Description1C8(Name = "ЗапрашиваемыеПараметры", Comment = "", Synonym = "Запрашиваемые параметры")]
    [Table("OperatsyiaBukh_ZaprashyvaemyeParametry")]
    public class ОперацияБух_ЗапрашиваемыеПараметры
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Имя", Comment = "", Synonym = "Имя")]
        [StringLength(100)]
        public string Имя {get; set;}
        [Description1C8(Name = "Представление", Comment = "", Synonym = "Представления")]
        [StringLength(100)]
        public string Представление {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public Documents.СторнированиеНачислений Значение {get; set;}
    }
    [Description1C8(Name = "ТаблицаРегистровНакопления", Comment = "(Общ)", Synonym = "Таблица регистров накопления")]
    [Table("OperatsyiaBukh_TablytsaRehystrovNakoplenyia")]
    public class ОперацияБух_ТаблицаРегистровНакопления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Имя", Comment = "(Общ)", Synonym = "Имя")]
        [StringLength(200)]
        public string Имя {get; set;}
    }
    [Description1C8(Name = "ТаблицаРегистровРасчета", Comment = "(Общ)", Synonym = "Таблица регистров расчета")]
    [Table("OperatsyiaBukh_TablytsaRehystrovRascheta")]
    public class ОперацияБух_ТаблицаРегистровРасчета
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Имя", Comment = "(Общ)", Synonym = "Имя")]
        public string Имя {get; set;}
    }
    [Description1C8(Name = "ТаблицаРегистровСведений", Comment = "(Общ)", Synonym = "Таблица регистров сведений")]
    [Table("OperatsyiaBukh_TablytsaRehystrovSvedenyi")]
    public class ОперацияБух_ТаблицаРегистровСведений
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Имя", Comment = "(Общ)", Synonym = "Имя")]
        [StringLength(200)]
        public string Имя {get; set;}
    }
}
