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
    [Table("YzmenenyeSposobovOtrazhenyiaRaskhodovPoAmortyzatsyyNMA")]
    [Description1C8(Name = "ИзменениеСпособовОтраженияРасходовПоАмортизацииНМА", Comment = "(Общ)", Synonym = "Изменение отражения амортизации НМА")]
    public class ИзменениеСпособовОтраженияРасходовПоАмортизацииНМА:DocumentItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "(Общ)", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "СпособОтраженияРасходовПоАмортизации", Comment = "(Общ)", Synonym = "Способ отражения расходов по амортизации")]
        public Catalogs.СпособыОтраженияРасходовПоАмортизации СпособОтраженияРасходовПоАмортизации {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
        public List<ИзменениеСпособовОтраженияРасходовПоАмортизацииНМА_НМА> ИзменениеСпособовОтраженияРасходовПоАмортизацииНМАНМА {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "НМА", Comment = "(Общ)", Synonym = "НМА")]
    [Table("YzmenenyeSposobovOtrazhenyiaRaskhodovPoAmortyzatsyyNMA_NMA")]
    public class ИзменениеСпособовОтраженияРасходовПоАмортизацииНМА_НМА
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "НематериальныйАктив", Comment = "(Общ)", Synonym = "Нематериальный актив")]
        public Catalogs.НематериальныеАктивы НематериальныйАктив {get; set;}
    }
}
