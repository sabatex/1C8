using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВидыДнейПроизводственногоКалендаря:EnumBase
    {
        public ВидыДнейПроизводственногоКалендаря(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Рабочий => GetProperty<EnumItem>("Рабочий");
        public EnumItem Суббота => GetProperty<EnumItem>("Суббота");
        public EnumItem Воскресенье => GetProperty<EnumItem>("Воскресенье");
        public EnumItem Предпраздничный => GetProperty<EnumItem>("Предпраздничный");
        public EnumItem Праздник => GetProperty<EnumItem>("Праздник");
        public EnumItem Нерабочий => GetProperty<EnumItem>("Нерабочий");
    }
}
