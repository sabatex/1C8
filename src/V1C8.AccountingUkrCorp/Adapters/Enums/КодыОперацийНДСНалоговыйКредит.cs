using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class КодыОперацийНДСНалоговыйКредит:V1C8COMObject
    {
        public КодыОперацийНДСНалоговыйКредит(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПервичныйДокумент => GetProperty<EnumItemBase>();
        public EnumItemBase КорректировкиПоИспользованию => GetProperty<EnumItemBase>();
        public EnumItemBase КорректировкиНеправильноЗарегистрированныхДокументов => GetProperty<EnumItemBase>();
    }
}
