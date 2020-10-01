using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииДолжностейДляВоинскогоУчета", Comment = "", Synonym = "Категории должностей для воинского учета")]
    public enum КатегорииДолжностейДляВоинскогоУчета
    {
        [Description1C8(Name = "Руководители", Comment = "", Synonym = "Руководители")]
        Руководители,
        [Description1C8(Name = "Специалисты", Comment = "", Synonym = "Специалисты")]
        Специалисты,
        [Description1C8(Name = "ДругиеСлужащие", Comment = "", Synonym = "Другие служащие")]
        ДругиеСлужащие,
        [Description1C8(Name = "Рабочие", Comment = "", Synonym = "Рабочие")]
        Рабочие
    }
}
