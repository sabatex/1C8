using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УстарелоВидыЗанятости:V1C8COMObject
    {
        public УстарелоВидыЗанятости(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОсновноеМестоРаботы => GetProperty<EnumItemBase>("ОсновноеМестоРаботы");
        public EnumItemBase Совместительство => GetProperty<EnumItemBase>("Совместительство");
        public EnumItemBase ВнутреннееСовместительство => GetProperty<EnumItemBase>("ВнутреннееСовместительство");
    }
}
