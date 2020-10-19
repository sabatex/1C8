using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.Enums;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыУдержанияНДФЛ:V1C8COMObject
    {
        public ВариантыУдержанияНДФЛ(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItemBase Удержано => GetProperty<EnumItemBase>("Удержано");
        public EnumItemBase ПереданоНаВзысканиеВНалоговыйОрган => GetProperty<EnumItemBase>("ПереданоНаВзысканиеВНалоговыйОрган");
        public EnumItemBase ВозвращеноНалоговымАгентом => GetProperty<EnumItemBase>("ВозвращеноНалоговымАгентом");
        public EnumItemBase ЗачетАвансовыхПлатежей => GetProperty<EnumItemBase>("ЗачетАвансовыхПлатежей");
    }
}
