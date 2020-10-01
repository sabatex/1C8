using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ДополнительнаяКолонкаПечатныхФормДокументов", Comment = "(Общ)", Synonym = "Дополнительная колонка печатных форм документов")]
    public enum ДополнительнаяКолонкаПечатныхФормДокументов
    {
        [Description1C8(Name = "НеВыводить", Comment = "(Общ)", Synonym = "Не выводить")]
        НеВыводить,
        [Description1C8(Name = "Артикул", Comment = "(Общ)", Synonym = "Артикул")]
        Артикул,
        [Description1C8(Name = "Код", Comment = "(Общ)", Synonym = "Код")]
        Код
    }
}
