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
    [Table("Orhanyzatsyy")]
    [Description1C8(Name = "Организации", Comment = "", Synonym = "Организации")]
    public class Организации:EnumItem
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
    [Description1C8(Name = "БанковскийСчетДляРасчетовСФСС", Comment = "", Synonym = "Банковский счет (для ФСС)")]
    public DBNull БанковскийСчетДляРасчетовСФСС {get; set;}
    [Description1C8(Name = "ГоловнаяОрганизация", Comment = "(Общ)", Synonym = "Головная организация")]
    public DBNull ГоловнаяОрганизация {get; set;}
    [Description1C8(Name = "ГрафикРаботы", Comment = "", Synonym = "График работы")]
    public DBNull ГрафикРаботы {get; set;}
    [Description1C8(Name = "ДатаНачалаИспользованияЗвит1С", Comment = "", Synonym = "Дата начала использования 'FREDO Звіт'")]
    public DateTime ДатаНачалаИспользованияЗвит1С {get; set;}
    [Description1C8(Name = "ИндивидуальныйПредприниматель", Comment = "", Synonym = "Физическое лицо")]
    public DBNull ИндивидуальныйПредприниматель {get; set;}
    [Description1C8(Name = "НаименованиеСокращенное", Comment = "", Synonym = "Сокращенное юр. наименование")]
    [StringLength(250)]
    public string НаименованиеСокращенное {get; set;}
    [Description1C8(Name = "КодПоЕДРПОУ", Comment = "Код ЕДРПОУ", Synonym = "Код по ЕДРПОУ")]
    [StringLength(20)]
    public string КодПоЕДРПОУ {get; set;}
    [Description1C8(Name = "НаименованиеПолное", Comment = "", Synonym = "Полное наименование")]
    [StringLength(250)]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "ГрафикРаботыСотрудников", Comment = "", Synonym = "График работы сотрудников")]
    public DBNull ГрафикРаботыСотрудников {get; set;}
    [Description1C8(Name = "ОбособленноеПодразделение", Comment = "", Synonym = "Обособленное подразделение")]
    public bool ОбособленноеПодразделение {get; set;}
    [Description1C8(Name = "ОсновнойБанковскийСчет", Comment = "(Общ)", Synonym = "Основной банковский счет")]
    public DBNull ОсновнойБанковскийСчет {get; set;}
    [Description1C8(Name = "Префикс", Comment = "", Synonym = "Префикс")]
    [StringLength(2)]
    public string Префикс {get; set;}
    [Description1C8(Name = "ПрефиксБ12", Comment = "(Общ)", Synonym = "Префикс (бух 1.2)")]
    [StringLength(3)]
    public string ПрефиксБ12 {get; set;}
    [Description1C8(Name = "УдалитьФайлЛоготип", Comment = "", Synonym = "(не используется) Логотип")]
    public DBNull УдалитьФайлЛоготип {get; set;}
    [Description1C8(Name = "УдалитьФайлФаксимильнаяПечать", Comment = "", Synonym = "(не используется) Факсимильная печать")]
    public DBNull УдалитьФайлФаксимильнаяПечать {get; set;}
    [Description1C8(Name = "УдалитьФайлФаксимильнаяПодпись", Comment = "", Synonym = "(не используется) Факсимильная подпись")]
    public DBNull УдалитьФайлФаксимильнаяПодпись {get; set;}
    [Description1C8(Name = "ЮридическоеФизическоеЛицо", Comment = "", Synonym = "Юридическое / физическое лицо")]
    public DBNull ЮридическоеФизическоеЛицо {get; set;}
    [Description1C8(Name = "ФайлЛоготип", Comment = "", Synonym = "Логотип")]
    public DBNull ФайлЛоготип {get; set;}
    [Description1C8(Name = "ФайлФаксимильнаяПечать", Comment = "", Synonym = "Факсимильная печать")]
    public DBNull ФайлФаксимильнаяПечать {get; set;}
    [Description1C8(Name = "ФайлФаксимильнаяПодпись", Comment = "", Synonym = "Факсимильная подпись")]
    public DBNull ФайлФаксимильнаяПодпись {get; set;}
    #endregion реквізити
    }
}
