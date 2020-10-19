using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.Enums
{
    public class ВариантыУдержанияНДФЛ:V1C8COMObject
    {
        public ВариантыУдержанияНДФЛ(EnumsType owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Удержано => GetProperty<EnumItemBase>();
        public EnumItemBase ПереданоНаВзысканиеВНалоговыйОрган => GetProperty<EnumItemBase>();
        public EnumItemBase ВозвращеноНалоговымАгентом => GetProperty<EnumItemBase>();
        public EnumItemBase ЗачетАвансовыхПлатежей => GetProperty<EnumItemBase>();
    }
}
