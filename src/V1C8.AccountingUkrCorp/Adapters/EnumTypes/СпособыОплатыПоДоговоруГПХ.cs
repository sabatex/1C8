using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sabatex.V1C8.EnumTypes;

namespace sabatex.V1C8.AccountingUkrCorp.Adapters.EnumTypes
{
    public class СпособыОплатыПоДоговоруГПХ:EnumBase
    {
        public СпособыОплатыПоДоговоруГПХ(Enums owner, object handle) : base(owner, handle)
        {
        }
        public EnumItem ОднократноВКонцеСрока => GetProperty<EnumItem>("ОднократноВКонцеСрока");
        public EnumItem ПоАктамВыполненныхРабот => GetProperty<EnumItem>("ПоАктамВыполненныхРабот");
        public EnumItem ВКонцеСрокаСАвансовымиПлатежами => GetProperty<EnumItem>("ВКонцеСрокаСАвансовымиПлатежами");
    }
}
