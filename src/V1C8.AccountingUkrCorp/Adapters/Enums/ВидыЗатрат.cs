using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВидыЗатрат:V1C8COMObject
    {
        public ВидыЗатрат(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Материальные => GetProperty<EnumItemBase>();
        public EnumItemBase ОплатаТруда => GetProperty<EnumItemBase>();
        public EnumItemBase ОтчисленияНаСоциальныеНужды => GetProperty<EnumItemBase>();
        public EnumItemBase Амортизация => GetProperty<EnumItemBase>();
        public EnumItemBase Прочие => GetProperty<EnumItemBase>();
    }
}
