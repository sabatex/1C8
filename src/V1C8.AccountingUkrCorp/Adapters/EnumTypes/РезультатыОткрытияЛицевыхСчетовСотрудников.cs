using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class РезультатыОткрытияЛицевыхСчетовСотрудников:EnumBase
    {
        public РезультатыОткрытияЛицевыхСчетовСотрудников(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem СчетОткрыт => GetProperty<EnumItem>("СчетОткрыт");
        public EnumItem ОшибкаЗаполненияДанных => GetProperty<EnumItem>("ОшибкаЗаполненияДанных");
        public EnumItem СчетНеОткрыт => GetProperty<EnumItem>("СчетНеОткрыт");
    }
}
