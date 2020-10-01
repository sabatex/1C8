using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыРасчетовПоДоговорам", Comment = "", Synonym = "Виды расчетов по договорам")]
    public enum ВидыРасчетовПоДоговорам
    {
        [Description1C8(Name = "РасчетыВВалютеРегламентированногоУчета", Comment = "", Synonym = "Расчеты в валюте регламентированного учета")]
        РасчетыВВалютеРегламентированногоУчета,
        [Description1C8(Name = "РасчетыВИностраннойВалюте", Comment = "", Synonym = "Расчеты в иностранной валюте")]
        РасчетыВИностраннойВалюте
    }
}
