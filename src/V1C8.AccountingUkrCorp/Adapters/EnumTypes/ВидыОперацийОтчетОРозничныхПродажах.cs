using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОперацийОтчетОРозничныхПродажах:V1C8COMObject
    {
        public ВидыОперацийОтчетОРозничныхПродажах(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОтчетККМОПродажах => GetProperty<EnumItemBase>("ОтчетККМОПродажах");
        public EnumItemBase ОтчетНТТОПродажах => GetProperty<EnumItemBase>("ОтчетНТТОПродажах");
    }
}
