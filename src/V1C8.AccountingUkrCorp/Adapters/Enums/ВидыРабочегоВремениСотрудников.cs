using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыРабочегоВремениСотрудников:V1C8COMObject
    {
        public ВидыРабочегоВремениСотрудников(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ОтработанноеВПределахНормы => GetProperty<EnumItemBase>();
        public EnumItemBase ОтработанноеСверхНормы => GetProperty<EnumItemBase>();
        public EnumItemBase ЦелодневноеНеотработанное => GetProperty<EnumItemBase>();
        public EnumItemBase ЧасовоеНеотработанное => GetProperty<EnumItemBase>();
        public EnumItemBase ДополнительноОплачиваемоеВПределахНормы => GetProperty<EnumItemBase>();
        public EnumItemBase ЧасовоеОтработанноеВПределахНормы => GetProperty<EnumItemBase>();
    }
}
