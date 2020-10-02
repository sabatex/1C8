using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДеятельностиНДС", Comment = "", Synonym = "Виды деятельности НДС")]
    public class ВидыДеятельностиНДС:EnumItem
    {
        public static readonly ВидыДеятельностиНДС Облагаемая = new ВидыДеятельностиНДС{Name= "Облагаемая",Synonim="Облагаемая",Comment=""};
        public static readonly ВидыДеятельностиНДС Необлагаемая = new ВидыДеятельностиНДС{Name= "Необлагаемая",Synonim="Необлагаемая",Comment=""};
        public static readonly ВидыДеятельностиНДС ПропорциональноОблагаемая = new ВидыДеятельностиНДС{Name= "ПропорциональноОблагаемая",Synonim="Пропорционально облагаемая",Comment=""};
    }
}
