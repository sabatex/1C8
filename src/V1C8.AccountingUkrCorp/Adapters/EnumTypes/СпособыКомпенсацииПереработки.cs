using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыКомпенсацииПереработки:V1C8COMObject
    {
        public СпособыКомпенсацииПереработки(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПовышеннаяОплата => GetProperty<EnumItemBase>("ПовышеннаяОплата");
        public EnumItemBase Отгул => GetProperty<EnumItemBase>("Отгул");
    }
}
