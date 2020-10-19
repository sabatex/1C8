using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class ВариантыУдержанияНДФЛ:EnumBase
    {
        public ВариантыУдержанияНДФЛ(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem Удержано => GetProperty<EnumItem>("Удержано");
        public EnumItem ПереданоНаВзысканиеВНалоговыйОрган => GetProperty<EnumItem>("ПереданоНаВзысканиеВНалоговыйОрган");
        public EnumItem ВозвращеноНалоговымАгентом => GetProperty<EnumItem>("ВозвращеноНалоговымАгентом");
        public EnumItem ЗачетАвансовыхПлатежей => GetProperty<EnumItem>("ЗачетАвансовыхПлатежей");
    }
}
