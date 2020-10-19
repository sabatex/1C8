using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыЗатрат:EnumBase
    {
        public ВидыЗатрат(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Материальные => GetProperty<EnumItem>("Материальные");
        public EnumItem ОплатаТруда => GetProperty<EnumItem>("ОплатаТруда");
        public EnumItem ОтчисленияНаСоциальныеНужды => GetProperty<EnumItem>("ОтчисленияНаСоциальныеНужды");
        public EnumItem Амортизация => GetProperty<EnumItem>("Амортизация");
        public EnumItem Прочие => GetProperty<EnumItem>("Прочие");
    }
}
