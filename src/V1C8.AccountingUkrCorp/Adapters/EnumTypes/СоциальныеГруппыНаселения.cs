using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СоциальныеГруппыНаселения:EnumBase
    {
        public СоциальныеГруппыНаселения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ДетиДо6 => GetProperty<EnumItem>("ДетиДо6");
        public EnumItem ДетиДо18 => GetProperty<EnumItem>("ДетиДо18");
        public EnumItem Трудоспособные => GetProperty<EnumItem>("Трудоспособные");
        public EnumItem НеТрудоспособные => GetProperty<EnumItem>("НеТрудоспособные");
    }
}
