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
    [Table("ZaiavkaNaPokupkuProdazhuValiuty")]
    [Description1C8(Name = "ЗаявкаНаПокупкуПродажуВалюты", Comment = "(Регл)", Synonym = "Заявка на покупку/продажу валюты")]
    public class ЗаявкаНаПокупкуПродажуВалюты:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "ВидОперации", Comment = "", Synonym = "Вид операции")]
        public Enums.ВидыОперацийПокупкаПродажаВалюты ВидОперации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Банк", Comment = "", Synonym = "Банк")]
        public Catalogs.Контрагенты Банк {get; set;}
        [Description1C8(Name = "Валюта", Comment = "", Synonym = "Валюта")]
        public Catalogs.Валюты Валюта {get; set;}
        [Description1C8(Name = "СуммаГривневая", Comment = "", Synonym = "Сумма гривневая")]
        // Format 15.2
        public decimal СуммаГривневая {get; set;}
        [Description1C8(Name = "СуммаВалютная", Comment = "", Synonym = "Сумма валютная")]
        // Format 15.2
        public decimal СуммаВалютная {get; set;}
        [Description1C8(Name = "Комиссионные", Comment = "", Synonym = "Комиссионные (%)")]
        // Format 10.2
        public decimal Комиссионные {get; set;}
        [Description1C8(Name = "СчетГривневый", Comment = "", Synonym = "Счет гривневый")]
        public Catalogs.БанковскиеСчета СчетГривневый {get; set;}
        [Description1C8(Name = "СчетВалютный", Comment = "", Synonym = "Счет валютный")]
        public Catalogs.БанковскиеСчета СчетВалютный {get; set;}
        [Description1C8(Name = "СчетВозврата", Comment = "", Synonym = "Счет возврата")]
        public Catalogs.БанковскиеСчета СчетВозврата {get; set;}
        [Description1C8(Name = "СчетБанка", Comment = "", Synonym = "Счет банка")]
        public Catalogs.БанковскиеСчета СчетБанка {get; set;}
        [Description1C8(Name = "Курс", Comment = "", Synonym = "Курс")]
        // Format 15.4
        public decimal Курс {get; set;}
        [Description1C8(Name = "Сотрудник", Comment = "", Synonym = "Уполномоченный сотрудник")]
        public Catalogs.ФизическиеЛица Сотрудник {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "Основание", Comment = "", Synonym = "Основание")]
        public string Основание {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
