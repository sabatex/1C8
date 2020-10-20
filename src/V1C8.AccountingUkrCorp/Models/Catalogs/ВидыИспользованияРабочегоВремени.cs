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
    [Table("VydyYspolzovanyiaRabochehoVremeny")]
    [Description1C8(Name = "ВидыИспользованияРабочегоВремени", Comment = "", Synonym = "Виды использования рабочего времени")]
    public class ВидыИспользованияРабочегоВремени:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "БуквенныйКод", Comment = "", Synonym = "Буквенный код")]
        [StringLength(3)]
        public string БуквенныйКод {get; set;}
        [Description1C8(Name = "ЦифровойКод", Comment = "", Synonym = "Цифровой код")]
        [StringLength(2)]
        public string ЦифровойКод {get; set;}
        [Description1C8(Name = "ПолноеНаименование", Comment = "", Synonym = "Полное наименование")]
        public string ПолноеНаименование {get; set;}
        [Description1C8(Name = "РабочееВремя", Comment = "", Synonym = "Рабочее время")]
        public bool РабочееВремя {get; set;}
        [Description1C8(Name = "ОсновноеВремя", Comment = "", Synonym = "Основное время")]
        public Catalogs.ВидыИспользованияРабочегоВремени ОсновноеВремя {get; set;}
        [Description1C8(Name = "Целосменное", Comment = "", Synonym = "Целосменное")]
        public bool Целосменное {get; set;}
        [Description1C8(Name = "НеИспользуется", Comment = "", Synonym = "Вид времени больше не используется")]
        public bool НеИспользуется {get; set;}
        [Description1C8(Name = "УважительнаяПричинаДляБольничных", Comment = "Является уважительной причиной для расчета больничных", Synonym = "Уважительная причина для больничных")]
        public bool УважительнаяПричинаДляБольничных {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
