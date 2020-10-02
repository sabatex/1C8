using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "СтатусыКонтрагентов", Comment = "(Общ)", Synonym = "Статусы контрагентов")]
    public class СтатусыКонтрагентов:EnumItem
    {
        public static readonly СтатусыКонтрагентов Покупатель = new СтатусыКонтрагентов{Name= "Покупатель",Synonym="Покупатель",Comment="(Общ)"};
        public static readonly СтатусыКонтрагентов Поставщик = new СтатусыКонтрагентов{Name= "Поставщик",Synonym="Поставщик",Comment="(Общ)"};
        public static readonly СтатусыКонтрагентов Прочее = new СтатусыКонтрагентов{Name= "Прочее",Synonym="Прочее",Comment="(Общ)"};
    }
}
