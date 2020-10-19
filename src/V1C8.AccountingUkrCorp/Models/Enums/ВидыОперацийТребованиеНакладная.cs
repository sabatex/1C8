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
    [Table("VydyOperatsyiTrebovanyeNakladnaia")]
    [Description1C8(Name = "ВидыОперацийТребованиеНакладная", Comment = "(Общ)", Synonym = "Виды операций документа 'Требование-накладная'")]
    public class ВидыОперацийТребованиеНакладная:EnumItem
    {
        public static readonly ВидыОперацийТребованиеНакладная Материалы = new ВидыОперацийТребованиеНакладная{Name= "Материалы",Synonym="Материалы",Comment=""};
        public static readonly ВидыОперацийТребованиеНакладная Оборудование = new ВидыОперацийТребованиеНакладная{Name= "Оборудование",Synonym="Оборудование",Comment=""};
    }
}
