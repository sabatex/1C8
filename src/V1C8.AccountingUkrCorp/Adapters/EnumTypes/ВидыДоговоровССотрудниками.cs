using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДоговоровССотрудниками:V1C8COMObject
    {
        public ВидыДоговоровССотрудниками(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ТрудовойДоговор => GetProperty<EnumItemBase>("ТрудовойДоговор");
        public EnumItemBase КонтрактГосслужащего => GetProperty<EnumItemBase>("КонтрактГосслужащего");
        public EnumItemBase ДоговорМуниципальногоСлужащего => GetProperty<EnumItemBase>("ДоговорМуниципальногоСлужащего");
        public EnumItemBase КонтрактВоеннослужащего => GetProperty<EnumItemBase>("КонтрактВоеннослужащего");
        public EnumItemBase ВоеннослужащийПоПризыву => GetProperty<EnumItemBase>("ВоеннослужащийПоПризыву");
    }
}
