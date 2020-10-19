using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ГруппыУчетаКарточкиВоинскогоУчета:V1C8COMObject
    {
        public ГруппыУчетаКарточкиВоинскогоУчета(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОфицерскийСостав => GetProperty<EnumItemBase>();
        public EnumItemBase РедовойСержантскийСтаршинскийСостав => GetProperty<EnumItemBase>();
        public EnumItemBase Женщины => GetProperty<EnumItemBase>();
        public EnumItemBase Призывники => GetProperty<EnumItemBase>();
    }
}
