using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыЗанятости", Comment = "", Synonym = "Виды занятости")]
    public class ВидыЗанятости:EnumItem
    {
        public static readonly ВидыЗанятости ОсновноеМестоРаботы = new ВидыЗанятости{Name= "ОсновноеМестоРаботы",Synonim="Основное место работы",Comment=""};
        public static readonly ВидыЗанятости Совместительство = new ВидыЗанятости{Name= "Совместительство",Synonim="Внешнее совместительство",Comment=""};
        public static readonly ВидыЗанятости ВнутреннееСовместительство = new ВидыЗанятости{Name= "ВнутреннееСовместительство",Synonim="Внутреннее совместительство",Comment=""};
        public static readonly ВидыЗанятости Подработка = new ВидыЗанятости{Name= "Подработка",Synonim="Подработка",Comment=""};
    }
}
