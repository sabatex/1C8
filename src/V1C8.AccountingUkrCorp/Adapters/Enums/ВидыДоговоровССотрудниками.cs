using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыДоговоровССотрудниками:V1C8COMObject
    {
        public ВидыДоговоровССотрудниками(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ТрудовойДоговор => GetProperty<EnumItemBase>();
        public EnumItemBase КонтрактГосслужащего => GetProperty<EnumItemBase>();
        public EnumItemBase ДоговорМуниципальногоСлужащего => GetProperty<EnumItemBase>();
        public EnumItemBase КонтрактВоеннослужащего => GetProperty<EnumItemBase>();
        public EnumItemBase ВоеннослужащийПоПризыву => GetProperty<EnumItemBase>();
    }
}
