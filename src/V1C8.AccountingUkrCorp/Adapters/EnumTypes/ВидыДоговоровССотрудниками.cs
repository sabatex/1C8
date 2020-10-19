using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДоговоровССотрудниками:EnumBase
    {
        public ВидыДоговоровССотрудниками(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ТрудовойДоговор => GetProperty<EnumItem>("ТрудовойДоговор");
        public EnumItem КонтрактГосслужащего => GetProperty<EnumItem>("КонтрактГосслужащего");
        public EnumItem ДоговорМуниципальногоСлужащего => GetProperty<EnumItem>("ДоговорМуниципальногоСлужащего");
        public EnumItem КонтрактВоеннослужащего => GetProperty<EnumItem>("КонтрактВоеннослужащего");
        public EnumItem ВоеннослужащийПоПризыву => GetProperty<EnumItem>("ВоеннослужащийПоПризыву");
    }
}
