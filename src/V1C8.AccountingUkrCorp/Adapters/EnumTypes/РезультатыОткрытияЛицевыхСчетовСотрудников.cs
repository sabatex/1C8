using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РезультатыОткрытияЛицевыхСчетовСотрудников:V1C8COMObject
    {
        public РезультатыОткрытияЛицевыхСчетовСотрудников(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase СчетОткрыт => GetProperty<EnumItemBase>("СчетОткрыт");
        public EnumItemBase ОшибкаЗаполненияДанных => GetProperty<EnumItemBase>("ОшибкаЗаполненияДанных");
        public EnumItemBase СчетНеОткрыт => GetProperty<EnumItemBase>("СчетНеОткрыт");
    }
}
