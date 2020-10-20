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
    [Table("UstareloSposobyOtrazhenyiaZarplatyVRehlUchete")]
    [Description1C8(Name = "УстарелоСпособыОтраженияЗарплатыВРеглУчете", Comment = "(Регл)", Synonym = "ѳ(устарело) Способы отражения зарплаты в регламентированном учете")]
    public class УстарелоСпособыОтраженияЗарплатыВРеглУчете:CatalogItem
    {
    #region Стандартні реквізити
    public Guid Id {get; set;}
    public bool IsFolder {get; set;}
    public bool DeletionMark {get; set;}
    public bool Predefined {get; set;}
    public string Code {get; set;}
    public string Description {get; set;}
    public Guid? Parent {get; set;}
    public Guid? Owner {get; set;}
    #endregion Стандартні реквізити
    #region реквізити
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
    [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Нал. назн. затрат (до 01.01.2015)")]
    public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
    [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Нал. назн. (НДС)")]
    public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    [Description1C8(Name = "СтратегияОтраженияЕСВФОТ", Comment = "", Synonym = "Стратегия отражения ЕСВ ФОТ")]
    public Enums.СтратегииОтраженияВУчетеЕСВ СтратегияОтраженияЕСВФОТ {get; set;}
    [Description1C8(Name = "СпособОтраженияЕСВФОТ", Comment = "", Synonym = "Способ отражения ЕСВ ФОТ")]
    public Catalogs.УстарелоСпособыОтраженияЗарплатыВРеглУчете СпособОтраженияЕСВФОТ {get; set;}
    [Description1C8(Name = "УДАЛИТЬВзносыОсновногоНачисления", Comment = "Особый способ отражения для ЕСВ ФОТ", Synonym = "(не используется) Особый способ отражения для ЕСВ ФОТ")]
    public bool УДАЛИТЬВзносыОсновногоНачисления {get; set;}
    [Description1C8(Name = "УдалитьСтатьяВаловыхРасходов", Comment = "", Synonym = "(не используется) Статья в/р")]
    public Catalogs.СтатьиНалоговыхДеклараций УдалитьСтатьяВаловыхРасходов {get; set;}
    #endregion реквізити
    }
}
