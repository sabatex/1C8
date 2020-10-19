using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыНачисленияАмортизацииНМА:EnumBase
    {
        public СпособыНачисленияАмортизацииНМА(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Прямолинейный => GetProperty<EnumItem>("Прямолинейный");
        public EnumItem УменьшенияОстатка => GetProperty<EnumItem>("УменьшенияОстатка");
        public EnumItem Производственный => GetProperty<EnumItem>("Производственный");
        public EnumItem Кумулятивный => GetProperty<EnumItem>("Кумулятивный");
        public EnumItem УскоренногоУменьшенияОстатка => GetProperty<EnumItem>("УскоренногоУменьшенияОстатка");
    }
}
