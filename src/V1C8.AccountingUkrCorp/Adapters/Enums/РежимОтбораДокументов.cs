using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РежимОтбораДокументов:V1C8COMObject
    {
        public РежимОтбораДокументов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПоРеквизитам => GetProperty<EnumItemBase>();
        public EnumItemBase ПоОборотам => GetProperty<EnumItemBase>();
        public EnumItemBase ПоОстаткам => GetProperty<EnumItemBase>();
    }
}
