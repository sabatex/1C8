using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыФайловДляВстроенногоРедактора:EnumBase
    {
        public ТипыФайловДляВстроенногоРедактора(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ГеографическиеСхемы => GetProperty<EnumItem>("ГеографическиеСхемы");
        public EnumItem ГрафическиеСхемы => GetProperty<EnumItem>("ГрафическиеСхемы");
        public EnumItem ТабличныеФайлы => GetProperty<EnumItem>("ТабличныеФайлы");
        public EnumItem ТекстовыеФайлы => GetProperty<EnumItem>("ТекстовыеФайлы");
    }
}
