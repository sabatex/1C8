using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УстарелоВидыЗанятости:EnumBase
    {
        public УстарелоВидыЗанятости(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОсновноеМестоРаботы => GetProperty<EnumItem>("ОсновноеМестоРаботы");
        public EnumItem Совместительство => GetProperty<EnumItem>("Совместительство");
        public EnumItem ВнутреннееСовместительство => GetProperty<EnumItem>("ВнутреннееСовместительство");
    }
}
