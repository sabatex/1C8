using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОплатыЗарплатнойКарты:V1C8COMObject
    {
        public ВидыОплатыЗарплатнойКарты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплачиваетсяПредприятием => GetProperty<EnumItemBase>("ОплачиваетсяПредприятием");
        public EnumItemBase ОплачиваетсяДержателем => GetProperty<EnumItemBase>("ОплачиваетсяДержателем");
        public EnumItemBase ОплачиваетсяПредприятиемИДержателемВДолях => GetProperty<EnumItemBase>("ОплачиваетсяПредприятиемИДержателемВДолях");
    }
}
