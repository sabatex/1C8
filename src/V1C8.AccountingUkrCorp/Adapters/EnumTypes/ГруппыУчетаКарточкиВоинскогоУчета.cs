using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ГруппыУчетаКарточкиВоинскогоУчета:EnumBase
    {
        public ГруппыУчетаКарточкиВоинскогоУчета(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОфицерскийСостав => GetProperty<EnumItem>("ОфицерскийСостав");
        public EnumItem РедовойСержантскийСтаршинскийСостав => GetProperty<EnumItem>("РедовойСержантскийСтаршинскийСостав");
        public EnumItem Женщины => GetProperty<EnumItem>("Женщины");
        public EnumItem Призывники => GetProperty<EnumItem>("Призывники");
    }
}
