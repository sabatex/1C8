using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ПорядкиОкругления:V1C8COMObject
    {
        public ПорядкиОкругления(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Окр0_01 => GetProperty<EnumItemBase>();
        public EnumItemBase Окр0_05 => GetProperty<EnumItemBase>();
        public EnumItemBase Окр0_1 => GetProperty<EnumItemBase>();
        public EnumItemBase Окр0_5 => GetProperty<EnumItemBase>();
        public EnumItemBase Окр1 => GetProperty<EnumItemBase>();
        public EnumItemBase Окр5 => GetProperty<EnumItemBase>();
        public EnumItemBase Окр10 => GetProperty<EnumItemBase>();
        public EnumItemBase Окр50 => GetProperty<EnumItemBase>();
        public EnumItemBase Окр100 => GetProperty<EnumItemBase>();
    }
}
