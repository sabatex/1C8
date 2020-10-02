using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыКонтактныхЛиц", Comment = "", Synonym = "Виды контактных лиц")]
    public class ВидыКонтактныхЛиц:EnumItem
    {
        public static readonly ВидыКонтактныхЛиц КонтактноеЛицоКонтрагента = new ВидыКонтактныхЛиц{Name= "КонтактноеЛицоКонтрагента",Synonim="Контактное лицо контрагента",Comment=""};
        public static readonly ВидыКонтактныхЛиц ПрочееКонтактноеЛицо = new ВидыКонтактныхЛиц{Name= "ПрочееКонтактноеЛицо",Synonim="Прочее контактное лицо",Comment=""};
        public static readonly ВидыКонтактныхЛиц ЛичныйКонтакт = new ВидыКонтактныхЛиц{Name= "ЛичныйКонтакт",Synonim="Личный контакт",Comment=""};
    }
}
