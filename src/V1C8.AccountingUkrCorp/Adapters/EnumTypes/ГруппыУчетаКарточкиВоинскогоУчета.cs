using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ГруппыУчетаКарточкиВоинскогоУчета:V1C8COMObject
    {
        public ГруппыУчетаКарточкиВоинскогоУчета(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОфицерскийСостав => GetProperty<EnumItemBase>("ОфицерскийСостав");
        public EnumItemBase РедовойСержантскийСтаршинскийСостав => GetProperty<EnumItemBase>("РедовойСержантскийСтаршинскийСостав");
        public EnumItemBase Женщины => GetProperty<EnumItemBase>("Женщины");
        public EnumItemBase Призывники => GetProperty<EnumItemBase>("Призывники");
    }
}
