using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыНачисленияАмортизацииНМА:V1C8COMObject
    {
        public СпособыНачисленияАмортизацииНМА(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Прямолинейный => GetProperty<EnumItemBase>();
        public EnumItemBase УменьшенияОстатка => GetProperty<EnumItemBase>();
        public EnumItemBase Производственный => GetProperty<EnumItemBase>();
        public EnumItemBase Кумулятивный => GetProperty<EnumItemBase>();
        public EnumItemBase УскоренногоУменьшенияОстатка => GetProperty<EnumItemBase>();
    }
}
