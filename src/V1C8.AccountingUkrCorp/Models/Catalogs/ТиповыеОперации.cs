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
    [Table("TypovyeOperatsyy")]
    [Description1C8(Name = "ТиповыеОперации", Comment = "", Synonym = "Типовые операции")]
    public class ТиповыеОперации:CatalogItem
    {
        #region реквізити
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Хозрасчетный", Comment = "", Synonym = "Хозрасчетный")]
        public List<ТиповыеОперации_Хозрасчетный> ТиповыеОперацииХозрасчетный {get;set;}
        [Description1C8(Name = "ДвиженияРегистров", Comment = "", Synonym = "Движения регистров")]
        public List<ТиповыеОперации_ДвиженияРегистров> ТиповыеОперацииДвиженияРегистров {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Хозрасчетный", Comment = "", Synonym = "Хозрасчетный")]
    [Table("TypovyeOperatsyy_Khozraschetnyi")]
    public class ТиповыеОперации_Хозрасчетный
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "СчетДт", Comment = "", Synonym = "Счет Дт")]
        public ПланСчетов.Хозрасчетный СчетДт {get; set;}
        [Description1C8(Name = "СубконтоДт1", Comment = "", Synonym = "Субконто Дт 1")]
        public Документ.СторнированиеНачислений СубконтоДт1 {get; set;}
        [Description1C8(Name = "СубконтоДт2", Comment = "", Synonym = "Субконто Дт 2")]
        public Документ.СторнированиеНачислений СубконтоДт2 {get; set;}
        [Description1C8(Name = "СубконтоДт3", Comment = "", Synonym = "Субконто Дт 3")]
        public Документ.СторнированиеНачислений СубконтоДт3 {get; set;}
        [Description1C8(Name = "КоличествоДт", Comment = "", Synonym = "Количество Дт")]
        public Catalogs.ПараметрыТиповойОперации КоличествоДт {get; set;}
        [Description1C8(Name = "ВалютаДт", Comment = "", Synonym = "Валюта Дт")]
        public Catalogs.Валюты ВалютаДт {get; set;}
        [Description1C8(Name = "ВалютнаяСуммаДт", Comment = "", Synonym = "Валютная сумма Дт")]
        public Catalogs.ПараметрыТиповойОперации ВалютнаяСуммаДт {get; set;}
        [Description1C8(Name = "СчетКт", Comment = "", Synonym = "Счет Кт")]
        public ПланСчетов.Хозрасчетный СчетКт {get; set;}
        [Description1C8(Name = "СубконтоКт1", Comment = "", Synonym = "Субконто Кт 1")]
        public Документ.СторнированиеНачислений СубконтоКт1 {get; set;}
        [Description1C8(Name = "СубконтоКт2", Comment = "", Synonym = "Субконто Кт 2")]
        public Документ.СторнированиеНачислений СубконтоКт2 {get; set;}
        [Description1C8(Name = "СубконтоКт3", Comment = "", Synonym = "Субконто Кт 3")]
        public Документ.СторнированиеНачислений СубконтоКт3 {get; set;}
        [Description1C8(Name = "КоличествоКт", Comment = "", Synonym = "Количество Кт")]
        public Catalogs.ПараметрыТиповойОперации КоличествоКт {get; set;}
        [Description1C8(Name = "ВалютаКт", Comment = "", Synonym = "Валюта Кт")]
        public Catalogs.Валюты ВалютаКт {get; set;}
        [Description1C8(Name = "ВалютнаяСуммаКт", Comment = "", Synonym = "Валютная сумма Кт")]
        public Catalogs.ПараметрыТиповойОперации ВалютнаяСуммаКт {get; set;}
        [Description1C8(Name = "Сумма", Comment = "", Synonym = "Сумма")]
        public Catalogs.ПараметрыТиповойОперации Сумма {get; set;}
        [Description1C8(Name = "Содержание", Comment = "", Synonym = "Содержание")]
        [StringLength(100)]
        public string Содержание {get; set;}
        [Description1C8(Name = "НомерЖурнала", Comment = "", Synonym = "Номер журнала")]
        [StringLength(2)]
        public string НомерЖурнала {get; set;}
        [Description1C8(Name = "Формулы", Comment = "", Synonym = "Формулы")]
        public string Формулы {get; set;}
        [Description1C8(Name = "Условие", Comment = "", Synonym = "Условие")]
        public string Условие {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеДт", Comment = "", Synonym = "Нал. назн. Дт")]
        public Catalogs.ПараметрыТиповойОперации НалоговоеНазначениеДт {get; set;}
        [Description1C8(Name = "НалоговоеНазначениеКт", Comment = "", Synonym = "Нал. назн. Кт")]
        public Catalogs.ПараметрыТиповойОперации НалоговоеНазначениеКт {get; set;}
        [Description1C8(Name = "СуммаНУДт", Comment = "", Synonym = "Сумма (н/у) Дт")]
        public Catalogs.ПараметрыТиповойОперации СуммаНУДт {get; set;}
        [Description1C8(Name = "СуммаНУКт", Comment = "", Synonym = "Сумма (н/у) Кт")]
        public Catalogs.ПараметрыТиповойОперации СуммаНУКт {get; set;}
    }
    [Description1C8(Name = "ДвиженияРегистров", Comment = "", Synonym = "Движения регистров")]
    [Table("TypovyeOperatsyy_DvyzhenyiaRehystrov")]
    public class ТиповыеОперации_ДвиженияРегистров
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "ИмяРегистра", Comment = "", Synonym = "Имя регистра")]
        [StringLength(100)]
        public string ИмяРегистра {get; set;}
        [Description1C8(Name = "ТипРегистра", Comment = "", Synonym = "Тип регистра")]
        public Enums.ТипыРегистров ТипРегистра {get; set;}
        [Description1C8(Name = "НомерДвижения", Comment = "", Synonym = "Номер движения")]
        // Format 3.0
        public long НомерДвижения {get; set;}
        [Description1C8(Name = "Аналитика", Comment = "", Synonym = "Аналитика")]
        [StringLength(100)]
        public string Аналитика {get; set;}
        [Description1C8(Name = "Синоним", Comment = "", Synonym = "Синоним")]
        [StringLength(100)]
        public string Синоним {get; set;}
        [Description1C8(Name = "Значение", Comment = "", Synonym = "Значение")]
        public Документ.СторнированиеНачислений Значение {get; set;}
        [Description1C8(Name = "ТипПоляРегистра", Comment = "Измерение, Ресурс, Реквизит", Synonym = "Тип поля регистра")]
        public Enums.ТипыПолейРегистра ТипПоляРегистра {get; set;}
        [Description1C8(Name = "НеИзменятьЗначение", Comment = "Используется для получения значения у периодического регистра сведений.", Synonym = "Не изменять значение")]
        public bool НеИзменятьЗначение {get; set;}
        [Description1C8(Name = "ВидДвиженияРегистраНакопления", Comment = "Истина - Приход, Ложь - Расход", Synonym = "Вид движения регистра накопления")]
        public bool ВидДвиженияРегистраНакопления {get; set;}
    }
}
