using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыМонетарныхСтатейВВалюте", Comment = "", Synonym = "Виды монетарных статей (в иностранной валюте)")]
    public enum ВидыМонетарныхСтатейВВалюте
    {
        [Description1C8(Name = "НеоперационнаяДеятельность", Comment = "", Synonym = "Неоперационная (финансовая, инвестиционная) деятельность")]
        НеоперационнаяДеятельность,
        [Description1C8(Name = "ОбязательстваУчредителей", Comment = "", Synonym = "Обязательства учредителей при формировании уставного капитала")]
        ОбязательстваУчредителей
    }
}
