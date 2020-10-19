using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class УдалитьПолФизическихЛиц:EnumBase
    {
        public УдалитьПолФизическихЛиц(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Мужской => GetProperty<EnumItem>("Мужской");
        public EnumItem Женский => GetProperty<EnumItem>("Женский");
    }
}
