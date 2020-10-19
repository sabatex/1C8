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
    [Table("RezhymyVyboraPartyi")]
    [Description1C8(Name = "РежимыВыбораПартий", Comment = "", Synonym = "Режимы выбора партий")]
    public class РежимыВыбораПартий:EnumItem
    {
        public static readonly РежимыВыбораПартий ВыборИзПолногоСпискаПартий = new РежимыВыбораПартий{Name= "ВыборИзПолногоСпискаПартий",Synonym="Выбор из полного списка партий",Comment=""};
        public static readonly РежимыВыбораПартий ВыборИзПартийПоНоменклатуре = new РежимыВыбораПартий{Name= "ВыборИзПартийПоНоменклатуре",Synonym="Выбор из партий по номенклатуре",Comment=""};
        public static readonly РежимыВыбораПартий ВыборИзПартийИмеющихОстатки = new РежимыВыбораПартий{Name= "ВыборИзПартийИмеющихОстатки",Synonym="Выбор из партий, имеющих остатки",Comment=""};
    }
}
