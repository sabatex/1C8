using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ВидыДоговоровКонтрагентов", Comment = "(Общ)", Synonym = "Виды договоров контрагентов")]
    public enum ВидыДоговоровКонтрагентов
    {
        [Description1C8(Name = "СПоставщиком", Comment = "(Общ)", Synonym = "С поставщиком")]
        СПоставщиком,
        [Description1C8(Name = "СПокупателем", Comment = "(Общ)", Synonym = "С покупателем")]
        СПокупателем,
        [Description1C8(Name = "СКомитентом", Comment = "(Общ)", Synonym = "С комитентом")]
        СКомитентом,
        [Description1C8(Name = "СКомиссионером", Comment = "(Общ)", Synonym = "С комиссионером")]
        СКомиссионером,
        [Description1C8(Name = "Бартерный", Comment = "", Synonym = "Бартерный")]
        Бартерный,
        [Description1C8(Name = "Прочее", Comment = "(Общ)", Synonym = "Прочее")]
        Прочее
    }
}
