using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыВызоваДополнительныхОбработок:V1C8COMObject
    {
        public СпособыВызоваДополнительныхОбработок(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВызовКлиентскогоМетода => GetProperty<EnumItemBase>("ВызовКлиентскогоМетода");
        public EnumItemBase ВызовСерверногоМетода => GetProperty<EnumItemBase>("ВызовСерверногоМетода");
        public EnumItemBase ЗаполнениеФормы => GetProperty<EnumItemBase>("ЗаполнениеФормы");
        public EnumItemBase ОткрытиеФормы => GetProperty<EnumItemBase>("ОткрытиеФормы");
        public EnumItemBase СценарийВБезопасномРежиме => GetProperty<EnumItemBase>("СценарийВБезопасномРежиме");
        public EnumItemBase ЗагрузкаДанныхИзФайла => GetProperty<EnumItemBase>("ЗагрузкаДанныхИзФайла");
    }
}
