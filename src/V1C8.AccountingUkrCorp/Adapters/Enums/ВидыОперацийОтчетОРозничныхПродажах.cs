using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОперацийОтчетОРозничныхПродажах:V1C8COMObject
    {
        public ВидыОперацийОтчетОРозничныхПродажах(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОтчетККМОПродажах => GetProperty<EnumItemBase>();
        public EnumItemBase ОтчетНТТОПродажах => GetProperty<EnumItemBase>();
    }
}
