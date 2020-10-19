using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьТипыСкладов:EnumBase
    {
        public УдалитьТипыСкладов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Оптовый => GetProperty<EnumItem>("Оптовый");
        public EnumItem Розничный => GetProperty<EnumItem>("Розничный");
    }
}
