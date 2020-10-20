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
    public List<СпособыОтраженияРасходовПоАмортизации_Способы> СпособыОтраженияРасходовПоАмортизацииСпособы
    #endregion tables
    }
}
