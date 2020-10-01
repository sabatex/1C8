using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "ФорматыФайловОбменаПоЗарплатномуПроекту", Comment = "", Synonym = "Форматы файлов обмена по зарплатному проекту")]
    public enum ФорматыФайловОбменаПоЗарплатномуПроекту
    {
        [Description1C8(Name = "Версия1", Comment = "Стандарт электронного обмена информацией с банком (версия 1)", Synonym = "Стандарт ЭОИ с банком (версия 1)")]
        Версия1,
        [Description1C8(Name = "Версия3", Comment = "Стандарт электронного обмена информацией с банком (версия 3)", Synonym = "Стандарт ЭОИ с банком (версия 3)")]
        Версия3,
        [Description1C8(Name = "Версия32", Comment = "Стандарт электронного обмена информацией с банком (версия 3.2)", Synonym = "Стандарт ЭОИ с банком (версия 3.2)")]
        Версия32,
        [Description1C8(Name = "Версия33", Comment = "Стандарт электронного обмена информацией с банком (версия 3.3)", Synonym = "Стандарт ЭОИ с банком (версия 3.3)")]
        Версия33,
        [Description1C8(Name = "Версия34", Comment = "Стандарт электронного обмена информацией с банком (версия 3.4)", Synonym = "Стандарт ЭОИ с банком (версия 3.4)")]
        Версия34
    }
}
