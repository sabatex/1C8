using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыГруппУчетаНачисленийИУдержаний:EnumBase
    {
        public ВидыГруппУчетаНачисленийИУдержаний(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Начисления => GetProperty<EnumItem>("Начисления");
        public EnumItem ОсобыеНачисления => GetProperty<EnumItem>("ОсобыеНачисления");
        public EnumItem НалогиИВзносы => GetProperty<EnumItem>("НалогиИВзносы");
        public EnumItem Удержания => GetProperty<EnumItem>("Удержания");
        public EnumItem Депоненты => GetProperty<EnumItem>("Депоненты");
    }
}
