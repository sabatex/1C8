using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыВызоваДополнительныхОбработок:EnumBase
    {
        public СпособыВызоваДополнительныхОбработок(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ВызовКлиентскогоМетода => GetProperty<EnumItem>("ВызовКлиентскогоМетода");
        public EnumItem ВызовСерверногоМетода => GetProperty<EnumItem>("ВызовСерверногоМетода");
        public EnumItem ЗаполнениеФормы => GetProperty<EnumItem>("ЗаполнениеФормы");
        public EnumItem ОткрытиеФормы => GetProperty<EnumItem>("ОткрытиеФормы");
        public EnumItem СценарийВБезопасномРежиме => GetProperty<EnumItem>("СценарийВБезопасномРежиме");
        public EnumItem ЗагрузкаДанныхИзФайла => GetProperty<EnumItem>("ЗагрузкаДанныхИзФайла");
    }
}
