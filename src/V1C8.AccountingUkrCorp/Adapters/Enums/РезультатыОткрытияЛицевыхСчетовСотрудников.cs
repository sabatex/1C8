using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class РезультатыОткрытияЛицевыхСчетовСотрудников:V1C8COMObject
    {
        public РезультатыОткрытияЛицевыхСчетовСотрудников(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СчетОткрыт => GetProperty<EnumItemBase>();
        public EnumItemBase ОшибкаЗаполненияДанных => GetProperty<EnumItemBase>();
        public EnumItemBase СчетНеОткрыт => GetProperty<EnumItemBase>();
    }
}
