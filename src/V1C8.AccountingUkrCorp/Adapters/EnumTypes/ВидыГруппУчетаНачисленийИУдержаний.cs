using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыГруппУчетаНачисленийИУдержаний:V1C8COMObject
    {
        public ВидыГруппУчетаНачисленийИУдержаний(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Начисления => GetProperty<EnumItemBase>("Начисления");
        public EnumItemBase ОсобыеНачисления => GetProperty<EnumItemBase>("ОсобыеНачисления");
        public EnumItemBase НалогиИВзносы => GetProperty<EnumItemBase>("НалогиИВзносы");
        public EnumItemBase Удержания => GetProperty<EnumItemBase>("Удержания");
        public EnumItemBase Депоненты => GetProperty<EnumItemBase>("Депоненты");
    }
}
