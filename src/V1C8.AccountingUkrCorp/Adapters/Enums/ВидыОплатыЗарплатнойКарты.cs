using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыОплатыЗарплатнойКарты:V1C8COMObject
    {
        public ВидыОплатыЗарплатнойКарты(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОплачиваетсяПредприятием => GetProperty<EnumItemBase>();
        public EnumItemBase ОплачиваетсяДержателем => GetProperty<EnumItemBase>();
        public EnumItemBase ОплачиваетсяПредприятиемИДержателемВДолях => GetProperty<EnumItemBase>();
    }
}
