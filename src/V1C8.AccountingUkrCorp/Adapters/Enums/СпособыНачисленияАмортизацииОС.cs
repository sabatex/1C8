using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class СпособыНачисленияАмортизацииОС:V1C8COMObject
    {
        public СпособыНачисленияАмортизацииОС(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Прямолинейный => GetProperty<EnumItemBase>();
        public EnumItemBase Налоговый => GetProperty<EnumItemBase>();
        public EnumItemBase УменьшенияОстатка => GetProperty<EnumItemBase>();
        public EnumItemBase Кумулятивный => GetProperty<EnumItemBase>();
        public EnumItemBase Производственный => GetProperty<EnumItemBase>();
        public EnumItemBase УскоренногоУменьшенияОстатка => GetProperty<EnumItemBase>();
        public EnumItemBase _100 => GetProperty<EnumItemBase>();
        public EnumItemBase _50_50 => GetProperty<EnumItemBase>();
    }
}
