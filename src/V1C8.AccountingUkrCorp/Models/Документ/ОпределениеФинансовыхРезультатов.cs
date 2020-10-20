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
    [Table("OpredelenyeFynansovykhRezultatov")]
    [Description1C8(Name = "ОпределениеФинансовыхРезультатов", Comment = "", Synonym = "Определение финансовых результатов")]
    public class ОпределениеФинансовыхРезультатов:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "Организация", Comment = "", Synonym = "Организация")]
        public Catalogs.Организации Организация {get; set;}
        [Description1C8(Name = "РассчитыватьПрибыльУбыток", Comment = "Расчет прибыли (убытка) в конце года с формированием сальдо на 44 счете", Synonym = "Рассчитывать прибыль/убыток (на счете 44)")]
        public bool РассчитыватьПрибыльУбыток {get; set;}
        [Description1C8(Name = "ЗакрыватьДоходыИРасходы", Comment = "", Synonym = "Закрывать доходы и расходы (на счет 79)")]
        public bool ЗакрыватьДоходыИРасходы {get; set;}
        [Description1C8(Name = "РучнаяКорректировка", Comment = "", Synonym = "Ручная корректировка")]
        public bool РучнаяКорректировка {get; set;}
        [Description1C8(Name = "Ответственный", Comment = "(Общ)", Synonym = "Ответственный")]
        public Catalogs.Пользователи Ответственный {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "(Общ) Любая дополнительная информация", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        #endregion реквізити
        #region tables
        #endregion tables
    }
}
