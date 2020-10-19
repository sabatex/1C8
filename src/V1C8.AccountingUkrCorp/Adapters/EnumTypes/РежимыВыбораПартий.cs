using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыВыбораПартий:V1C8COMObject
    {
        public РежимыВыбораПартий(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВыборИзПолногоСпискаПартий => GetProperty<EnumItemBase>("ВыборИзПолногоСпискаПартий");
        public EnumItemBase ВыборИзПартийПоНоменклатуре => GetProperty<EnumItemBase>("ВыборИзПартийПоНоменклатуре");
        public EnumItemBase ВыборИзПартийИмеющихОстатки => GetProperty<EnumItemBase>("ВыборИзПартийИмеющихОстатки");
    }
}
