using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьВидыКалендарей:EnumBase
    {
        public УдалитьВидыКалендарей(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Пятидневка => GetProperty<EnumItem>("Пятидневка");
        public EnumItem Шестидневка => GetProperty<EnumItem>("Шестидневка");
        public EnumItem Произвольный => GetProperty<EnumItem>("Произвольный");
    }
}
