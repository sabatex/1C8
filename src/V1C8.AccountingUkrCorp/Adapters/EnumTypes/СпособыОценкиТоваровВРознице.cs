using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыОценкиТоваровВРознице:V1C8COMObject
    {
        public СпособыОценкиТоваровВРознице(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоСтоимостиПриобретения => GetProperty<EnumItemBase>("ПоСтоимостиПриобретения");
        public EnumItemBase ПоПродажнойСтоимости => GetProperty<EnumItemBase>("ПоПродажнойСтоимости");
    }
}
