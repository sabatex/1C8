using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыКонтактныхЛиц", Comment = "", Synonym = "Виды контактных лиц")]
    public enum ВидыКонтактныхЛиц
    {
        [Description1C8(Name = "КонтактноеЛицоКонтрагента", Comment = "", Synonym = "Контактное лицо контрагента")]
        КонтактноеЛицоКонтрагента,
        [Description1C8(Name = "ПрочееКонтактноеЛицо", Comment = "", Synonym = "Прочее контактное лицо")]
        ПрочееКонтактноеЛицо,
        [Description1C8(Name = "ЛичныйКонтакт", Comment = "", Synonym = "Личный контакт")]
        ЛичныйКонтакт
    }
}
