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
    [Table("Kontrahenty")]
    [Description1C8(Name = "Контрагенты", Comment = "", Synonym = "Контрагенты")]
    public class Контрагенты:EnumItem
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
    [Description1C8(Name = "НаименованиеПолное", Comment = "(Общ)", Synonym = "Полное наименование")]
    [StringLength(250)]
    public string НаименованиеПолное {get; set;}
    [Description1C8(Name = "ОбособленноеПодразделение", Comment = "", Synonym = "Обособленное подразделение")]
    public bool ОбособленноеПодразделение {get; set;}
    [Description1C8(Name = "ЮридическоеФизическоеЛицо", Comment = "(Общ)", Synonym = "Юр. / физ. лицо")]
    public DBNull ЮридическоеФизическоеЛицо {get; set;}
    [Description1C8(Name = "ГоловнойКонтрагент", Comment = "(Общ)", Synonym = "Головной контрагент")]
    public DBNull ГоловнойКонтрагент {get; set;}
    [Description1C8(Name = "ИНН", Comment = "Идентификационный номер налогоплательщика", Synonym = "ИНН")]
    [StringLength(12)]
    public string ИНН {get; set;}
    [Description1C8(Name = "ДокументУдостоверяющийЛичность", Comment = "", Synonym = "Документ")]
    [StringLength(250)]
    public string ДокументУдостоверяющийЛичность {get; set;}
    [Description1C8(Name = "ОсновнойБанковскийСчет", Comment = "", Synonym = "Банковский счет")]
    public DBNull ОсновнойБанковскийСчет {get; set;}
    [Description1C8(Name = "ОсновнойДоговорКонтрагента", Comment = "", Synonym = "Договор")]
    public DBNull ОсновнойДоговорКонтрагента {get; set;}
    [Description1C8(Name = "ОсновноеКонтактноеЛицо", Comment = "", Synonym = "Контактное лицо")]
    public DBNull ОсновноеКонтактноеЛицо {get; set;}
    [Description1C8(Name = "КодПоЕДРПОУ", Comment = "(Регл) Код по ЕДРПОУ", Synonym = "Код по ЕДРПОУ")]
    [StringLength(12)]
    public string КодПоЕДРПОУ {get; set;}
    [Description1C8(Name = "НомерСвидетельства", Comment = "Номер свидетельства плательщика НДС", Synonym = "Номер свидетельства")]
    [StringLength(12)]
    public string НомерСвидетельства {get; set;}
    [Description1C8(Name = "НеЯвляетсяРезидентом", Comment = "", Synonym = "Не является резидентом")]
    public bool НеЯвляетсяРезидентом {get; set;}
    [Description1C8(Name = "ДополнятьНаименованиеАдресДаннымиГоловногоКонтрагентаВНН", Comment = "", Synonym = "В налоговых накладных дополнять наименование и адрес данными головного контрагента")]
    public bool ДополнятьНаименованиеАдресДаннымиГоловногоКонтрагентаВНН {get; set;}
    [Description1C8(Name = "Комментарий", Comment = "", Synonym = "Комментарий")]
    public string Комментарий {get; set;}
    [Description1C8(Name = "ДополнительнаяИнформация", Comment = "", Synonym = "Дополнительная информация")]
    public string ДополнительнаяИнформация {get; set;}
    [Description1C8(Name = "КодФилиала", Comment = "", Synonym = "Код филиала (для отправки налоговых документов через FREDO Звіт)")]
    [StringLength(15)]
    public string КодФилиала {get; set;}
    [Description1C8(Name = "ИспользоватьЭДО1СЗвит", Comment = "", Synonym = "Использовать FREDO ДокМен")]
    public bool ИспользоватьЭДО1СЗвит {get; set;}
    #endregion реквізити
    }
}
