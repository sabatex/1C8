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
    [Table("Doverennost")]
    [Description1C8(Name = "Доверенность", Comment = "(Общ)", Synonym = "Доверенность")]
    public class Доверенность:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ФизЛицо", Comment = "(Общ)", Synonym = "Подотчетное лицо")]
        public Catalogs.ФизическиеЛица ФизЛицо {get; set;}
        [Description1C8(Name = "Контрагент", Comment = "(Общ)", Synonym = "Контрагент")]
        public Catalogs.Контрагенты Контрагент {get; set;}
        [Description1C8(Name = "Сделка", Comment = "(Общ)", Synonym = "Док. расчетов")]
        public Документ.ПлатежныйОрдерСписаниеДенежныхСредств Сделка {get; set;}
        [Description1C8(Name = "ДатаДействия", Comment = "(Общ)", Synonym = "Дата действия")]
        public DateTime ДатаДействия {get; set;}
        [Description1C8(Name = "СтруктурнаяЕдиница", Comment = "(Общ)", Synonym = "Банковский счет")]
        public Catalogs.БанковскиеСчета СтруктурнаяЕдиница {get; set;}
        [Description1C8(Name = "ДоговорКонтрагента", Comment = "(Общ)", Synonym = "Договор")]
        public Catalogs.ДоговорыКонтрагентов ДоговорКонтрагента {get; set;}
        [Description1C8(Name = "НаПолучениеОт", Comment = "(Общ)", Synonym = "На получение От")]
        public string НаПолучениеОт {get; set;}
        [Description1C8(Name = "ПоДокументу", Comment = "(Общ)", Synonym = "По документу")]
        public string ПоДокументу {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "СерияДоверенности", Comment = "", Synonym = "Серия доверенности")]
        [StringLength(3)]
        public string СерияДоверенности {get; set;}
        [Description1C8(Name = "НомерДоверенности", Comment = "", Synonym = "Номер доверенности")]
        [StringLength(7)]
        public string НомерДоверенности {get; set;}
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийДоверенность ВидОперации {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
        public List<Доверенность_Товары> ДоверенностьТовары {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Товары", Comment = "(Общ)", Synonym = "Товары")]
    [Table("Doverennost_Tovary")]
    public class Доверенность_Товары
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НаименованиеТовара", Comment = "(Общ)", Synonym = "Наименование товара")]
        [StringLength(1000)]
        public string НаименованиеТовара {get; set;}
        [Description1C8(Name = "ЕдиницаПоКлассификатору", Comment = "(Общ)", Synonym = "Единица")]
        public Catalogs.КлассификаторЕдиницИзмерения ЕдиницаПоКлассификатору {get; set;}
        [Description1C8(Name = "Количество", Comment = "(Общ)", Synonym = "Количество")]
        // Format 15.3
        public decimal Количество {get; set;}
    }
}
