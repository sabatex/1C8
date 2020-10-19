using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ТипыХраненияФайлов:V1C8COMObject
    {
        public ТипыХраненияФайлов(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВИнформационнойБазе => GetProperty<EnumItemBase>();
        public EnumItemBase ВТомахНаДиске => GetProperty<EnumItemBase>();
    }
}
