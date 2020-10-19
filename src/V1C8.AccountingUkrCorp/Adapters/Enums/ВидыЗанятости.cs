using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыЗанятости:V1C8COMObject
    {
        public ВидыЗанятости(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОсновноеМестоРаботы => GetProperty<EnumItemBase>();
        public EnumItemBase Совместительство => GetProperty<EnumItemBase>();
        public EnumItemBase ВнутреннееСовместительство => GetProperty<EnumItemBase>();
        public EnumItemBase Подработка => GetProperty<EnumItemBase>();
    }
}
