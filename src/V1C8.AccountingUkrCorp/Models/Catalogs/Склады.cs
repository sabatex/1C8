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
    [Table("Sklady")]
    [Description1C8(Name = "Склады", Comment = "", Synonym = "Склады (места хранения)")]
    public class Склады:CatalogItem
    {
    #region реквізити
    [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "ТипЦенРозничнойТорговли", Comment = "(Общ)", Synonym = "Тип цен розничной торговли")]
    public Catalogs.ТипыЦенНоменклатуры ТипЦенРозничнойТорговли {get; set;}
    [Description1C8(Name = "ТипСклада", Comment = "", Synonym = "Тип склада")]
    public Enums.ТипыСкладов ТипСклада {get; set;}
    [Description1C8(Name = "ТерриторияПоКОАТУУ", Comment = "Название и код территории по КОАТУУ, на которой расположен склад (торговая точка)", Synonym = "Территория по КОАТУУ")]
    public Catalogs.КлассификаторКОАТУУ ТерриторияПоКОАТУУ {get; set;}
    [Description1C8(Name = "Местонахождение", Comment = "", Synonym = "Местонахождение")]
    public string Местонахождение {get; set;}
    #endregion реквізити
    #region tables
    [Description1C8(Name = "ДополнительныеРеквизиты", Comment = "", Synonym = "Дополнительные реквизиты")]
    public List<Склады_ДополнительныеРеквизиты> СкладыДополнительныеРеквизиты
    #endregion tables
    }
}
