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
    [Table("VydyZaniatosty")]
    [Description1C8(Name = "ВидыЗанятости", Comment = "", Synonym = "Виды занятости")]
    public class ВидыЗанятости:EnumItem
    {
        public static readonly ВидыЗанятости ОсновноеМестоРаботы = new ВидыЗанятости{Name= "ОсновноеМестоРаботы",Synonym="Основное место работы",Comment=""};
        public static readonly ВидыЗанятости Совместительство = new ВидыЗанятости{Name= "Совместительство",Synonym="Внешнее совместительство",Comment=""};
        public static readonly ВидыЗанятости ВнутреннееСовместительство = new ВидыЗанятости{Name= "ВнутреннееСовместительство",Synonym="Внутреннее совместительство",Comment=""};
        public static readonly ВидыЗанятости Подработка = new ВидыЗанятости{Name= "Подработка",Synonym="Подработка",Comment=""};
    }
}
