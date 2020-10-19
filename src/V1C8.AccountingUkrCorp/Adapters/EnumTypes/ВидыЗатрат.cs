using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыЗатрат:V1C8COMObject
    {
        public ВидыЗатрат(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Материальные => GetProperty<EnumItemBase>("Материальные");
        public EnumItemBase ОплатаТруда => GetProperty<EnumItemBase>("ОплатаТруда");
        public EnumItemBase ОтчисленияНаСоциальныеНужды => GetProperty<EnumItemBase>("ОтчисленияНаСоциальныеНужды");
        public EnumItemBase Амортизация => GetProperty<EnumItemBase>("Амортизация");
        public EnumItemBase Прочие => GetProperty<EnumItemBase>("Прочие");
    }
}
