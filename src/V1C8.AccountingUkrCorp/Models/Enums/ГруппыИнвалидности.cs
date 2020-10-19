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
    [Table("HruppyYnvalydnosty")]
    [Description1C8(Name = "ГруппыИнвалидности", Comment = "(Регл)", Synonym = "Группы инвалидности")]
    public class ГруппыИнвалидности:EnumItem
    {
        public static readonly ГруппыИнвалидности ПерваяГруппа = new ГруппыИнвалидности{Name= "ПерваяГруппа",Synonym="Первая (I)",Comment=""};
        public static readonly ГруппыИнвалидности ВтораяГруппа = new ГруппыИнвалидности{Name= "ВтораяГруппа",Synonym="Вторая (II)",Comment=""};
        public static readonly ГруппыИнвалидности ТретьяГруппа = new ГруппыИнвалидности{Name= "ТретьяГруппа",Synonym="Третья (III)",Comment=""};
    }
}
