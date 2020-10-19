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
    [Table("VydyOperatsyiOtchetORoznychnykhProdazhakh")]
    [Description1C8(Name = "ВидыОперацийОтчетОРозничныхПродажах", Comment = "", Synonym = "Виды операций отчет о розничных продажах")]
    public class ВидыОперацийОтчетОРозничныхПродажах:EnumItem
    {
        public static readonly ВидыОперацийОтчетОРозничныхПродажах ОтчетККМОПродажах = new ВидыОперацийОтчетОРозничныхПродажах{Name= "ОтчетККМОПродажах",Synonym="ККМ",Comment=""};
        public static readonly ВидыОперацийОтчетОРозничныхПродажах ОтчетНТТОПродажах = new ВидыОперацийОтчетОРозничныхПродажах{Name= "ОтчетНТТОПродажах",Synonym="НТТ",Comment=""};
    }
}
