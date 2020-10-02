using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УстарелоВидыПропорцииВремени", Comment = "", Synonym = "Устарело виды пропорции времени")]
    public class УстарелоВидыПропорцииВремени:EnumItem
    {
        public static readonly УстарелоВидыПропорцииВремени ПоДням = new УстарелоВидыПропорцииВремени{Name= "ПоДням",Synonim="По дням",Comment=""};
        public static readonly УстарелоВидыПропорцииВремени ПоЧасам = new УстарелоВидыПропорцииВремени{Name= "ПоЧасам",Synonim="По часам",Comment=""};
    }
}
