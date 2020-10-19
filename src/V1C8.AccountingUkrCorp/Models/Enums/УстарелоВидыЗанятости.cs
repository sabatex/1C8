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
    [Table("UstareloVydyZaniatosty")]
    [Description1C8(Name = "УстарелоВидыЗанятости", Comment = "(Регл)", Synonym = "Устарело виды занятости")]
    public class УстарелоВидыЗанятости:EnumItem
    {
        public static readonly УстарелоВидыЗанятости ОсновноеМестоРаботы = new УстарелоВидыЗанятости{Name= "ОсновноеМестоРаботы",Synonym="Основное место работы",Comment=""};
        public static readonly УстарелоВидыЗанятости Совместительство = new УстарелоВидыЗанятости{Name= "Совместительство",Synonym="Совместительство",Comment=""};
        public static readonly УстарелоВидыЗанятости ВнутреннееСовместительство = new УстарелоВидыЗанятости{Name= "ВнутреннееСовместительство",Synonym="Внутреннее совместительство",Comment=""};
    }
}
