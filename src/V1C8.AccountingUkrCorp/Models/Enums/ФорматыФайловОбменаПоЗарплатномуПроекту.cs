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
    [Table("FormatyFailovObmenaPoZarplatnomuProektu")]
    [Description1C8(Name = "ФорматыФайловОбменаПоЗарплатномуПроекту", Comment = "", Synonym = "Форматы файлов обмена по зарплатному проекту")]
    public class ФорматыФайловОбменаПоЗарплатномуПроекту:EnumItem
    {
        public static readonly ФорматыФайловОбменаПоЗарплатномуПроекту Версия1 = new ФорматыФайловОбменаПоЗарплатномуПроекту{Name= "Версия1",Synonym="Стандарт ЭОИ с банком (версия 1)",Comment="Стандарт электронного обмена информацией с банком (версия 1)"};
        public static readonly ФорматыФайловОбменаПоЗарплатномуПроекту Версия3 = new ФорматыФайловОбменаПоЗарплатномуПроекту{Name= "Версия3",Synonym="Стандарт ЭОИ с банком (версия 3)",Comment="Стандарт электронного обмена информацией с банком (версия 3)"};
        public static readonly ФорматыФайловОбменаПоЗарплатномуПроекту Версия32 = new ФорматыФайловОбменаПоЗарплатномуПроекту{Name= "Версия32",Synonym="Стандарт ЭОИ с банком (версия 3.2)",Comment="Стандарт электронного обмена информацией с банком (версия 3.2)"};
        public static readonly ФорматыФайловОбменаПоЗарплатномуПроекту Версия33 = new ФорматыФайловОбменаПоЗарплатномуПроекту{Name= "Версия33",Synonym="Стандарт ЭОИ с банком (версия 3.3)",Comment="Стандарт электронного обмена информацией с банком (версия 3.3)"};
        public static readonly ФорматыФайловОбменаПоЗарплатномуПроекту Версия34 = new ФорматыФайловОбменаПоЗарплатномуПроекту{Name= "Версия34",Synonym="Стандарт ЭОИ с банком (версия 3.4)",Comment="Стандарт электронного обмена информацией с банком (версия 3.4)"};
    }
}
