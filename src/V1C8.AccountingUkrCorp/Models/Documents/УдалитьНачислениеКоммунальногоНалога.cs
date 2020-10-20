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
    [Table("UdalytNachyslenyeKommunalnohoNaloha")]
    [Description1C8(Name = "УдалитьНачислениеКоммунальногоНалога", Comment = "(Регл)", Synonym = "(не используется) Начисление коммунального налога")]
    public class УдалитьНачислениеКоммунальногоНалога:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "УдалитьПодразделениеОрганизации", Comment = "", Synonym = "Удалить подразделение организации")]
        public Catalogs.ПодразделенияОрганизаций УдалитьПодразделениеОрганизации {get; set;}
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "ПериодРегистрации", Comment = "", Synonym = "Период регистрации")]
        public DateTime ПериодРегистрации {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "СреднесписочнаяЧисленность", Comment = "", Synonym = "Среднесписочная численность")]
        // Format 10.0
        public long СреднесписочнаяЧисленность {get; set;}
        [Description1C8(Name = "СпособОтраженияВБухучете", Comment = "", Synonym = "Способ отражения в бухучете")]
        public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияВБухучете {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "СтавкаКоммунальногоНалога", Comment = "", Synonym = "Ставка коммунального налога")]
        // Format 7.2
        public decimal СтавкаКоммунальногоНалога {get; set;}
        [Description1C8(Name = "НеоблагаемыйМинимум", Comment = "", Synonym = "Необлагаемый минимум")]
        // Format 7.2
        public decimal НеоблагаемыйМинимум {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "ОтражениеВУчете", Comment = "", Synonym = "Отражение в учете")]
        public List<УдалитьНачислениеКоммунальногоНалога_ОтражениеВУчете> УдалитьНачислениеКоммунальногоНалогаОтражениеВУчете {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "ОтражениеВУчете", Comment = "", Synonym = "Отражение в учете")]
    [Table("UdalytNachyslenyeKommunalnohoNaloha_OtrazhenyeVUchete")]
    public class УдалитьНачислениеКоммунальногоНалога_ОтражениеВУчете
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "СчетДт", Comment = "", Synonym = "Счет Дт")]
        public ПланСчетов.Хозрасчетный СчетДт {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "", Synonym = "Субконто Дт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "", Synonym = "Субконто Дт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "", Synonym = "Субконто Дт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоДт3 {get; set;}
        [Description1C8(Name = "СчетКт", Comment = "", Synonym = "Счет Кт")]
        public ПланСчетов.Хозрасчетный СчетКт {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "", Synonym = "Субконто Кт номер 1")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "", Synonym = "Субконто Кт номер 2")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "", Synonym = "Субконто Кт номер 3")]
        public Catalogs.ВидыНалоговойДеятельности СубконтоКт3 {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        // Format 15.2
        public decimal Сумма {get; set;}
        [Description1C8(Name = "СтатьяВаловыхРасходов", Comment = "", Synonym = "Статья в/р")]
        public Catalogs.СтатьиНалоговыхДеклараций СтатьяВаловыхРасходов {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Налоговое назначение")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
}
