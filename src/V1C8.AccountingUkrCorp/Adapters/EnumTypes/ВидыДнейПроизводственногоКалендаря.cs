using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДнейПроизводственногоКалендаря:V1C8COMObject
    {
        public ВидыДнейПроизводственногоКалендаря(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Рабочий => GetProperty<EnumItemBase>("Рабочий");
        public EnumItemBase Суббота => GetProperty<EnumItemBase>("Суббота");
        public EnumItemBase Воскресенье => GetProperty<EnumItemBase>("Воскресенье");
        public EnumItemBase Предпраздничный => GetProperty<EnumItemBase>("Предпраздничный");
        public EnumItemBase Праздник => GetProperty<EnumItemBase>("Праздник");
        public EnumItemBase Нерабочий => GetProperty<EnumItemBase>("Нерабочий");
    }
}
