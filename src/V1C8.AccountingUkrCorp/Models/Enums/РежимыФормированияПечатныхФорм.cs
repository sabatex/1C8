using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимыФормированияПечатныхФорм", Comment = "", Synonym = "Режимы формирования печатных форм")]
    public class РежимыФормированияПечатныхФорм:EnumItem
    {
        public static readonly РежимыФормированияПечатныхФорм НаЯзыкеИнформационнойБазы = new РежимыФормированияПечатныхФорм{Name= "НаЯзыкеИнформационнойБазы",Synonym="На языке информационной базы",Comment=""};
        public static readonly РежимыФормированияПечатныхФорм НаЯзыкеИнтерфейсаПользователя = new РежимыФормированияПечатныхФорм{Name= "НаЯзыкеИнтерфейсаПользователя",Synonym="На языке интерфейса пользователя",Comment=""};
        public static readonly РежимыФормированияПечатныхФорм НаРусскомЯзыке = new РежимыФормированияПечатныхФорм{Name= "НаРусскомЯзыке",Synonym="На русском языке",Comment=""};
        public static readonly РежимыФормированияПечатныхФорм НаУкраинскомЯзыке = new РежимыФормированияПечатныхФорм{Name= "НаУкраинскомЯзыке",Synonym="На украинском языке",Comment=""};
    }
}
