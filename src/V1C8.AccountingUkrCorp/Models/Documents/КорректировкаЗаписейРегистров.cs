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
    [Table("KorrektyrovkaZapyseiRehystrov")]
    [Description1C8(Name = "КорректировкаЗаписейРегистров", Comment = "(Общ)", Synonym = "Корректировка записей регистров")]
    public class КорректировкаЗаписейРегистров:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Комментарий", Comment = "(Общ)", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "ИспользоватьЗаполнениеДвижений", Comment = "", Synonym = "Использовать заполнение движений")]
        public bool ИспользоватьЗаполнениеДвижений {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ТаблицаРегистровНакопления", Comment = "(Общ)", Synonym = "Таблица регистров накопления")]
        public List<КорректировкаЗаписейРегистров_ТаблицаРегистровНакопления> КорректировкаЗаписейРегистровТаблицаРегистровНакопления {get;set;}
        [Description1C8(Name = "ТаблицаРегистровСведений", Comment = "(Общ)", Synonym = "Таблица регистров сведений")]
        public List<КорректировкаЗаписейРегистров_ТаблицаРегистровСведений> КорректировкаЗаписейРегистровТаблицаРегистровСведений {get;set;}
        [Description1C8(Name = "ТаблицаРегистровБухгалтерии", Comment = "(Общ)", Synonym = "Таблица регистров бухгалтерии")]
        public List<КорректировкаЗаписейРегистров_ТаблицаРегистровБухгалтерии> КорректировкаЗаписейРегистровТаблицаРегистровБухгалтерии {get;set;}
        [Description1C8(Name = "ТаблицаРегистровРасчета", Comment = "(Общ)", Synonym = "Таблица регистров расчета")]
        public List<КорректировкаЗаписейРегистров_ТаблицаРегистровРасчета> КорректировкаЗаписейРегистровТаблицаРегистровРасчета {get;set;}
        [Description1C8(Name = "ЗаполнениеДвижений", Comment = "", Synonym = "Заполнение движений")]
        public List<КорректировкаЗаписейРегистров_ЗаполнениеДвижений> КорректировкаЗаписейРегистровЗаполнениеДвижений {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ТаблицаРегистровНакопления", Comment = "(Общ)", Synonym = "Таблица регистров накопления")]
    [Table("KorrektyrovkaZapyseiRehystrov_TablytsaRehystrovNakoplenyia")]
    public class КорректировкаЗаписейРегистров_ТаблицаРегистровНакопления
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Имя", Comment = "(Общ)", Synonym = "Имя")]
        public string Имя {get; set;}
        [Description1C8(Name = "Представление", Comment = "(Общ)", Synonym = "Представления")]
        public string Представление {get; set;}
    }
    [Description1C8(Name = "ТаблицаРегистровСведений", Comment = "(Общ)", Synonym = "Таблица регистров сведений")]
    [Table("KorrektyrovkaZapyseiRehystrov_TablytsaRehystrovSvedenyi")]
    public class КорректировкаЗаписейРегистров_ТаблицаРегистровСведений
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Имя", Comment = "(Общ)", Synonym = "Имя")]
        public string Имя {get; set;}
        [Description1C8(Name = "Представление", Comment = "(Общ)", Synonym = "Представления")]
        public string Представление {get; set;}
    }
    [Description1C8(Name = "ТаблицаРегистровБухгалтерии", Comment = "(Общ)", Synonym = "Таблица регистров бухгалтерии")]
    [Table("KorrektyrovkaZapyseiRehystrov_TablytsaRehystrovBukhhalteryy")]
    public class КорректировкаЗаписейРегистров_ТаблицаРегистровБухгалтерии
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Имя", Comment = "(Общ)", Synonym = "Имя")]
        public string Имя {get; set;}
        [Description1C8(Name = "Представление", Comment = "(Общ)", Synonym = "Представления")]
        public string Представление {get; set;}
    }
    [Description1C8(Name = "ТаблицаРегистровРасчета", Comment = "(Общ)", Synonym = "Таблица регистров расчета")]
    [Table("KorrektyrovkaZapyseiRehystrov_TablytsaRehystrovRascheta")]
    public class КорректировкаЗаписейРегистров_ТаблицаРегистровРасчета
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Имя", Comment = "(Общ)", Synonym = "Имя")]
        public string Имя {get; set;}
        [Description1C8(Name = "Представление", Comment = "(Общ)", Synonym = "Представления")]
        public string Представление {get; set;}
    }
    [Description1C8(Name = "ЗаполнениеДвижений", Comment = "", Synonym = "Заполнение движений")]
    [Table("KorrektyrovkaZapyseiRehystrov_ZapolnenyeDvyzhenyi")]
    public class КорректировкаЗаписейРегистров_ЗаполнениеДвижений
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Действие", Comment = "", Synonym = "Действие")]
        public Catalogs.УдалитьВнешниеОбработки Действие {get; set;}
        [Description1C8(Name = "Документ", Comment = "", Synonym = "Документ")]
        public Documents.СторнированиеНачислений Документ {get; set;}
        [Description1C8(Name = "Примечание", Comment = "", Synonym = "Примечание")]
        public string Примечание {get; set;}
    }
}
