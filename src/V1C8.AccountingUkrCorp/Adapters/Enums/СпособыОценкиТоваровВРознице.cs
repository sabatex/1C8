using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыОценкиТоваровВРознице:V1C8COMObject
    {
        public СпособыОценкиТоваровВРознице(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоСтоимостиПриобретения => GetProperty<EnumItemBase>();
        public EnumItemBase ПоПродажнойСтоимости => GetProperty<EnumItemBase>();
    }
}
