using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыВызоваДополнительныхОбработок:V1C8COMObject
    {
        public СпособыВызоваДополнительныхОбработок(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase ВызовКлиентскогоМетода => GetProperty<EnumItemBase>();
        public EnumItemBase ВызовСерверногоМетода => GetProperty<EnumItemBase>();
        public EnumItemBase ЗаполнениеФормы => GetProperty<EnumItemBase>();
        public EnumItemBase ОткрытиеФормы => GetProperty<EnumItemBase>();
        public EnumItemBase СценарийВБезопасномРежиме => GetProperty<EnumItemBase>();
        public EnumItemBase ЗагрузкаДанныхИзФайла => GetProperty<EnumItemBase>();
    }
}
