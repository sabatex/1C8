using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыРегламентированныхОтчетов", Comment = "", Synonym = "Статусы регламентированных отчетов")]
    public enum СтатусыРегламентированныхОтчетов
    {
        [Description1C8(Name = "Принят", Comment = "", Synonym = "Принят")]
        Принят,
        [Description1C8(Name = "НеПринят", Comment = "", Synonym = "Не принят")]
        НеПринят,
        [Description1C8(Name = "ЖдетПодтвержденияСтатуса", Comment = "", Synonym = "Ждет подтверждения статуса")]
        ЖдетПодтвержденияСтатуса
    }
}
