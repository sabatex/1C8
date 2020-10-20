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
    [Table("RaschetKoeffytsyentovDliaZapolnenyiaPrylozhenyiaSVDeklaratsyyPoPrybyly")]
    [Description1C8(Name = "РасчетКоэффициентовДляЗаполненияПриложенияСВДекларацииПоПрибыли", Comment = "(регл)", Synonym = "Расчет коэффициентов для заполнения Приложения СВ к Декларации о прибыли")]
    public class РасчетКоэффициентовДляЗаполненияПриложенияСВДекларацииПоПрибыли:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "СуммаНЗПиПродукцииНаНачало", Comment = "", Synonym = "Сумма НЗП и продукции на начало периода")]
        // Format 15.2
        public decimal СуммаНЗПиПродукцииНаНачало {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Статьи", Comment = "", Synonym = "Статьи")]
        public List<РасчетКоэффициентовДляЗаполненияПриложенияСВДекларацииПоПрибыли_Статьи> РасчетКоэффициентовДляЗаполненияПриложенияСВДекларацииПоПрибылиСтатьи {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Статьи", Comment = "", Synonym = "Статьи")]
    [Table("RaschetKoeffytsyentovDliaZapolnenyiaPrylozhenyiaSVDeklaratsyyPoPrybyly_Staty")]
    public class РасчетКоэффициентовДляЗаполненияПриложенияСВДекларацииПоПрибыли_Статьи
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "Статья", Comment = "", Synonym = "Статья")]
        public Catalogs.СтатьиНалоговыхДеклараций Статья {get; set;}
        [Description1C8(Name = "КоэффициентНаНачало", Comment = "", Synonym = "Коэффициент на начало")]
        // Format 15.13
        public decimal КоэффициентНаНачало {get; set;}
        [Description1C8(Name = "СуммаОборот", Comment = "", Synonym = "Сумма оборот")]
        // Format 15.2
        public decimal СуммаОборот {get; set;}
        [Description1C8(Name = "КоэффициентНаКонец", Comment = "", Synonym = "Коэффициент на конец")]
        // Format 15.13
        public decimal КоэффициентНаКонец {get; set;}
    }
}
