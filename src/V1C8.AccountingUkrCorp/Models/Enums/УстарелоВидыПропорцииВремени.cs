using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("UstareloVydyProportsyyVremeny")]
    [Description1C8(Name = "УстарелоВидыПропорцииВремени", Comment = "", Synonym = "Устарело виды пропорции времени")]
    public class УстарелоВидыПропорцииВремени:EnumItem
    {
        public static readonly УстарелоВидыПропорцииВремени ПоДням = new УстарелоВидыПропорцииВремени{Name= "ПоДням",Synonym="По дням",Comment=""};
        public static readonly УстарелоВидыПропорцииВремени ПоЧасам = new УстарелоВидыПропорцииВремени{Name= "ПоЧасам",Synonym="По часам",Comment=""};
    }
}
