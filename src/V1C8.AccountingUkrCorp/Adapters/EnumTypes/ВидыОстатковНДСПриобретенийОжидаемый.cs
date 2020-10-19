using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОстатковНДСПриобретенийОжидаемый:V1C8COMObject
    {
        public ВидыОстатковНДСПриобретенийОжидаемый(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ПравильнаяРегистрация => GetProperty<EnumItemBase>("ПравильнаяРегистрация");
        public EnumItemBase ЕщеНеПолучены => GetProperty<EnumItemBase>("ЕщеНеПолучены");
        public EnumItemBase НеБудутПолучены => GetProperty<EnumItemBase>("НеБудутПолучены");
    }
}
