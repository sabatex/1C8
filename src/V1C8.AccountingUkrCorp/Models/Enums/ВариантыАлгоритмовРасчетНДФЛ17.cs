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
    [Table("VaryantyAlhorytmovRaschetNDFL17")]
    [Description1C8(Name = "ВариантыАлгоритмовРасчетНДФЛ17", Comment = "", Synonym = "Варианты алгоритмов расчет НДФЛ 17%")]
    public class ВариантыАлгоритмовРасчетНДФЛ17:EnumItem
    {
        public static readonly ВариантыАлгоритмовРасчетНДФЛ17 ДоначислениеНаСуммуПревышения = new ВариантыАлгоритмовРасчетНДФЛ17{Name= "ДоначислениеНаСуммуПревышения",Synonym="Доначисление на сумму превышения",Comment=""};
        public static readonly ВариантыАлгоритмовРасчетНДФЛ17 ОтдельныйРасчетБазы = new ВариантыАлгоритмовРасчетНДФЛ17{Name= "ОтдельныйРасчетБазы",Synonym="Устарело - Отдельный расчет базы для 17%",Comment=""};
    }
}
