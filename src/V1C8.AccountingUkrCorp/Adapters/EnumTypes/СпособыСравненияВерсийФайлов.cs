using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыСравненияВерсийФайлов:EnumBase
    {
        public СпособыСравненияВерсийФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem MicrosoftOfficeWord => GetProperty<EnumItem>("MicrosoftOfficeWord");
        public EnumItem OpenOfficeOrgWriter => GetProperty<EnumItem>("OpenOfficeOrgWriter");
    }
}
