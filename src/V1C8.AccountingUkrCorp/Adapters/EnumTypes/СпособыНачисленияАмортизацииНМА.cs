using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыНачисленияАмортизацииНМА:V1C8COMObject
    {
        public СпособыНачисленияАмортизацииНМА(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Прямолинейный => GetProperty<EnumItemBase>("Прямолинейный");
        public EnumItemBase УменьшенияОстатка => GetProperty<EnumItemBase>("УменьшенияОстатка");
        public EnumItemBase Производственный => GetProperty<EnumItemBase>("Производственный");
        public EnumItemBase Кумулятивный => GetProperty<EnumItemBase>("Кумулятивный");
        public EnumItemBase УскоренногоУменьшенияОстатка => GetProperty<EnumItemBase>("УскоренногоУменьшенияОстатка");
    }
}
