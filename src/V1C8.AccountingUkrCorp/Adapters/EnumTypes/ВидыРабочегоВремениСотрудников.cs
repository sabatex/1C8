using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыРабочегоВремениСотрудников:V1C8COMObject
    {
        public ВидыРабочегоВремениСотрудников(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОтработанноеВПределахНормы => GetProperty<EnumItemBase>("ОтработанноеВПределахНормы");
        public EnumItemBase ОтработанноеСверхНормы => GetProperty<EnumItemBase>("ОтработанноеСверхНормы");
        public EnumItemBase ЦелодневноеНеотработанное => GetProperty<EnumItemBase>("ЦелодневноеНеотработанное");
        public EnumItemBase ЧасовоеНеотработанное => GetProperty<EnumItemBase>("ЧасовоеНеотработанное");
        public EnumItemBase ДополнительноОплачиваемоеВПределахНормы => GetProperty<EnumItemBase>("ДополнительноОплачиваемоеВПределахНормы");
        public EnumItemBase ЧасовоеОтработанноеВПределахНормы => GetProperty<EnumItemBase>("ЧасовоеОтработанноеВПределахНормы");
    }
}
