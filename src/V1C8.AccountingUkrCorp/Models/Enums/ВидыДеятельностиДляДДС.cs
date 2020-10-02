using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДеятельностиДляДДС", Comment = "Виды деятельности для отчета ДДС", Synonym = "Виды деятельности для отчета ДДС")]
    public class ВидыДеятельностиДляДДС:EnumItem
    {
        public static readonly ВидыДеятельностиДляДДС Операционная = new ВидыДеятельностиДляДДС{Name= "Операционная",Synonim="Операционная",Comment=""};
        public static readonly ВидыДеятельностиДляДДС Инвестиционная = new ВидыДеятельностиДляДДС{Name= "Инвестиционная",Synonim="Инвестиционная",Comment=""};
        public static readonly ВидыДеятельностиДляДДС Финансовая = new ВидыДеятельностиДляДДС{Name= "Финансовая",Synonim="Финансовая",Comment=""};
    }
}
