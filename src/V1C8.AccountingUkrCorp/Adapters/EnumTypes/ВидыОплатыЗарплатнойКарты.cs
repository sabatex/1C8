using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыОплатыЗарплатнойКарты:EnumBase
    {
        public ВидыОплатыЗарплатнойКарты(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОплачиваетсяПредприятием => GetProperty<EnumItem>("ОплачиваетсяПредприятием");
        public EnumItem ОплачиваетсяДержателем => GetProperty<EnumItem>("ОплачиваетсяДержателем");
        public EnumItem ОплачиваетсяПредприятиемИДержателемВДолях => GetProperty<EnumItem>("ОплачиваетсяПредприятиемИДержателемВДолях");
    }
}
