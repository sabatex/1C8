using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыСравненияВерсийФайлов:V1C8COMObject
    {
        public СпособыСравненияВерсийФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase MicrosoftOfficeWord => GetProperty<EnumItemBase>("MicrosoftOfficeWord");
        public EnumItemBase OpenOfficeOrgWriter => GetProperty<EnumItemBase>("OpenOfficeOrgWriter");
    }
}
