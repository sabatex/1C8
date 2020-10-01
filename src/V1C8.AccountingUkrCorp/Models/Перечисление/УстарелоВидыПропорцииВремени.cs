using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УстарелоВидыПропорцииВремени", Comment = "", Synonym = "Устарело виды пропорции времени")]
    public enum УстарелоВидыПропорцииВремени
    {
        [Description1C8(Name = "ПоДням", Comment = "", Synonym = "По дням")]
        ПоДням,
        [Description1C8(Name = "ПоЧасам", Comment = "", Synonym = "По часам")]
        ПоЧасам
    }
}
