using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КатегорииСведенийОФизическихЛицах", Comment = "", Synonym = "Категории сведений о физических лицах")]
    public class КатегорииСведенийОФизическихЛицах:EnumItem
    {
        public static readonly КатегорииСведенийОФизическихЛицах Должность = new КатегорииСведенийОФизическихЛицах{Name= "Должность",Synonim="Должность",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах Инвалидность = new КатегорииСведенийОФизическихЛицах{Name= "Инвалидность",Synonim="Инвалидность",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах КонтактнаяИнформация = new КатегорииСведенийОФизическихЛицах{Name= "КонтактнаяИнформация",Synonim="Контактная информация",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах Образование = new КатегорииСведенийОФизическихЛицах{Name= "Образование",Synonim="Образование",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах Организация = new КатегорииСведенийОФизическихЛицах{Name= "Организация",Synonim="Организация",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах Подразделение = new КатегорииСведенийОФизическихЛицах{Name= "Подразделение",Synonim="Подразделение",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах СемейноеПоложение = new КатегорииСведенийОФизическихЛицах{Name= "СемейноеПоложение",Synonim="Семейное положение",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах СоставСемьи = new КатегорииСведенийОФизическихЛицах{Name= "СоставСемьи",Synonim="Состав семьи",Comment=""};
    }
}
