using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class КодыОперацийНДСНалоговыйКредит:V1C8COMObject
    {
        public КодыОперацийНДСНалоговыйКредит(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПервичныйДокумент => GetProperty<EnumItemBase>("ПервичныйДокумент");
        public EnumItemBase КорректировкиПоИспользованию => GetProperty<EnumItemBase>("КорректировкиПоИспользованию");
        public EnumItemBase КорректировкиНеправильноЗарегистрированныхДокументов => GetProperty<EnumItemBase>("КорректировкиНеправильноЗарегистрированныхДокументов");
    }
}
