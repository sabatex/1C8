using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "РежимыВыбораПартий", Comment = "", Synonym = "Режимы выбора партий")]
    public enum РежимыВыбораПартий
    {
        [Description1C8(Name = "ВыборИзПолногоСпискаПартий", Comment = "", Synonym = "Выбор из полного списка партий")]
        ВыборИзПолногоСпискаПартий,
        [Description1C8(Name = "ВыборИзПартийПоНоменклатуре", Comment = "", Synonym = "Выбор из партий по номенклатуре")]
        ВыборИзПартийПоНоменклатуре,
        [Description1C8(Name = "ВыборИзПартийИмеющихОстатки", Comment = "", Synonym = "Выбор из партий, имеющих остатки")]
        ВыборИзПартийИмеющихОстатки
    }
}
