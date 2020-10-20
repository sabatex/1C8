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
    [Table("PostavliaemyeRasshyrenyia")]
    [Description1C8(Name = "ПоставляемыеРасширения", Comment = "", Synonym = "Поставляемые расширения")]
    public class ПоставляемыеРасширения:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Имя", Comment = "", Synonym = "Имя")]
        [StringLength(260)]
        public string Имя {get; set;}
        [Description1C8(Name = "Версия", Comment = "", Synonym = "Версия")]
        [StringLength(18)]
        public string Версия {get; set;}
        [Description1C8(Name = "ХранилищеРасширения", Comment = "", Synonym = "Хранилище расширения")]
        // Сховище значень
        public byte[] ХранилищеРасширения {get; set;}
        [Description1C8(Name = "Информация", Comment = "", Synonym = "Информация")]
        [StringLength(1024)]
        public string Информация {get; set;}
        [Description1C8(Name = "ИдентификаторВерсии", Comment = "", Synonym = "Идентификатор версии")]
        public Guid ИдентификаторВерсии {get; set;}
        [Description1C8(Name = "Отключено", Comment = "", Synonym = "Отключено")]
        public bool Отключено {get; set;}
        [Description1C8(Name = "ПричинаОтключения", Comment = "", Synonym = "Причина отключения")]
        public Enums.ПричиныОтключенияРасширенийВМоделиСервиса ПричинаОтключения {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "Совместимость", Comment = "", Synonym = "Совместимость")]
        public List<ПоставляемыеРасширения_Совместимость> ПоставляемыеРасширенияСовместимость {get;set;}
        [Description1C8(Name = "Разрешения", Comment = "", Synonym = "Разрешения")]
        public List<ПоставляемыеРасширения_Разрешения> ПоставляемыеРасширенияРазрешения {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "Совместимость", Comment = "", Synonym = "Совместимость")]
    [Table("PostavliaemyeRasshyrenyia_Sovmestymost")]
    public class ПоставляемыеРасширения_Совместимость
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "МинимальнаяВерсия", Comment = "", Synonym = "Минимальная версия")]
        [StringLength(18)]
        public string МинимальнаяВерсия {get; set;}
        [Description1C8(Name = "МаксимальнаяВерсия", Comment = "", Synonym = "Максимальная версия")]
        [StringLength(18)]
        public string МаксимальнаяВерсия {get; set;}
    }
    [Description1C8(Name = "Разрешения", Comment = "", Synonym = "Разрешения")]
    [Table("PostavliaemyeRasshyrenyia_Razreshenyia")]
    public class ПоставляемыеРасширения_Разрешения
    {
    public long Id {get;set;}
    public Guid Owner {get;set;}
        [Description1C8(Name = "ВидРазрешения", Comment = "", Synonym = "Вид разрешения")]
        [StringLength(255)]
        public string ВидРазрешения {get; set;}
        [Description1C8(Name = "Параметры", Comment = "", Synonym = "Параметры")]
        // Сховище значень
        public byte[] Параметры {get; set;}
    }
}
