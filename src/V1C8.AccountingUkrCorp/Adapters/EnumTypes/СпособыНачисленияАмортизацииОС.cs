using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыНачисленияАмортизацииОС:EnumBase
    {
        public СпособыНачисленияАмортизацииОС(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Прямолинейный => GetProperty<EnumItem>("Прямолинейный");
        public EnumItem Налоговый => GetProperty<EnumItem>("Налоговый");
        public EnumItem УменьшенияОстатка => GetProperty<EnumItem>("УменьшенияОстатка");
        public EnumItem Кумулятивный => GetProperty<EnumItem>("Кумулятивный");
        public EnumItem Производственный => GetProperty<EnumItem>("Производственный");
        public EnumItem УскоренногоУменьшенияОстатка => GetProperty<EnumItem>("УскоренногоУменьшенияОстатка");
        public EnumItem _100 => GetProperty<EnumItem>("_100");
        public EnumItem _50_50 => GetProperty<EnumItem>("_50_50");
    }
}
