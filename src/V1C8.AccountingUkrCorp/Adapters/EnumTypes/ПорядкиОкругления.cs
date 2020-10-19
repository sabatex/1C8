using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ПорядкиОкругления:EnumBase
    {
        public ПорядкиОкругления(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Окр0_01 => GetProperty<EnumItem>("Окр0_01");
        public EnumItem Окр0_05 => GetProperty<EnumItem>("Окр0_05");
        public EnumItem Окр0_1 => GetProperty<EnumItem>("Окр0_1");
        public EnumItem Окр0_5 => GetProperty<EnumItem>("Окр0_5");
        public EnumItem Окр1 => GetProperty<EnumItem>("Окр1");
        public EnumItem Окр5 => GetProperty<EnumItem>("Окр5");
        public EnumItem Окр10 => GetProperty<EnumItem>("Окр10");
        public EnumItem Окр50 => GetProperty<EnumItem>("Окр50");
        public EnumItem Окр100 => GetProperty<EnumItem>("Окр100");
    }
}
