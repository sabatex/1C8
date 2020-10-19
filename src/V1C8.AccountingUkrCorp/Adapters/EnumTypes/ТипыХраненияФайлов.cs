using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыХраненияФайлов:EnumBase
    {
        public ТипыХраненияФайлов(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВИнформационнойБазе => GetProperty<EnumItem>("ВИнформационнойБазе");
        public EnumItem ВТомахНаДиске => GetProperty<EnumItem>("ВТомахНаДиске");
    }
}
