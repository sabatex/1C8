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
    [Table("StsenaryyObmenovDannymy")]
    [Description1C8(Name = "СценарииОбменовДанными", Comment = "", Synonym = "Сценарии синхронизации данных")]
    public class СценарииОбменовДанными:CatalogItem
    {
        #region реквізити
        [Description1C8(Name = "ИспользоватьРегламентноеЗадание", Comment = "", Synonym = "Использовать регламентное задание")]
        public bool ИспользоватьРегламентноеЗадание {get; set;}
        [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
        public string Комментарий {get; set;}
        [Description1C8(Name = "РегламентноеЗаданиеGUID", Comment = "", Synonym = "Регламентное задание GUID")]
        [StringLength(40)]
        public string РегламентноеЗаданиеGUID {get; set;}
        #endregion реквізити
        #region tables
        [Description1C8(Name = "НастройкиОбмена", Comment = "", Synonym = "Настройки синхронизации")]
        public List<СценарииОбменовДанными_НастройкиОбмена> СценарииОбменовДаннымиНастройкиОбмена {get;set;}
        #endregion tables
    }
    [Description1C8(Name = "НастройкиОбмена", Comment = "", Synonym = "Настройки синхронизации")]
    [Table("StsenaryyObmenovDannymy_NastroikyObmena")]
    public class СценарииОбменовДанными_НастройкиОбмена
    {
        public long Id {get;set;}
        public Guid Owner {get;set;}
        [Description1C8(Name = "УзелИнформационнойБазы", Comment = "", Synonym = "Информационная база")]
        public ПланОбмена.УдалитьОбменУправлениеТорговлейБухгалтерияФоновый УзелИнформационнойБазы {get; set;}
        [Description1C8(Name = "ВидТранспортаОбмена", Comment = "", Synonym = "Подключение")]
        public Enums.ВидыТранспортаСообщенийОбмена ВидТранспортаОбмена {get; set;}
        [Description1C8(Name = "ВыполняемоеДействие", Comment = "", Synonym = "Выполняемое действие")]
        public Enums.ДействияПриОбмене ВыполняемоеДействие {get; set;}
    }
}
