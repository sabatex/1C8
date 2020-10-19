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
    [Table("VydyNaznachenyiaDatZapreta")]
    [Description1C8(Name = "ВидыНазначенияДатЗапрета", Comment = "", Synonym = "Виды назначения дат запрета")]
    public class ВидыНазначенияДатЗапрета:EnumItem
    {
        public static readonly ВидыНазначенияДатЗапрета ДляВсехПользователей = new ВидыНазначенияДатЗапрета{Name= "ДляВсехПользователей",Synonym="Для всех пользователей",Comment=""};
        public static readonly ВидыНазначенияДатЗапрета ДляВсехИнформационныхБаз = new ВидыНазначенияДатЗапрета{Name= "ДляВсехИнформационныхБаз",Synonym="Для всех информационных баз",Comment=""};
    }
}
