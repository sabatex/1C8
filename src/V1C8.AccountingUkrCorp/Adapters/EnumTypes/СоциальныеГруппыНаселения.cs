using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СоциальныеГруппыНаселения:V1C8COMObject
    {
        public СоциальныеГруппыНаселения(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ДетиДо6 => GetProperty<EnumItemBase>("ДетиДо6");
        public EnumItemBase ДетиДо18 => GetProperty<EnumItemBase>("ДетиДо18");
        public EnumItemBase Трудоспособные => GetProperty<EnumItemBase>("Трудоспособные");
        public EnumItemBase НеТрудоспособные => GetProperty<EnumItemBase>("НеТрудоспособные");
    }
}
