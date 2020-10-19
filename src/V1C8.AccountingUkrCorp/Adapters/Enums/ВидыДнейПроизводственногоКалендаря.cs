using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыДнейПроизводственногоКалендаря:V1C8COMObject
    {
        public ВидыДнейПроизводственногоКалендаря(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Рабочий => GetProperty<EnumItemBase>();
        public EnumItemBase Суббота => GetProperty<EnumItemBase>();
        public EnumItemBase Воскресенье => GetProperty<EnumItemBase>();
        public EnumItemBase Предпраздничный => GetProperty<EnumItemBase>();
        public EnumItemBase Праздник => GetProperty<EnumItemBase>();
        public EnumItemBase Нерабочий => GetProperty<EnumItemBase>();
    }
}
