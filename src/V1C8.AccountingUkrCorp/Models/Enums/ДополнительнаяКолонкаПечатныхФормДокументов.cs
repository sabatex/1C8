using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДополнительнаяКолонкаПечатныхФормДокументов", Comment = "(Общ)", Synonym = "Дополнительная колонка печатных форм документов")]
    public class ДополнительнаяКолонкаПечатныхФормДокументов:EnumItem
    {
        public static readonly ДополнительнаяКолонкаПечатныхФормДокументов НеВыводить = new ДополнительнаяКолонкаПечатныхФормДокументов{Name= "НеВыводить",Synonim="Не выводить",Comment="(Общ)"};
        public static readonly ДополнительнаяКолонкаПечатныхФормДокументов Артикул = new ДополнительнаяКолонкаПечатныхФормДокументов{Name= "Артикул",Synonim="Артикул",Comment="(Общ)"};
        public static readonly ДополнительнаяКолонкаПечатныхФормДокументов Код = new ДополнительнаяКолонкаПечатныхФормДокументов{Name= "Код",Synonim="Код",Comment="(Общ)"};
    }
}
