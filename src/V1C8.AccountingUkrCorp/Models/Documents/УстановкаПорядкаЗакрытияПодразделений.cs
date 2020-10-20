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
    [Table("UstanovkaPoriadkaZakrytyiaPodrazdelenyi")]
    [Description1C8(Name = "УстановкаПорядкаЗакрытияПодразделений", Comment = "", Synonym = "Установка порядка подразделений для закрытия счетов")]
    public class УстановкаПорядкаЗакрытияПодразделений:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ПорядокЗакрытия", Comment = "", Synonym = "Порядок закрытия")]
        public List<УстановкаПорядкаЗакрытияПодразделений_ПорядокЗакрытия> УстановкаПорядкаЗакрытияПодразделенийПорядокЗакрытия {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ПорядокЗакрытия", Comment = "", Synonym = "Порядок закрытия")]
    [Table("UstanovkaPoriadkaZakrytyiaPodrazdelenyi_PoriadokZakrytyia")]
    public class УстановкаПорядкаЗакрытияПодразделений_ПорядокЗакрытия
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Подразделение", Comment = "", Synonym = "Подразделение")]
        public Catalogs.ПодразделенияОрганизаций Подразделение {get; set;}
    }
}
