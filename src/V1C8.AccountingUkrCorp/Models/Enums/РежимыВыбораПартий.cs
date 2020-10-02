using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимыВыбораПартий", Comment = "", Synonym = "Режимы выбора партий")]
    public class РежимыВыбораПартий:EnumItem
    {
        public static readonly РежимыВыбораПартий ВыборИзПолногоСпискаПартий = new РежимыВыбораПартий{Name= "ВыборИзПолногоСпискаПартий",Synonim="Выбор из полного списка партий",Comment=""};
        public static readonly РежимыВыбораПартий ВыборИзПартийПоНоменклатуре = new РежимыВыбораПартий{Name= "ВыборИзПартийПоНоменклатуре",Synonim="Выбор из партий по номенклатуре",Comment=""};
        public static readonly РежимыВыбораПартий ВыборИзПартийИмеющихОстатки = new РежимыВыбораПартий{Name= "ВыборИзПартийИмеющихОстатки",Synonim="Выбор из партий, имеющих остатки",Comment=""};
    }
}
