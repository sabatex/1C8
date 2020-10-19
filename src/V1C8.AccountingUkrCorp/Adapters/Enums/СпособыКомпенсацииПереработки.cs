using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыКомпенсацииПереработки:V1C8COMObject
    {
        public СпособыКомпенсацииПереработки(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПовышеннаяОплата => GetProperty<EnumItemBase>();
        public EnumItemBase Отгул => GetProperty<EnumItemBase>();
    }
}
