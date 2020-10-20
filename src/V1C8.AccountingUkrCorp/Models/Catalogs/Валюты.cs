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
    [Table("Valiuty")]
    [Description1C8(Name = "Валюты", Comment = "", Synonym = "Валюты")]
    public class Валюты
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
    [Description1C8(Name = "ЗагружаетсяИзИнтернета", Comment = "", Synonym = "Загружается из Интернета")]
    public bool ЗагружаетсяИзИнтернета {get; set;}
    [Description1C8(Name = "НаименованиеПолное", Comment = "", Synonym = "Наименование валюты")]
    [StringLength(50)]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "ПараметрыПрописиНаУкраинском", Comment = "", Synonym = "Параметры прописи на украинском")]
    [StringLength(200)]
    public string ПараметрыПрописиНаУкраинском {get; set;}
    [Description1C8(Name = "Наценка", Comment = "", Synonym = "Наценка")]
    // Format 10.2
    public decimal Наценка {get; set;}
    [Description1C8(Name = "ОсновнаяВалюта", Comment = "", Synonym = "Основная валюта")]
    public Catalogs.Валюты ОсновнаяВалюта {get; set;}
    [Description1C8(Name = "ПараметрыПрописиНаРусском", Comment = "", Synonym = "Параметры прописи на русском")]
    [StringLength(200)]
    public string ПараметрыПрописиНаРусском {get; set;}
    [Description1C8(Name = "ФормулаРасчетаКурса", Comment = "", Synonym = "Формула расчета курса")]
    [StringLength(100)]
    public string ФормулаРасчетаКурса {get; set;}
    [Description1C8(Name = "СпособУстановкиКурса", Comment = "", Synonym = "Способ установки курса")]
    public Enums.СпособыУстановкиКурсаВалюты СпособУстановкиКурса {get; set;}
    #endregion реквізити
    }
}
