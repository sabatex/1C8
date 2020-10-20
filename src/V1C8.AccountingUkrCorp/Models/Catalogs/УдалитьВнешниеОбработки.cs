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
        public List<УдалитьВнешниеОбработки_Принадлежность> УдалитьВнешниеОбработкиПринадлежность {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Принадлежность", Comment = "", Synonym = "Принадлежность")]
    [Table("UdalytVneshnyeObrabotky_Prynadlezhnost")]
    public class УдалитьВнешниеОбработки_Принадлежность
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "ПредставлениеОбъекта", Comment = "", Synonym = "Представление объекта")]
        public string ПредставлениеОбъекта {get; set;}
        [Description1C8(Name = "СсылкаОбъекта", Comment = "", Synonym = "Ссылка объекта")]
        public Documents.СторнированиеНачислений СсылкаОбъекта {get; set;}
        [Description1C8(Name = "ТабличнаяЧастьИмя", Comment = "", Synonym = "Табличная часть имя")]
        [StringLength(100)]
        public string ТабличнаяЧастьИмя {get; set;}
        [Description1C8(Name = "ТабличнаяЧастьПредставление", Comment = "", Synonym = "Табличная часть представление")]
        public string ТабличнаяЧастьПредставление {get; set;}
        [Description1C8(Name = "НастройкиПостроителяДляОтбора", Comment = "", Synonym = "Настройки построителя для отбора")]
        // Сховище значень
        public byte[] НастройкиПостроителяДляОтбора {get; set;}
        [Description1C8(Name = "ХранилищеВнешнейОбработки", Comment = "", Synonym = "Хранилище внешней обработки")]
        // Сховище значень
        public byte[] ХранилищеВнешнейОбработки {get; set;}
        [Description1C8(Name = "ЗаменяемаяПечатнаяФорма", Comment = "", Synonym = "Заменяемая печатная форма")]
        public Catalogs.УдалитьВнешниеОбработки ЗаменяемаяПечатнаяФорма {get; set;}
        [Description1C8(Name = "ИмяФайлаПечатнойФормы", Comment = "", Synonym = "Имя файла печатной формы")]
        public string ИмяФайлаПечатнойФормы {get; set;}
        [Description1C8(Name = "ПредставлениеОтбораПостроителя", Comment = "", Synonym = "Представление отбора построителя")]
        public string ПредставлениеОтбораПостроителя {get; set;}
        [Description1C8(Name = "ПредставлениеКнопки", Comment = "", Synonym = "Представление кнопки")]
        [StringLength(100)]
        public string ПредставлениеКнопки {get; set;}
        [Description1C8(Name = "ДополнительныеПараметрыОбработки", Comment = "", Synonym = "Дополнительные параметры обработки")]
        // Сховище значень
        public byte[] ДополнительныеПараметрыОбработки {get; set;}
        [Description1C8(Name = "ПредставлениеНастроекОбработки", Comment = "", Synonym = "Представление настроек обработки")]
        [StringLength(50)]
        public string ПредставлениеНастроекОбработки {get; set;}
    }
}
