using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РежимыВыбораПартий:EnumBase
    {
        public РежимыВыбораПартий(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВыборИзПолногоСпискаПартий => GetProperty<EnumItem>("ВыборИзПолногоСпискаПартий");
        public EnumItem ВыборИзПартийПоНоменклатуре => GetProperty<EnumItem>("ВыборИзПартийПоНоменклатуре");
        public EnumItem ВыборИзПартийИмеющихОстатки => GetProperty<EnumItem>("ВыборИзПартийИмеющихОстатки");
    }
}
