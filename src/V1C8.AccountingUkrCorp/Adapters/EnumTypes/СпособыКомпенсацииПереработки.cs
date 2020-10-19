using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыКомпенсацииПереработки:EnumBase
    {
        public СпособыКомпенсацииПереработки(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПовышеннаяОплата => GetProperty<EnumItem>("ПовышеннаяОплата");
        public EnumItem Отгул => GetProperty<EnumItem>("Отгул");
    }
}
