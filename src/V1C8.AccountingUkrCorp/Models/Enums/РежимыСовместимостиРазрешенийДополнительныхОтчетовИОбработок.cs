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
    [Table("RezhymySovmestymostyRazreshenyiDopolnytelnykhOtchetovYObrabotok")]
    [Description1C8(Name = "РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок", Comment = "", Synonym = "Режимы совместимости разрешений дополнительных отчетов и обработок")]
    public class РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок:EnumItem
    {
        public static readonly РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок Версия_2_1_3 = new РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок{Name= "Версия_2_1_3",Synonym="Версия 2.1.3",Comment=""};
        public static readonly РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок Версия_2_2_2 = new РежимыСовместимостиРазрешенийДополнительныхОтчетовИОбработок{Name= "Версия_2_2_2",Synonym="Версия 2.2.2",Comment=""};
    }
}
