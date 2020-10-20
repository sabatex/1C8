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
    [Table("DeponyrovanyeZarplaty")]
    [Description1C8(Name = "ДепонированиеЗарплаты", Comment = "", Synonym = "Депонирование зарплаты")]
    public class ДепонированиеЗарплаты:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ведомость", Comment = "", Synonym = "Ведомость")]
        public Documents.ВедомостьНаВыплатуЗарплатыВКассу Ведомость {get; set;}
        [Description1C8(Name = "КраткийСоставДокумента", Comment = "Краткий перечень сотрудников, включенных в документ", Synonym = "Сотрудники")]
        [StringLength(100)]
        public string КраткийСоставДокумента {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Депоненты", Comment = "", Synonym = "Депоненты")]
        public List<ДепонированиеЗарплаты_Депоненты> ДепонированиеЗарплатыДепоненты {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Депоненты", Comment = "", Synonym = "Депоненты")]
    [Table("DeponyrovanyeZarplaty_Deponenty")]
    public class ДепонированиеЗарплаты_Депоненты
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ФизическоеЛицо", Comment = "", Synonym = "Сотрудник")]
        public Catalogs.ФизическиеЛица ФизическоеЛицо {get; set;}
    }
}
