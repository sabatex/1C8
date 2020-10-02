using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыРегламентированныхОтчетов", Comment = "", Synonym = "Статусы регламентированных отчетов")]
    public class СтатусыРегламентированныхОтчетов:EnumItem
    {
        public static readonly СтатусыРегламентированныхОтчетов Принят = new СтатусыРегламентированныхОтчетов{Name= "Принят",Synonym="Принят",Comment=""};
        public static readonly СтатусыРегламентированныхОтчетов НеПринят = new СтатусыРегламентированныхОтчетов{Name= "НеПринят",Synonym="Не принят",Comment=""};
        public static readonly СтатусыРегламентированныхОтчетов ЖдетПодтвержденияСтатуса = new СтатусыРегламентированныхОтчетов{Name= "ЖдетПодтвержденияСтатуса",Synonym="Ждет подтверждения статуса",Comment=""};
    }
}
