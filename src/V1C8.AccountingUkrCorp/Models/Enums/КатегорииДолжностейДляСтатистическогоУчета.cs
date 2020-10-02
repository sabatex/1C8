using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииДолжностейДляСтатистическогоУчета", Comment = "", Synonym = "Категории должностей для статистического учета")]
    public class КатегорииДолжностейДляСтатистическогоУчета:EnumItem
    {
        public static readonly КатегорииДолжностейДляСтатистическогоУчета Руководители = new КатегорииДолжностейДляСтатистическогоУчета{Name= "Руководители",Synonim="Руководители",Comment=""};
        public static readonly КатегорииДолжностейДляСтатистическогоУчета Специалисты = new КатегорииДолжностейДляСтатистическогоУчета{Name= "Специалисты",Synonim="Специалисты",Comment=""};
        public static readonly КатегорииДолжностейДляСтатистическогоУчета ДругиеСлужащие = new КатегорииДолжностейДляСтатистическогоУчета{Name= "ДругиеСлужащие",Synonim="Другие служащие",Comment=""};
        public static readonly КатегорииДолжностейДляСтатистическогоУчета Рабочие = new КатегорииДолжностейДляСтатистическогоУчета{Name= "Рабочие",Synonim="Рабочие",Comment=""};
    }
}
