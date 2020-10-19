using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ТипыФайловДляВстроенногоРедактора:V1C8COMObject
    {
        public ТипыФайловДляВстроенногоРедактора(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ГеографическиеСхемы => GetProperty<EnumItemBase>("ГеографическиеСхемы");
        public EnumItemBase ГрафическиеСхемы => GetProperty<EnumItemBase>("ГрафическиеСхемы");
        public EnumItemBase ТабличныеФайлы => GetProperty<EnumItemBase>("ТабличныеФайлы");
        public EnumItemBase ТекстовыеФайлы => GetProperty<EnumItemBase>("ТекстовыеФайлы");
    }
}
