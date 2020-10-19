using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядкиОкругления:V1C8COMObject
    {
        public ПорядкиОкругления(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Окр0_01 => GetProperty<EnumItemBase>("Окр0_01");
        public EnumItemBase Окр0_05 => GetProperty<EnumItemBase>("Окр0_05");
        public EnumItemBase Окр0_1 => GetProperty<EnumItemBase>("Окр0_1");
        public EnumItemBase Окр0_5 => GetProperty<EnumItemBase>("Окр0_5");
        public EnumItemBase Окр1 => GetProperty<EnumItemBase>("Окр1");
        public EnumItemBase Окр5 => GetProperty<EnumItemBase>("Окр5");
        public EnumItemBase Окр10 => GetProperty<EnumItemBase>("Окр10");
        public EnumItemBase Окр50 => GetProperty<EnumItemBase>("Окр50");
        public EnumItemBase Окр100 => GetProperty<EnumItemBase>("Окр100");
    }
}
