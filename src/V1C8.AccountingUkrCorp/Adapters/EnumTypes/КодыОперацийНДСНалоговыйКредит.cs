using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КодыОперацийНДСНалоговыйКредит:EnumBase
    {
        public КодыОперацийНДСНалоговыйКредит(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ПервичныйДокумент => GetProperty<EnumItem>("ПервичныйДокумент");
        public EnumItem КорректировкиПоИспользованию => GetProperty<EnumItem>("КорректировкиПоИспользованию");
        public EnumItem КорректировкиНеправильноЗарегистрированныхДокументов => GetProperty<EnumItem>("КорректировкиНеправильноЗарегистрированныхДокументов");
    }
}
