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
    [Table("UdalytVneshnyeObrabotky")]
    [Description1C8(Name = "УдалитьВнешниеОбработки", Comment = "", Synonym = "(не используется) Внешние обработки, печатные формы, обработки по заполнению табличных частей")]
    public class УдалитьВнешниеОбработки:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "ХранилищеВнешнейОбработки", Comment = "", Synonym = "Хранилище внешней обработки")]
    // Сховище значень
    public byte[] ХранилищеВнешнейОбработки {get; set;}
    [Description1C8(Name = "ВидОбработки", Comment = "", Synonym = "Вид обработки")]
    [StringLength(10)]
    public string ВидОбработки {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "КомментарийКФайлуИсточнику", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий к файлу источнику")]
    public string КомментарийКФайлуИсточнику {get; set;}
    #endregion реквізити
    #region tables
    [Description1C8(Name = "Принадлежность", Comment = "", Synonym = "Принадлежность")]
    public List<УдалитьВнешниеОбработки_Принадлежность> УдалитьВнешниеОбработкиПринадлежность
    #endregion tables
    }
}
