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
    [Table("KatehoryySvedenyiOFyzycheskykhLytsakh")]
    [Description1C8(Name = "КатегорииСведенийОФизическихЛицах", Comment = "", Synonym = "Категории сведений о физических лицах")]
    public class КатегорииСведенийОФизическихЛицах:EnumItem
    {
        public static readonly КатегорииСведенийОФизическихЛицах Должность = new КатегорииСведенийОФизическихЛицах{Name= "Должность",Synonym="Должность",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах Инвалидность = new КатегорииСведенийОФизическихЛицах{Name= "Инвалидность",Synonym="Инвалидность",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах КонтактнаяИнформация = new КатегорииСведенийОФизическихЛицах{Name= "КонтактнаяИнформация",Synonym="Контактная информация",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах Образование = new КатегорииСведенийОФизическихЛицах{Name= "Образование",Synonym="Образование",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах Организация = new КатегорииСведенийОФизическихЛицах{Name= "Организация",Synonym="Организация",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах Подразделение = new КатегорииСведенийОФизическихЛицах{Name= "Подразделение",Synonym="Подразделение",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах СемейноеПоложение = new КатегорииСведенийОФизическихЛицах{Name= "СемейноеПоложение",Synonym="Семейное положение",Comment=""};
        public static readonly КатегорииСведенийОФизическихЛицах СоставСемьи = new КатегорииСведенийОФизическихЛицах{Name= "СоставСемьи",Synonym="Состав семьи",Comment=""};
    }
}
