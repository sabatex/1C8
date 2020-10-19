using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыХраненияФайлов:V1C8COMObject
    {
        public ТипыХраненияФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВИнформационнойБазе => GetProperty<EnumItemBase>("ВИнформационнойБазе");
        public EnumItemBase ВТомахНаДиске => GetProperty<EnumItemBase>("ВТомахНаДиске");
    }
}
