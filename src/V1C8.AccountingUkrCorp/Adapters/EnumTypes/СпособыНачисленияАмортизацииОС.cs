using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыНачисленияАмортизацииОС:V1C8COMObject
    {
        public СпособыНачисленияАмортизацииОС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Прямолинейный => GetProperty<EnumItemBase>("Прямолинейный");
        public EnumItemBase Налоговый => GetProperty<EnumItemBase>("Налоговый");
        public EnumItemBase УменьшенияОстатка => GetProperty<EnumItemBase>("УменьшенияОстатка");
        public EnumItemBase Кумулятивный => GetProperty<EnumItemBase>("Кумулятивный");
        public EnumItemBase Производственный => GetProperty<EnumItemBase>("Производственный");
        public EnumItemBase УскоренногоУменьшенияОстатка => GetProperty<EnumItemBase>("УскоренногоУменьшенияОстатка");
        public EnumItemBase _100 => GetProperty<EnumItemBase>("_100");
        public EnumItemBase _50_50 => GetProperty<EnumItemBase>("_50_50");
    }
}
