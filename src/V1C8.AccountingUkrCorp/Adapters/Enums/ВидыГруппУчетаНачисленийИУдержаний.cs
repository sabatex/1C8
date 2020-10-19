using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыГруппУчетаНачисленийИУдержаний:V1C8COMObject
    {
        public ВидыГруппУчетаНачисленийИУдержаний(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Начисления => GetProperty<EnumItemBase>();
        public EnumItemBase ОсобыеНачисления => GetProperty<EnumItemBase>();
        public EnumItemBase НалогиИВзносы => GetProperty<EnumItemBase>();
        public EnumItemBase Удержания => GetProperty<EnumItemBase>();
        public EnumItemBase Депоненты => GetProperty<EnumItemBase>();
    }
}
