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
    [Table("SposobyOtrazhenyiaRaskhodovPoAmortyzatsyy")]
    [Description1C8(Name = "СпособыОтраженияРасходовПоАмортизации", Comment = "(Общ)", Synonym = "Способы отражения расходов по амортизации и улучшению")]
    public class СпособыОтраженияРасходовПоАмортизации:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ)", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Способы", Comment = "(Общ)", Synonym = "Способы")]
        public List<СпособыОтраженияРасходовПоАмортизации_Способы> СпособыОтраженияРасходовПоАмортизацииСпособы {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Способы", Comment = "(Общ)", Synonym = "Способы")]
    [Table("SposobyOtrazhenyiaRaskhodovPoAmortyzatsyy_Sposoby")]
    public class СпособыОтраженияРасходовПоАмортизации_Способы
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "СчетЗатрат", Comment = "", Synonym = "Счет затрат")]
        public ПланСчетов.Хозрасчетный СчетЗатрат {get; set;}
        [Description1C8(Name = "Субконто1", Comment = "(Регл)", Synonym = "Субконто 1")]
        public Catalogs.ВидыНалоговойДеятельности Субконто1 {get; set;}
        [Description1C8(Name = "Субконто2", Comment = "(Регл)", Synonym = "Субконто 2")]
        public Catalogs.ВидыНалоговойДеятельности Субконто2 {get; set;}
        [Description1C8(Name = "Субконто3", Comment = "(Регл)", Synonym = "Субконто 3")]
        public Catalogs.ВидыНалоговойДеятельности Субконто3 {get; set;}
        [Description1C8(Name = "Коэффициент", Comment = "(Общ)", Synonym = "Коэффициент")]
        // Format 6.3
        public decimal Коэффициент {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДоходовИЗатрат", Comment = "", Synonym = "Нал. назн. затрат (до 01.01.2015)")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначениеДоходовИЗатрат {get; set;}
        [Description1C8(Name = "СтатьяЗатратНаУлучшениеОС", Comment = "", Synonym = "Статья затрат на улучшение ОС")]
        public Catalogs.СтатьиЗатрат СтатьяЗатратНаУлучшениеОС {get; set;}
        [Description1C8(Name = "НалоговоеНазначение", Comment = "", Synonym = "Нал. назн.")]
        public Catalogs.НалоговыеНазначенияАктивовИЗатрат НалоговоеНазначение {get; set;}
    }
}
