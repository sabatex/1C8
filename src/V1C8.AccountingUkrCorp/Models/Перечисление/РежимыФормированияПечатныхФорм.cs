using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимыФормированияПечатныхФорм", Comment = "", Synonym = "Режимы формирования печатных форм")]
    public enum РежимыФормированияПечатныхФорм
    {
        [Description1C8(Name = "НаЯзыкеИнформационнойБазы", Comment = "", Synonym = "На языке информационной базы")]
        НаЯзыкеИнформационнойБазы,
        [Description1C8(Name = "НаЯзыкеИнтерфейсаПользователя", Comment = "", Synonym = "На языке интерфейса пользователя")]
        НаЯзыкеИнтерфейсаПользователя,
        [Description1C8(Name = "НаРусскомЯзыке", Comment = "", Synonym = "На русском языке")]
        НаРусскомЯзыке,
        [Description1C8(Name = "НаУкраинскомЯзыке", Comment = "", Synonym = "На украинском языке")]
        НаУкраинскомЯзыке
    }
}
