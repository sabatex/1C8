using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииДолжностейДляВоинскогоУчета", Comment = "", Synonym = "Категории должностей для воинского учета")]
    public class КатегорииДолжностейДляВоинскогоУчета:EnumItem
    {
        public static readonly КатегорииДолжностейДляВоинскогоУчета Руководители = new КатегорииДолжностейДляВоинскогоУчета{Name= "Руководители",Synonym="Руководители",Comment=""};
        public static readonly КатегорииДолжностейДляВоинскогоУчета Специалисты = new КатегорииДолжностейДляВоинскогоУчета{Name= "Специалисты",Synonym="Специалисты",Comment=""};
        public static readonly КатегорииДолжностейДляВоинскогоУчета ДругиеСлужащие = new КатегорииДолжностейДляВоинскогоУчета{Name= "ДругиеСлужащие",Synonym="Другие служащие",Comment=""};
        public static readonly КатегорииДолжностейДляВоинскогоУчета Рабочие = new КатегорииДолжностейДляВоинскогоУчета{Name= "Рабочие",Synonym="Рабочие",Comment=""};
    }
}
