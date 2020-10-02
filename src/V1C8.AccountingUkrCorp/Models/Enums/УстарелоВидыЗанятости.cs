using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "УстарелоВидыЗанятости", Comment = "(Регл)", Synonym = "Устарело виды занятости")]
    public class УстарелоВидыЗанятости:EnumItem
    {
        public static readonly УстарелоВидыЗанятости ОсновноеМестоРаботы = new УстарелоВидыЗанятости{Name= "ОсновноеМестоРаботы",Synonim="Основное место работы",Comment=""};
        public static readonly УстарелоВидыЗанятости Совместительство = new УстарелоВидыЗанятости{Name= "Совместительство",Synonim="Совместительство",Comment=""};
        public static readonly УстарелоВидыЗанятости ВнутреннееСовместительство = new УстарелоВидыЗанятости{Name= "ВнутреннееСовместительство",Synonim="Внутреннее совместительство",Comment=""};
    }
}
